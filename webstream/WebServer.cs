using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace webstream
{
	[Serializable]
	public class WebServer
	{
		public string Name;
		public string URL;
		public string Username = null;
		public string Password = null;
		public bool DetailsRequired = false;

		public WebServer()
		{

		}
	}
}
