using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CamadaUC
{
	public class ucData : MaskedTextBox
	{
		public ucData()
		{
			// Mask
			this.Mask = "00/00/0000";

			// Handlers
			this.GotFocus += ucTelefone_GotFocus;
			this.KeyDown += ucTelefone_KeyDown;
		}

		private void ucTelefone_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
			{
				e.SuppressKeyPress = true;
				SendKeys.Send("{Tab}");
			};
		}

		private void ucTelefone_GotFocus(object sender, EventArgs e)
		{
			this.SelectAll();
		}
	}
}
