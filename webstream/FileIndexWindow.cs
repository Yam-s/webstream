﻿using System;
using System.Collections.Generic;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Linq;

namespace webstream
{
	public partial class FileIndexWindow : Form
	{
		public WebServer Server;
		private bool isDoubleClick;

		private TreeNode rootNode;
		public FileIndexWindow(WebServer server)
		{
			InitializeComponent();
			Server = server;
		}

		private void FileIndexWindow_Load(object sender, EventArgs e)
		{
			try
			{
				var auth = Convert.ToBase64String(Encoding.ASCII.GetBytes(String.Format("{0}:{1}", Server.Username, Server.Password)));
				MainWindow.WebClient.Headers[HttpRequestHeader.Authorization] = string.Format("Basic {0}", auth);

				rootNode = new TreeNode(Server.Name);
				rootNode.Tag = new Uri(Server.URL);
				rootNode.Expand();

				buildTree(Server.URL, rootNode);

				treeView_Index.Invoke((MethodInvoker)(() =>
				{
					updateTree(rootNode);
				}));
			}
			catch (Exception exception)
			{
				MessageBox.Show(exception.Message);
				this.Close();
			}
		}

		private void updateTree(TreeNode node)
		{
			treeView_Index.BeginUpdate();
			treeView_Index.Nodes.Clear();
			treeView_Index.Nodes.Add(node);
			treeView_Index.EndUpdate();
		}

		private void buildTree(string URL, TreeNode startNode)
		{
			var page = MainWindow.WebClient.DownloadString(URL);
			var regex = new Regex("<a href=\"(?<href>.*)\">(?<name>.*)</a>");
			var matchCollection = regex.Matches(page);

			foreach (Match match in matchCollection)
			{
				// prevent indexing previous directories, current directories or non directories/files.
				if (match.Groups["href"].Value == "../" || match.Groups["href"].Value == "/" || match.Groups["href"].Value.Contains("?"))
					continue;

				// Web server index page specifics.. I guess?
				if (match.Groups["name"].Value == "Parent Directory")
					continue;

				var childNode = startNode.Nodes.Add(Uri.UnescapeDataString(match.Groups["href"].Value));
				childNode.Tag = new Uri(startNode.Tag + match.Groups["href"].Value);

				if (match.Groups["href"].Value.Contains("/"))
					buildTree(URL + match.Groups["href"].Value, childNode);
			}
		}

		private void treeView_Index_DoubleClick(object sender, MouseEventArgs e)
		{
			var filetype = System.IO.Path.GetExtension(((Uri)treeView_Index.SelectedNode.Tag).OriginalString);
			if (filetype.Length < 1)
				return;

			var taskChoices = new List<FileTask>();
			foreach (var task in Database.Tasks)
			{
				if (task.Filetypes.Contains(filetype))
				{
					task.Run((Uri)treeView_Index.SelectedNode.Tag, Server);
					// TO-DO: Add ability to choose from a list of tasks if multiple filetypes match.
					taskChoices.Add(task);
				}
			}
			if (!taskChoices.Any())
				MessageBox.Show("No task associated with selected filetype.");
		}

		private void treeView_Index_BeforeExpand(object sender, TreeViewCancelEventArgs e)
		{
			if (isDoubleClick && e.Action == TreeViewAction.Expand)
				e.Cancel = true;
		}

		private void treeView_Index_BeforeCollapse(object sender, TreeViewCancelEventArgs e)
		{
			if (isDoubleClick && e.Action == TreeViewAction.Collapse)
				e.Cancel = true;
		}

		private void treeView_Index_MouseDown(object sender, MouseEventArgs e)
		{
			isDoubleClick = e.Clicks > 1;
		}

		private void Button_Refresh_Click(object sender, EventArgs e)
		{
			rootNode.Nodes.Clear();
			FileIndexWindow_Load(null, null);
		}
	}
}
