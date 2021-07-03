using System;
using System.Drawing;
using System.Windows.Forms;

namespace CamadaUI.Main
{
	public partial class frmMain : Form
	{
		public static string errorLog;

		public frmMain()
		{
			InitializeComponent();
		}

		public void updateStatusBar(long bytes, string msg)
		{
			if (InvokeRequired)
			{
				Invoke(new Action<long, string>(updateStatusBar), new object[] { bytes, msg });
				return;
			}
			progressBar.Value = (int)bytes;
			lblProgress.Text = msg;
			lblProgress.Location = new Point(this.ClientRectangle.Width - lblProgress.Width - progressBar.Width - 20, 4);
		}

	}
}
