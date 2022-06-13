using CamadaBLL;
using CamadaDTO;
using CamadaUI.Main;
using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using static CamadaUI.FuncoesGlobais;
using static CamadaUI.Utilidades;

namespace CamadaUI.Membros
{
	public partial class frmMembro : CamadaUI.Models.frmModFinBorder
	{
		public delegate void DelegateUpdate(long bytes, string msg);

		private objMembro _membro;
		private BindingSource bind = new BindingSource();
		private EnumFlagEstado _Sit;
		private Form _formOrigem;
		private Image FotoImage = null;
		public objMembro propEscolha { get; set; }

		private enum EnumDefineFoto { LOADING, SEM_FOTO, FOTO_OK }
		private EnumDefineFoto FotoState;

		#region SUB NEW | PROPERTIES

		// SUB NEW
		//------------------------------------------------------------------------------------------------------------
		public frmMembro(objMembro obj, Form formOrigem = null)
		{
			InitializeComponent();

			_membro = obj;
			_formOrigem = formOrigem;
			bind.DataSource = _membro;
			BindingCreator();

			_membro.PropertyChanged += RegistroAlterado;

			if (_membro.IDCongregacao == null)
			{
				Sit = EnumFlagEstado.NovoRegistro;
				DefineFotoEstado(EnumDefineFoto.SEM_FOTO);
			}
			else
			{
				Sit = EnumFlagEstado.RegistroSalvo;
				ObterFotoServidor();
			}

			//--- Nascimento Date Controlling
			dtpMembresiaData.MaxDate = DateTime.Today;
			dtpNascimentoData.MaxDate = DateTime.Today.AddYears(-1);

			//--- Funcao label text
			lblFuncNumber.Text = $"(nº 1 a {Program.lstFuncao.Count})";

			// ADD HANDLERS
			HandlerKeyDownControl(this);
			txtRGMembro.LostFocus += TxtIDMembro_LostFocus;
			txtRGMembro.GotFocus += TxtIDMembro_GotFocus;
			txtCongregacao.Enter += text_Enter;

			txtMembroNome.Validating += (a, b) => PrimeiraLetraMaiuscula(txtMembroNome);


			

		}

		// DEFINE ESTADO DA FOTO
		//------------------------------------------------------------------------------------------------------------
		private void DefineFotoEstado(EnumDefineFoto value)
		{
			switch (value)
			{
				case EnumDefineFoto.LOADING:
					if (FotoImage != null) FotoImage.Dispose();
					FotoImage = null;
					picFoto.Image = Properties.Resources.loading;
					break;
				case EnumDefineFoto.SEM_FOTO:
					if (FotoImage != null) FotoImage.Dispose();
					FotoImage = null;
					picFoto.Image = Properties.Resources.sem_foto;
					break;
				case EnumDefineFoto.FOTO_OK:
					if (FotoImage == null)
						picFoto.Image = Properties.Resources.sem_foto;
					else
						picFoto.Image = FotoImage;

					break;
				default:
					break;
			}

			FotoState = value;
		}

		// PROPERTY SITUACAO
		//------------------------------------------------------------------------------------------------------------
		public EnumFlagEstado Sit
		{
			get { return _Sit; }
			set
			{
				_Sit = value;
				switch (value)
				{
					case EnumFlagEstado.RegistroSalvo:
						btnNovo.Enabled = true;
						btnSalvar.Enabled = false;
						btnCancelar.Enabled = false;
						btnAnexarFoto.Enabled = true;
						//btnAnexarFoto.BackColor = Color.FromArgb(255, 237, 215);
						btnAnexarFoto.BackColor = Color.White;
						break;
					case EnumFlagEstado.Alterado:
						btnNovo.Enabled = false;
						btnSalvar.Enabled = true;
						btnCancelar.Enabled = true;
						btnAnexarFoto.Enabled = true;
						//btnAnexarFoto.BackColor = Color.FromArgb(255, 237, 215);
						btnAnexarFoto.BackColor = Color.White;
						break;
					case EnumFlagEstado.NovoRegistro:
						btnNovo.Enabled = false;
						btnSalvar.Enabled = true;
						btnCancelar.Enabled = true;
						btnAnexarFoto.Enabled = false;
						btnAnexarFoto.BackColor = Color.Gainsboro;
						break;
					case EnumFlagEstado.RegistroBloqueado:
						btnNovo.Enabled = true;
						btnSalvar.Enabled = false;
						btnCancelar.Enabled = false;
						btnAnexarFoto.Enabled = false;
						btnAnexarFoto.BackColor = Color.Gainsboro;
						break;
					default:
						break;
				}
			}
		}

		#endregion

		#region DATABINDING

		// ADD DATA BINDIGNS
		//------------------------------------------------------------------------------------------------------------
		private void BindingCreator()
		{
			// CREATE BINDINGS
			lblID.DataBindings.Add("Text", bind, "IDMembro", true);
			txtMembroNome.DataBindings.Add("Text", bind, "MembroNome", true, DataSourceUpdateMode.OnPropertyChanged);
			txtRGMembro.DataBindings.Add("Text", bind, "RGMembro", true, DataSourceUpdateMode.OnPropertyChanged);
			dtpNascimentoData.DataBindings.Add("Value", bind, "NascimentoData", true, DataSourceUpdateMode.OnPropertyChanged);
			dtpMembresiaData.DataBindings.Add("Value", bind, "MembresiaData", true, DataSourceUpdateMode.OnPropertyChanged);
			dtpBatismoData.DataBindings.Add("Value", bind, "BatismoData", true, DataSourceUpdateMode.OnPropertyChanged);
			txtCongregacao.DataBindings.Add("Text", bind, "Congregacao", true, DataSourceUpdateMode.OnPropertyChanged);
			txtEstadoCivil.DataBindings.Add("Text", bind, "EstadoCivil", true, DataSourceUpdateMode.OnPropertyChanged);
			txtFuncao.DataBindings.Add("Text", bind, "Funcao", true, DataSourceUpdateMode.OnPropertyChanged);

			// CARREGA COMBOS
			CarregaCmbSexo();

			// FORMAT HANDLERS
			lblID.DataBindings["Text"].Format += FormatID;
			txtRGMembro.DataBindings["Text"].Format += FormatID;
			bind.CurrentChanged += BindRegistroChanged;

		}

		private void FormatID(object sender, ConvertEventArgs e)
		{
			e.Value = e.Value == null ? "NOVO" : $"{e.Value: 0000}";
		}

		private void RegistroAlterado(object sender, PropertyChangedEventArgs e)
		{
			if (Sit != EnumFlagEstado.Alterado && Sit != EnumFlagEstado.NovoRegistro)
			{
				Sit = EnumFlagEstado.Alterado;
			}
		}
		private void BindRegistroChanged(object sender, EventArgs e)
		{
			//MessageBox.Show("alterado");
		}

		// CARREGA COMBO
		//------------------------------------------------------------------------------------------------------------
		private void CarregaCmbSexo()
		{
			//--- Create DataTable
			DataTable dtAtivo = new DataTable();
			dtAtivo.Columns.Add("Sexo");
			dtAtivo.Columns.Add("Texto");
			dtAtivo.Rows.Add(new object[] { 1, "MASC" });
			dtAtivo.Rows.Add(new object[] { 2, "FEM" });

			//--- Set DataTable
			cmbSexo.DataSource = dtAtivo;
			cmbSexo.ValueMember = "Sexo";
			cmbSexo.DisplayMember = "Texto";
			cmbSexo.DataBindings.Add("SelectedValue", bind, "Sexo", true, DataSourceUpdateMode.OnPropertyChanged);
		}

		#endregion

		#region BUTTONS

		// ANEXAR SAVE FOTO
		//------------------------------------------------------------------------------------------------------------
		private void btnAnexarFoto_Click(object sender, EventArgs e)
		{
			if (FotoState == EnumDefineFoto.FOTO_OK)
			{
				var resp = AbrirDialog("Já existe uma foto anexada ao Registro de Membro...\n" +
								"Deseja alterar / substituir a foto atual?", "Alterar Foto",
								DialogType.SIM_NAO, DialogIcon.Question, DialogDefaultButton.Second);
				if (resp == DialogResult.No) return;
			}

			//--- Get File Image
			string ImagePath = "";

			using (OpenFileDialog OFD = new OpenFileDialog() { Filter = "JPG (*.jpg)|*.jpg" })
			{
				if (OFD.ShowDialog() == DialogResult.OK)
				{
					ImagePath = OFD.FileName;
				}
			}

			if (ImagePath.Length == 0) return;

			//--- check foto size
			FileInfo foto = new FileInfo(ImagePath);

			if (foto.Length > 200000)
			{
				AbrirDialog("Essa imagem/foto tem um tamanho acima do valor máximo previsto...\n" +
					"Favor otimizar a foto para obter no máximo 200Kb",
					"Tamanho da Imagem", DialogType.OK, DialogIcon.Exclamation);
				return;
			}

			//--- check image Dimension (3x4)
			Image image = Image.FromFile(ImagePath);
			double dim = (Convert.ToDouble(image.Width) / 3) / (Convert.ToDouble(image.Height) / 4);

			if (dim < 0.95 || dim > 1.05)
			{
				AbrirDialog("Essa imagem/foto não está na dimensão desejada de 3x4...\n" +
					"Favor otimizar a foto para obter esta dimensão.",
					"Dimensão da Imagem", DialogType.OK, DialogIcon.Exclamation);
				return;
			}

			//--- upload to server
			try
			{
				// --- Ampulheta ON
				Cursor.Current = Cursors.WaitCursor;
				FotoServerUpload(ImagePath);
			}
			catch (Exception ex)
			{
				AbrirDialog("Uma exceção ocorreu ao Anexar a foto no servidor..." + "\n" +
							ex.Message, "Exceção", DialogType.OK, DialogIcon.Exclamation);
			}
			finally
			{
				// --- Ampulheta OFF
				Cursor.Current = Cursors.Default;
			}
		}

		// FECHAR FORM
		//------------------------------------------------------------------------------------------------------------
		private void btnFechar_Click(object sender, EventArgs e)
		{
			if (Sit == EnumFlagEstado.Alterado || Sit == EnumFlagEstado.NovoRegistro)
			{
				AbrirDialog("Esse registro ainda não foi salvo... \n" +
					"Favor SALVAR ou CANCELAR a edição do registro atual antes de fechar.",
					"Registro Novo ou Alterado", DialogType.OK, DialogIcon.Exclamation);
				txtMembroNome.Focus();
				return;
			}

			Close();

			if (_formOrigem.GetType() == typeof(Main.frmPrincipal))
				MostraMenuPrincipal();

		}

		// CANCELAR ALTERACAO
		//------------------------------------------------------------------------------------------------------------
		private void btnCancelar_Click(object sender, EventArgs e)
		{
			if (Sit == EnumFlagEstado.NovoRegistro)
			{
				var response = AbrirDialog("Deseja cancelar a inserção de um novo registro?",
							   "Cancelar", DialogType.SIM_NAO, DialogIcon.Question);

				if (response != DialogResult.Yes) return;

				//--- check origem
				if (_formOrigem == null || _formOrigem.GetType() == typeof(Main.frmPrincipal)) // return to frmPrincipal
				{
					AutoValidate = AutoValidate.Disable;
					Close();
					MostraMenuPrincipal();
				}
				else // return to formOrigem
				{
					AutoValidate = AutoValidate.Disable;
					Close();
				}
			}
			else if (Sit == EnumFlagEstado.Alterado)
			{
				bind.CancelEdit();
				Sit = EnumFlagEstado.RegistroSalvo;
			}
			else
			{
				Sit = EnumFlagEstado.RegistroSalvo;
			}

		}

		// OPEN CONGREGACAO PROCURA FORM
		//------------------------------------------------------------------------------------------------------------
		private void btnCongregacaoEscolher_Click(object sender, EventArgs e)
		{
			frmCongregacaoProcura frm = new frmCongregacaoProcura(this, _membro.IDCongregacao);
			frm.ShowDialog();

			//--- check return
			if (frm.DialogResult == DialogResult.OK)
			{
				_membro.IDCongregacao = frm.propEscolha.IDCongregacao;
				txtCongregacao.Text = frm.propEscolha.Congregacao;
			}

			//--- select
			txtCongregacao.Focus();
			txtCongregacao.SelectAll();
		}

		// NOVO REGISTRO INSERIR
		//------------------------------------------------------------------------------------------------------------
		private void btnNovo_Click(object sender, EventArgs e)
		{
			if (Sit != EnumFlagEstado.RegistroSalvo) return;

			_membro = new objMembro(null);
			Sit = EnumFlagEstado.NovoRegistro;
			bind.DataSource = _membro;
			txtRGMembro.Focus();
			txtRGMembro.SelectAll();
			if (FotoImage != null) FotoImage.Dispose();
			picFoto.Image = Properties.Resources.sem_foto;
		}

		#endregion

		#region SAVE REGISTRY

		// SALVAR REGISTRO
		//------------------------------------------------------------------------------------------------------------
		private void btnSalvar_Click(object sender, EventArgs e)
		{
			try
			{
				// --- Ampulheta ON
				Cursor.Current = Cursors.WaitCursor;

				//--- check data
				if (!CheckSaveData()) return;

				MembroBLL cBLL = new MembroBLL(DBPath());

				if (_membro.IDMembro == null)
				{
					//--- save | Insert
					int ID = (int)cBLL.InsertMembro(_membro);

					//--- define newID
					_membro.IDMembro = ID;
					lblID.DataBindings["Text"].ReadValue();
				}
				else
				{
					//--- update
					cBLL.UpdateMembro(_membro);
				}

				//--- change Sit
				Sit = EnumFlagEstado.RegistroSalvo;
				//--- emit massage
				AbrirDialog("Registro Salvo com sucesso!",
					"Registro Salvo", DialogType.OK, DialogIcon.Information);
			}
			catch (AppException ex)
			{
				AbrirDialog("Uma duplicação de registro irá acontecer ao Salvar Registro de Membro..." + "\n" +
							ex.Message, "Duplicação", DialogType.OK, DialogIcon.Exclamation);
			}
			catch (Exception ex)
			{
				AbrirDialog("Uma exceção ocorreu ao Salvar Registro de Membro..." + "\n" +
							ex.Message, "Exceção", DialogType.OK, DialogIcon.Warning);
			}
			finally
			{
				// --- Ampulheta OFF
				Cursor.Current = Cursors.Default;
			}

		}

		// CHECK DATA BEFORE SAVE
		//------------------------------------------------------------------------------------------------------------
		private bool CheckSaveData()
		{
			if (!VerificaDadosClasse(txtMembroNome, "Nome do Membro", _membro)) return false;
			if (!VerificaDadosClasse(cmbSexo, "Sexo do Membro", _membro)) return false;
			if (!VerificaDadosClasse(txtRGMembro, "Reg do Membro", _membro)) return false;
			if (!VerificaDadosClasse(txtCongregacao, "Congregação", _membro)) return false;
			if (!VerificaDadosClasse(txtEstadoCivil, "Estado do Civil", _membro)) return false;
			if (!VerificaDadosClasse(txtFuncao, "Função do Membro", _membro)) return false;

			return true;
		}

		#endregion

		#region FORM CONTROLS FUCTIONS

		// FORM KEYPRESS: BLOQUEIA (+)
		//------------------------------------------------------------------------------------------------------------
		private void frmMembro_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (e.KeyChar == 43)
			{
				//--- cria uma lista de controles que serao impedidos de receber '+'
				Control[] controlesBloqueados = {
					txtCongregacao, txtEstadoCivil, txtFuncao
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
					case "txtCongregacao":
						btnCongregacaoEscolher_Click(sender, new EventArgs());
						break;
					case "txtFuncao":
						btnSetFuncao_Click(sender, new EventArgs());
						break;
					case "txtEstadoCivil":
						btnSetEstadoCivil_Click(sender, new EventArgs());
						break;
					default:
						break;
				}
			}
			else if ((e.KeyCode >= Keys.D0 && e.KeyCode <= Keys.D9) | (e.KeyCode >= Keys.NumPad0 && e.KeyCode <= Keys.NumPad9))
			{
				//--- cria um array de controles que serao liberados ao KEYPRESS
				Control[] controlesID = {
					txtFuncao,
					txtEstadoCivil,
				};

				if (controlesID.Contains(ctr))
				{
					e.Handled = false;
				}
				else
				{
					e.Handled = true;
					e.SuppressKeyPress = true;
				}
			}
			else if (e.Alt)
			{
				e.Handled = false;
			}
			else
			{
				//--- cria um array de controles que serão bloqueados de alteracao
				Control[] controlesBloqueados = { txtCongregacao, txtEstadoCivil, txtFuncao };

				if (controlesBloqueados.Contains(ctr))
				{
					e.Handled = true;
					e.SuppressKeyPress = true;
				}
			}
		}

		// CREATE SHORTCUT TO TEXTBOX LIST VALUES
		//------------------------------------------------------------------------------------------------------------
		private void Control_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (char.IsDigit(e.KeyChar))
			{
				Control ctr = (Control)sender;
				e.Handled = true;

				switch (ctr.Name)
				{
					case "txtFuncao":

						if (Program.lstFuncao.Count > 0)
						{
							var forma = Program.lstFuncao.FirstOrDefault(x => x.IDFuncao == int.Parse(e.KeyChar.ToString()));

							if (forma == null) return;

							if (forma.IDFuncao != _membro.IDFuncao)
							{
								if (Sit == EnumFlagEstado.RegistroSalvo) Sit = EnumFlagEstado.Alterado;

								_membro.IDFuncao = (byte)forma.IDFuncao;
								txtFuncao.Text = forma.Funcao;
							}

						}
						break;

					case "txtEstadoCivil":

						if (Program.lstEstadoCivil.Count > 0)
						{
							var tipo = Program.lstEstadoCivil.FirstOrDefault(x => x.IDEstadoCivil == int.Parse(e.KeyChar.ToString()));

							if (tipo == null) return;

							if (tipo.IDEstadoCivil != _membro.IDEstadoCivil)
							{
								if (Sit == EnumFlagEstado.RegistroSalvo) Sit = EnumFlagEstado.Alterado;

								_membro.IDEstadoCivil = (byte)tipo.IDEstadoCivil;
								txtEstadoCivil.Text = tipo.EstadoCivil;
							}
						}
						break;

					default:
						break;
				}
			}
		}

		// DIGITA SOMENTE NUMEROS
		//------------------------------------------------------------------------------------------------------------
		private void txtIDMembro_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (!char.IsNumber(e.KeyChar) && e.KeyChar != 8)
				e.Handled = true;
		}

		// VALIDA O ID MEMBRO
		//------------------------------------------------------------------------------------------------------------
		private void txtIDMembro_Validating(object sender, CancelEventArgs e)
		{
			if (txtRGMembro.Text.Length == 0)
			{
				e.Cancel = false;
			}
		}

		// GOT LOST FOCUS IDMEMBRO
		//------------------------------------------------------------------------------------------------------------
		private void TxtIDMembro_LostFocus(object sender, EventArgs e)
		{
			AutoValidate = AutoValidate.EnablePreventFocusChange;
		}

		private void TxtIDMembro_GotFocus(object sender, EventArgs e)
		{
			AutoValidate = AutoValidate.EnableAllowFocusChange;
		}

		#endregion // FORM CONTROLS FUCTIONS --- END

		#region DESIGN FORM FUNCTIONS

		// CRIAR EFEITO VISUAL DE FORM SELECIONADO
		//------------------------------------------------------------------------------------------------------------
		private void form_Activated(object sender, EventArgs e)
		{
			if (_formOrigem != null)
			{
				if (_formOrigem.GetType() != typeof(Main.frmPrincipal))
				{
					Panel pnl = (Panel)_formOrigem.Controls["Panel1"];
					pnl.BackColor = Color.Silver;
				}
				else
				{
					DesativaMenuPrincipal();
				}
			}
		}

		private void form_FormClosed(object sender, FormClosedEventArgs e)
		{
			if (FotoImage != null) FotoImage.Dispose();

			if (_formOrigem != null)
			{
				if (_formOrigem.GetType() != typeof(Main.frmPrincipal))
				{
					_formOrigem.Visible = true;
					Panel pnl = (Panel)_formOrigem.Controls["Panel1"];
					pnl.BackColor = Color.SlateGray;
				}
				else
				{
					MostraMenuPrincipal();
				}

			}
		}

		// EMITE TOOLTIP ON ENTER E DESABILITA
		//------------------------------------------------------------------------------------------------------------
		private void text_Enter(object sender, EventArgs e)
		{
			ShowToolTip(sender as Control);
			((TextBox)sender).Enter -= text_Enter;
		}

		// CONTROLA TOOLTIP
		//------------------------------------------------------------------------------------------------------------
		private void ShowToolTip(Control control)
		{
			//--- Cria a ToolTip e associa com o Form container.
			ToolTip toolTip1 = new ToolTip();

			//--- Define o delay para a ToolTip.
			toolTip1.AutoPopDelay = 2000;
			toolTip1.InitialDelay = 2000;
			toolTip1.ReshowDelay = 500;
			toolTip1.IsBalloon = true;
			toolTip1.UseAnimation = true;
			toolTip1.UseFading = true;

			if (string.IsNullOrEmpty(control.Tag.ToString()))
				toolTip1.Show("Clique aqui...", control, control.Width - 30, -40, 2000);
			else
				toolTip1.Show(control.Tag.ToString(), control, control.Width - 30, -40, 2000);
		}

		private void btnProcurar_EnabledChanged(object sender, EventArgs e)
		{
			Control control = (Control)sender;

			if (control.Enabled == true)
				ShowToolTip(control);
		}

		#endregion // DESIGN FORM FUNCTIONS --- END

		#region SET DADOS

		private void btnSetEstadoCivil_Click(object sender, EventArgs e)
		{
			if (Program.lstEstadoCivil == null || Program.lstEstadoCivil.Count == 0)
			{
				AbrirDialog("Não há Estado Civil cadastrados...", "Estado Civil",
					DialogType.OK, DialogIcon.Exclamation);
				return;
			}

			var dic = Program.lstEstadoCivil.ToDictionary(x => (int)x.IDEstadoCivil, x => x.EstadoCivil);

			Main.frmComboLista frm = new Main.frmComboLista(dic, txtEstadoCivil, _membro.IDEstadoCivil);

			// show form
			frm.ShowDialog();

			//--- check return
			if (frm.DialogResult == DialogResult.OK)
			{
				_membro.IDEstadoCivil = (byte)frm.propEscolha.Key;
				txtEstadoCivil.Text = frm.propEscolha.Value;
			}

			//--- select
			txtEstadoCivil.Focus();
			txtEstadoCivil.SelectAll();
		}

		private void btnSetFuncao_Click(object sender, EventArgs e)
		{
			if (Program.lstFuncao == null || Program.lstFuncao.Count == 0)
			{
				AbrirDialog("Não há Funcões cadastradas...", "Funções",
					DialogType.OK, DialogIcon.Exclamation);
				return;
			}

			var dic = Program.lstFuncao.ToDictionary(x => (int)x.IDFuncao, x => x.Funcao);

			Main.frmComboLista frm = new Main.frmComboLista(dic, txtFuncao, _membro.IDFuncao);

			// show form
			frm.ShowDialog();

			//--- check return
			if (frm.DialogResult == DialogResult.OK)
			{
				_membro.IDFuncao = (byte)frm.propEscolha.Key;
				txtFuncao.Text = frm.propEscolha.Value;
			}

			//--- select
			txtFuncao.Focus();
			txtFuncao.SelectAll();
		}

		#endregion // SET DADOS --- END

		#region FOTOS SEVER FUNCTION

		// SEND/UPLOAD IMAGE FOTO TO SERVER
		//------------------------------------------------------------------------------------------------------------
		private async void FotoServerUpload(string ImagePath)
		{
			try
			{
				//--- clear Image
				DefineFotoEstado(EnumDefineFoto.LOADING);

				//--- define new Name
				string newFileName = $"{_membro.RGMembro}.jpg";

				//--- upload to GOOGLE DRIVE
				await GDriveControl.SaveFileInDriveImageFolder(ImagePath, newFileName, this);

				//--- define new Image
				FotoImage = Image.FromFile(ImagePath);
				DefineFotoEstado(EnumDefineFoto.FOTO_OK);

				//--- notify message
				new NotifyIcon("Foto enviada", "Foto do Membro enviada com sucesso!", ToolTipIcon.Info);

			}
			catch (Exception ex)
			{
				AbrirDialog("Um erro aconteceu ao copiar a Imagem para a Nuvem...\n" +
					ex.Message, "Exceção", DialogType.OK, DialogIcon.Exclamation);
				DefineFotoEstado(EnumDefineFoto.SEM_FOTO);
			}
		}

		// GET AND VIZUALIZE FOTO IMAGE FROM SERVER
		//------------------------------------------------------------------------------------------------------------
		private async void ObterFotoServidor()
		{
			DefineFotoEstado(EnumDefineFoto.LOADING);

			try
			{
				var image = await GDriveControl.GetImageFromDrive($"{_membro.RGMembro}.jpg");

				if (image != null)
				{
					FotoImage = image;
					DefineFotoEstado(EnumDefineFoto.FOTO_OK);
				}
				else
				{
					DefineFotoEstado(EnumDefineFoto.SEM_FOTO);
				}
			}
			catch (Exception ex)
			{
				AbrirDialog("Uma exceção ocorreu ao Obter a Imagem da Foto no Drive..." + "\n" +
							ex.Message, "Exceção", DialogType.OK, DialogIcon.Exclamation);
				DefineFotoEstado(EnumDefineFoto.SEM_FOTO);
			}
		}

		// UPDATE PROGRESS BAR
		//------------------------------------------------------------------------------------------------------------
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

		#endregion // FOTOS SEVER FUNCTION --- END

		#region FOTOS LOCAL FUNCTION

		private void AnexarFotoLocal()
		{
			//--- check folder default
			string FotosFolder = ObterConfigValorNode("FotosImageFolder");

			if (string.IsNullOrEmpty(FotosFolder))
			{
				AbrirDialog("A pasta de iamgens não foi selecionada na configuração do sistema...\n" +
					"Favor indicar a pasta de fotos padrão do sistema...", "Pasta de Fotos",
					DialogType.OK, DialogIcon.Exclamation);
				return;
			}

			if (FotoImage != null)
			{
				var resp = AbrirDialog("Já existe uma foto anexada ao Registro de Membro\n" +
								"Deseja alterar a foto atual?", "Alterar Foto",
								DialogType.SIM_NAO, DialogIcon.Question, DialogDefaultButton.Second);
				if (resp == DialogResult.No) return;
			}

			//--- Get File Image
			string ImagePath = "";

			using (OpenFileDialog OFD = new OpenFileDialog() { Filter = "JPG (*.jpg)|*.jpg" })
			{
				if (OFD.ShowDialog() == DialogResult.OK)
				{
					ImagePath = OFD.FileName;
				}
			}

			// move foto to default folder
			if (ImagePath.Length > 0)
				FotoCopiaLocal(ImagePath, FotosFolder);
			else
				return;
		}

		private bool FotoCopiaLocal(string ImagePath, string FotosFolder)
		{
			try
			{
				if (!Directory.Exists(FotosFolder))
				{
					Directory.CreateDirectory(FotosFolder);
				}

				picFoto.Image = null;
				if (FotoImage != null) FotoImage.Dispose();

				string newFile = FotosFolder + $"\\{_membro.RGMembro}.jpg";

				File.Copy(ImagePath, newFile, true);
				FotoImage = Image.FromFile(newFile);
				picFoto.Image = FotoImage;
			}
			catch (Exception ex)
			{
				AbrirDialog("Um erro aconteceu ao copiar a Foto/Imagem para o diretório padrão...\n" +
					ex.Message, "Exceção", DialogType.OK, DialogIcon.Exclamation);
				return false;
			}
			return true;
		}

		// GET AND VIZUALIZE FOTO IMAGE FROM LOCAL DRIVE
		//------------------------------------------------------------------------------------------------------------
		private void VisualizarFoto()
		{
			//--- check folder default
			string FotosFolder = ObterConfigValorNode("FotosImageFolder");
			string newFile = FotosFolder + $"\\{_membro.RGMembro}.jpg";

			var file = new FileInfo(newFile);

			if (!file.Exists)
			{
				return;
			}

			FotoImage = Image.FromFile(newFile);
			picFoto.Image = FotoImage;
		}

		#endregion // FOTOS FUNCTION --- END

		#region CONTEXT MENU

		// OPEN CONTEXT MENU
		//------------------------------------------------------------------------------------------------------------
		private void picFoto_MouseDown(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Right)
			{
				//--- check fotostate
				if (FotoState == EnumDefineFoto.LOADING) return;

				mnuAnexarFoto.Enabled = FotoState == EnumDefineFoto.SEM_FOTO;
				mnuDownloadFoto.Enabled = FotoState == EnumDefineFoto.FOTO_OK;
				mnuRemoverFoto.Enabled = FotoState == EnumDefineFoto.FOTO_OK;

				// revela menu
				Control c = (Control)sender;
				MenuFoto.Show(c.PointToScreen(e.Location));
			}
		}

		// INSERIR NOVA IMAGEM DE FOTO E ENVIAR PARA O SERVIDOR
		//------------------------------------------------------------------------------------------------------------
		private void mnuAnexarFoto_Click(object sender, EventArgs e)
		{
			btnAnexarFoto_Click(sender, e);
		}

		// DOWNLOAD DA FOTO
		//------------------------------------------------------------------------------------------------------------
		private async void mnuDownloadFoto_Click(object sender, EventArgs e)
		{
			if (FotoState != EnumDefineFoto.FOTO_OK)
			{
				AbrirDialog("Não existe uma foto anexada ao Registro de Membro...\n" +
								"Não é possível realizar o Download da Foto.", "Obter Foto",
								DialogType.OK, DialogIcon.Exclamation);
				return;
			}

			//--- Get File Image
			string ImagePath = "";

			using (FolderBrowserDialog OFD = new FolderBrowserDialog()
			{
				ShowNewFolderButton = true,
				RootFolder = Environment.SpecialFolder.Desktop
			})
			{
				if (OFD.ShowDialog() == DialogResult.OK)
				{
					ImagePath = OFD.SelectedPath;
				}
			}

			if (ImagePath.Length == 0) return;

			//--- DOWNLOAD from server
			try
			{
				// --- Ampulheta ON
				Cursor.Current = Cursors.WaitCursor;
				await GDriveControl.DownloadImageAndSaveLocal($"{_membro.RGMembro}.jpg", ImagePath);

				AbrirDialog("Foto obtida com sucesso!", "Download de Foto", DialogType.OK, DialogIcon.Information);
			}
			catch (Exception ex)
			{
				AbrirDialog("Uma exceção ocorreu ao Obter a foto do servidor..." + "\n" +
							ex.Message, "Exceção", DialogType.OK, DialogIcon.Exclamation);
			}
			finally
			{
				// --- Ampulheta OFF
				Cursor.Current = Cursors.Default;
			}
		}

		// REMOVE FOTO FROM SERVER
		//------------------------------------------------------------------------------------------------------------
		private async void mnuRemoverFoto_Click(object sender, EventArgs e)
		{
			var resp = AbrirDialog("Deseja realmente excluir / remover a Foto do membro atual?\n" +
				"Aconselhasse antes fazer download da foto atual para salvar em Backup...",
				"Excluir Foto do Membro", DialogType.SIM_NAO, DialogIcon.Question, DialogDefaultButton.Second);

			if (resp == DialogResult.No) return;

			try
			{
				// --- Ampulheta ON
				Cursor.Current = Cursors.WaitCursor;

				//--- remove foto
				await GDriveControl.RemoveImageFromDefaultFolder($"{_membro.RGMembro}.jpg");

				//--- clear image
				DefineFotoEstado(EnumDefineFoto.SEM_FOTO);
			}
			catch (Exception ex)
			{
				AbrirDialog("Uma exceção ocorreu ao Remover a Foto do Drive..." + "\n" +
							ex.Message, "Exceção", DialogType.OK, DialogIcon.Exclamation);
			}
			finally
			{
				// --- Ampulheta OFF
				Cursor.Current = Cursors.Default;
			}
		}

		#endregion // CONTEXT MENU --- END

	}
}
