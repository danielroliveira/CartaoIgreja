using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Resources;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace CamadaUI
{
	//=================================================================================================
	// UTILITIES
	//=================================================================================================
	public static class Utilidades
	{
		// MESSAGE DIALOG BOX
		// =============================================================================
		public static DialogResult AbrirDialog
			(string Message,
			string Title,
			DialogType Type = DialogType.OK,
			DialogIcon Icon = DialogIcon.Information,
			DialogDefaultButton DefaultButton = DialogDefaultButton.First)
		{
			using (Main.frmMessage f = new Main.frmMessage(Message, Title, Type, Icon, DefaultButton))
			{
				f.ShowDialog();
				return f.DialogResult;
			}
		}

		// VERIFY IS STRING CAN CHANGE TO NUMERIC
		// =============================================================================
		public static bool IsNumeric(this string text) => double.TryParse(text, out _);

		// RESIZE FONT SIZE LABEL TO FIT ALL TEXT
		// =============================================================================
		public static void ResizeFontLabel(Label myLabel)
		{
			Font lblFont = new Font(myLabel.Font.FontFamily, myLabel.Font.Size, myLabel.Font.Style);

			while (myLabel.Width < TextRenderer.MeasureText(myLabel.Text, lblFont).Width)
			{
				myLabel.Font = new Font(myLabel.Font.FontFamily, myLabel.Font.Size - 0.5F, myLabel.Font.Style);
				lblFont = new Font(myLabel.Font.FontFamily, myLabel.Font.Size, myLabel.Font.Style);
			}
		}

		// HANDLER DEFAULT FOR TEXTBOX ENTER => TAB
		// =============================================================================
		public static void HandlerKeyDownControl(Form form)
		{
			//--- Tipos de Controles
			List<Type> types = new List<Type>()
			{
				typeof(TextBox),
				typeof(ComboBox),
				typeof(MaskedTextBox),
				typeof(DateTimePicker),
				typeof(CheckBox)
			};

			//--- para cada TabPage no tabPrincipal
			foreach (Control control in form.Controls)
			{

				if (control.Controls.Count > 0)
				{
					foreach (Control item in control.Controls)
					{
						if (types.Contains(item.GetType()))
						{
							item.KeyDown += Control_KeyDown;
						}
					}
				}
				else
				{
					if (types.Contains(control.GetType()))
					{
						control.KeyDown += Control_KeyDown;
					}
				}

			}
		}
		static void Control_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
			{
				e.SuppressKeyPress = true;
				SendKeys.Send("{Tab}");
			};
		}

		// GET TEXT AND RETURN CNPJ OR CPF FORMAT STRING
		//=================================================================================================
		public static string CNPConvert(string CNP)
		{
			// remove '/' and '.' and '-'
			CNP = CNP.Replace("/", "").Replace("-", "").Replace(".", "");

			if (CNP.Length == 11)
			{
				// txtCNPJ.Mask = "000,000,000-00"
				return CNP.Insert(3, ".").Insert(7, ".").Insert(11, "-");
			}
			else if (CNP.Length == 14)
			{
				// txtCNPJ.Mask = "00,000,000/0000-00"
				return CNP.Insert(2, ".").Insert(6, ".").Insert(10, "/").Insert(15, "-");
			}
			else
			{
				throw new CamadaDTO.AppException("Número de CNPJ ou CPF inválido...");
			}
		}

		// REMOVE ACENTOS FUNCTION
		//=================================================================================================
		public static string RemoveAcentos(string texto)
		{
			for (int i = 0; i < texto.Length; i++)
			{

			}

			int vPos;

			const string vComAcento = "ÀÁÂÃÄÅÇÈÉÊËÌÍÎÏÒÓÔÕÖÙÚÛÜàáâãäåçèéêëìíîïòóôõöùúûü`´^~";
			const string vSemAcento = "AAAAAACEEEEIIIIOOOOOUUUUaaaaaaceeeeiiiiooooouuuu    ";
			string newTexto = "";

			for (int i = 0; i < texto.Length; i++)
			{
				vPos = vComAcento.IndexOf(texto.ElementAt(i));

				if (vPos != -1)
				{
					newTexto += vSemAcento.ElementAt(vPos);
				}
				else
				{
					newTexto += texto.ElementAt(i);
				}
			}

			return newTexto.Trim();
		}

		// PRIMEIRA LETRA MAIUSCULA
		//=================================================================================================
		public static string PrimeiraLetraMaiuscula(TextBox textBox)
		{
			string texto = textBox.Text;

			//--- Get chars quantity
			if (texto.Length == 0) return "";


			string[] palavrasLowerCase = {
				"de", "da", "do", "e", "das", "dos"
			};

			string[] palavrasUpperCase = {
				"LTDA", "ltda", "SA", "sa", "S.A.", "s.a.", "me", "ME"
			};

			string[] palavras = texto.Split(' ');  //texto.Split(" ");
			string resposta = "";

			foreach (string palavra in palavras)
			{
				// continue if palavra is EMPTY
				if (string.IsNullOrEmpty(palavra)) continue;

				string newPalavra = palavra.Trim();

				if (palavrasLowerCase.Contains(palavra))
				{
					newPalavra = palavra.ToLower();
				}
				else if (palavrasUpperCase.Contains(palavra))
				{
					newPalavra = palavra.ToUpper();
				}
				else if (palavra == palavra.ToUpper()) //if palavra is UPPER CASE (SIGLA)
				{
					newPalavra = palavra;
				}
				else
				{
					newPalavra = palavra.ToLower(); // convert all to lower case
					char[] caracteres = newPalavra.ToArray();
					caracteres[0] = caracteres[0].ToString().ToUpper()[0];
					newPalavra = string.Join("", caracteres);
				}

				resposta = resposta.Length > 0 ? resposta + " " + newPalavra : newPalavra;
			}

			textBox.Text = resposta;
			return resposta.Trim();
		}

		// VALIDA EMAIL
		//=================================================================================================
		public static bool ValidaEmail(string email)
		{
			string pattern = @"^[a-zA-Z][\w\.-]*[a-zA-Z0-9]@[a-zA-Z0-9][\w\.-]*[a-zA-Z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]$";
			Match emailAddressMatch = Regex.Match(email, pattern);

			return emailAddressMatch.Success;
		}
	}

	//=================================================================================================
	// VALIDA CNPJ | CPF
	//=================================================================================================
	public static class ValidacaoCNP
	{
		public static bool ValidaCNP(string CNP)
		{
			if (CNP.Length > 0)
			{
				CNP = CNP.Replace(".", "").Replace("/", "").Replace("-", "");

				if (CNP.Length == 11)
				{
					return ValidaCPF(CNP);
				}
				else if (CNP.Length == 14)
				{
					return ValidaCNPJ(CNP);
				}
			}

			return false;
		}

		private static bool ValidaCPF(string vrCPF)
		{

			string valor = vrCPF.Replace(".", "").Replace("-", "");

			if (valor.Length != 11)
				return false;

			bool igual = true;

			for (int i = 1; i < 11 && igual; i++)
			{
				if (valor[i] != valor[0])
					igual = false;
			}

			if (igual || valor == "12345678909")
				return false;

			int[] numeros = new int[11];

			for (int i = 0; i < 11; i++)
			{
				numeros[i] = int.Parse(valor[i].ToString());
			}

			int soma = 0;

			for (int i = 0; i < 9; i++)
			{
				soma += (10 - i) * numeros[i];
			}

			int resultado = soma % 11;

			if (resultado == 1 || resultado == 0)
			{
				if (numeros[9] != 0)
					return false;
			}
			else if (numeros[9] != 11 - resultado)
			{
				return false;
			}

			soma = 0;

			for (int i = 0; i < 10; i++)
			{
				soma += (11 - i) * numeros[i];
			}

			resultado = soma % 11;

			if (resultado == 1 || resultado == 0)
			{
				if (numeros[10] != 0)
					return false;
			}
			else
			{
				if (numeros[10] != 11 - resultado)
					return false;
			}

			return true;
		}

		private static bool ValidaCNPJ(string vrCNPJ)
		{

			string CNPJ = vrCNPJ.Replace(".", "").Replace("/", "").Replace("-", "");

			int[] digitos, soma, resultado;
			int nrDig;
			string ftmt;
			bool[] CNPJOk;

			ftmt = "6543298765432";

			digitos = new int[14];
			soma = new int[2];
			soma[0] = 0;
			soma[1] = 0;
			resultado = new int[2];
			resultado[0] = 0;
			resultado[1] = 0;
			CNPJOk = new bool[2];
			CNPJOk[0] = false;
			CNPJOk[1] = false;

			try
			{
				for (nrDig = 0; nrDig < 14; nrDig++)
				{
					digitos[nrDig] = int.Parse(CNPJ.Substring(nrDig, 1));

					if (nrDig <= 11)
						soma[0] += (digitos[nrDig] * int.Parse(ftmt.Substring(nrDig + 1, 1)));

					if (nrDig <= 12)
						soma[1] += (digitos[nrDig] * int.Parse(ftmt.Substring(nrDig, 1)));
				}

				for (nrDig = 0; nrDig < 2; nrDig++)
				{
					resultado[nrDig] = (soma[nrDig] % 11);

					if ((resultado[nrDig] == 0) || (resultado[nrDig] == 1))
						CNPJOk[nrDig] = (digitos[12 + nrDig] == 0);
					else
						CNPJOk[nrDig] = (digitos[12 + nrDig] == (11 - resultado[nrDig]));
				}

				return (CNPJOk[0] && CNPJOk[1]);
			}
			catch
			{
				return false;
			}

		}




	}

}
