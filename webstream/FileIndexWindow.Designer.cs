﻿namespace webstream
{
	partial class FileIndexWindow
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
			this.treeView_Index = new System.Windows.Forms.TreeView();
			this.SuspendLayout();
			// 
			// treeView_Index
			// 
			this.treeView_Index.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.treeView_Index.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.treeView_Index.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.treeView_Index.FullRowSelect = true;
			this.treeView_Index.HideSelection = false;
			this.treeView_Index.Location = new System.Drawing.Point(12, 12);
			this.treeView_Index.Margin = new System.Windows.Forms.Padding(0);
			this.treeView_Index.Name = "treeView_Index";
			this.treeView_Index.ShowRootLines = false;
			this.treeView_Index.Size = new System.Drawing.Size(763, 440);
			this.treeView_Index.TabIndex = 0;
			this.treeView_Index.BeforeCollapse += new System.Windows.Forms.TreeViewCancelEventHandler(this.treeView_Index_BeforeCollapse);
			this.treeView_Index.BeforeExpand += new System.Windows.Forms.TreeViewCancelEventHandler(this.treeView_Index_BeforeExpand);
			this.treeView_Index.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.treeView_Index_DoubleClick);
			this.treeView_Index.MouseDown += new System.Windows.Forms.MouseEventHandler(this.treeView_Index_MouseDown);
			// 
			// FileIndexWindow
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(784, 461);
			this.Controls.Add(this.treeView_Index);
			this.MinimumSize = new System.Drawing.Size(800, 500);
			this.Name = "FileIndexWindow";
			this.ShowIcon = false;
			this.Text = "FileIndexWindow";
			this.Load += new System.EventHandler(this.FileIndexWindow_Load);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TreeView treeView_Index;
	}
}