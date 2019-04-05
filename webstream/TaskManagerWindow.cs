using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace webstream
{
	public partial class TaskManagerWindow : Form
	{
		public TaskManagerWindow()
		{
			InitializeComponent();
			listView_TaskList.Columns.Add("Command", -2, HorizontalAlignment.Left);
			listView_TaskList.Columns.Add("Filetypes", -2);
		}

		private void TaskManagerWindow_Load(object sender, EventArgs e)
		{
			UpdateList(false);
		}

		private void Button_AddTask_Click(object sender, EventArgs e)
		{
			OpenEditTaskWindow(new FileTask(), true);
		}

		private void OpenEditTaskWindow(FileTask task, bool isNewTask)
		{
			using (var editTaskWindow = new EditTaskForm(task, isNewTask))
			{
				editTaskWindow.ShowDialog();

				if (editTaskWindow.Canceled)
					return;

				if (isNewTask)
					Database.Tasks.Add(task);

				UpdateList();
			}
		}

		private void UpdateList(bool save = true)
		{
			listView_TaskList.BeginUpdate();
			listView_TaskList.Items.Clear();
			foreach (var task in Database.Tasks)
			{
				var item = listView_TaskList.Items.Add(task.Command);
				item.SubItems.Add(String.Join(", ", task.Filetypes));
				item.Tag = task;
			}
			listView_TaskList.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
			listView_TaskList.EndUpdate();

			if (save)
				Database.UpdateDB();
		}

		private void Button_OK_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void Button_Cancel_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void listView_TaskList_MouseUp(object sender, MouseEventArgs e)
		{
			if (e.Button != MouseButtons.Right)
				return;

			if (listView_TaskList.FocusedItem.Bounds.Contains(e.Location))
				listView_TaskList.ContextMenuStrip = contextMenuStrip_EditDelete;
			else
				listView_TaskList.ContextMenuStrip = contextMenuStrip_Add;
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

			var selectedTask = (FileTask)listView.SelectedItems[0].Tag;

			if (e.ClickedItem.ToString() == "Edit")
				OpenEditTaskWindow(selectedTask, !Database.Tasks.Contains(selectedTask));


			if (e.ClickedItem.ToString() == "Delete")
			{
				Database.Tasks.Remove(selectedTask);
				UpdateList();
			}
		}

		private void contextMenuStrip_Add_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
		{
			if (e.ClickedItem.ToString() == "Add")
				OpenEditTaskWindow(new FileTask(), true);
		}
	}
}
