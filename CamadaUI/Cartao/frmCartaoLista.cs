using CamadaBLL;
using CamadaDTO;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using static CamadaUI.FuncoesGlobais;
using static CamadaUI.Utilidades;

namespace CamadaUI.Cartao
{
	public partial class frmCartaoLista : CamadaUI.Models.frmModFinBorder
	{
		private List<objMembro> lstMembros = new List<objMembro>();
		private Form _formOrigem;

		#region NEW | OPEN FUNCTIONS

		public frmCartaoLista(Form formOrigem = null)
		{
			InitializeComponent();

			//--- Add any initialization after the InitializeComponent() call.
			_formOrigem = formOrigem;
			ObterDados();
			FormataListagem();

			//--- get dados
			dgvListagem.CellDoubleClick += btnEditar_Click;
			HandlerKeyDownControl(this);
		}

		//--- PROPRIEDADE DE ESCOLHA
		public objMembro propEscolha { get; set; }

		// GET DATA
		//------------------------------------------------------------------------------------------------------------
		private void ObterDados()
		{
			try
			{
				// --- Ampulheta ON
				Cursor.Current = Cursors.WaitCursor;
				MembroBLL cBLL = new MembroBLL(DBPath());
				lstMembros = cBLL.GetListMembroToPrint();
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

			//--- Add Columns
			dgvListagem.Columns.AddRange(clnRG, clnMembro, clnFuncao, clnCongregacao);
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
			MostraMenuPrincipal();
		}

		private void btnAdicionar_Click(object sender, EventArgs e)
		{
			if (_formOrigem == null)
			{
				/*
				frmMembro frm = new frmMembro(new objMembro(null));
				frm.MdiParent = Application.OpenForms.OfType<Main.frmPrincipal>().FirstOrDefault();
				DesativaMenuPrincipal();
				Close();
				frm.Show();
				*/
			}
			else
			{
				propEscolha = new objMembro(null);
				DialogResult = DialogResult.Yes;
			}
		}

		private void btnEditar_Click(object sender, EventArgs e)
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
			if (_formOrigem == null)
			{
				/*
				frmMembro frm = new frmMembro(item);
				frm.MdiParent = Application.OpenForms.OfType<Main.frmPrincipal>().FirstOrDefault();
				DesativaMenuPrincipal();
				Close();
				frm.Show();
				*/
			}
			else
			{
				propEscolha = item;
				DialogResult = DialogResult.Yes;
			}
		}

		#endregion

		#region ATIVAR DESATIVAR MENU

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

		#endregion // ATIVAR DESATIVAR MENU --- END

		#region CONTROLS FUNCTION

		// ESC TO CLOSE || KEYDOWN TO DOWNLIST || KEYUP TO UPLIST
		//------------------------------------------------------------------------------------------------------------
		private void frmCartaoLista_KeyDown(object sender, KeyEventArgs e)
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

		#endregion // CONTROLS FUNCTION --- END

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
	}
}
