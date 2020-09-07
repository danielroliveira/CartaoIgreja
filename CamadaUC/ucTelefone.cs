using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CamadaUC
{
	public class ucTelefone : MaskedTextBox
    {
        public ucTelefone()
        {
            this.Mask = "(99) 99000-0000";
            this.Width = 144;
            this.Height = 27;

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
