namespace webstream
{
	partial class TaskManagerWindow
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
			this.components = new System.ComponentModel.Container();
			this.listView_TaskList = new System.Windows.Forms.ListView();
			this.button_AddTask = new System.Windows.Forms.Button();
			this.button_OK = new System.Windows.Forms.Button();
			this.button_Cancel = new System.Windows.Forms.Button();
			this.contextMenuStrip_EditDelete = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.contextMenuStrip_Add = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.contextMenuStrip_EditDelete.SuspendLayout();
			this.contextMenuStrip_Add.SuspendLayout();
			this.SuspendLayout();
			// 
			// listView_TaskList
			// 
			this.listView_TaskList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.listView_TaskList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.listView_TaskList.FullRowSelect = true;
			this.listView_TaskList.Location = new System.Drawing.Point(12, 12);
			this.listView_TaskList.MultiSelect = false;
			this.listView_TaskList.Name = "listView_TaskList";
			this.listView_TaskList.Size = new System.Drawing.Size(528, 218);
			this.listView_TaskList.TabIndex = 0;
			this.listView_TaskList.UseCompatibleStateImageBehavior = false;
			this.listView_TaskList.View = System.Windows.Forms.View.Details;
			this.listView_TaskList.MouseUp += new System.Windows.Forms.MouseEventHandler(this.listView_TaskList_MouseUp);
			// 
			// button_AddTask
			// 
			this.button_AddTask.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button_AddTask.Location = new System.Drawing.Point(12, 236);
			this.button_AddTask.Name = "button_AddTask";
			this.button_AddTask.Size = new System.Drawing.Size(77, 23);
			this.button_AddTask.TabIndex = 4;
			this.button_AddTask.Text = "Add Task";
			this.button_AddTask.UseVisualStyleBackColor = true;
			this.button_AddTask.Click += new System.EventHandler(this.Button_AddTask_Click);
			// 
			// button_OK
			// 
			this.button_OK.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button_OK.Location = new System.Drawing.Point(463, 236);
			this.button_OK.Name = "button_OK";
			this.button_OK.Size = new System.Drawing.Size(77, 23);
			this.button_OK.TabIndex = 5;
			this.button_OK.Text = "OK";
			this.button_OK.UseVisualStyleBackColor = true;
			this.button_OK.Click += new System.EventHandler(this.Button_OK_Click);
			// 
			// button_Cancel
			// 
			this.button_Cancel.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button_Cancel.Location = new System.Drawing.Point(380, 236);
			this.button_Cancel.Name = "button_Cancel";
			this.button_Cancel.Size = new System.Drawing.Size(77, 23);
			this.button_Cancel.TabIndex = 6;
			this.button_Cancel.Text = "Cancel";
			this.button_Cancel.UseVisualStyleBackColor = true;
			this.button_Cancel.Click += new System.EventHandler(this.Button_Cancel_Click);
			// 
			// contextMenuStrip_EditDelete
			// 
			this.contextMenuStrip_EditDelete.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editToolStripMenuItem,
            this.deleteToolStripMenuItem});
			this.contextMenuStrip_EditDelete.Name = "contextMenuStrip_EditDelete";
			this.contextMenuStrip_EditDelete.Size = new System.Drawing.Size(108, 48);
			this.contextMenuStrip_EditDelete.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.contextMenuStrip_EditDelete_ItemClicked);
			// 
			// editToolStripMenuItem
			// 
			this.editToolStripMenuItem.Name = "editToolStripMenuItem";
			this.editToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
			this.editToolStripMenuItem.Text = "Edit";
			// 
			// deleteToolStripMenuItem
			// 
			this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
			this.deleteToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
			this.deleteToolStripMenuItem.Text = "Delete";
			// 
			// contextMenuStrip_Add
			// 
			this.contextMenuStrip_Add.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem});
			this.contextMenuStrip_Add.Name = "contextMenuStrip_Add";
			this.contextMenuStrip_Add.Size = new System.Drawing.Size(97, 26);
			this.contextMenuStrip_Add.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.contextMenuStrip_Add_ItemClicked);
			// 
			// addToolStripMenuItem
			// 
			this.addToolStripMenuItem.Name = "addToolStripMenuItem";
			this.addToolStripMenuItem.Size = new System.Drawing.Size(96, 22);
			this.addToolStripMenuItem.Text = "Add";
			// 
			// TaskManagerWindow
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(552, 271);
			this.Controls.Add(this.button_Cancel);
			this.Controls.Add(this.button_OK);
			this.Controls.Add(this.button_AddTask);
			this.Controls.Add(this.listView_TaskList);
			this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Name = "TaskManagerWindow";
			this.ShowIcon = false;
			this.Text = "Tasks";
			this.Load += new System.EventHandler(this.TaskManagerWindow_Load);
			this.contextMenuStrip_EditDelete.ResumeLayout(false);
			this.contextMenuStrip_Add.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.ListView listView_TaskList;
		private System.Windows.Forms.Button button_AddTask;
		private System.Windows.Forms.Button button_OK;
		private System.Windows.Forms.Button button_Cancel;
		private System.Windows.Forms.ContextMenuStrip contextMenuStrip_EditDelete;
		private System.Windows.Forms.ContextMenuStrip contextMenuStrip_Add;
		private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
	}
}