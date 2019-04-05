namespace webstream
{
	partial class EditServerWindow
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
			this.button_ConfirmAddServer = new System.Windows.Forms.Button();
			this.button_CancelAddServer = new System.Windows.Forms.Button();
			this.checkBox1 = new System.Windows.Forms.CheckBox();
			this.textBox_Name = new webstream.CueTextBox();
			this.textBox_Password = new webstream.CueTextBox();
			this.textBox_Username = new webstream.CueTextBox();
			this.textBox_URL = new webstream.CueTextBox();
			this.SuspendLayout();
			// 
			// button_ConfirmAddServer
			// 
			this.button_ConfirmAddServer.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button_ConfirmAddServer.Location = new System.Drawing.Point(205, 125);
			this.button_ConfirmAddServer.Name = "button_ConfirmAddServer";
			this.button_ConfirmAddServer.Size = new System.Drawing.Size(75, 23);
			this.button_ConfirmAddServer.TabIndex = 1;
			this.button_ConfirmAddServer.Text = "OK";
			this.button_ConfirmAddServer.UseVisualStyleBackColor = true;
			this.button_ConfirmAddServer.Click += new System.EventHandler(this.Button_ConfirmAddServer_Click);
			// 
			// button_CancelAddServer
			// 
			this.button_CancelAddServer.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button_CancelAddServer.Location = new System.Drawing.Point(124, 125);
			this.button_CancelAddServer.Name = "button_CancelAddServer";
			this.button_CancelAddServer.Size = new System.Drawing.Size(75, 23);
			this.button_CancelAddServer.TabIndex = 2;
			this.button_CancelAddServer.Text = "Cancel";
			this.button_CancelAddServer.UseVisualStyleBackColor = true;
			this.button_CancelAddServer.Click += new System.EventHandler(this.Button_CancelAddServer_Click);
			// 
			// checkBox1
			// 
			this.checkBox1.AutoSize = true;
			this.checkBox1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.checkBox1.Location = new System.Drawing.Point(12, 66);
			this.checkBox1.Name = "checkBox1";
			this.checkBox1.Size = new System.Drawing.Size(97, 17);
			this.checkBox1.TabIndex = 4;
			this.checkBox1.Text = "Authenticate?";
			this.checkBox1.UseVisualStyleBackColor = true;
			this.checkBox1.CheckedChanged += new System.EventHandler(this.CheckBox1_CheckedChanged);
			// 
			// textBox_Name
			// 
			this.textBox_Name.Cue = "Name";
			this.textBox_Name.Location = new System.Drawing.Point(12, 13);
			this.textBox_Name.Name = "textBox_Name";
			this.textBox_Name.Size = new System.Drawing.Size(268, 22);
			this.textBox_Name.TabIndex = 7;
			// 
			// textBox_Password
			// 
			this.textBox_Password.Cue = "Password";
			this.textBox_Password.Location = new System.Drawing.Point(150, 89);
			this.textBox_Password.Name = "textBox_Password";
			this.textBox_Password.Size = new System.Drawing.Size(130, 22);
			this.textBox_Password.TabIndex = 6;
			// 
			// textBox_Username
			// 
			this.textBox_Username.Cue = "Username";
			this.textBox_Username.Location = new System.Drawing.Point(12, 89);
			this.textBox_Username.Name = "textBox_Username";
			this.textBox_Username.Size = new System.Drawing.Size(128, 22);
			this.textBox_Username.TabIndex = 5;
			// 
			// textBox_URL
			// 
			this.textBox_URL.Cue = "URL";
			this.textBox_URL.Location = new System.Drawing.Point(12, 39);
			this.textBox_URL.Name = "textBox_URL";
			this.textBox_URL.Size = new System.Drawing.Size(268, 22);
			this.textBox_URL.TabIndex = 3;
			// 
			// EditServerWindow
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(292, 156);
			this.Controls.Add(this.textBox_Name);
			this.Controls.Add(this.textBox_Password);
			this.Controls.Add(this.textBox_Username);
			this.Controls.Add(this.checkBox1);
			this.Controls.Add(this.textBox_URL);
			this.Controls.Add(this.button_CancelAddServer);
			this.Controls.Add(this.button_ConfirmAddServer);
			this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.MaximumSize = new System.Drawing.Size(308, 195);
			this.MinimumSize = new System.Drawing.Size(308, 195);
			this.Name = "EditServerWindow";
			this.ShowIcon = false;
			this.Text = "Add Server";
			this.Load += new System.EventHandler(this.EditServerWindow_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Button button_ConfirmAddServer;
		private System.Windows.Forms.Button button_CancelAddServer;
		private CueTextBox textBox_URL;
		private System.Windows.Forms.CheckBox checkBox1;
		private CueTextBox textBox_Username;
		private CueTextBox textBox_Password;
		private CueTextBox textBox_Name;
	}
}