using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using TestTask_WF.Models;
using TestTask_WF.Services;

namespace TestTask_WF
{
	public partial class RegisterForm : Form
	{
		public RegisterForm()
		{
			InitializeComponent();
		}

		private async void register_Click(object sender, EventArgs e)
		{
			var username = textBoxUsername.Text;
			var password = textBoxPassword.Text;
			var confirmedPass = textBoxConfirmPass.Text;

			try
			{
				if (confirmedPass == password)
				{
					using (var context = new ApplicationDbContext())
					{
						var isExist = context.Users.Where(s => s.UserName == username).Count() > 0 ? true : false;

						if (isExist)
						{
							MessageBox.Show("Такое имя пользователя уже существует", "Регистрация", MessageBoxButtons.OK, MessageBoxIcon.Error);
							textBoxUsername.Text = "";
							textBoxPassword.Text = "";
							textBoxConfirmPass.Text = "";
							return;
						}

						if (!Regex.IsMatch(password, "^(?=.*[A-Za-z])(?=.*\\d).{6,}$"))
						{
							MessageBox.Show("Пароль должен содержать минимум 6 символов, из которых обязательно должна быть 1 цифра и 1 буква", "Регистрация", MessageBoxButtons.OK, MessageBoxIcon.Error);
							textBoxPassword.Text = "";
							textBoxConfirmPass.Text = "";
							return;
						}

						context.Users.Add(new Users { Id = Guid.NewGuid(), UserName = username, Password = password });
						await context.SaveChangesAsync();
					}
					MessageBox.Show("Вы зарегистрированы", "Регистрация", MessageBoxButtons.OK, MessageBoxIcon.Information);
					Close();
				}
				else
				{
					MessageBox.Show("Пароли не совпадают", "Регистрация", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}

		}
	}
}
