using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace webstream
{
	class CueTextBox : TextBox
	{
		[DllImport("user32.dll", CharSet = CharSet.Unicode)]
		public static extern IntPtr SendMessage(IntPtr hWnd, UInt32 Msg, IntPtr wParam, string lParam);

		private string _cue;

		public string Cue
		{
			get { return _cue; }
			set { _cue = value; UpdateCue(); }
		}

		private void UpdateCue()
		{
			if (IsHandleCreated && _cue != null)
				SendMessage(Handle, 0x1501, (IntPtr)1, _cue);
		}

		protected override void OnHandleCreated(EventArgs e)
		{
			base.OnHandleCreated(e);
			UpdateCue();
		}
	}
}
