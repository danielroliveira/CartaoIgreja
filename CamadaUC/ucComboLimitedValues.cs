using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CamadaUC
{
	public class ucComboLimitedValues : ComboBox
	{
		public bool RestrictContentToListItems = true;

		public ucComboLimitedValues()
		{
			Width = 234;
			Height = 27;
			AutoCompleteSource = AutoCompleteSource.ListItems;
			AutoCompleteMode = AutoCompleteMode.SuggestAppend;

			GotFocus += UcComboLimitedValues_GotFocus;
			KeyDown += UcComboLimitedValues_KeyDown;
		}

		private void UcComboLimitedValues_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
			{
				e.SuppressKeyPress = true;
				SendKeys.Send("{Tab}");
			}
			else if (e.KeyCode == Keys.Escape)
			{
				SendKeys.Send("{Tab}");
				SendKeys.Send("{Esc}");
			}
		}

		private void UcComboLimitedValues_GotFocus(object sender, EventArgs e)
		{
			SelectAll();
		}

		protected override void OnValidating(CancelEventArgs e)
		{
			if (Text.Length == 0) return;

			if (RestrictContentToListItems && Items.Count > 0)
			{
				int index = FindString(this.Text);

				if (index > -1) SelectedIndex = index;
				else
				{
					e.Cancel = true;
					Text = "";
					System.Media.SystemSounds.Beep.Play();
					SendKeys.Send("%{DOWN}");
				}
			}

			base.OnValidating(e);
		}
	}
}
