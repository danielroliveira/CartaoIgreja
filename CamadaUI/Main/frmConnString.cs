using CamadaBLL;
using ComponentOwl.BetterListView;
using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using static CamadaUI.Utilidades;

namespace CamadaUI.Main
{
	public partial class frmConnString : CamadaUI.Models.frmModFinBorder
	{
		private string SourceXMLFile = "";
		private bool ArquivoNovo = false;
		private bool _ArquivoAlterado;
		private string _SelectedString = "";

		#region SUBNEW | PROPERTIES

		// SUB NEW
		//------------------------------------------------------------------------------------------------------------
		public frmConnString()
		{
			InitializeComponent();
		}

		// PROPERTY SELECTED STRING
		//------------------------------------------------------------------------------------------------------------
		public string SelectedString
		{
			get => _SelectedString;
			set
			{
				_SelectedString = value;

				if (string.IsNullOrEmpty(value))
				{
					btnAtualizar.Enabled = false;
					btnRemoverString.Enabled = false;
					btnUsar.Enabled = false;
				}
				else
				{
					btnAtualizar.Enabled = true;
					btnRemoverString.Enabled = true;

					if (ArquivoAlterado || ArquivoNovo)
					{
						btnUsar.Enabled = false;
					}
					else
					{
						btnUsar.Enabled = true;
					}
				}
			}
		}

		// PROPERTY ARQUIVO ALTERADO
		//------------------------------------------------------------------------------------------------------------
		public bool ArquivoAlterado
		{
			get => _ArquivoAlterado;
			set
			{
				_ArquivoAlterado = value;

				if (value = true && lstConn.Items.Count > 0)
				{
					btnSalvarArquivo.Enabled = true;
					btnUsar.Enabled = false;
				}
				else
				{
					btnSalvarArquivo.Enabled = false;
				}

			}
		}

		#endregion

		#region BUTTONS

		// Obter Abrir Arquivo
		private void btnObterArquivo_Click(object sender, EventArgs e)
		{
			using (OpenFileDialog OFD = new OpenFileDialog())
			{
				OFD.Filter = "XML (*.xml)|*.xml";
				OFD.InitialDirectory = FuncoesGlobais.appDataSavePath;

				if (OFD.ShowDialog() == DialogResult.OK)
				{
					SourceXMLFile = OFD.FileName;
					lblCaminho.Text = SourceXMLFile;
					ArquivoNovo = false;
					ArquivoAlterado = false;

					LoadXMLConnection();
				}
			}
		}

		// BTN FECHAR FORM | CANCELAR
		//------------------------------------------------------------------------------------------------------------
		private void btnClose_Click(object sender, EventArgs e)
		{
			DialogResult = DialogResult.Cancel;
		}

		// BTN NOVA STRING
		//------------------------------------------------------------------------------------------------------------
		private void btnNovaString_Click(object sender, EventArgs e)
		{
			//--- check SourceXMLFile
			if (string.IsNullOrEmpty(SourceXMLFile))
			{
				MessageBox.Show("Favor escolher antes um arquivo XML válido...",
					"Arquivo XML Inválido", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				return;
			}

			//--- check text on txtConnString
			if (txtConnString.Text.Trim().Length < 10)
			{
				MessageBox.Show("String de Conexão inválida... \n" +
					"Favor entrar com uma nova String de Conexão válida",
					"String Inválida",
					MessageBoxButtons.OK,
					MessageBoxIcon.Exclamation);
				txtConnString.Focus();
				txtConnString.SelectAll();
				return;
			}

			string novaString = "";
			DialogResult response = InputBoxTexto("Titulo", ref novaString);

			if (response == DialogResult.Cancel || string.IsNullOrEmpty(novaString)) return;

			//--- check if duplicated string name
			foreach (var item in lstConn.Items)
			{
				if (item.Text == novaString.Trim())
				{
					MessageBox.Show("Já existe uma string de conexão com esse mesmo nome... \n" +
					"Favor entrar com um nome diferente.",
					"Nome Inválido",
					MessageBoxButtons.OK,
					MessageBoxIcon.Exclamation);
					return;
				}
			}

			//--- EXECUTE
			lstConn.Items.Add(new string[] { novaString, txtConnString.Text.Trim() });
			txtConnString.Clear();
			ArquivoAlterado = true;
		}

		// BTN REMOVER STRING
		//------------------------------------------------------------------------------------------------------------
		private void btnRemoverString_Click(object sender, EventArgs e)
		{
			if (lstConn.Items.Count == 1)
			{
				MessageBox.Show("Não é possível salvar arquivo de acesso do Servidor sem pelo menos uma String de Conexão",
								"Somente uma String",
								MessageBoxButtons.OK,
								MessageBoxIcon.Information);
				return;
			}

			if (lstConn.SelectedItems.Count > 0)
			{
				lstConn.Items.RemoveAt(lstConn.SelectedItems[0].Index);
				ArquivoAlterado = true;
			}
		}

		// BTN ATUALIZAR STRING
		//------------------------------------------------------------------------------------------------------------
		private void btnAtualizar_Click(object sender, EventArgs e)
		{
			//--- check SourceXMLFile
			if (string.IsNullOrEmpty(SourceXMLFile))
			{
				MessageBox.Show("Favor escolher antes um arquivo XML válido...",
								"Arquivo XML Inválido", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				return;
			}

			//--- check text on txtConnString
			if (txtConnString.Text.Trim().Length < 10)
			{
				MessageBox.Show("String de Conexão inválida... \n" +
								"Favor entrar com uma nova String de Conexão válida",
								"String Inválida", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				txtConnString.Focus();
				txtConnString.SelectAll();
				return;
			}

			//--- execute
			if (lstConn.SelectedItems.Count > 0)
			{
				var novaString = lstConn.SelectedItems[0].Text;
				lstConn.Items.First(x => x.Text == novaString).SubItems[1].Text = txtConnString.Text.Trim();
				ArquivoAlterado = true;
			}
		}

		// BTN SALVAR STRING
		//------------------------------------------------------------------------------------------------------------
		private void btnSalvarArquivo_Click(object sender, EventArgs e)
		{
			try
			{
				// --- Ampulheta ON
				Cursor.Current = Cursors.WaitCursor;

				XmlTextWriter writer = new XmlTextWriter(SourceXMLFile, Encoding.UTF8);

				writer.WriteStartDocument();

				//--- define a indentação do arquivo
				writer.Formatting = Formatting.Indented;

				writer.WriteStartElement("configuration");
				writer.WriteStartElement("userSettings");
				writer.WriteStartElement("MySettings");

				foreach (var item in lstConn.Items)
				{
					writer.WriteStartElement("setting");
					// atributo para marcar arquivo recebido
					writer.WriteAttributeString("name", item.Text);
					// atributo para marcar arquivo devolvido e confirmado
					writer.WriteAttributeString("serializeAs", "String");
					writer.WriteElementString("value", item.SubItems[1].Text);
					writer.WriteEndElement(); // setting
				}

				writer.WriteEndElement(); // END: MySettings
				writer.WriteEndElement(); // END: userSettings

				//--- CONFIG EMAIL ELEMENTS
				writer.WriteStartElement("emailServerSettings"); //--- START

				writer.WriteElementString("emailUserName", "");
				writer.WriteElementString("emailPassword", "");
				writer.WriteElementString("smtpPort", "");
				writer.WriteElementString("smtpHost", "");
				writer.WriteElementString("smtpEnableSSL", "");
				writer.WriteElementString("logoRemotaURL", "");
				writer.WriteElementString("sitePadraoURL", "");

				writer.WriteEndElement(); // END: emailServerSettings

				writer.WriteEndElement(); // END: configuration
				writer.Close();

				ArquivoAlterado = false;
				ArquivoNovo = false;

			}
			catch (Exception ex)
			{
				AbrirDialog("Uma exceção ocorreu ao Salvar Arquivo XML..." + "\n" +
							ex.Message, "Exceção", DialogType.OK, DialogIcon.Exclamation);
			}
			finally
			{
				// --- Ampulheta OFF
				Cursor.Current = Cursors.Default;
			}
		}

		// BTN CRIAR ARQUIVO
		//------------------------------------------------------------------------------------------------------------
		private void btnCriarArquivo_Click(object sender, EventArgs e)
		{
			using (SaveFileDialog OFD = new SaveFileDialog()
			{
				Filter = "XML (*.xml)|*.xml",
				InitialDirectory = FuncoesGlobais.appDataSavePath
			})
			{
				if (OFD.ShowDialog() == DialogResult.OK)
				{
					SourceXMLFile = OFD.FileName;
					lblCaminho.Text = SourceXMLFile;
					ArquivoNovo = true;
					ArquivoAlterado = false;
				}
			}
		}

		// BTN USAR STRING
		//------------------------------------------------------------------------------------------------------------
		private void btnUsar_Click(object sender, EventArgs e)
		{
			AcessoControlBLL acessoControl = new AcessoControlBLL();

			try
			{
				if (lstConn.SelectedItems.Count == 0)
				{
					AbrirDialog("Favor abrir o arquivo chave e selecionar uma string de conexão",
						"Selecionar String", DialogType.OK, DialogIcon.Exclamation);
					return;
				}

				acessoControl.SaveConnString(SourceXMLFile, lstConn.SelectedItems[0].Text);
				DialogResult = DialogResult.OK;
			}
			catch (Exception ex)
			{
				MessageBox.Show("Uma exceção ocorreu ao Salvar arquivo de configuração... /n" +
								ex.Message, "Exceção", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		#endregion

		#region FUNCTIONS

		private bool LoadXMLConnection()
		{
			XmlDocument doc = new XmlDocument();

			try
			{
				// --- Ampulheta ON
				Cursor.Current = Cursors.WaitCursor;

				doc.Load(SourceXMLFile);

				//--- CHECK XML FILE
				bool check1 = doc.GetElementsByTagName("userSettings").Count == 1;
				bool check2 = doc.GetElementsByTagName("MySettings").Count == 1;
				bool check3 = doc.GetElementsByTagName("setting").Count > 0;

				if (!(check1 && check2 && check3))
				{
					MessageBox.Show("Arquivo XML Inválido", "XML Inválido",
									MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
					SourceXMLFile = "";
					lblCaminho.Text = SourceXMLFile;
					return false;
				}

				//--- FILL LIST ITEMS
				lstConn.Items.Clear();

				XmlNodeList stringsConn = doc.GetElementsByTagName("setting");

				foreach (XmlNode conn in stringsConn)
				{
					lstConn.Items.Add(new string[] { conn.Attributes["name"].Value, conn.SelectSingleNode("value").InnerText });
				}

			}
			catch (Exception ex)
			{
				AbrirDialog("Uma exceção ocorreu ao Ler Arquivo XML..." + "\n" +
							ex.Message, "Exceção", DialogType.OK, DialogIcon.Exclamation);
				return false;
			}
			finally
			{
				// --- Ampulheta OFF
				Cursor.Current = Cursors.Default;
			}

			//--- RETURN
			return true;
		}

		// AO ALTERAR INDEX DA LISTAGEM
		//------------------------------------------------------------------------------------------------------------
		private void lstConn_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (lstConn.SelectedItems.Count > 0)
			{
				try
				{
					var ConnString = lstConn.SelectedItems[0].SubItems[1].Text;

					string[] itens = ConnString.Split(';');

					var originalPass = itens.FirstOrDefault(x => x.StartsWith("Password"));
					var encryptPass = "";
					var init = itens.FirstOrDefault(x => x.StartsWith("Initial Catalog"));

					if (init != null)
					{
						init = init.Replace("Initial Catalog=", "");
					}
					else
					{
						AbrirDialog("String de Conexão Inválida:\n\n" +
							"Não há Initial Catalog", "String Inválida",
							DialogType.OK, DialogIcon.Warning);
					}

					//--- control initial catalog LENGHT
					var len = init.Length;

					if (len != 16)
					{
						if (len < 16)
						{
							while (init.Length != 16) init += "_";
						}
						else
						{
							init = init.Substring(0, 16);
						}
					}

					if (originalPass != null)
					{
						originalPass = originalPass.Replace("Password=", "");

						// encrypt password
						var util = new EncryptDecrypt(Encoding.ASCII.GetBytes(init));
						encryptPass = util.Encrypt(originalPass);

						// change visible password to encrypt pass
						var i = Array.IndexOf(itens, itens.FirstOrDefault(x => x.StartsWith("Password")));
						itens[i] = "Password=" + encryptPass;

						txtPassword.Visible = false;
						lblPassword.Visible = false;
						txtConnString.Height = 112;
					}
					else
					{
						encryptPass = "";
						originalPass = "";
						txtPassword.Visible = true;
						lblPassword.Visible = true;
						txtConnString.Height = 74;
					}

					txtConnString.Text = string.Join("\r\n", itens);

					SelectedString = lstConn.SelectedItems[0].Text;
				}
				catch (Exception ex)
				{
					AbrirDialog("Uma exceção ocorreu ao Verificar a string de Conexão..." + "\n" +
								ex.Message, "Exceção", DialogType.OK, DialogIcon.Exclamation);
				}
			}
			else
			{
				txtConnString.Text = "";
				SelectedString = "";
			}
		}

		private void lstConn_DrawColumnHeader(object sender, BetterListViewDrawColumnHeaderEventArgs eventArgs)
		{
			if (eventArgs.ColumnHeaderBounds.BoundsOuter.Width > 0 && eventArgs.ColumnHeaderBounds.BoundsOuter.Height > 0)
			{
				Brush brush = new LinearGradientBrush(
					eventArgs.ColumnHeaderBounds.BoundsOuter,
					Color.Transparent,
					Color.FromArgb(64, Color.SteelBlue),
					LinearGradientMode.Vertical
					);
				eventArgs.Graphics.FillRectangle(brush, eventArgs.ColumnHeaderBounds.BoundsOuter);
				brush.Dispose();
			}
		}

		#endregion
	}

	//=================================================================================================
	// ENCRYPT CLASS
	//=================================================================================================
	public class EncryptDecrypt
	{
		public byte[] Key { get; set; }
		public byte[] IniVetor { get; set; }
		public Aes Algorithm { get; set; }

		public EncryptDecrypt(byte[] key)
		{
			var listKey = key.ToList();

			if (listKey.Count != 16)
			{
				if (listKey.Count > 16)
				{
					listKey.RemoveRange(15, listKey.Count - 1);
				}
				else
				{
					for (int i = 16 - listKey.Count; i < 16; i++)
					{
						listKey.Add((byte)(i + 1));
					}
				}
			}

			this.Key = listKey.ToArray();
			this.IniVetor = new byte[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16 };

			this.Algorithm = Aes.Create();
		}

		public EncryptDecrypt(byte[] key, byte[] iniVetor)
		{
			this.Key = key;
			this.IniVetor = iniVetor;
			this.Algorithm = Aes.Create();
		}

		public string Encrypt(string entryText)
		{
			byte[] symEncryptedData;

			var dataToProtectAsArray = Encoding.UTF8.GetBytes(entryText);
			using (var encryptor = this.Algorithm.CreateEncryptor(this.Key, this.IniVetor))
			using (var memoryStream = new MemoryStream())
			using (var cryptoStream = new CryptoStream(memoryStream, encryptor, CryptoStreamMode.Write))
			{
				cryptoStream.Write(dataToProtectAsArray, 0, dataToProtectAsArray.Length);
				cryptoStream.FlushFinalBlock();
				symEncryptedData = memoryStream.ToArray();
			}
			this.Algorithm.Dispose();
			return Convert.ToBase64String(symEncryptedData);
		}

		public string Decrypt(string entryText)
		{
			var symEncryptedData = Convert.FromBase64String(entryText);
			byte[] symUnencryptedData;
			using (var decryptor = this.Algorithm.CreateDecryptor(this.Key, this.IniVetor))
			using (var memoryStream = new MemoryStream())
			using (var cryptoStream = new CryptoStream(memoryStream, decryptor, CryptoStreamMode.Write))
			{
				cryptoStream.Write(symEncryptedData, 0, symEncryptedData.Length);
				cryptoStream.FlushFinalBlock();
				symUnencryptedData = memoryStream.ToArray();
			}
			this.Algorithm.Dispose();
			return System.Text.Encoding.Default.GetString(symUnencryptedData);
		}
	}
}
