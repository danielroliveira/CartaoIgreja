using CamadaBLL;
using CamadaDTO;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using static CamadaUI.FuncoesGlobais;
using static CamadaUI.Utilidades;

namespace CamadaUI.Main
{
	public partial class frmPrincipal : Form
	{
		public static string errorLog;
		public delegate void DelegateUpdate(long bytes, string msg);

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
				string pathDB = DBPath();
				FileInfo DB = new FileInfo(pathDB);

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

				//--- PREENCHE AS LISTAGENS
				//------------------------------------------------------------------------------------------------------------
				DiversosBLL div = new DiversosBLL(pathDB);
				Program.lstCongregacao = new CongregacaoBLL(pathDB).GetListCongregacao();
				Program.lstFuncao = new FuncaoBLL(pathDB).GetListFuncao();
				Program.lstEstadoCivil = div.GetListEstadoCivil();
				Program.lstSituacao = div.GetListSituacao();
			}
			catch (Exception ex)
			{
				AbrirDialog("Uma exceção ocorreu... " + "\n" +
							ex.Message, "Exceção", DialogType.OK, DialogIcon.Exclamation);
			}
			finally
			{
				// --- Ampulheta OFF
				Cursor.Current = Cursors.Default;
			}

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
			// MENU CADASTROS
			mnuMembroAdicionar.Click += (a, b) => MenuClickOpenForm(new Membros.frmMembro(new objMembro(null), this));
			mnuMembroProcurar.Click += (a, b) => MenuClickOpenForm(new Membros.frmMembroListagem());
			mnuImpressaoLista.Click += (a, b) => MenuClickOpenForm(new Cartao.frmCartaoLista());
			mnuFuncoes.Click += (a, b) => MenuClickOpenForm(new Cadastros.frmFuncaoControle());
			mnuCongregacoes.Click += (a, b) => MenuClickOpenForm(new Cadastros.frmCongregacaoControle());
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

		public void updateStatusBar(long bytes, string msg)
		{
			if (InvokeRequired)
			{
				var d = new DelegateUpdate(updateStatusBar);
				BeginInvoke(d, new object[] { bytes, msg });
			}
			else
			{
				if (bytes > 0)
				{
					progressBar.Visible = true;
					lblProgress.Visible = true;
				}

				progressBar.Value = (int)bytes;
				lblProgress.Text = msg;
				lblProgress.Location = new Point(this.ClientRectangle.Width - lblProgress.Width - progressBar.Width - 34, 385);
			}
		}
	}
}
