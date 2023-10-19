using System;
using System.Data.Entity.Migrations;
using System.Windows.Forms;
using TestTask_WF.Models;
using TestTask_WF.Services;

namespace TestTask_WF.Forms
{
	public partial class EditModeForm : Form
	{
		private Modes _mode;
		public EditModeForm(Modes mode)
		{
			InitializeComponent();
			_mode = mode;

			IdTextBox.Text = _mode.Id.ToString();
			NameTextBox.Text = _mode.Name;
			MaxBottleNumberTextBox.Text = _mode.MaxBottleNumber.ToString();
			MaxUsedTipsTextBox.Text = _mode.MaxUsedTips.ToString();
		}

		private void SaveModeButton_Click(object sender, EventArgs e)
		{
			var mode = new Modes();
			try
			{
				mode.Id = int.Parse(IdTextBox.Text);
				mode.Name = NameTextBox.Text;
				mode.MaxBottleNumber = int.Parse(MaxBottleNumberTextBox.Text);
				mode.MaxUsedTips = int.Parse(MaxUsedTipsTextBox.Text);

				using(var context = new ApplicationDbContext())
				{
					context.Modes.AddOrUpdate(mode);
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
