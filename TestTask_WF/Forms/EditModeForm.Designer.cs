namespace TestTask_WF.Forms
{
	partial class EditModeForm
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
			this.IdLabel = new System.Windows.Forms.Label();
			this.IdTextBox = new System.Windows.Forms.TextBox();
			this.NameTextBox = new System.Windows.Forms.TextBox();
			this.NameLabel = new System.Windows.Forms.Label();
			this.MaxBottleNumberTextBox = new System.Windows.Forms.TextBox();
			this.MaxBottleNumberLabel = new System.Windows.Forms.Label();
			this.MaxUsedTipsTextBox = new System.Windows.Forms.TextBox();
			this.MaxUsedTipsLabel = new System.Windows.Forms.Label();
			this.SaveModeButton = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// IdLabel
			// 
			this.IdLabel.AutoSize = true;
			this.IdLabel.Location = new System.Drawing.Point(39, 71);
			this.IdLabel.Name = "IdLabel";
			this.IdLabel.Size = new System.Drawing.Size(18, 16);
			this.IdLabel.TabIndex = 0;
			this.IdLabel.Text = "Id";
			// 
			// IdTextBox
			// 
			this.IdTextBox.Location = new System.Drawing.Point(159, 68);
			this.IdTextBox.Name = "IdTextBox";
			this.IdTextBox.Size = new System.Drawing.Size(237, 22);
			this.IdTextBox.TabIndex = 1;
			// 
			// NameTextBox
			// 
			this.NameTextBox.Location = new System.Drawing.Point(159, 96);
			this.NameTextBox.Name = "NameTextBox";
			this.NameTextBox.Size = new System.Drawing.Size(237, 22);
			this.NameTextBox.TabIndex = 3;
			// 
			// NameLabel
			// 
			this.NameLabel.AutoSize = true;
			this.NameLabel.Location = new System.Drawing.Point(39, 99);
			this.NameLabel.Name = "NameLabel";
			this.NameLabel.Size = new System.Drawing.Size(44, 16);
			this.NameLabel.TabIndex = 2;
			this.NameLabel.Text = "Name";
			// 
			// MaxBottleNumberTextBox
			// 
			this.MaxBottleNumberTextBox.Location = new System.Drawing.Point(159, 124);
			this.MaxBottleNumberTextBox.Name = "MaxBottleNumberTextBox";
			this.MaxBottleNumberTextBox.Size = new System.Drawing.Size(237, 22);
			this.MaxBottleNumberTextBox.TabIndex = 5;
			// 
			// MaxBottleNumberLabel
			// 
			this.MaxBottleNumberLabel.AutoSize = true;
			this.MaxBottleNumberLabel.Location = new System.Drawing.Point(39, 127);
			this.MaxBottleNumberLabel.Name = "MaxBottleNumberLabel";
			this.MaxBottleNumberLabel.Size = new System.Drawing.Size(114, 16);
			this.MaxBottleNumberLabel.TabIndex = 4;
			this.MaxBottleNumberLabel.Text = "MaxBottleNumber";
			// 
			// MaxUsedTipsTextBox
			// 
			this.MaxUsedTipsTextBox.Location = new System.Drawing.Point(159, 152);
			this.MaxUsedTipsTextBox.Name = "MaxUsedTipsTextBox";
			this.MaxUsedTipsTextBox.Size = new System.Drawing.Size(237, 22);
			this.MaxUsedTipsTextBox.TabIndex = 7;
			// 
			// MaxUsedTipsLabel
			// 
			this.MaxUsedTipsLabel.AutoSize = true;
			this.MaxUsedTipsLabel.Location = new System.Drawing.Point(39, 155);
			this.MaxUsedTipsLabel.Name = "MaxUsedTipsLabel";
			this.MaxUsedTipsLabel.Size = new System.Drawing.Size(115, 20);
			this.MaxUsedTipsLabel.TabIndex = 6;
			this.MaxUsedTipsLabel.Text = "MaxUsedTips";
			// 
			// SaveModeButton
			// 
			this.SaveModeButton.Location = new System.Drawing.Point(159, 204);
			this.SaveModeButton.Name = "SaveModeButton";
			this.SaveModeButton.Size = new System.Drawing.Size(189, 41);
			this.SaveModeButton.TabIndex = 8;
			this.SaveModeButton.Text = "Save";
			this.SaveModeButton.UseVisualStyleBackColor = true;
			this.SaveModeButton.Click += new System.EventHandler(this.SaveModeButton_Click);
			// 
			// AddModeForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(473, 277);
			this.Controls.Add(this.SaveModeButton);
			this.Controls.Add(this.MaxUsedTipsTextBox);
			this.Controls.Add(this.MaxUsedTipsLabel);
			this.Controls.Add(this.MaxBottleNumberTextBox);
			this.Controls.Add(this.MaxBottleNumberLabel);
			this.Controls.Add(this.NameTextBox);
			this.Controls.Add(this.NameLabel);
			this.Controls.Add(this.IdTextBox);
			this.Controls.Add(this.IdLabel);
			this.Name = "AddModeForm";
			this.Text = "AddModeForm";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label IdLabel;
		private System.Windows.Forms.TextBox IdTextBox;
		private System.Windows.Forms.TextBox NameTextBox;
		private System.Windows.Forms.Label NameLabel;
		private System.Windows.Forms.TextBox MaxBottleNumberTextBox;
		private System.Windows.Forms.Label MaxBottleNumberLabel;
		private System.Windows.Forms.TextBox MaxUsedTipsTextBox;
		private System.Windows.Forms.Label MaxUsedTipsLabel;
		private System.Windows.Forms.Button SaveModeButton;
	}
}