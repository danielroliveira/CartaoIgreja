using System;
using System.Linq;
using System.Windows.Forms;
using static CamadaUI.Utilidades;
using static CamadaUI.FuncoesGlobais;
using System.Xml;

namespace CamadaUI.Config
{
	public partial class frmConfigDados : Models.frmModConfig
	{
		#region SUB NEW | LOAD

		// SUB NEW
		public frmConfigDados()
		{
			InitializeComponent();
			LoadConfig();

			HandlerKeyDownControl(this);
			txtCNPJ.GotFocus += onFocus;
			txtCEP.GotFocus += onFocus;
		}

		// LOAD
		private void frmConfigDados_Load(object sender, EventArgs e)
		{
			txtRazao.Focus();
		}

		// MASK TEXT SELECTALL ON FOCUS
		private void onFocus(object sender, EventArgs e)
		{
			((MaskedTextBox)sender).SelectAll();
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

				txtRazao.Text = LoadNode(doc, "RazaoSocial");
				txtCNPJ.Text = LoadNode(doc, "CNPJ");
				txtTelefoneFixo.Text = LoadNode(doc, "TelefonePrincipal");
				txtTelefoneFinanceiro.Text = LoadNode(doc, "TelefoneFinanceiro");
				txtContatoFinanceiro.Text = LoadNode(doc, "ContatoFinanceiro");
				txtEndereco.Text = LoadNode(doc, "Endereco");
				txtBairro.Text = LoadNode(doc, "Bairro");
				txtCidade.Text = LoadNode(doc, "Cidade");
				txtUF.Text = LoadNode(doc, "UF");
				txtCEP.Text = LoadNode(doc, "CEP");
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
				SaveConfigValorNode("RazaoSocial", txtRazao.Text);
				SaveConfigValorNode("CNPJ", txtCNPJ.Text);
				SaveConfigValorNode("TelefonePrincipal", txtTelefoneFixo.Text);
				SaveConfigValorNode("TelefoneFinanceiro", txtTelefoneFinanceiro.Text);
				SaveConfigValorNode("ContatoFinanceiro", txtContatoFinanceiro.Text);
				SaveConfigValorNode("Endereco", txtEndereco.Text);
				SaveConfigValorNode("Bairro", txtBairro.Text);
				SaveConfigValorNode("Cidade", txtCidade.Text);
				SaveConfigValorNode("UF", txtUF.Text);
				SaveConfigValorNode("CEP", txtCEP.Text);

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
			if (!VerificaControle(txtRazao, "RAZÃO SOCIAL DA IGREJA")) return false;
			if (!VerificaControle(txtEndereco, "ENDEREÇO DA IGREJA")) return false;
			if (!VerificaControle(txtBairro, "BAIRRO DA IGREJA")) return false;
			if (!VerificaControle(txtCidade, "CIDADE DA IGREJA")) return false;
			if (!VerificaControle(txtUF, "ESTADO DA IGREJA")) return false;

			return true;
		}

		#endregion // SAVE CONFIG --- END
	}
}
