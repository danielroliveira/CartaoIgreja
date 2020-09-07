using System;
using System.Linq;
using System.Windows.Forms;
using static CamadaUI.Utilidades;
using static CamadaUI.FuncoesGlobais;
using System.Drawing;
using CamadaDTO;
using System.IO;
using System.Xml;

namespace CamadaUI.Config
{
	public partial class frmConfigGeral : Models.frmModConfig
	{
		private int? _IDCongregacao;

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
					txtContaPadrao, txtSetorPadrao
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
					case "txtContaPadrao":
						break;
					case "txtSetorPadrao":
						break;
					case "txtImageFolder":
						btnProcImageFolder_Click(sender, new EventArgs());
						break;
					default:
						break;
				}
			}
			else
			{
				//--- cria um array de controles que serão bloqueados de alteracao
				Control[] controlesBloqueados = { txtContaPadrao, txtSetorPadrao, txtImageFolder };

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
				_IDCongregacao = string.IsNullOrEmpty(strIDCong) ? null : int.Parse(strIDCong) as int?;
				lblCongregacao.Text = LoadNode(doc, "CongregacaoDescricao");

				// CONTA
				//string strIDConta = LoadNode(doc, "ContaPadrao");
				//_Conta.IDConta = string.IsNullOrEmpty(strIDConta) ? null : int.Parse(strIDConta) as int?;
				txtContaPadrao.Text = LoadNode(doc, "ContaDescricao");

				// SETOR
				//string strIDSetor = LoadNode(doc, "SetorPadrao");
				//_Setor.IDSetor = string.IsNullOrEmpty(strIDSetor) ? null : int.Parse(strIDSetor) as int?;
				txtSetorPadrao.Text = LoadNode(doc, "SetorDescricao");

				// DATA BLOQUEIO | DATA PADRAO
				lblDataBloqueio.Text = LoadNode(doc, "DataBloqueada");
				string DataPadrao = LoadNode(doc, "DataPadrao");
				dtpDataPadrao.Value = string.IsNullOrEmpty(DataPadrao) ? DateTime.Today : Convert.ToDateTime(DataPadrao);

				// CIDADE PADRAO
				txtCidadePadrao.Text = LoadNode(doc, "CidadePadrao");

				// UF PADRAO
				txtUFPadrao.Text = LoadNode(doc, "UFPadrao");

				// IMAGES FOLDER
				txtImageFolder.Text = LoadNode(doc, "DocumentsImageFolder");

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
				SaveConfigValorNode("CongregacaoDescricao", lblCongregacao.Text);
				SaveConfigValorNode("CongregacaoPadrao", _IDCongregacao.ToString());
				SaveConfigValorNode("ContaDescricao", txtContaPadrao.Text);
				SaveConfigValorNode("ContaPadrao", "");
				SaveConfigValorNode("SetorDescricao", txtSetorPadrao.Text);
				SaveConfigValorNode("SetorPadrao", "");
				SaveConfigValorNode("DataPadrao", dtpDataPadrao.Value.ToShortDateString());
				SaveConfigValorNode("CidadePadrao", txtCidadePadrao.Text);
				SaveConfigValorNode("UFPadrao", txtUFPadrao.Text);
				SaveConfigValorNode("DocumentsImageFolder", txtImageFolder.Text);

				//< DocumentsImageFolder ></ DocumentsImageFolder >

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
			if (!VerificaControle(dtpDataPadrao, "DATA PADRÃO")) return false;
			if (!VerificaControle(lblCongregacao, "CONGREGAÇÃO PADRÃO")) return false;
			if (!VerificaControle(txtContaPadrao, "CONTA PADRÃO")) return false;
			if (!VerificaControle(txtSetorPadrao, "SETOR PADRÃO")) return false;
			if (!VerificaControle(txtCidadePadrao, "CIDADE PADRÃO")) return false;
			if (!VerificaControle(txtUFPadrao, "UF PADRÃO")) return false;

			return true;
		}

		#endregion // SAVE CONFIG --- END

		private void btnProcImageFolder_Click(object sender, EventArgs e)
		{
			try
			{
				string oldPath = txtImageFolder.Text;
				string path = "";

				// CHECK IF EXISTS DEFAULT BACKUP FOLDER
				if (oldPath == string.Empty)
				{
					string defFolder = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
					defFolder += "\\Tesouraria\\DocumentosImagens\\";

					if (Directory.Exists(defFolder))
					{
						path = defFolder;
					}
					else
					{
						DialogResult resp = AbrirDialog("Ainda não foi criada a pasta padrão para os Documentos e Comprovantes. \n" +
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
						btnProcImageFolder_Click(sender, e);
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
					Description = "Pasta de Imagens dos Documentos",
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

				SaveConfigValorNode("DocumentsImageFolder", path);
				txtImageFolder.Text = path;
			}
			catch (Exception ex)
			{
				AbrirDialog("Uma exceção ocorreu ao Salvar a pasta de Imagens dos Documentos..." + "\n" +
							ex.Message, "Exceção", DialogType.OK, DialogIcon.Exclamation);
			}
		}
	}
}
