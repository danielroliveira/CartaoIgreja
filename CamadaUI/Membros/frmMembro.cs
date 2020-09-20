using CamadaBLL;
using CamadaDTO;
using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using static CamadaUI.FuncoesGlobais;
using static CamadaUI.Utilidades;

namespace CamadaUI.Membros
{
	public partial class frmMembro : CamadaUI.Models.frmModFinBorder
	{
		private objMembro _membro;
		private BindingSource bind = new BindingSource();
		private EnumFlagEstado _Sit;
		private Form _formOrigem;
		public objMembro propEscolha { get; set; }

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
			}
			else
			{
				Sit = EnumFlagEstado.RegistroSalvo;
			}

			// ADD HANDLERS
			HandlerKeyDownControl(this);
			txtRGMembro.LostFocus += TxtIDMembro_LostFocus;
			txtRGMembro.GotFocus += TxtIDMembro_GotFocus;
			txtCongregacao.Enter += text_Enter;

			txtMembroNome.Validating += (a, b) => PrimeiraLetraMaiuscula(txtMembroNome);
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
						break;
					case EnumFlagEstado.Alterado:
						btnNovo.Enabled = false;
						btnSalvar.Enabled = true;
						btnCancelar.Enabled = true;
						break;
					case EnumFlagEstado.NovoRegistro:
						btnNovo.Enabled = false;
						btnSalvar.Enabled = true;
						btnCancelar.Enabled = true;
						break;
					case EnumFlagEstado.RegistroBloqueado:
						btnNovo.Enabled = true;
						btnSalvar.Enabled = false;
						btnCancelar.Enabled = false;
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
			MessageBox.Show("alterado");
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
			txtMembroNome.Focus();
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
	}
}
