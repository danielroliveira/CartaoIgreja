using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Xml;
using static CamadaUI.FuncoesGlobais;
using static CamadaUI.Utilidades;

namespace CamadaUI.Config
{
	public partial class frmConfigGeral : Models.frmModConfig
	{
		private static string appDataSavePath = Environment.GetFolderPath(
			Environment.SpecialFolder.ApplicationData)
			+ "\\CartaoIgreja";

		#region SUB NEW | LOAD

		// SUB NEW | CONSTRUCTOR
		public frmConfigGeral()
		{
			InitializeComponent();
			LoadConfig();

			HandlerKeyDownControl(this);

		}

		// LOAD
		private void frmConfigGeral_Load(object sender, EventArgs e)
		{
			txtIgrejaTitulo.Focus();
		}

		#endregion

		#region BUTTONS FUNCTION

		// CLOSE
		// =============================================================================
		private void btnClose_Click(object sender, EventArgs e)
		{
			frmConfig f = Application.OpenForms.OfType<frmConfig>().FirstOrDefault();
			f.FormNoPanelClosed(this);
		}

		// CANCELAR BTN
		//------------------------------------------------------------------------------------------------------------
		private void btnCancelar_Click(object sender, EventArgs e)
		{
			LoadConfig();
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
					txtFotosFolder, txtDesignFolder
				};

				if (controlesBloqueados.Contains(ActiveControl)) e.Handled = true;
			}
		}

		// CONTROL KEYDOWN: BLOCK (+), CREATE (DELETE), BLOCK EDIT
		//------------------------------------------------------------------------------------------------------------
		private void Control_KeyDown(object sender, KeyEventArgs e)
		{
			Control ctr = (Control)sender;

			if (ctr.Name == "txtFotosFolder" && cmbImageOrigin.SelectedItem.ToString() == "GoogleDrive")
			{
				return;
			}

			if (e.KeyCode == Keys.Add || e.KeyCode == Keys.F4)
			{
				e.Handled = true;

				switch (ctr.Name)
				{
					case "txtDesignFolder":
						break;
					case "txtFotosFolder":
						btnProcFotosFolder_Click(sender, new EventArgs());
						break;
					default:
						break;
				}
			}
			else
			{
				//--- cria um array de controles que serão bloqueados de alteracao
				Control[] controlesBloqueados = { txtFotosFolder, txtDesignFolder };

				if (controlesBloqueados.Contains(ctr))
				{
					e.Handled = true;
					e.SuppressKeyPress = true;
				}
			}
		}

		// TITULO VALIDATING
		//------------------------------------------------------------------------------------------------------------
		private void txtIgrejaTitulo_Validating(object sender, System.ComponentModel.CancelEventArgs e)
		{
			try
			{
				frmConfig fConfig = Application.OpenForms.OfType<frmConfig>().FirstOrDefault();

				Main.frmPrincipal f = Application.OpenForms.OfType<Main.frmPrincipal>().FirstOrDefault();
				f.AplicacaoTitulo = txtIgrejaTitulo.Text;
			}
			catch (Exception ex)
			{
				AbrirDialog("Houve uma execeção ao salvar Config... \n" +
					ex.Message, "Exceção", DialogType.OK, DialogIcon.Exclamation);
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

				txtIgrejaTitulo.Text = LoadNode(doc, "IgrejaTitulo");

				// CONGREGACAO
				string strIDCong = LoadNode(doc, "CongregacaoPadrao");

				// CIDADE PADRAO
				txtCidadePadrao.Text = LoadNode(doc, "CidadePadrao");

				// VALIDADE ANOS
				numValidade.Text = LoadNode(doc, "ValidadeAnos");

				// UF PADRAO
				txtUFPadrao.Text = LoadNode(doc, "UFPadrao");

				// IMAGES FOLDER
				cmbImageOrigin.SelectedItem = LoadNode(doc, "ImageOrigin");
				Change_cmbImageOrigin();
				txtFotosFolder.Text = LoadNode(doc, "FotosImageFolder");
				txtDesignFolder.Text = LoadNode(doc, "DesignImageFolder");

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
			// check controls
			if (!VerificaControles()) return;

			try
			{
				// --- Ampulheta ON
				Cursor.Current = Cursors.WaitCursor;

				// save items
				SaveConfigValorNode("IgrejaTitulo", txtIgrejaTitulo.Text);
				SaveConfigValorNode("CidadePadrao", txtCidadePadrao.Text);
				SaveConfigValorNode("UFPadrao", txtUFPadrao.Text);
				SaveConfigValorNode("ValidadeAnos", numValidade.Value.ToString());
				SaveConfigValorNode("FotosImageFolder", txtFotosFolder.Text);
				SaveConfigValorNode("DesignImageFolder", txtDesignFolder.Text);
				SaveConfigValorNode("ImageOrigin", cmbImageOrigin.SelectedItem.ToString());

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

		// VERIFICA OS CONTROLES BEFORE SAVE
		//------------------------------------------------------------------------------------------------------------
		private bool VerificaControles()
		{
			if (!VerificaControle(txtIgrejaTitulo, "TÍTULO DA IGREJA")) return false;
			if (!VerificaControle(txtCidadePadrao, "CIDADE PADRÃO")) return false;
			if (!VerificaControle(txtUFPadrao, "UF PADRÃO")) return false;
			if (!VerificaControle(txtFotosFolder, "PASTA DAS FOTOS")) return false;
			if (!VerificaControle(txtDesignFolder, "PASTA DO DESIGN DO CARTÃO")) return false;

			if (cmbImageOrigin.SelectedItem.ToString() == "GoogleDrive")
			{
				if (txtFotosFolder.Text.Contains(":") || txtFotosFolder.Text.Contains("/"))
				{
					AbrirDialog("Favor definir a pasta do GoogleDrive que contém as fotos...\n" +
						"Digite somente o nome da pasta. Essa pasta deve ter um nome exclusivo.",
						"Pasta do Google Drive", DialogType.OK, DialogIcon.Exclamation);
					txtFotosFolder.Focus();
					txtFotosFolder.SelectAll();
					return false;
				}
			}

			return true;
		}

		#endregion // SAVE CONFIG --- END

		private void btnProcFotosFolder_Click(object sender, EventArgs e)
		{
			try
			{
				string oldPath = txtFotosFolder.Text;
				string path = "";

				// CHECK IF EXISTS DEFAULT BACKUP FOLDER
				if (oldPath == string.Empty)
				{
					string defFolder = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
					defFolder += "\\Igreja Cartão\\Fotos\\";

					if (Directory.Exists(defFolder))
					{
						path = defFolder;
					}
					else
					{
						DialogResult resp = AbrirDialog("Ainda não foi criada a pasta padrão das Fotos dos Membros. \n" +
							"Deseja criar a pasta padrão?",
							"Pasta de Fotos",
							DialogType.SIM_NAO,
							DialogIcon.Question);

						if (resp == DialogResult.Yes)
						{
							Directory.CreateDirectory(defFolder);
							path = defFolder;
						}
						else
						{
							path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
						}
					}
				}
				else
				{
					if (!Directory.Exists(oldPath))
					{
						txtFotosFolder.Text = "";
						oldPath = "";
						btnProcFotosFolder_Click(sender, e);
						return;
					}
					else
					{
						path = oldPath;
					}
				}

				// get folder
				using (FolderBrowserDialog FBDiag = new FolderBrowserDialog()
				{
					Description = "Pasta de Fotos dos Membros",
					SelectedPath = path,
					ShowNewFolderButton = true
				})
				{

					DialogResult result = FBDiag.ShowDialog();
					if (result == DialogResult.OK)
					{
						path = FBDiag.SelectedPath;
					}
					else
					{
						return;
					}
				}

				SaveConfigValorNode("FotosImageFolder", path);
				txtFotosFolder.Text = path;
			}
			catch (Exception ex)
			{
				AbrirDialog("Uma exceção ocorreu ao Salvar a pasta de Fotos dos Membros..." + "\n" +
							ex.Message, "Exceção", DialogType.OK, DialogIcon.Exclamation);
			}
		}

		private void btnProcDesignFolder_Click(object sender, EventArgs e)
		{
			try
			{
				string oldPath = txtDesignFolder.Text;
				string path = "";

				// CHECK IF EXISTS DEFAULT BACKUP FOLDER
				if (oldPath == string.Empty)
				{
					string defFolder = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
					defFolder += "\\Igreja Cartão\\Design\\";

					if (Directory.Exists(defFolder))
					{
						path = defFolder;
					}
					else
					{
						DialogResult resp = AbrirDialog("Ainda não foi criada a pasta padrão para o Design dos Cartões. \n" +
							"Deseja criar a pasta padrão?",
							"Pasta de Documentos",
							DialogType.SIM_NAO,
							DialogIcon.Question);

						if (resp == DialogResult.Yes)
						{
							Directory.CreateDirectory(defFolder);
							path = defFolder;
						}
						else
						{
							path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
						}
					}
				}
				else
				{
					if (!Directory.Exists(oldPath))
					{
						oldPath = "";
						txtDesignFolder.Text = "";
						btnProcDesignFolder_Click(sender, e);
						return;
					}
					else
					{
						path = oldPath;
					}
				}

				// get folder
				using (FolderBrowserDialog FBDiag = new FolderBrowserDialog()
				{
					Description = "Pasta de Imagens do Design dos Cartões",
					SelectedPath = path,
					ShowNewFolderButton = true
				})
				{

					DialogResult result = FBDiag.ShowDialog();
					if (result == DialogResult.OK)
					{
						path = FBDiag.SelectedPath;
					}
					else
					{
						return;
					}
				}

				SaveConfigValorNode("DesignImageFolder", path);
				txtDesignFolder.Text = path;
			}
			catch (Exception ex)
			{
				AbrirDialog("Uma exceção ocorreu ao Salvar a pasta do Design dos Cartões..." + "\n" +
							ex.Message, "Exceção", DialogType.OK, DialogIcon.Exclamation);
			}
		}

		private void cmbImageOrigin_SelectionChangeCommitted(object sender, EventArgs e)
		{
			Change_cmbImageOrigin();
		}

		// CHANGE COMBO IMAGE ORIGIN
		//------------------------------------------------------------------------------------------------------------
		private void Change_cmbImageOrigin()
		{
			if (cmbImageOrigin.SelectedItem.ToString() == "Drive Local")
			{
				lblOrigemPath.Text = "Pasta Local das Fotos de Membros:";
				btnCredencial.Visible = false;
				btnProcFotosFolder.Visible = true;
			}
			else
			{
				lblOrigemPath.Text = "Pasta das Fotos de Membros no Google Drive:";
				btnCredencial.Visible = true;
				btnProcFotosFolder.Visible = false;
				CheckCredentialFile(true);
			}
		}

		// CHECK CREDENTIAL FILE
		//------------------------------------------------------------------------------------------------------------
		private bool CheckCredentialFile(bool showmessage)
		{
			if (cmbImageOrigin.SelectedItem.ToString() != "GoogleDrive") return true;

			var filepath = ObterDefault("CredentialPath");

			if (string.IsNullOrEmpty(filepath) || !File.Exists(filepath))
			{
				if (showmessage)
					AbrirDialog("A Credencial de acesso ao GoogleDrive ainda não foi definida...\n" +
						"Favor definir o arquivo da credencial.", "Credencial", DialogType.OK, DialogIcon.Exclamation);

				btnCredencial.Text = "Definir Credencial...";
				btnCredencial.BackColor = System.Drawing.Color.MistyRose;
				return false;
			}

			btnCredencial.BackColor = System.Drawing.Color.Azure;
			btnCredencial.Text = "Alterar Credencial...";
			return true;
		}

		// DEFINIR A CREDENCIAL
		//------------------------------------------------------------------------------------------------------------
		private void btnCredencial_Click(object sender, EventArgs e)
		{
			//--- open dialog
			DialogResult result = ofgJsonFile.ShowDialog();

			//--- get result
			if (result != DialogResult.OK) return;

			//--- check exists credential
			if (CheckCredentialFile(false))
			{
				var resp = AbrirDialog("Já existe uma credencial definida...\n" +
					"Deseja realmente alterar o arquivo de credencial atual?",
					"Credencial Existente", DialogType.SIM_NAO, DialogIcon.Question, DialogDefaultButton.Second);

				if (resp == DialogResult.No) return;
			}

			try
			{
				//--- create directory
				Directory.CreateDirectory(appDataSavePath);

				//--- copy Credential
				var jsonfile = ofgJsonFile.FileName;
				File.Copy(jsonfile, Path.Combine(appDataSavePath, "credential.json"), true);

				//--- save Config
				SaveConfigValorNode("CredentialPath", Path.Combine(appDataSavePath, "credential.json"));
			}
			catch (Exception ex)
			{
				AbrirDialog("Uma exceção ocorreu ao Salvar a Credencial..." + "\n" +
							ex.Message, "Exceção", DialogType.OK, DialogIcon.Exclamation);
			}
		}
	}
}
