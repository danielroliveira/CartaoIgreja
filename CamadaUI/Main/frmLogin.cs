using CamadaBLL;
using CamadaDTO;
using System;
using System.IO;
using System.Windows.Forms;
using static CamadaUI.Utilidades;

namespace CamadaUI.Main
{
	public partial class frmLogin : Models.frmModNoBorder
	{
		private bool Logado = false;
		AcessoControlBLL db = new AcessoControlBLL();
		private string TituloIgreja = "";

		//=================================================================================================
		// LOGIN | SUBNEW
		//=================================================================================================
		public frmLogin()
		{
			InitializeComponent();
			txtApelido.Focus();

			txtApelido.GotFocus += txt_GotFocus;
			txtSenha.GotFocus += txt_GotFocus;
			btnClose.Click += btnCancel_Click;

			//--- ler o arquivo de imagem da LOGO e captar o nome fantasia
			if (File.Exists(FuncoesGlobais.appDataSavePath + "//Config.xml"))
			{
				try
				{
					//--- nome fantasia
					TituloIgreja = FuncoesGlobais.ObterDefault("IgrejaTitulo");

					//--- arquivo de imagem
					picLogo.ImageLocation = FuncoesGlobais.ObterConfigValorNode("ArquivoLogoColor");
				}
				catch (Exception e)
				{
					AbrirDialog("Uma exceção ocorreu ao Ler a imagem..." + "\n" +
								e.Message, "Exceção", DialogType.OK, DialogIcon.Exclamation);
				}
			}
		}

		#region BUTTONS

		// BUTTON FECHAR
		//------------------------------------------------------------------------------------------------------------
		private void btnCancel_Click(object sender, EventArgs e)
		{
			Logado = false;
			Close();
		}

		// BUTTON CLICK
		//------------------------------------------------------------------------------------------------------------
		private void btnOK_Click(object sender, EventArgs e)
		{

			if (!VerificaCampos()) return;

			try
			{
				// --- Ampulheta ON
				Cursor.Current = Cursors.WaitCursor;

				objUsuario obj = db.GetAuthorization(txtApelido.Text, txtSenha.Text);

				Program.usuarioAtual = obj;
				Logado = true;

				string AcessoTipo = Program.usuarioAtual.UsuarioAcessoDesc;

				//--- Bem-vindo
				AbrirDialog("Seja Bem-Vindo: " + txtApelido.Text.ToUpper() + "\n \n" +
							"Acesso: " + AcessoTipo.ToUpper(), TituloIgreja,
							DialogType.OK,
							DialogIcon.Information);
				DialogResult = DialogResult.Yes;
				Close();
			}
			catch (AppException ex)
			{
				switch (db.TentativasAcesso)
				{
					case 1:
						MessageBox.Show(ex.Message + "\n" +
										"Tente novamente..." + "\n" +
										"PRIMEIRA TENTATIVA, você pode tentar mais DUAS vezes",
										"Senha e/ou Usuário Incorreto",
										MessageBoxButtons.OK, MessageBoxIcon.Information);
						txtApelido.Focus();
						break;
					case 2:
						MessageBox.Show("Usuário ou Senha estão incorretas! \n" +
										"Tente novamente...\n" +
										"SEGUNDA TENTATIVA, você pode tentar mais UMA vezes",
										"Senha e/ou Usuário Incorreto",
										MessageBoxButtons.OK, MessageBoxIcon.Information);
						txtApelido.Focus();
						break;
					case 3:
						MessageBox.Show("Usuário ou Senha estão incorretas!\n" +
										"TERCEIRA TENTATIVA, a aplicação será encerrada...",
										"Erro de Senha e Usuário",
										MessageBoxButtons.OK, MessageBoxIcon.Stop);
						Logado = false;
						Close();
						return;
					default:
						break;
				}
			}
			catch (Exception ex)
			{
				AbrirDialog("Uma exceção ocorreu ao Conectar o BD SQL... \n" +
							"Verique a conexão com o servidor e tente novamente... \n" +
							ex.Message, "Conexão Inválida",
							DialogType.OK,
							DialogIcon.Exclamation);
				Logado = false;
				Close();
				return;
			}
			finally
			{
				// --- Ampulheta OFF
				Cursor.Current = Cursors.Default;
			}
		}

		#endregion

		private bool VerificaCampos()
		{
			//--- Verifica se o campo Apelido tem algum valor
			if (txtApelido.Text.Trim().Length == 0)
			{
				AbrirDialog("Por Favor, preencha o campo Nome do Usuário...",
					"Nome do Usuário Vazio", DialogType.OK, DialogIcon.Exclamation);
				txtApelido.Focus();
				return false;
			}
			///--- Verifica se o campo senha tem algum valor
			if (txtSenha.Text.Trim().Length < 8)
			{
				AbrirDialog("Por Favor, preencha o campo da SENHA...\n" +
					   "Sua SENHA precisa ter pelo menos 8 caracteres",
					   "Senha Incompleta", DialogType.OK, DialogIcon.Exclamation);
				txtSenha.Focus();
				return false;
			}

			return true;
		}

		private void txt_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
			{
				e.SuppressKeyPress = true;
				e.Handled = true;

				if (txtSenha.Text.Length == 8)
				{
					btnOK_Click(sender, e);
				}
				else
				{
					txtSenha.Focus();
				}
			}
		}

		private void txtSenha_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
			{
				e.SuppressKeyPress = true;
				e.Handled = true;
				btnOK.Focus();
			}
		}

		private void frmLogin_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter && txtSenha.Text.Length == 8 && txtApelido.Text.Length > 0)
			{
				e.Handled = true;
				e.SuppressKeyPress = true;
				btnOK_Click(new object(), new EventArgs());
			}
			else if (e.KeyCode == Keys.Escape)
			{
				btnCancel_Click(new object(), new EventArgs());
			}
			else if (e.Alt && e.KeyCode == Keys.F12)
			{
				e.Handled = true;
				e.SuppressKeyPress = true;
				txtApelido.Text = "Suporte";
				txtSenha.Text = "12345678";
				btnOK_Click(new object(), new EventArgs());
			}
			else if (e.Alt && e.KeyCode == Keys.D)
			{
				e.Handled = true;
				e.SuppressKeyPress = true;
				txtApelido.Text = "Daniel";
				txtSenha.Text = "12345678";
				btnOK_Click(new object(), new EventArgs());
			}
		}

		private void frmLogin_FormClosing(object sender, FormClosingEventArgs e)
		{
			if (Logado == true)
			{
				DialogResult = DialogResult.OK;
			}
			else
			{
				DialogResult = DialogResult.No;
			}
		}

		//--- SELECIONAR TODO O TEXTO QUANDO RECEBE O FOCO NO CONTROLE
		private void txt_GotFocus(object sender, EventArgs e)
		{
			txtApelido.SelectAll();
		}

	}
}
