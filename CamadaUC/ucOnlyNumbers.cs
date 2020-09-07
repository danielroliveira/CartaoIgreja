using System;
using System.ComponentModel;
using System.Globalization;
using System.Windows.Forms;

namespace CamadaUC
{
	public class ucOnlyNumbers : TextBox
	{
		public ucOnlyNumbers()
		{
			TextAlign = HorizontalAlignment.Right;
			Inteiro = false;
			Positivo = true;
			Moeda = false;

			GotFocus += UcOnlyNumbers_GotFocus;
			LostFocus += UcOnlyNumbers_LostFocus;
			Validating += UcOnlyNumbers_Validating;
			KeyPress += UcOnlyNumbers_KeyPress;
			KeyDown += UcOnlyNumbers_KeyDown;
		}

		[EditorBrowsable]
		public bool Inteiro { get; set; }

		[EditorBrowsable]
		public bool Positivo { get; set; }

		[EditorBrowsable]
		public bool Moeda { get; set; }


		private void UcOnlyNumbers_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (e.KeyChar == ',' && Inteiro == false)
			{
				e.Handled = false;
			}
			else if (e.KeyChar == '.' && Inteiro == false)
			{
				SelectedText = ",";
				e.Handled = true;
			}
			else if (!char.IsNumber(e.KeyChar) && e.KeyChar != (char)Keys.Back)
			{
				e.Handled = true;
			}
		}

		private void UcOnlyNumbers_Validating(object sender, CancelEventArgs e)
		{
			// check lenght is > 0
			if (TextLength > 0)
			{
				// check is NUMBER
				if (double.TryParse(Text, NumberStyles.Currency, new CultureInfo("pt-BR"), out double n) == false)
				{
					MessageBox.Show("Valor númerico incorreto...\n" +
									"Digite um valor numérico",
									"Valor Incorreto",
									MessageBoxButtons.OK,
									MessageBoxIcon.Information);
					e.Cancel = true;
					return;
				}
				else
				{
					// check POSITIVE number
					if (Positivo == true && n < 0)
					{
						MessageBox.Show("O Valor precisa ser positivo...\n" +
										"Digite um valor positivo",
										"Valor Incorreto",
										MessageBoxButtons.OK,
										MessageBoxIcon.Information);
						e.Cancel = true;
						return;
					}
				}

				// check INTEGER number
				if (Inteiro == true && int.TryParse(Text, out _) == false)
				{
					MessageBox.Show("Valor númerico incorreto...\n" +
									"Digite um INTEIRO",
									"Valor Incorreto",
									MessageBoxButtons.OK,
									MessageBoxIcon.Information);
					e.Cancel = true;
					return;
				}

				// check IS MOEDA format
				if (Moeda == true)
				{
					decimal newValor = decimal.Parse(Text, NumberStyles.Currency);
					Text = newValor.ToString("c");
				}
			}
			else
			{
				e.Cancel = false;
			}

		}

		private void UcOnlyNumbers_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
			{
				e.SuppressKeyPress = true;
				SendKeys.Send("{Tab}");
			};
		}

		private void UcOnlyNumbers_LostFocus(object sender, EventArgs e)
		{
			//throw new NotImplementedException();
		}

		private void UcOnlyNumbers_GotFocus(object sender, EventArgs e)
		{
			if (Text.Length > 0) SelectAll();
		}
	}
}
