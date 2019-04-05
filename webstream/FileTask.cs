using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace webstream
{
	[Serializable]
	public class FileTask
	{
		public string Command { get; set; }
		public List<string> Filetypes = new List<string>();

		public FileTask(string command, List<string> filetypes)
		{
			Command = command;
			Filetypes = filetypes;
		}

		public FileTask()
		{

		}

		public void Run(Uri file, WebServer server)
		{
			Console.WriteLine("running " + file.OriginalString);

			var newString = "";
			if (server.DetailsRequired)
			{
				newString = string.Format("{0}://{1}:{2}@{3}", file.Scheme, server.Username, server.Password, file.Host + file.PathAndQuery);
			}
			System.Diagnostics.Process.Start("cmd.exe", "/K " + Command.Replace("%f", newString));
		}
	}
}
