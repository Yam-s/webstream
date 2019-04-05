namespace webstream
{
	partial class MainWindow
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
			this.button_AddServer = new System.Windows.Forms.Button();
			this.button_EditServer = new System.Windows.Forms.Button();
			this.listView_ServerList = new System.Windows.Forms.ListView();
			this.contextMenuStrip_EditDelete = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.testToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.contextMenuStrip_Add = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.button_TaskManager = new System.Windows.Forms.Button();
			this.contextMenuStrip_EditDelete.SuspendLayout();
			this.contextMenuStrip_Add.SuspendLayout();
			this.SuspendLayout();
			// 
			// button_AddServer
			// 
			this.button_AddServer.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button_AddServer.Location = new System.Drawing.Point(12, 12);
			this.button_AddServer.Name = "button_AddServer";
			this.button_AddServer.Size = new System.Drawing.Size(77, 23);
			this.button_AddServer.TabIndex = 2;
			this.button_AddServer.Text = "Add Server";
			this.button_AddServer.UseVisualStyleBackColor = true;
			this.button_AddServer.Click += new System.EventHandler(this.Button_AddServer_Click);
			// 
			// button_EditServer
			// 
			this.button_EditServer.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button_EditServer.Location = new System.Drawing.Point(12, 41);
			this.button_EditServer.Name = "button_EditServer";
			this.button_EditServer.Size = new System.Drawing.Size(77, 23);
			this.button_EditServer.TabIndex = 3;
			this.button_EditServer.Text = "Edit Server";
			this.button_EditServer.UseVisualStyleBackColor = true;
			this.button_EditServer.Click += new System.EventHandler(this.Button_EditServer_Click);
			// 
			// listView_ServerList
			// 
			this.listView_ServerList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.listView_ServerList.FullRowSelect = true;
			this.listView_ServerList.Location = new System.Drawing.Point(98, 12);
			this.listView_ServerList.MultiSelect = false;
			this.listView_ServerList.Name = "listView_ServerList";
			this.listView_ServerList.Scrollable = false;
			this.listView_ServerList.Size = new System.Drawing.Size(324, 387);
			this.listView_ServerList.TabIndex = 4;
			this.listView_ServerList.UseCompatibleStateImageBehavior = false;
			this.listView_ServerList.View = System.Windows.Forms.View.Details;
			this.listView_ServerList.DoubleClick += new System.EventHandler(this.listView_ServerList_DoubleClick);
			this.listView_ServerList.MouseUp += new System.Windows.Forms.MouseEventHandler(this.listView_ServerList_MouseUp);
			// 
			// contextMenuStrip_EditDelete
			// 
			this.contextMenuStrip_EditDelete.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.testToolStripMenuItem,
            this.deleteToolStripMenuItem});
			this.contextMenuStrip_EditDelete.Name = "contextMenuStrip1";
			this.contextMenuStrip_EditDelete.Size = new System.Drawing.Size(108, 48);
			this.contextMenuStrip_EditDelete.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.contextMenuStrip_EditDelete_ItemClicked);
			// 
			// testToolStripMenuItem
			// 
			this.testToolStripMenuItem.Name = "testToolStripMenuItem";
			this.testToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
			this.testToolStripMenuItem.Text = "Edit";
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
			// button_TaskManager
			// 
			this.button_TaskManager.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button_TaskManager.Location = new System.Drawing.Point(12, 70);
			this.button_TaskManager.Name = "button_TaskManager";
			this.button_TaskManager.Size = new System.Drawing.Size(77, 23);
			this.button_TaskManager.TabIndex = 5;
			this.button_TaskManager.Text = "Tasks";
			this.button_TaskManager.UseVisualStyleBackColor = true;
			this.button_TaskManager.Click += new System.EventHandler(this.button_TaskManager_Click);
			// 
			// MainWindow
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(434, 411);
			this.Controls.Add(this.button_TaskManager);
			this.Controls.Add(this.button_EditServer);
			this.Controls.Add(this.button_AddServer);
			this.Controls.Add(this.listView_ServerList);
			this.MaximizeBox = false;
			this.MaximumSize = new System.Drawing.Size(1920, 1080);
			this.MinimumSize = new System.Drawing.Size(450, 450);
			this.Name = "MainWindow";
			this.ShowIcon = false;
			this.Text = "Webstream";
			this.Load += new System.EventHandler(this.MainWindow_Load);
			this.contextMenuStrip_EditDelete.ResumeLayout(false);
			this.contextMenuStrip_Add.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.Button button_AddServer;
		private System.Windows.Forms.Button button_EditServer;
		private System.Windows.Forms.ListView listView_ServerList;
		private System.Windows.Forms.ContextMenuStrip contextMenuStrip_EditDelete;
		private System.Windows.Forms.ToolStripMenuItem testToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
		private System.Windows.Forms.ContextMenuStrip contextMenuStrip_Add;
		private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
		private System.Windows.Forms.Button button_TaskManager;
	}
}

