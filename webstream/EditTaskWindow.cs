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
	public partial class EditTaskWindow : Form
	{
		public bool Canceled { get; private set; } = true;

		private FileTask Task;
		private bool newTask = false;
		public EditTaskWindow(FileTask task, bool isNewTask)
		{
			InitializeComponent();
			Task = task;
			newTask = isNewTask;
		}

		private void NewTaskForm_Load(object sender, EventArgs e)
		{
			if (newTask)
				return;

			textBox_Command.Text = Task.Command;
			textBox_Filetypes.Text = String.Join(String.Empty, Task.Filetypes);
		}

		private void button_Save_Click(object sender, EventArgs e)
		{
			Task.Command = textBox_Command.Text;
			Task.Filetypes = new List<string>(textBox_Filetypes.Text.Replace(" ", "").Split(','));
			Canceled = false;
			this.Close();
		}

		private void Button_Cancel_Click(object sender, EventArgs e)
		{
			Canceled = true;
			this.Close();
		}
	}
}
