using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using TestTask_WF.Forms;
using TestTask_WF.Models;
using TestTask_WF.Services;

namespace TestTask_WF
{
	public partial class MainForm : Form
	{
		private List<Modes> _modesList;
		public List<Modes> ModesList
		{
			get => _modesList; private set
			{
				_modesList = value;
				dataGridModes.DataSource = _modesList.OrderBy(s => s.Id).ToList();
			}
		}
		private List<Steps> _stepsList;
		public List<Steps> StepsList
		{
			get => _stepsList; private set
			{
				_stepsList = value;
				dataGridSteps.DataSource = _stepsList.OrderBy(s => s.Id).ToList();
			}
		}

		private Modes _mode = null;
		private Steps _step = null;

		public MainForm()
		{
			InitializeComponent();
		}

		private void EditStepButton_Click(object sender, EventArgs e)
		{
			if(_step == null)
			{
				MessageBox.Show("Выберите элемент", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			var form = new EditStepForm(_step);
			form.ShowDialog();

			try
			{
				using (var context = new ApplicationDbContext())
				{
					StepsList = context.Steps.ToList();
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			finally 
			{ 
				_step = null;
			}
		}

		private void EditModeButton_Click(object sender, EventArgs e)
		{
			if (_mode == null)
			{
				MessageBox.Show("Выберите элемент", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			var form = new EditModeForm(_mode);
			form.ShowDialog();

			try
			{
				using (var context = new ApplicationDbContext())
				{
					ModesList = context.Modes.ToList();
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			finally 
			{ 
				_mode = null;
			}
		}
		private void DeleteModeButton_Click(object sender, EventArgs e)
		{
			if (_mode == null)
			{
				MessageBox.Show("Выберите элемент", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			var result = MessageBox.Show($"Подтвердите удаление объекта ID: {_mode.Id}, Name: {_mode.Name}", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
			if(result == DialogResult.Yes)
			{
				try
				{
					using (var context = new ApplicationDbContext())
					{
						var mode = context.Modes.Find(_mode.Id);
						context.Modes.Remove(mode);
						context.SaveChanges();
						ModesList = context.Modes.ToList();
					}
				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
				finally
				{
					_mode = null;
				}
			}
		}

		private void DeleteStepButton_Click(object sender, EventArgs e)
		{
			if (_step == null)
			{
				MessageBox.Show("Выберите элемент", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			var result = MessageBox.Show($"Подтвердите удаление объекта ID: {_step.Id}", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
			if (result == DialogResult.Yes)
			{
				try
				{
					using (var context = new ApplicationDbContext())
					{
						var step = context.Steps.Find(_step.Id);
						context.Steps.Remove(step);
						context.SaveChanges();
						StepsList = context.Steps.ToList();
					}
				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
				finally
				{
					_step = null;
				}
			}

		}
		private void dataGridModes_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			var modeList = dataGridModes.DataSource as List<Modes>;
			_mode = modeList.ElementAt(e.RowIndex);
		}

		private void dataGridSteps_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			var stepList = dataGridSteps.DataSource as List<Steps>;
			_step = stepList.ElementAt(e.RowIndex);
		}
		private async void LoadDataButton_Click(object sender, EventArgs e)
		{
			OpenFileDialog dialog = new OpenFileDialog();
			dialog.Filter = ".xlsx files (*.xlsx)|*.xlsx|All files (*.*)|*.*";
			dialog.RestoreDirectory = true;
			dialog.InitialDirectory = Environment.CurrentDirectory;
			dialog.ShowDialog();

			var parser = new ExcelParser();
			try
			{
				var tuple = await Task.Run(() => parser.Parse(dialog.FileName));

				ModesList = tuple.Item1;
				StepsList = tuple.Item2;

				using (var context = new ApplicationDbContext())
				{
					foreach (var mode in ModesList)
					{
					
						if(context.Modes
							.Where(s => s.Id == mode.Id &&
									s.Name == mode.Name &&
									s.MaxBottleNumber == mode.MaxBottleNumber &&
									s.MaxUsedTips == mode.MaxUsedTips)
							.Count() == 0)
						{
							context.Modes.Add(mode);
						}
					}

					foreach (var step in StepsList)
					{

						if (context.Steps
							.Where(s => s.Id == step.Id &&
									s.ModeId == step.ModeId &&
									s.Timer == step.Timer &&
									s.Destination == step.Destination &&
									s.Speed == step.Speed &&
									s.Type == step.Type &&
									s.Volume == step.Volume)
							.Count() == 0)
						{
							context.Steps.Add(step);
						}
					}

					await context.SaveChangesAsync();

					ModesList = context.Modes.OrderBy(s => s.Id).ToList();
					StepsList = context.Steps.OrderBy(s => s.Id).ToList();
				}
				
			}
			catch (Exception ex) 
			{
				MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void MainForm_Load(object sender, EventArgs e)
		{
			try
			{
				using (var context = new ApplicationDbContext())
				{
					ModesList = context.Modes.OrderBy(s => s.Id).ToList();
					StepsList = context.Steps.OrderBy(s => s.Id).ToList();
				}
			}
			catch(Exception ex) 
			{
				MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}

			dataGridModes.AutoGenerateColumns = true;
			dataGridModes.Columns["Id"].HeaderText = "Id";
			dataGridModes.Columns["Name"].HeaderText = "Name";
			dataGridModes.Columns["MaxBottleNumber"].HeaderText = "MaxBottleNumber";
			dataGridModes.Columns["MaxUsedTips"].HeaderText = "MaxUsedTips";

			dataGridSteps.AutoGenerateColumns = true;
			dataGridSteps.Columns["Id"].HeaderText = "Id";
			dataGridSteps.Columns["ModeId"].HeaderText = "ModeId";
			dataGridSteps.Columns["Timer"].HeaderText = "Timer";
			dataGridSteps.Columns["Destination"].HeaderText = "Destination";
			dataGridSteps.Columns["Speed"].HeaderText = "Speed";
			dataGridSteps.Columns["Type"].HeaderText = "Type";
			dataGridSteps.Columns["Volume"].HeaderText = "Volume";
		}
	}
}
