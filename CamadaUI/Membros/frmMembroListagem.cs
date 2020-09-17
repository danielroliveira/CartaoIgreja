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
		private Image ImgInativo = Properties.Resources.block_24;
		private Image ImgAtivo = Properties.Resources.accept_24;

		private Form _formOrigem;

		#region NEW | OPEN FUNCTIONS

		public frmMembroListagem(Form formOrigem = null)
		{
			InitializeComponent();

			//--- Add any initialization after the InitializeComponent() call.
			_formOrigem = formOrigem;
			CarregaCmbSituacao();
			ObterDados(this, new EventArgs());
			FormataListagem();

			//--- get dados
			cmbAtivo.SelectedValueChanged += ObterDados;
			dgvListagem.CellDoubleClick += btnEditar_Click;
			txtProcura.TextChanged += FiltrarListagem;
			HandlerKeyDownControl(this);
		}

		//--- PROPRIEDADE DE ESCOLHA
		public objMembro propEscolha { get; set; }

		// GET DATA
		//------------------------------------------------------------------------------------------------------------
		private void ObterDados(object sender, EventArgs e)
		{
			try
			{
				// --- Ampulheta ON
				Cursor.Current = Cursors.WaitCursor;
				MembroBLL cBLL = new MembroBLL(DBPath());
				lstMembros = cBLL.GetListMembro();
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

		// CARREGA COMBO
		//------------------------------------------------------------------------------------------------------------
		private void CarregaCmbSituacao()
		{
			//--- Set DataTable
			cmbAtivo.DataSource = Program.lstSituacao;
			cmbAtivo.ValueMember = "IDSituacao";
			cmbAtivo.DisplayMember = "Situacao";
			cmbAtivo.SelectedValue = 1;
			cmbAtivo.SelectedIndex = 0;
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

			//--- (3) Coluna da imagem
			/*
			clnImage.Name = "Ativo";
			clnImage.Resizable = DataGridViewTriState.False;
			clnImage.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
			clnImage.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
			*/

			//--- Add Columns
			dgvListagem.Columns.AddRange(clnRG, clnMembro);
		}

		// CONTROL IMAGES OF LIST DATAGRID
		//------------------------------------------------------------------------------------------------------------
		private void dgvListagem_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
		{
			if (e.ColumnIndex == 2)
			{
				objMembro item = (objMembro)dgvListagem.Rows[e.RowIndex].DataBoundItem;
				//if (item.Ativo) e.Value = ImgAtivo;
				//else e.Value = ImgInativo;
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
			MostraMenuPrincipal();
		}

		private void btnAdicionar_Click(object sender, EventArgs e)
		{
			if (_formOrigem == null)
			{
				frmMembro frm = new frmMembro(new objMembro(null), this);
				frm.MdiParent = Application.OpenForms.OfType<Main.frmPrincipal>().FirstOrDefault();
				DesativaMenuPrincipal();
				Close();
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
				frmMembro frm = new frmMembro(item, this);
				frm.MdiParent = Application.OpenForms.OfType<Main.frmPrincipal>().FirstOrDefault();
				DesativaMenuPrincipal();
				Close();
				frm.Show();
			}
			else
			{
				propEscolha = item;
				DialogResult = DialogResult.Yes;
			}
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

		#region ATIVAR DESATIVAR MENU

		private void dgvListagem_MouseDown(object sender, MouseEventArgs e)
		{
			/*
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

				// mostra o MENU ativar e desativar
				if (dgvListagem.Columns[hit.ColumnIndex].Name == "Ativo")
				{
					objMembroSetor Setor = (objMembroSetor)dgvListagem.Rows[hit.RowIndex].DataBoundItem;

					if (Setor.Ativo == true)
					{
						AtivarToolStripMenuItem.Enabled = false;
						DesativarToolStripMenuItem.Enabled = true;
					}
					else
					{
						AtivarToolStripMenuItem.Enabled = true;
						DesativarToolStripMenuItem.Enabled = false;
					}

					// revela menu
					MenuListagem.Show(c.PointToScreen(e.Location));
				}
			}
			*/
		}

		private void AtivarDesativar_Setor_Click(object sender, EventArgs e)
		{
			/*
			//--- verifica se existe alguma cell 
			if (dgvListagem.SelectedRows.Count == 0) return;

			//--- Verifica o item
			objMembroSetor setor = (objMembroSetor)dgvListagem.SelectedRows[0].DataBoundItem;

			//---pergunta ao usuário
			var reponse = AbrirDialog($"Deseja realmente {(setor.Ativo ? "DESATIVAR " : "ATIVAR")} esse Setor?\n" +
									  setor.CongregacaoSetor.ToUpper(), (setor.Ativo ? "DESATIVAR " : "ATIVAR"),
									  DialogType.SIM_NAO, DialogIcon.Question);
			if (reponse == DialogResult.No) return;

			//--- altera o valor
			setor.Ativo = !setor.Ativo;

			//--- Salvar o Registro
			try
			{
				// --- Ampulheta ON
				Cursor.Current = Cursors.WaitCursor;

				CongregacaoBLL cBLL = new CongregacaoBLL();
				cBLL.UpdateCongregacaoSetor(setor);

				//--- altera a imagem
				FiltrarListagem(sender, e);
			}
			catch (Exception ex)
			{
				AbrirDialog("Uma exceção ocorreu ao Alterar Setor..." + "\n" +
							ex.Message, "Exceção", DialogType.OK, DialogIcon.Exclamation);
			}
			finally
			{
				// --- Ampulheta OFF
				Cursor.Current = Cursors.Default;
			}
			*/
		}

		#endregion // ATIVAR DESATIVAR MENU --- END

		#region CONTROLS FUNCTION

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

		#endregion // CONTROLS FUNCTION --- END
	}
}
