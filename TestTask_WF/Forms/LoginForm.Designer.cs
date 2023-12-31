﻿using System;
using System.Windows.Forms;

namespace TestTask_WF
{
	partial class LoginForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.labelUsername = new System.Windows.Forms.Label();
			this.labelPassword = new System.Windows.Forms.Label();
			this.textBoxUsername = new System.Windows.Forms.TextBox();
			this.textBoxPassword = new System.Windows.Forms.TextBox();
			this.buttonLogin = new System.Windows.Forms.Button();
			this.buttonRegister = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// labelUsername
			// 
			this.labelUsername.Location = new System.Drawing.Point(20, 20);
			this.labelUsername.Name = "labelUsername";
			this.labelUsername.Size = new System.Drawing.Size(100, 23);
			this.labelUsername.TabIndex = 0;
			this.labelUsername.Text = "Логин:";
			// 
			// labelPassword
			// 
			this.labelPassword.Location = new System.Drawing.Point(20, 50);
			this.labelPassword.Name = "labelPassword";
			this.labelPassword.Size = new System.Drawing.Size(100, 23);
			this.labelPassword.TabIndex = 1;
			this.labelPassword.Text = "Пароль:";
			// 
			// textBoxUsername
			// 
			this.textBoxUsername.Location = new System.Drawing.Point(143, 20);
			this.textBoxUsername.Name = "textBoxUsername";
			this.textBoxUsername.Size = new System.Drawing.Size(100, 22);
			this.textBoxUsername.TabIndex = 2;
			// 
			// textBoxPassword
			// 
			this.textBoxPassword.Location = new System.Drawing.Point(143, 50);
			this.textBoxPassword.Name = "textBoxPassword";
			this.textBoxPassword.PasswordChar = '*';
			this.textBoxPassword.Size = new System.Drawing.Size(100, 22);
			this.textBoxPassword.TabIndex = 3;
			// 
			// buttonLogin
			// 
			this.buttonLogin.Location = new System.Drawing.Point(111, 91);
			this.buttonLogin.Name = "buttonLogin";
			this.buttonLogin.Size = new System.Drawing.Size(75, 23);
			this.buttonLogin.TabIndex = 4;
			this.buttonLogin.Text = "Войти";
			this.buttonLogin.Click += new System.EventHandler(this.ButtonLogin_Click);
			// 
			// button1
			// 
			this.buttonRegister.Location = new System.Drawing.Point(245, 91);
			this.buttonRegister.Name = "button1";
			this.buttonRegister.Size = new System.Drawing.Size(130, 23);
			this.buttonRegister.TabIndex = 5;
			this.buttonRegister.Text = "Регистрация";
			this.buttonRegister.Click += new System.EventHandler(this.ButtonRegister_Click);
			// 
			// LoginForm
			// 
			this.ClientSize = new System.Drawing.Size(426, 148);
			this.Controls.Add(this.buttonRegister);
			this.Controls.Add(this.labelUsername);
			this.Controls.Add(this.labelPassword);
			this.Controls.Add(this.textBoxUsername);
			this.Controls.Add(this.textBoxPassword);
			this.Controls.Add(this.buttonLogin);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Name = "LoginForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Форма входа";
			
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion


		private Label labelUsername;
		private Label labelPassword;
		private TextBox textBoxUsername;
		private TextBox textBoxPassword;
		private Button buttonLogin;
		private Button buttonRegister;
	}
}