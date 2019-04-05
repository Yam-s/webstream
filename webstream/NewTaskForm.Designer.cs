namespace webstream
{
	partial class EditTaskForm
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
			this.button_Save = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.textBox_Command = new System.Windows.Forms.TextBox();
			this.textBox_Filetypes = new webstream.CueTextBox();
			this.button_Cancel = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// button_Save
			// 
			this.button_Save.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.button_Save.Location = new System.Drawing.Point(347, 130);
			this.button_Save.Name = "button_Save";
			this.button_Save.Size = new System.Drawing.Size(75, 23);
			this.button_Save.TabIndex = 1;
			this.button_Save.Text = "Save";
			this.button_Save.UseVisualStyleBackColor = true;
			this.button_Save.Click += new System.EventHandler(this.button_Save_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(12, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(359, 13);
			this.label1.TabIndex = 2;
			this.label1.Text = "Enter command line. Parameters: %f file, %u username, %p password";
			// 
			// textBox_Command
			// 
			this.textBox_Command.Location = new System.Drawing.Point(12, 25);
			this.textBox_Command.Multiline = true;
			this.textBox_Command.Name = "textBox_Command";
			this.textBox_Command.Size = new System.Drawing.Size(410, 73);
			this.textBox_Command.TabIndex = 3;
			// 
			// textBox_Filetypes
			// 
			this.textBox_Filetypes.Cue = "Comma seperated list of filetypes e.g: \".mkv, .mp4\"";
			this.textBox_Filetypes.Location = new System.Drawing.Point(12, 104);
			this.textBox_Filetypes.Name = "textBox_Filetypes";
			this.textBox_Filetypes.Size = new System.Drawing.Size(410, 20);
			this.textBox_Filetypes.TabIndex = 4;
			// 
			// button_Cancel
			// 
			this.button_Cancel.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.button_Cancel.Location = new System.Drawing.Point(266, 130);
			this.button_Cancel.Name = "button_Cancel";
			this.button_Cancel.Size = new System.Drawing.Size(75, 23);
			this.button_Cancel.TabIndex = 5;
			this.button_Cancel.Text = "Cancel";
			this.button_Cancel.UseVisualStyleBackColor = true;
			this.button_Cancel.Click += new System.EventHandler(this.Button_Cancel_Click);
			// 
			// EditTaskForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(434, 158);
			this.Controls.Add(this.button_Cancel);
			this.Controls.Add(this.textBox_Filetypes);
			this.Controls.Add(this.textBox_Command);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.button_Save);
			this.MinimizeBox = false;
			this.Name = "EditTaskForm";
			this.ShowIcon = false;
			this.Text = "Add Task";
			this.Load += new System.EventHandler(this.NewTaskForm_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Button button_Save;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox textBox_Command;
		private CueTextBox textBox_Filetypes;
		private System.Windows.Forms.Button button_Cancel;
	}
}