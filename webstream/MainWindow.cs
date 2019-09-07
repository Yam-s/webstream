using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Windows.Forms;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using webstream.Properties;

namespace webstream
{
	public partial class MainWindow : Form
	{

		public static WebClient WebClient = new WebClient();
		public MainWindow()
		{
			InitializeComponent();
			listView_ServerList.Columns.Add(" ", -2, HorizontalAlignment.Left);
			listView_ServerList.Columns.Add("Name", -2);
			listView_ServerList.Columns.Add("URL", -2);
		}

		private void MainWindow_Load(object sender, EventArgs e)
		{
			if (Settings.Default.Position != null)
				Location = Settings.Default.Position;
			try
			{
				var jsonDir = Directory.GetCurrentDirectory() + "\\db.json";

				if (!Database.Load(jsonDir))
					return;

				UpdateList(false);
			}
			catch (Exception exception)
			{
				MessageBox.Show(exception.Message);
			}
		}

		private void MainWindow_FormClosing(object sender, FormClosingEventArgs e)
		{
			Settings.Default.Position = WindowState == FormWindowState.Normal ? Location : RestoreBounds.Location;
			Settings.Default.Save();
		}

		private void Button_AddServer_Click(object sender, EventArgs e)
		{
			OpenEditServerWindow(new WebServer(), true);
		}

		private void Button_EditServer_Click(object sender, EventArgs e)
		{
			if (listView_ServerList.SelectedItems.Count < 1)
				return;

			var selectedServer = (WebServer)listView_ServerList.SelectedItems[0].Tag;
			OpenEditServerWindow(selectedServer, !Database.Servers.Contains(selectedServer));
		}

		private void OpenEditServerWindow(WebServer server, bool isNewServer)
		{
			using (EditServerWindow editServerWindow = new EditServerWindow(server, isNewServer))
			{
				editServerWindow.ShowDialog();

				if (editServerWindow.Canceled)
					return;

				if (isNewServer)
					Database.Servers.Add(server);

				UpdateList();
			}
		}

		private void UpdateList(bool save = true)
		{
			// Rebuild the list
			listView_ServerList.BeginUpdate();
			listView_ServerList.Items.Clear();
			foreach (var server in Database.Servers)
			{
				var item = listView_ServerList.Items.Add("Icon");
				item.SubItems.Add(server.Name);
				item.SubItems.Add(server.URL);
				item.Tag = server;
			}
			listView_ServerList.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
			listView_ServerList.EndUpdate();

			// Update the DB too.
			if (save)
				Database.UpdateDB();
		}

		/// <summary>
		/// Called when double clicking a server in the list.
		/// </summary>
		private void listView_ServerList_DoubleClick(object sender, EventArgs e)
		{
			using (var indexWindow = new FileIndexWindow((WebServer)listView_ServerList.SelectedItems[0].Tag))
			{
				this.Hide();
				indexWindow.ShowDialog();
				this.Show();
			}
		}

		private void listView_ServerList_MouseUp(object sender, MouseEventArgs e)
		{
			if (e.Button != MouseButtons.Right)
				return;

			if (listView_ServerList.FocusedItem == null)
				return;

			if (listView_ServerList.FocusedItem.Bounds.Contains(e.Location))
				listView_ServerList.ContextMenuStrip = contextMenuStrip_EditDelete;
			else
				listView_ServerList.ContextMenuStrip = contextMenuStrip_Add;
		}

		private void contextMenuStrip_EditDelete_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
		{
			var menu = sender as ContextMenuStrip;
			if (menu == null)
				return;

			var listView = menu.SourceControl as ListView;
			if (listView == null)
				return;

			if (listView.SelectedItems.Count < 1)
				return;

			var selectedServer = (WebServer)listView.SelectedItems[0].Tag;

			if (e.ClickedItem.ToString() == "Edit")
				OpenEditServerWindow(selectedServer, !Database.Servers.Contains(selectedServer));


			if (e.ClickedItem.ToString() == "Delete")
			{
				Database.Servers.Remove(selectedServer);
				UpdateList();
			}
		}

		private void contextMenuStrip_Add_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
		{
			if (e.ClickedItem.ToString() == "Add")
				OpenEditServerWindow(new WebServer(), true);
		}

		private void button_TaskManager_Click(object sender, EventArgs e)
		{
			using (var taskManager = new TaskManagerWindow())
			{
				taskManager.ShowDialog();
			}
		}
	}
}
