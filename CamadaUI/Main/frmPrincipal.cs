using System;
using System.Drawing;
using System.Windows.Forms;
using static CamadaUI.Utilidades;
using static CamadaUI.FuncoesGlobais;
using System.IO;

namespace CamadaUI.Main
{
	public partial class frmPrincipal : Form
	{
		#region SUB NEW | LOAD

		// SUB NEW
		// =============================================================================
		public frmPrincipal()
		{
			InitializeComponent();

			string titulo = AplicacaoTitulo;
			lblTitulo.Text = titulo == string.Empty ? "Título da Igreja" : titulo;

			//--- INSERT BACKGROUND MDI FORM
			foreach (Control control in this.Controls)
			{
				MdiClient client = control as MdiClient;
				if (!(client == null))
				{
					BackgroundImageLayout = ImageLayout.Zoom;
					client.BackgroundImage = Properties.Resources.Logo_ADRJ_Fundo;
				}
			}
		}

		// LOAD
		// =============================================================================
		private void frmPrincipal_Load(object sender, EventArgs e)
		{
			mnuPrincipal.Focus();

			//--- VERIFICA SE EXISTE CONFIG DO CAMINHO DO BD
			//------------------------------------------------------------------------------------------------------------
			try
			{
				//--- Ampulheta ON
				Cursor.Current = Cursors.WaitCursor;

				//--- open check DATABASE
				FileInfo DB = new FileInfo(DBPath());

				if (!DB.Exists)
				{
					AbrirDialog("Não foi encontrado o Banco de Dados...\n" +
						"Desculpe, o aplicativo não pode ser aberto!",
						"Exceção", DialogType.OK, DialogIcon.Exclamation);
					Application.Exit();
					return;
				}

				//--- VERFICA SE O ARQUIVO DE CONFIG FOI ENCONTRADO
				//------------------------------------------------------------------------------------------------------------
				if (VerificaConfigXML() == false)
				{
					AbrirDialog("O arquivo de configuração não pôde ser criado...\n" +
						"Desculpe, o aplicativo não pode ser aberto!",
						"Exceção", DialogType.OK, DialogIcon.Exclamation);
					Application.Exit();
					return;
				}

			}
			catch (Exception ex)
			{
				AbrirDialog("Uma exceção ocorreu ao obter o caminho do BD..." + "\n" +
							ex.Message, "Exceção", DialogType.OK, DialogIcon.Exclamation);
			}
			finally
			{
				// --- Ampulheta OFF
				Cursor.Current = Cursors.Default;
			}

			//--- HABILITA A VERSAO E O TITULO
			//----------------------------------------------------------------
			string Versao = System.Reflection.Assembly.GetExecutingAssembly().GetName().Version.ToString();
			lblVersao.Text = Versao;

			//-- HABILITA O MENU
			//----------------------------------------------------------------
			mnuPrincipal.Enabled = true;

			//--- HABILITA O HANDLER DE ABERTURA DO MENU
			//----------------------------------------------------------------
			MenuOpen_Handler();
			mnuPrincipal.Focus();
			btnCadastros.Select();

			// CREATE HANDLERS TO OPEN FORM ONCLICK
			//----------------------------------------------------------------
			HandlersMenuClickToOpenForm();

		}

		public string AplicacaoTitulo
		{
			get
			{
				return ObterDefault("IgrejaTitulo");
			}
			set
			{
				lblTitulo.Text = value;
				SaveConfigValorNode("IgrejaTitulo", value);
			}
		}

		#endregion

		#region MENU FUNCOES

		private void HandlersMenuClickToOpenForm()
		{
			/*

			// MENU CADASTROS
			mnuContribuintes.Click += (a, b) => MenuClickOpenForm(new Registres.frmContribuinteListagem(false, this));
			mnuCredores.Click += (a, b) => MenuClickOpenForm(new Registres.frmCredorListagem(false, this));
			mnuCongregacoes.Click += (a, b) => MenuClickOpenForm(new Congregacoes.frmCongregacaoListagem());
			mnuSetoresCongregacao.Click += (a, b) => MenuClickOpenForm(new Congregacoes.frmCongregacaoSetorListagem());
			mnuReunioes.Click += (a, b) => MenuClickOpenForm(new Congregacoes.frmCongregacaoReuniaoListagem());

			// MENU ENTRADAS
			mnuCampanhas.Click += (a, b) => MenuClickOpenForm(new Entradas.frmCampanhaListagem());
			mnuContribuicaoInserir.Click += (a, b) => MenuClickOpenForm(new Entradas.frmContribuicao(new objContribuicao(null)));
			mnuContribuicaoProcurar.Click += (a, b) => MenuClickOpenForm(new Entradas.frmContribuicaoListagem());
			mnuAReceberProcurar.Click += (a, b) => MenuClickOpenForm(new frmAReceberListagem());

			*/
		}

		private void MenuClickOpenForm(Form form)
		{
			try
			{
				// --- Ampulheta ON
				Cursor.Current = Cursors.WaitCursor;

				form.MdiParent = this;
				DesativaMenuPrincipal();
				form.Show();

			}
			catch (Exception ex)
			{
				AbrirDialog("Uma exceção ocorreu ao abrir formulário..." + "\n" +
							ex.Message, "Exceção", DialogType.OK, DialogIcon.Exclamation);
			}
			finally
			{
				// --- Ampulheta OFF
				Cursor.Current = Cursors.Default;
			}
		}

		#endregion

		#region BUTTONS
		private void MenuOpen_Handler()
		{
			foreach (object control in mnuPrincipal.Items)
			{
				if (control.GetType() == typeof(ToolStripSplitButton))
				{
					ToolStripSplitButton splitButton = (ToolStripSplitButton)control;
					splitButton.ButtonClick += ToolStripSplitButton_ButtonClick;
					splitButton.MouseHover += ToolStripSplitButton_ButtonClick;
				}
			}
		}

		private void ToolStripSplitButton_ButtonClick(object sender, EventArgs e)
		{
			ToolStripSplitButton control = (ToolStripSplitButton)sender;
			control.ShowDropDown();
		}

		// APPLICATION EXIT
		// =============================================================================
		private void btnSair_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		// APPLICATION MINIMIZE
		// =============================================================================
		private void btnMinimizer_Click(object sender, EventArgs e)
		{
			WindowState = FormWindowState.Minimized;
		}

		// OPEN CONFIG
		// =============================================================================
		private void btnConfig_Click(object sender, EventArgs e)
		{
			try
			{
				// --- Ampulheta ON
				Cursor.Current = Cursors.WaitCursor;

				Form f = new Config.frmConfig(this);
				MenuEnabled(false);
				f.MdiParent = this;
				f.Show();
			}
			catch (Exception ex)
			{
				AbrirDialog("Uma exceção ocorreu ao Abrir o formulário de Configuração..." + "\n" +
							ex.Message, "Exceção", DialogType.OK, DialogIcon.Exclamation);
			}
			finally
			{
				// --- Ampulheta OFF
				Cursor.Current = Cursors.Default;
			}
		}

		#endregion

		#region OTHER FUNCTIONS

		public void MenuEnabled(bool IsEnabled)
		{
			mnuPrincipal.Enabled = IsEnabled;
			btnConfig.Enabled = IsEnabled;
		}

		#endregion
	}
}
