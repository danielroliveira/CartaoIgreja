using CamadaBLL;
using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using static CamadaUI.Utilidades;
using static CamadaUI.FuncoesGlobais;
using System.Xml;
using System.Drawing;

namespace CamadaUI.Config
{
	public partial class frmConfigImagem : Modals.frmModConfig
	{
		Image ImageLogoColor = null;
		Image ImageLogoMono = null;

		#region SUB NEW | LOAD

		// SUB NEW
		public frmConfigImagem()
		{
			InitializeComponent();
			LoadConfig();
			LerLogosImagem();
			HandlerKeyDownControl(this);
		}

		// LOAD
		private void frmConfigImagem_Load(object sender, EventArgs e)
		{
			txtLogoColorCaminho.Focus();
		}

		#endregion

		#region IMAGENS

		// LOAD IMAGES
		private bool LerLogosImagem()
		{
			bool resp = false;

			// Ler a imagem do arquivo da LOGO COLOR
			if (txtLogoColorCaminho.Text.Length > 0)
			{
				try
				{
					ImageLogoColor = Image.FromFile(txtLogoColorCaminho.Text);
					picLogoColor.Image = ImageLogoColor;
					resp = true;
				}
				catch (Exception)
				{
					AbrirDialog("O arquivo de imagem da LOGO Colorida não foi encontrado no caminho especificado:\n" + txtLogoMonoCaminho.Text,
						"Erro: Arquivo da Logo",
						DialogType.OK,
						DialogIcon.Information);
					resp = false;
				}
			}

			// Ler a imagem do arquivo da LOGO MONO
			if (txtLogoMonoCaminho.Text.Length > 0)
			{
				try
				{
					ImageLogoMono = Image.FromFile(txtLogoMonoCaminho.Text);
					picLogoMono.Image = ImageLogoMono;
				}
				catch (Exception)
				{
					AbrirDialog("O arquivo de imagem da LOGO Monocromática não foi encontrado no caminho especificado:\n" +
						txtLogoMonoCaminho.Text,
						"Erro: Arquivo da Logo",
						DialogType.OK,
						DialogIcon.Information);
					resp = false;
				}
			}
			return resp;
		}

		private bool Copia_LogoColor()
		{
			try
			{
				// --- se o arquivo foi selecionado
				if (txtLogoColorCaminho.Text.Length > 0)
				{
					// --- copia LOGO COLOR
					if (txtLogoColorCaminho.Text != Application.StartupPath + @"\Imagens\LogoColor.png")
					{
						if (!Directory.Exists(Application.StartupPath + @"\Imagens"))
						{
							Directory.CreateDirectory(Application.StartupPath + @"\Imagens");
						}

						File.Copy(txtLogoColorCaminho.Text, Application.StartupPath + @"\Imagens\LogoColor.png", true);
						txtLogoColorCaminho.Text = Application.StartupPath + @"\Imagens\LogoColor.png";
					}
				}
				else
					return false;
			}
			catch (Exception ex)
			{
				AbrirDialog("Um erro aconteceu ao copiar a LogoColor para o diretório padrão...\n" +
					ex.Message, "Exceção", DialogType.OK, DialogIcon.Exclamation);
				return false;
			}
			return true;
		}

		private bool Copia_LogoMono()
		{
			try
			{
				// --- se o arquivo foi selecionado
				if (txtLogoMonoCaminho.Text.Length > 0)
				{
					// --- copia LOGO COLOR
					if (txtLogoMonoCaminho.Text != Application.StartupPath + @"\Imagens\LogoMono.png")
					{
						if (!Directory.Exists(Application.StartupPath + @"\Imagens"))
						{
							Directory.CreateDirectory(Application.StartupPath + @"\Imagens");
						}

						File.Copy(txtLogoMonoCaminho.Text, Application.StartupPath + @"\Imagens\LogoMono.png", true);
						txtLogoMonoCaminho.Text = Application.StartupPath + @"\Imagens\LogoMono.png";
					}
				}
				else
					return false;
			}
			catch (Exception ex)
			{
				AbrirDialog("Um erro aconteceu ao copiar a LogoMono para o diretório padrão...\n" +
					ex.Message, "Exceção", DialogType.OK, DialogIcon.Exclamation);
				return false;
			}
			return true;
		}

		#endregion // IMAGENS --- END

		#region BUTTONS FUNCTION

		private void btnProcLogoColor_Click(object sender, EventArgs e)
		{
			using (OpenFileDialog OFD = new OpenFileDialog() { Filter = "PNG (*.png)|*.png" })
			{
				if (OFD.ShowDialog() == DialogResult.OK)
				{
					txtLogoColorCaminho.Text = OFD.FileName;
					ImageLogoColor = Image.FromFile(OFD.FileName);
					picLogoColor.Image = ImageLogoColor;
					btnSalvarConfig.Enabled = true;
				}
			}
		}

		private void btnProcurarImagem_Click(object sender, EventArgs e)
		{
			using (OpenFileDialog OFD = new OpenFileDialog() { Filter = "PNG (*.png)|*.png" })
			{
				if (OFD.ShowDialog() == DialogResult.OK)
				{
					txtLogoMonoCaminho.Text = OFD.FileName;
					ImageLogoMono = Image.FromFile(OFD.FileName);
					picLogoMono.Image = ImageLogoMono;
					btnSalvarConfig.Enabled = true;
				}
			}
		}

		// CLOSE
		// =============================================================================
		private void btnClose_Click(object sender, EventArgs e)
		{
			frmConfig f = Application.OpenForms.OfType<frmConfig>().FirstOrDefault();
			f.FormNoPanelClosed(this);
		}

		#endregion

		#region CONTROLS FUNCTIONS

		// FORM KEYPRESS: BLOQUEIA (+)
		//------------------------------------------------------------------------------------------------------------
		private void frm_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (e.KeyChar == 43)
			{
				//--- cria uma lista de controles que serao impedidos de receber '+'
				Control[] controlesBloqueados = {
					txtLogoColorCaminho, txtLogoMonoCaminho
				};

				if (controlesBloqueados.Contains(ActiveControl)) e.Handled = true;
			}
		}

		// CONTROL KEYDOWN: BLOCK (+), CREATE (DELETE), BLOCK EDIT
		//------------------------------------------------------------------------------------------------------------
		private void Control_KeyDown(object sender, KeyEventArgs e)
		{

			Control ctr = (Control)sender;

			if (e.KeyCode == Keys.Add || e.KeyCode == Keys.F4)
			{
				e.Handled = true;

				switch (ctr.Name)
				{
					case "txtLogoColorCaminho":
						btnProcLogoColor_Click(sender, new EventArgs());
						break;
					case "txtLogoMonoCaminho":
						btnProcurarImagem_Click(sender, new EventArgs());
						break;
					default:
						break;
				}
			}
			else
			{
				//--- cria um array de controles que serão bloqueados de alteracao
				Control[] controlesBloqueados = { txtLogoColorCaminho, txtLogoMonoCaminho };

				if (controlesBloqueados.Contains(ctr))
				{
					e.Handled = true;
					e.SuppressKeyPress = true;
				}
			}
		}

		#endregion // CONTROLS FUNCTIONS --- END

		#region XML FUNCTIONS

		private void LoadConfig()
		{
			try
			{
				XmlDocument doc = MyConfig();

				if (doc == null)
				{
					throw new Exception("Arquivo de Configuração Inválido...");
				}

				txtLogoColorCaminho.Text = LoadNode(doc, "ArquivoLogoColor");
				txtLogoMonoCaminho.Text = LoadNode(doc, "ArquivoLogoMono");

			}
			catch (Exception ex)
			{
				AbrirDialog("Uma exceção ocorreu ao Ler arquivo XML..." + "\n" +
							ex.Message, "Exceção", DialogType.OK, DialogIcon.Exclamation);
			}

		}

		private string LoadNode(XmlDocument doc, string nodeName)
		{
			XmlNodeList elemList = doc.GetElementsByTagName(nodeName);
			string myValor = "";

			for (int i = 0; i < elemList.Count; i++)
			{
				myValor = elemList[i].InnerXml;
			}

			return myValor;
		}

		#endregion

		#region SAVE CONFIG

		// SAVE CONFIG
		//------------------------------------------------------------------------------------------------------------
		private void btnSalvarConfig_Click(object sender, EventArgs e)
		{
			try
			{
				// --- Ampulheta ON
				Cursor.Current = Cursors.WaitCursor;

				//--- faz a copia dir padrao
				Copia_LogoColor();
				Copia_LogoMono();

				// save items
				SaveConfigValorNode("ArquivoLogoColor", txtLogoColorCaminho.Text);
				SaveConfigValorNode("ArquivoLogoMono", txtLogoMonoCaminho.Text);
				btnSalvarConfig.Enabled = false;


				AbrirDialog("Arquivo de Configuração Salvo com sucesso!", "Arquivo Salvo",
					DialogType.OK, DialogIcon.Information);
			}
			catch (Exception ex)
			{
				AbrirDialog("Uma exceção ocorreu ao Salvar o arquivo de Configuração..." + "\n" +
							ex.Message, "Exceção", DialogType.OK, DialogIcon.Exclamation);
			}
			finally
			{
				// --- Ampulheta OFF
				Cursor.Current = Cursors.Default;
			}
		}

		#endregion // SAVE CONFIG --- END
	}
}
