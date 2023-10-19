using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TestTask_WF.Services;

namespace TestTask_WF
{
	public partial class LoginForm : Form
	{
		public LoginForm()
		{
			InitializeComponent();
		}

		private void ButtonRegister_Click(object sender, EventArgs e)
		{
			var registerForm = new RegisterForm();
			registerForm.Show();
			textBoxUsername.Text = "";
			textBoxPassword.Text = "";
		}
		private void ButtonLogin_Click(object sender, EventArgs e)
		{
			var username = textBoxUsername.Text;
			var password = textBoxPassword.Text;

			try
			{
				using (var context = new ApplicationDbContext())
				{
					var users = context.Users.Where(s => s.UserName == username && s.Password == password);

					if (users.Count() > 0)
					{
						MainForm.IsUserAuthotised = true;
						MessageBox.Show("Вход выполнен успешно!", "Вход", MessageBoxButtons.OK, MessageBoxIcon.Information);
						DialogResult = DialogResult.OK;
					}
					else
					{
						textBoxUsername.Text = "";
						textBoxPassword.Text = "";
						MessageBox.Show("Неправильный логин или пароль. Попробуйте снова или зарегистрируйтесь", "Вход", MessageBoxButtons.OK, MessageBoxIcon.Error);
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
	}
}
