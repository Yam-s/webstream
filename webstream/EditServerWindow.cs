using System;
using System.Windows.Forms;

namespace webstream
{
	public partial class EditServerWindow : Form
	{
		public bool Canceled { get; private set; } = true;

		private WebServer Server;
		private bool newServer = false;
		public EditServerWindow(WebServer server, bool isNewServer)
		{
			InitializeComponent();
			Server = server;
			newServer = isNewServer;
		}

		private void EditServerWindow_Load(object sender, EventArgs e)
		{
			checkBox1.Checked = Server.DetailsRequired;
			textBox_Username.Enabled = checkBox1.Checked;
			textBox_Password.Enabled = checkBox1.Checked;

			if (!newServer)
			{
				this.Text = "Edit Server";
				textBox_Name.Text = Server.Name;
				textBox_URL.Text = Server.URL;
				textBox_Username.Text = Server.Username;
				textBox_Password.Text = Server.Password;
			}
		}

		private void Button_ConfirmAddServer_Click(object sender, EventArgs e)
		{
			if (textBox_Name.Text.Length < 1 || textBox_URL.Text.Length < 1)
			{
				MessageBox.Show("You must provide a name and URL for the server");
				return;
			}

			Server.Name = textBox_Name.Text;
			Server.URL = textBox_URL.Text;
			Server.Username = textBox_Username.Text;
			Server.Password = textBox_Password.Text;
			Server.DetailsRequired = checkBox1.Checked;
			Canceled = false;
			this.Close();
		}

		private void Button_CancelAddServer_Click(object sender, EventArgs e)
		{
			Canceled = true;
			this.Close();
		}

		private void CheckBox1_CheckedChanged(object sender, EventArgs e)
		{
			textBox_Username.Enabled = checkBox1.Checked;
			textBox_Password.Enabled = checkBox1.Checked;
		}
	}
}
