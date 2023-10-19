using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Migrations;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TestTask_WF.Models;
using TestTask_WF.Services;

namespace TestTask_WF.Forms
{
	public partial class EditStepForm : Form
	{
		private Steps _step;
		public EditStepForm(Steps step)
		{
			InitializeComponent();
			_step = step;
			IdTextBox.Text = _step.Id.ToString();
			ModeIdBox.Text = _step.ModeId.ToString();
			TimerTextBox.Text = _step.Timer.ToString();
			DestinationTextBox.Text = _step.Destination;
			SpeedTextBox.Text = _step.Speed.ToString();
			TypeTextBox.Text = _step.Type;
			VolumeTextBox.Text = _step.Volume.ToString();
		}

		private void SaveStepButton_Click(object sender, EventArgs e)
		{
			try
			{
				_step.Id = int.Parse(IdTextBox.Text);
				_step.ModeId = int.Parse(ModeIdBox.Text);
				_step.Timer = int.Parse(TimerTextBox.Text);
				_step.Destination = DestinationTextBox.Text;
				_step.Speed = int.Parse(SpeedTextBox.Text);
				_step.Destination = TypeTextBox.Text;
				_step.Speed = int.Parse(VolumeTextBox.Text);

				using (var context = new ApplicationDbContext())
				{
					context.Steps.AddOrUpdate(_step);
					context.SaveChanges();
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			MessageBox.Show("Done", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
			Close();
		}
	}
}
