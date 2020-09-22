using CamadaBLL;
using CamadaDTO;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using static CamadaUI.FuncoesGlobais;
using static CamadaUI.Utilidades;

namespace CamadaUI.Membros
{
	public partial class frmMembroListagem : CamadaUI.Models.frmModFinBorder
	{
		private List<objMembro> lstMembros = new List<objMembro>();
		private Image ImgPrint = Properties.Resources.print_16;
		private Image ImgNPrint = Properties.Resources.CloseIcon;
		private int _validade;
		private Form _formOrigem;
		private byte? IDFuncao;
		private byte? IDCongregacao;
		private byte? IDSituacao;

		//--- PROPRIEDADE DE ESCOLHA
		public objMembro propEscolha { get; set; }

		#region NEW | OPEN FUNCTIONS

		public frmMembroListagem(Form formOrigem = null)
		{
			InitializeComponent();

			//--- Add any initialization after the InitializeComponent() call.
			_ = int.TryParse(ObterConfigValorNode("ValidadeAnos"), out _validade);
			_formOrigem = formOrigem;

			if (_formOrigem != null && _formOrigem.Name == "frmCartaoLista")
			{
				btnAdicionar.Visible = false;
				btnEditar.Visible = false;
				btnEscolher.Visible = true;
				lblTitulo.Text = "Selecionar Membro";
			}
			else
			{
				btnAdicionar.Visible = true;
				btnEditar.Visible = true;
				btnEscolher.Visible = false;
				lblTitulo.Text = "Procurar Membro";
			}

			//--- DEFINE DEFAULT SITUACAO
			IDSituacao = 1; // ativo
			txtSituacao.Text = "Ativo";
			txtCongregacao.Text = "TODAS";
			txtFuncao.Text = "TODAS";

			//--- GET DATA
			ObterDados();
			FormataListagem();

			//--- get dados
			dgvListagem.CellDoubleClick += btnEditar_Click;
			txtProcura.TextChanged += FiltrarListagem;
			HandlerKeyDownControl(this);
		}

		// GET DATA
		//------------------------------------------------------------------------------------------------------------
		private void ObterDados()
		{
			try
			{
				// --- Ampulheta ON
				Cursor.Current = Cursors.WaitCursor;
				MembroBLL cBLL = new MembroBLL(DBPath());
				lstMembros = cBLL.GetListMembro("", IDCongregacao, IDFuncao, IDSituacao);
				dgvListagem.DataSource = lstMembros;
			}
			catch (Exception ex)
			{
				AbrirDialog("Uma exceção ocorreu ao Obter os Dados da listagem..." + "\n" +
							ex.Message, "Exceção", DialogType.OK, DialogIcon.Exclamation);
			}
			finally
			{
				// --- Ampulheta OFF
				Cursor.Current = Cursors.Default;
			}
		}

		#endregion

		#region DATAGRID LIST FUNCTIONS

		// FORMATA LISTAGEM
		//------------------------------------------------------------------------------------------------------------
		private void FormataListagem()
		{
			dgvListagem.Columns.Clear();
			dgvListagem.AutoGenerateColumns = false;
			dgvListagem.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			dgvListagem.MultiSelect = false;
			dgvListagem.ColumnHeadersVisible = true;
			dgvListagem.AllowUserToResizeRows = false;
			dgvListagem.AllowUserToResizeColumns = false;
			dgvListagem.RowHeadersWidth = 36;
			dgvListagem.RowTemplate.Height = 30;
			dgvListagem.StandardTab = true;
			dgvListagem.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.LightSteelBlue;

			//--- (1) COLUNA REG
			Padding newPadding = new Padding(5, 0, 0, 0);
			clnRG.DataPropertyName = "RGMembro";
			clnRG.Visible = true;
			clnRG.ReadOnly = true;
			clnRG.Resizable = DataGridViewTriState.False;
			clnRG.SortMode = DataGridViewColumnSortMode.NotSortable;
			clnRG.DefaultCellStyle.Padding = newPadding;
			clnRG.DefaultCellStyle.Format = "0000";

			//--- (2) COLUNA MEMBRO NOME
			clnMembro.DataPropertyName = "MembroNome";
			clnMembro.Visible = true;
			clnMembro.ReadOnly = true;
			clnMembro.Resizable = DataGridViewTriState.False;
			clnMembro.SortMode = DataGridViewColumnSortMode.NotSortable;
			clnMembro.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
			clnMembro.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleLeft;

			//--- (3) COLUNA FUNCAO
			clnFuncao.DataPropertyName = "Funcao";
			clnFuncao.Visible = true;
			clnFuncao.ReadOnly = true;
			clnFuncao.Resizable = DataGridViewTriState.False;
			clnFuncao.SortMode = DataGridViewColumnSortMode.NotSortable;
			clnFuncao.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
			clnFuncao.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleLeft;

			//--- (4) COLUNA CONGREGACAO
			clnCongregacao.DataPropertyName = "Congregacao";
			clnCongregacao.Visible = true;
			clnCongregacao.ReadOnly = true;
			clnCongregacao.Resizable = DataGridViewTriState.False;
			clnCongregacao.SortMode = DataGridViewColumnSortMode.NotSortable;
			clnCongregacao.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
			clnCongregacao.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleLeft;

			//--- (5) COLUNA DA IMPRIMIR
			//clnImprimir.Name = "Ativo";
			clnImprimir.Resizable = DataGridViewTriState.False;
			clnImprimir.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
			clnImprimir.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

			//--- (6) COLUNA EMISSAO DATA
			clnEmissaoData.DataPropertyName = "EmissaoData";
			clnEmissaoData.Visible = true;
			clnEmissaoData.ReadOnly = true;
			clnEmissaoData.Resizable = DataGridViewTriState.False;
			clnEmissaoData.SortMode = DataGridViewColumnSortMode.NotSortable;
			clnEmissaoData.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
			clnEmissaoData.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleLeft;

			//--- (6) COLUNA VALIDADE DATA
			//clnValidadeData.DataPropertyName = "ValidadeData";
			clnValidadeData.Visible = true;
			clnValidadeData.ReadOnly = true;
			clnValidadeData.Resizable = DataGridViewTriState.False;
			clnValidadeData.SortMode = DataGridViewColumnSortMode.NotSortable;
			clnValidadeData.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
			clnValidadeData.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleLeft;

			//--- Add Columns
			dgvListagem.Columns.AddRange(clnRG, clnMembro, clnFuncao, clnCongregacao, clnImprimir, clnEmissaoData, clnValidadeData);
		}

		// CONTROL IMAGES OF LIST DATAGRID
		//------------------------------------------------------------------------------------------------------------
		private void dgvListagem_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
		{
			if (e.ColumnIndex == clnImprimir.Index)
			{
				objMembro item = (objMembro)dgvListagem.Rows[e.RowIndex].DataBoundItem;
				if (item.Imprimir) e.Value = ImgPrint;
				else e.Value = ImgNPrint;
			}
			else if (e.ColumnIndex == clnEmissaoData.Index)
			{
				if (e.Value == null)
				{
					e.Value = "---";
					dgvListagem.Rows[e.RowIndex].Cells[e.ColumnIndex + 1].Value = "---";
				}
				else
				{
					dgvListagem.Rows[e.RowIndex].Cells[e.ColumnIndex + 1].Value = ((DateTime)e.Value).AddYears(_validade);
				}
			}
		}

		// ON ENTER SELECT ITEM
		//------------------------------------------------------------------------------------------------------------
		private void dgvListagem_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
			{
				e.Handled = true;
				e.SuppressKeyPress = true;
				btnEditar_Click(sender, new EventArgs());
			}
		}

		#endregion

		#region BUTTONS FUNCTION

		private void btnFechar_Click(object sender, EventArgs e)
		{
			Close();

			if (_formOrigem == null || _formOrigem.Name != "frmCartaoLista")
			{
				MostraMenuPrincipal();
			}
		}

		private void btnAdicionar_Click(object sender, EventArgs e)
		{
			if (_formOrigem == null)
			{
				frmMembro frm = new frmMembro(new objMembro(null), this);
				frm.MdiParent = Application.OpenForms.OfType<Main.frmPrincipal>().FirstOrDefault();
				DesativaMenuPrincipal();
				Visible = false;
				frm.Show();
			}
			else
			{
				propEscolha = new objMembro(null);
				DialogResult = DialogResult.Yes;
			}
		}

		private void btnEditar_Click(object sender, EventArgs e)
		{
			if (_formOrigem != null && _formOrigem.Name == "frmCartaoLista")
			{
				// ESCOLHER
				EscolherRegistro();
			}
			else
			{
				// EDITAR
				EditarRegistro();
			}
		}

		private void EditarRegistro()
		{
			//--- check selected item
			if (dgvListagem.SelectedRows.Count == 0)
			{
				AbrirDialog("Favor selecionar um registro para Editar...",
					"Selecionar Registro", DialogType.OK, DialogIcon.Information);
				return;
			}

			//--- get Selected item
			objMembro item = (objMembro)dgvListagem.SelectedRows[0].DataBoundItem;

			//--- open edit form
			frmMembro frm = new frmMembro(item, this);
			frm.MdiParent = Application.OpenForms.OfType<Main.frmPrincipal>().FirstOrDefault();
			DesativaMenuPrincipal();
			Visible = false;
			frm.Show();
		}

		private void EscolherRegistro()
		{
			//--- check selected item
			if (dgvListagem.SelectedRows.Count == 0)
			{
				AbrirDialog("Favor selecionar um registro para Editar...",
					"Selecionar Registro", DialogType.OK, DialogIcon.Information);
				return;
			}

			//--- get Selected item
			propEscolha = (objMembro)dgvListagem.SelectedRows[0].DataBoundItem;

			DialogResult = DialogResult.OK;

		}

		#endregion

		#region FILTRAGEM PROCURA

		private void FiltrarListagem(object sender, EventArgs e)
		{
			if (txtProcura.TextLength > 0)
			{
				// filter
				if (!int.TryParse(txtProcura.Text, out int i))
				{
					// declare function
					Func<objMembro, bool> FiltroItem = c => c.MembroNome.ToLower().Contains(txtProcura.Text.ToLower());

					// aply filter using function
					dgvListagem.DataSource = lstMembros.FindAll(c => FiltroItem(c));
				}
				else
				{
					// declare function
					Func<objMembro, bool> FiltroID = c => c.RGMembro == i;

					// aply filter using function
					dgvListagem.DataSource = lstMembros.FindAll(c => FiltroID(c));
				}
			}
			else
			{
				dgvListagem.DataSource = lstMembros;
			}
		}

		#endregion // FILTRAGEM PROCURA --- END

		#region CONTEXT MENU

		private void dgvListagem_MouseDown(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Right)
			{
				Control c = (Control)sender;
				DataGridView.HitTestInfo hit = dgvListagem.HitTest(e.X, e.Y);
				dgvListagem.ClearSelection();

				//---VERIFICAÇÕES NECESSARIAS
				if (hit.Type != DataGridViewHitTestType.Cell) return;

				// seleciona o ROW
				dgvListagem.Rows[hit.RowIndex].Cells[0].Selected = true;
				dgvListagem.Rows[hit.RowIndex].Selected = true;

				objMembro membro = (objMembro)dgvListagem.Rows[hit.RowIndex].DataBoundItem;

				if (membro.Imprimir == true)
				{
					mnuImprimir.Enabled = false;
					mnuNaoImprimir.Enabled = true;
				}
				else
				{
					mnuImprimir.Enabled = true;
					mnuNaoImprimir.Enabled = false;
				}

				if (membro.IDSituacao == 1)
				{
					mnuAtivar.Enabled = false;
					mnuDesativar.Enabled = true;
				}
				else
				{
					mnuAtivar.Enabled = true;
					mnuDesativar.Enabled = false;
				}

				// revela menu
				MenuListagem.Show(c.PointToScreen(e.Location));
			}
		}

		private void ImprimirMarcarDesmarcar_Click(object sender, EventArgs e)
		{
			ToolStripMenuItem menu = (ToolStripMenuItem)sender;

			bool print = bool.Parse(menu.Tag.ToString());

			//--- verifica se existe alguma cell 
			if (dgvListagem.SelectedRows.Count == 0) return;

			//--- Verifica o item
			objMembro membro = (objMembro)dgvListagem.SelectedRows[0].DataBoundItem;

			//--- altera o valor
			membro.Imprimir = print;
			dgvListagem.Refresh();

			//--- Salvar o Registro
			try
			{
				// --- Ampulheta ON
				Cursor.Current = Cursors.WaitCursor;

				MembroBLL cBLL = new MembroBLL(DBPath());
				cBLL.UpdateMembro(membro);

				//--- altera a imagem
				FiltrarListagem(sender, e);
			}
			catch (Exception ex)
			{
				AbrirDialog("Uma exceção ocorreu ao Alterar a Situação do Membro..." + "\n" +
							ex.Message, "Exceção", DialogType.OK, DialogIcon.Exclamation);
			}
			finally
			{
				// --- Ampulheta OFF
				Cursor.Current = Cursors.Default;
			}
		}

		private void mnuAlterarSituacao_Click(object sender, EventArgs e)
		{
			ToolStripMenuItem menu = (ToolStripMenuItem)sender;

			byte newSit = byte.Parse(menu.Tag.ToString());
			string acao = "";

			switch (newSit)
			{
				case 1:
					acao = "ATIVO";
					break;
				case 2:
					acao = "DESLIGADO";
					break;
				case 3:
					acao = "TRANSFERIDO";
					break;
				case 4:
					acao = "FALECIDO";
					break;
				default:
					break;
			}

			//--- verifica se existe alguma cell 
			if (dgvListagem.SelectedRows.Count == 0) return;

			//--- Verifica o item
			objMembro membro = (objMembro)dgvListagem.SelectedRows[0].DataBoundItem;

			//---pergunta ao usuário
			var response = AbrirDialog($"Deseja realmente alterar a situação do membro para: {acao}?\n",
					(membro.IDSituacao == 1 ? "DESATIVAR " : "ATIVAR"),
					DialogType.SIM_NAO, DialogIcon.Question);
			if (response == DialogResult.No) return;

			//--- altera o valor
			membro.IDSituacao = newSit;

			//--- Salvar o Registro
			try
			{
				// --- Ampulheta ON
				Cursor.Current = Cursors.WaitCursor;

				MembroBLL cBLL = new MembroBLL(DBPath());
				cBLL.UpdateMembro(membro);

				//--- altera a imagem
				ObterDados();
				FiltrarListagem(sender, e);
			}
			catch (Exception ex)
			{
				AbrirDialog("Uma exceção ocorreu ao Alterar a Situação do Membro..." + "\n" +
							ex.Message, "Exceção", DialogType.OK, DialogIcon.Exclamation);
			}
			finally
			{
				// --- Ampulheta OFF
				Cursor.Current = Cursors.Default;
			}
		}

		#endregion // CONTEXT MENU --- END

		#region CONTROLS FUNCTION

		// FORM KEYPRESS: BLOQUEIA (+)
		//------------------------------------------------------------------------------------------------------------
		private void frm_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (e.KeyChar == 43)
			{
				//--- cria uma lista de controles que serao impedidos de receber '+'
				Control[] controlesBloqueados = {
					txtCongregacao, txtFuncao, txtSituacao
				};

				if (controlesBloqueados.Contains(ActiveControl)) e.Handled = true;
			}
		}

		// ESC TO CLOSE || KEYDOWN TO DOWNLIST || KEYUP TO UPLIST
		//------------------------------------------------------------------------------------------------------------
		private void frmMembroListagem_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Escape)
			{
				e.Handled = true;
				btnFechar_Click(sender, new EventArgs());
			}
			else if (e.KeyCode == Keys.Up && ActiveControl.GetType().BaseType.Name != "ComboBox")
			{
				e.Handled = true;

				if (dgvListagem.Rows.Count > 0)
				{
					if (dgvListagem.SelectedRows.Count > 0)
					{
						int i = dgvListagem.SelectedRows[0].Index;
						dgvListagem.Rows[i].Selected = false;
						if (i == 0) i = dgvListagem.Rows.Count;
						dgvListagem.Rows[i - 1].Selected = true;
					}
					else
					{
						dgvListagem.Rows[0].Selected = true;
					}

					dgvListagem.FirstDisplayedScrollingRowIndex = dgvListagem.SelectedRows[0].Index;
					dgvListagem.SelectedRows[0].Cells[0].Selected = true;
				}
			}
			else if (e.KeyCode == Keys.Down && ActiveControl.GetType().BaseType.Name != "ComboBox")
			{
				e.Handled = true;

				if (dgvListagem.Rows.Count > 0)
				{
					if (dgvListagem.SelectedRows.Count > 0)
					{
						int i = dgvListagem.SelectedRows[0].Index;
						dgvListagem.Rows[i].Selected = false;
						if (i == dgvListagem.Rows.Count - 1) i = -1;
						dgvListagem.Rows[i + 1].Selected = true;
					}
					else
					{
						dgvListagem.Rows[0].Selected = true;
					}

					dgvListagem.FirstDisplayedScrollingRowIndex = dgvListagem.SelectedRows[0].Index;
					dgvListagem.SelectedRows[0].Cells[0].Selected = true;
				}
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
					case "txtSituacao":
						btnSetSituacao_Click(sender, new EventArgs());
						break;
					default:
						break;
				}
			}
			else if ((e.KeyCode >= Keys.D0 && e.KeyCode <= Keys.D9) | (e.KeyCode >= Keys.NumPad0 && e.KeyCode <= Keys.NumPad9))
			{
				//--- cria um array de controles que serao liberados ao KEYPRESS
				Control[] controlesID = {
					txtFuncao, txtSituacao
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
			else if (e.KeyCode == Keys.Delete)
			{
				e.Handled = true;

				switch (ctr.Name)
				{
					case "txtCongregacao":
						txtCongregacao.Text = "TODAS";
						IDCongregacao = null;
						ObterDados();
						break;
					case "txtFuncao":
						txtFuncao.Text = "TODAS";
						IDFuncao = null;
						ObterDados();
						break;
					case "txtSituacao":
						txtSituacao.Text = "TODAS";
						IDSituacao = null;
						ObterDados();
						break;
					default:
						break;
				}
			}
			else if (e.Alt)
			{
				e.Handled = false;
			}
			else
			{
				//--- cria um array de controles que serão bloqueados de alteracao
				Control[] controlesBloqueados = { txtCongregacao, txtFuncao, txtSituacao };

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

							if (forma.IDFuncao != IDFuncao)
							{
								IDFuncao = (byte)forma.IDFuncao;
								txtFuncao.Text = forma.Funcao;
							}

						}
						break;

					case "txtSituacao":

						if (Program.lstSituacao.Count > 0)
						{
							var forma = Program.lstSituacao.FirstOrDefault(x => x.IDSituacao == int.Parse(e.KeyChar.ToString()));

							if (forma == null) return;

							if (forma.IDSituacao != IDFuncao)
							{
								IDFuncao = (byte)forma.IDSituacao;
								txtSituacao.Text = forma.Situacao;
							}

						}
						break;

					default:
						break;
				}
			}
		}

		// OPEN CONGREGACAO PROCURA FORM
		//------------------------------------------------------------------------------------------------------------
		private void btnCongregacaoEscolher_Click(object sender, EventArgs e)
		{
			frmCongregacaoProcura frm = new frmCongregacaoProcura(this, IDCongregacao);
			frm.ShowDialog();

			//--- check return
			if (frm.DialogResult == DialogResult.OK)
			{
				IDCongregacao = frm.propEscolha.IDCongregacao;
				txtCongregacao.Text = frm.propEscolha.Congregacao;
				ObterDados();
			}

			//--- select
			txtCongregacao.Focus();
			txtCongregacao.SelectAll();
		}

		// SELECT FUNCAO
		//------------------------------------------------------------------------------------------------------------
		private void btnSetFuncao_Click(object sender, EventArgs e)
		{
			if (Program.lstFuncao == null || Program.lstFuncao.Count == 0)
			{
				AbrirDialog("Não há Funcões cadastradas...", "Funções",
					DialogType.OK, DialogIcon.Exclamation);
				return;
			}

			var dic = Program.lstFuncao.ToDictionary(x => (int)x.IDFuncao, x => x.Funcao);

			Main.frmComboLista frm = new Main.frmComboLista(dic, txtFuncao, IDFuncao);

			// show form
			frm.ShowDialog();

			//--- check return
			if (frm.DialogResult == DialogResult.OK)
			{
				IDFuncao = (byte)frm.propEscolha.Key;
				txtFuncao.Text = frm.propEscolha.Value;
				ObterDados();
			}

			//--- select
			txtFuncao.Focus();
			txtFuncao.SelectAll();
		}

		// SELECT SITUACAO
		//------------------------------------------------------------------------------------------------------------
		private void btnSetSituacao_Click(object sender, EventArgs e)
		{
			if (Program.lstSituacao == null || Program.lstSituacao.Count == 0)
			{
				AbrirDialog("Não há Situações cadastradas...", "Situações",
					DialogType.OK, DialogIcon.Exclamation);
				return;
			}

			var dic = Program.lstSituacao.ToDictionary(x => (int)x.IDSituacao, x => x.Situacao);

			Main.frmComboLista frm = new Main.frmComboLista(dic, txtSituacao, IDSituacao);

			// show form
			frm.ShowDialog();

			//--- check return
			if (frm.DialogResult == DialogResult.OK)
			{
				IDSituacao = (byte)frm.propEscolha.Key;
				txtSituacao.Text = frm.propEscolha.Value;
				ObterDados();
			}

			//--- select
			txtSituacao.Focus();
			txtSituacao.SelectAll();
		}

		#endregion // CONTROLS FUNCTION --- END

	}
}
