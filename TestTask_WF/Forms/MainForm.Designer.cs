using System;
using System.Windows.Forms;

namespace TestTask_WF
{
	partial class MainForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		public static bool IsUserAuthotised = false;

#if true
		protected override void OnLoad(EventArgs e)
		{
			var loginForm = new LoginForm();
			var result = loginForm.ShowDialog();

			if (result == DialogResult.OK && IsUserAuthotised)
			{
				base.OnLoad(e);
			}
			else
			{
				Close();
			}

		}
#endif
		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.EditModeButton = new System.Windows.Forms.Button();
			this.EditStepButton = new System.Windows.Forms.Button();
			this.dataGridModes = new System.Windows.Forms.DataGridView();
			this.dataGridSteps = new System.Windows.Forms.DataGridView();
			this.LoadDataButton = new System.Windows.Forms.Button();
			this.DeleteModeButton = new System.Windows.Forms.Button();
			this.DeleteStepButton = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dataGridModes)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridSteps)).BeginInit();
			this.SuspendLayout();
			// 
			// EditModeButton
			// 
			this.EditModeButton.Location = new System.Drawing.Point(1293, 65);
			this.EditModeButton.Name = "EditModeButton";
			this.EditModeButton.Size = new System.Drawing.Size(163, 41);
			this.EditModeButton.TabIndex = 2;
			this.EditModeButton.Text = "Edit Mode";
			this.EditModeButton.UseVisualStyleBackColor = true;
			this.EditModeButton.Click += new System.EventHandler(this.EditModeButton_Click);
			// 
			// EditStepButton
			// 
			this.EditStepButton.Location = new System.Drawing.Point(1293, 384);
			this.EditStepButton.Name = "EditStepButton";
			this.EditStepButton.Size = new System.Drawing.Size(163, 42);
			this.EditStepButton.TabIndex = 3;
			this.EditStepButton.Text = "Edit Step";
			this.EditStepButton.UseVisualStyleBackColor = true;
			this.EditStepButton.Click += new System.EventHandler(this.EditStepButton_Click);
			// 
			// dataGridModes
			// 
			this.dataGridModes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridModes.Location = new System.Drawing.Point(43, 65);
			this.dataGridModes.Name = "dataGridModes";
			this.dataGridModes.RowHeadersWidth = 51;
			this.dataGridModes.RowTemplate.Height = 24;
			this.dataGridModes.Size = new System.Drawing.Size(1181, 289);
			this.dataGridModes.TabIndex = 4;
			this.dataGridModes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridModes_CellClick);
			// 
			// dataGridSteps
			// 
			this.dataGridSteps.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridSteps.Location = new System.Drawing.Point(43, 395);
			this.dataGridSteps.Name = "dataGridSteps";
			this.dataGridSteps.RowHeadersWidth = 51;
			this.dataGridSteps.RowTemplate.Height = 24;
			this.dataGridSteps.Size = new System.Drawing.Size(1181, 306);
			this.dataGridSteps.TabIndex = 5;
			this.dataGridSteps.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridSteps_CellClick);
			// 
			// LoadDataButton
			// 
			this.LoadDataButton.Location = new System.Drawing.Point(460, 753);
			this.LoadDataButton.Name = "LoadDataButton";
			this.LoadDataButton.Size = new System.Drawing.Size(329, 74);
			this.LoadDataButton.TabIndex = 6;
			this.LoadDataButton.Text = "Load Data From Excel";
			this.LoadDataButton.UseVisualStyleBackColor = true;
			this.LoadDataButton.Click += new System.EventHandler(this.LoadDataButton_Click);
			// 
			// DeleteModeButton
			// 
			this.DeleteModeButton.Location = new System.Drawing.Point(1293, 140);
			this.DeleteModeButton.Name = "DeleteModeButton";
			this.DeleteModeButton.Size = new System.Drawing.Size(162, 43);
			this.DeleteModeButton.TabIndex = 7;
			this.DeleteModeButton.Text = "Delete Mode";
			this.DeleteModeButton.UseVisualStyleBackColor = true;
			this.DeleteModeButton.Click += new System.EventHandler(this.DeleteModeButton_Click);
			// 
			// DeleteStepButton
			// 
			this.DeleteStepButton.Location = new System.Drawing.Point(1293, 460);
			this.DeleteStepButton.Name = "DeleteStepButton";
			this.DeleteStepButton.Size = new System.Drawing.Size(162, 42);
			this.DeleteStepButton.TabIndex = 8;
			this.DeleteStepButton.Text = "Delete Step";
			this.DeleteStepButton.UseVisualStyleBackColor = true;
			this.DeleteStepButton.Click += new System.EventHandler(this.DeleteStepButton_Click);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1565, 859);
			this.Controls.Add(this.DeleteStepButton);
			this.Controls.Add(this.DeleteModeButton);
			this.Controls.Add(this.LoadDataButton);
			this.Controls.Add(this.dataGridSteps);
			this.Controls.Add(this.dataGridModes);
			this.Controls.Add(this.EditStepButton);
			this.Controls.Add(this.EditModeButton);
			this.Name = "MainForm";
			this.Text = "Main Form";
			this.Load += new System.EventHandler(this.MainForm_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridModes)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridSteps)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

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
		private Button EditModeButton;
		private Button EditStepButton;
		private DataGridView dataGridModes;
		private DataGridView dataGridSteps;
		private Button LoadDataButton;
		private Button DeleteModeButton;
		private Button DeleteStepButton;
	}
}

