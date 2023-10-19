using System.Windows.Forms;

namespace TestTask_WF
{
	partial class RegisterForm
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
			this.register = new System.Windows.Forms.Button();
			this.labelConfirmPassword = new System.Windows.Forms.Label();
			this.textBoxConfirmPass = new System.Windows.Forms.TextBox();
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
			this.textBoxUsername.Location = new System.Drawing.Point(208, 21);
			this.textBoxUsername.Name = "textBoxUsername";
			this.textBoxUsername.Size = new System.Drawing.Size(100, 22);
			this.textBoxUsername.TabIndex = 2;
			// 
			// textBoxPassword
			// 
			this.textBoxPassword.Location = new System.Drawing.Point(208, 47);
			this.textBoxPassword.Name = "textBoxPassword";
			this.textBoxPassword.PasswordChar = '*';
			this.textBoxPassword.Size = new System.Drawing.Size(100, 22);
			this.textBoxPassword.TabIndex = 3;
			// 
			// register
			// 
			this.register.Location = new System.Drawing.Point(143, 113);
			this.register.Name = "register";
			this.register.Size = new System.Drawing.Size(165, 23);
			this.register.TabIndex = 4;
			this.register.Text = "Зарегистрироваться";
			this.register.Click += new System.EventHandler(this.register_Click);
			// 
			// labelConfirmPassword
			// 
			this.labelConfirmPassword.Location = new System.Drawing.Point(20, 73);
			this.labelConfirmPassword.Name = "labelConfirmPassword";
			this.textBoxConfirmPass.PasswordChar = '*';
			this.labelConfirmPassword.Size = new System.Drawing.Size(182, 23);
			this.labelConfirmPassword.TabIndex = 5;
			this.labelConfirmPassword.Text = "Подтвердите пароль:";
			// 
			// textBoxConfirmPass
			// 
			this.textBoxConfirmPass.Location = new System.Drawing.Point(208, 73);
			this.textBoxConfirmPass.Name = "textBoxConfirmPass";
			this.textBoxConfirmPass.PasswordChar = '*';
			this.textBoxConfirmPass.Size = new System.Drawing.Size(100, 22);
			this.textBoxConfirmPass.TabIndex = 6;
			// 
			// RegisterForm
			// 
			this.ClientSize = new System.Drawing.Size(426, 148);
			this.Controls.Add(this.textBoxConfirmPass);
			this.Controls.Add(this.labelConfirmPassword);
			this.Controls.Add(this.labelUsername);
			this.Controls.Add(this.labelPassword);
			this.Controls.Add(this.textBoxUsername);
			this.Controls.Add(this.textBoxPassword);
			this.Controls.Add(this.register);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Name = "RegisterForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Регистрация";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Label labelUsername;
		private Label labelPassword;
		private TextBox textBoxUsername;
		private TextBox textBoxPassword;
		private Button register;
		private Label labelConfirmPassword;
		private TextBox textBoxConfirmPass;
	}
}