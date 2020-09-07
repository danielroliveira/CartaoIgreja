using System.ComponentModel;
using System.Windows.Forms;

namespace CamadaUC
{
	public partial class ucTextBoxUnclicked : TextBox
	{
		int WM_LBUTTONDOWN = 0x0201; //513
		int WM_LBUTTONUP = 0x0202; //514
		int WM_LBUTTONDBLCLK = 0x0203; //515
		const int WM_SETFOCUS = 0x0007;
		const int WM_KILLFOCUS = 0x0008;
		[DefaultValue(true)]
		public bool SelectionHighlightEnabled { get; set; }

		public ucTextBoxUnclicked()
		{
			InitializeComponent();
			SelectionHighlightEnabled = false;
		}

		protected override void WndProc(ref Message m)
		{
			if (m.Msg == WM_SETFOCUS && !SelectionHighlightEnabled)
				m.Msg = WM_KILLFOCUS;

			if (
				m.Msg == WM_LBUTTONDOWN ||
				m.Msg == WM_LBUTTONUP ||
				m.Msg == WM_LBUTTONDBLCLK // && Your State To Check
			   )
			{
				Cursor.Current = Cursors.Arrow;
				//Dont dispatch message
				return;
			}

			//Dispatch as usual
			base.WndProc(ref m);
		}

		protected override void OnMouseMove(MouseEventArgs e)
		{
			base.OnMouseMove(e);
			Cursor.Current = Cursors.Arrow;
		}

	}
}
