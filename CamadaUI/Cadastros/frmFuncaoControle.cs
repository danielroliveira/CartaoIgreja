using CamadaBLL;
using CamadaDTO;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using static CamadaUI.FuncoesGlobais;
using static CamadaUI.Utilidades;

namespace CamadaUI.Cadastros
{
	public partial class frmFuncaoControle : CamadaUI.Models.frmModFinBorder
	{
		private List<classFuncao> list;
		private BindingSource bindList = new BindingSource();
		FuncaoBLL fBLL = new FuncaoBLL();

		private Form _formOrigem;

		private Image ImgInativo = Properties.Resources.block_24;
		private Image ImgAtivo = Properties.Resources.accept_24;
		private Image ImgNew = Properties.Resources.novo_peq_24;

		private EnumFlagEstado _Sit;

		public objFuncao propEscolhido { get; set; }

		//=================================================================================================
		// SUB NEW
		//=================================================================================================
		#region CONSTRUCTOR | SUB NEW

		public frmFuncaoControle(Form formOrigem = null)
		{
			InitializeComponent();

			_formOrigem = formOrigem;
			mnuAtivar.Text = "Ativar Função";
			mnuDesativar.Text = "Desativar Função";

			bindList.DataSource = typeof(classFuncao);
			ObterDados();
			FormataListagem();

			if (dgvListagem.RowCount > 0)
				Sit = EnumFlagEstado.RegistroSalvo;
			else
			{
				bindList.AddNew();
				Sit = EnumFlagEstado.NovoRegistro;
			}
		}

		// ON SHOW GOTO CONTROL COLLUN CADASTRO
		private void frmFuncaoControle_Shown(object sender, EventArgs e)
		{
			if (list.Count == 0)
			{
				dgvListagem.CurrentCell = dgvListagem.Rows[dgvListagem.CurrentRow.Index].Cells[1];
				dgvListagem.BeginEdit(false);
			}
		}

		private class classFuncao : objFuncao
		{
			public EnumFlagEstado RowSit { get; set; }

			public static List<classFuncao> convertFrom(List<objFuncao> lstFuncao)
			{
				var novaClasse = new List<classFuncao>();

				foreach (var funcao in lstFuncao)
				{
					var cl = new classFuncao()
					{
						Funcao = funcao.Funcao,
						IDFuncao = funcao.IDFuncao,
						Posicao = funcao.Posicao,
						Ativo = funcao.Ativo,
						RowSit = funcao.IDFuncao == null ? EnumFlagEstado.NovoRegistro : EnumFlagEstado.RegistroSalvo
					};

					novaClasse.Add(cl);
				}

				return novaClasse;
			}
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
						btnSalvar.Enabled = false;
						btnCancelar.Enabled = false;
						btnNovo.Enabled = true;
						lblAcao.Visible = false;
						lblAcao.Text = "";
						btnDescer.Enabled = true;
						btnSubir.Enabled = true;
						break;
					case EnumFlagEstado.Alterado:
						btnSalvar.Enabled = true;
						btnCancelar.Enabled = true;
						btnNovo.Enabled = false;
						lblAcao.Visible = true;
						lblAcao.Text = $"Editando {dgvListagem.CurrentRow.Cells[1].Value}";
						btnDescer.Enabled = false;
						btnSubir.Enabled = false;
						break;
					case EnumFlagEstado.NovoRegistro:
						btnSalvar.Enabled = true;
						btnCancelar.Enabled = true;
						btnNovo.Enabled = false;
						lblAcao.Visible = true;
						lblAcao.Text = "Adicionando Novo Registro";
						btnDescer.Enabled = false;
						btnSubir.Enabled = false;
						break;
					default:
						break;
				}
			}
		}

		// GET DATA
		//------------------------------------------------------------------------------------------------------------
		private void ObterDados()
		{
			try
			{
				// --- Ampulheta ON
				Cursor.Current = Cursors.WaitCursor;
				list = classFuncao.convertFrom(fBLL.GetListFuncao());
				bindList.DataSource = list;
				dgvListagem.DataSource = bindList;
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

		#endregion // CONSTRUCTOR | SUB NEW --- END

		//=================================================================================================
		// LISTAGEM | DATAGRIDVIEW
		//=================================================================================================
		#region LISTAGEM | DATAGRIDVIEW

		// FORMATA LISTAGEM
		//------------------------------------------------------------------------------------------------------------
		private void FormataListagem()
		{
			dgvListagem.Columns.Clear();
			dgvListagem.AutoGenerateColumns = false;
			dgvListagem.SelectionMode = DataGridViewSelectionMode.CellSelect;
			dgvListagem.MultiSelect = false;
			dgvListagem.ColumnHeadersVisible = true;
			dgvListagem.AllowUserToResizeRows = false;
			dgvListagem.AllowUserToResizeColumns = false;
			dgvListagem.RowHeadersWidth = 36;
			dgvListagem.RowTemplate.Height = 30;
			dgvListagem.StandardTab = false;
			dgvListagem.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.LightSteelBlue;

			//--- (1) COLUNA POSICAO
			Padding newPadding = new Padding(5, 0, 0, 0);
			clnPosicao.DataPropertyName = "Posicao";
			clnPosicao.Visible = true;
			clnPosicao.ReadOnly = true;
			clnPosicao.Resizable = DataGridViewTriState.False;
			clnPosicao.SortMode = DataGridViewColumnSortMode.NotSortable;
			clnPosicao.DefaultCellStyle.Padding = newPadding;
			clnPosicao.DefaultCellStyle.Format = "00";

			//--- (2) COLUNA CADASTRO
			clnCadastro.DataPropertyName = "Funcao";
			clnCadastro.Visible = true;
			clnCadastro.ReadOnly = false;
			clnCadastro.Resizable = DataGridViewTriState.False;
			clnCadastro.SortMode = DataGridViewColumnSortMode.NotSortable;
			clnCadastro.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
			clnCadastro.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleLeft;

			//--- (4) Coluna da imagem
			clnImage.Name = "Ativo";
			clnImage.ReadOnly = true;
			clnImage.Resizable = DataGridViewTriState.False;
			clnImage.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
			clnImage.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

			//--- Add Columns
			dgvListagem.Columns.AddRange(clnPosicao, clnCadastro, clnImage);
		}

		// CONTROL IMAGES OF LIST DATAGRID
		//------------------------------------------------------------------------------------------------------------
		private void dgvListagem_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
		{
			if (e.ColumnIndex == clnImage.Index)
			{
				objFuncao item = (objFuncao)dgvListagem.Rows[e.RowIndex].DataBoundItem;

				if (item.IDFuncao == null)
				{
					e.Value = ImgNew;
				}
				else
				{
					if (item.Ativo) e.Value = ImgAtivo;
					else e.Value = ImgInativo;
				}
			}
		}

		#endregion // LISTAGEM | DATAGRIDVIEW --- END

		//=================================================================================================
		// EDITING DATAGRID ITENS
		//=================================================================================================
		#region EDITING DATAGRID ITENS

		private void dgvListagem_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
		{
			//--- impede alteracoes nas colunas
			if (e.ColumnIndex == clnPosicao.Index || e.ColumnIndex == clnImage.Index)
			{
				e.Cancel = true;
				return;
			}

			classFuncao currentItem = (classFuncao)dgvListagem.Rows[e.RowIndex].DataBoundItem;

			if (Sit != EnumFlagEstado.RegistroSalvo && currentItem.RowSit == EnumFlagEstado.RegistroSalvo)
			{
				e.Cancel = true;
				return;
			}

			if (currentItem.IDFuncao == null)
			{
				Sit = EnumFlagEstado.NovoRegistro;
				currentItem.RowSit = EnumFlagEstado.NovoRegistro;
				dgvListagem.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.MistyRose;
			}
			else
			{
				Sit = EnumFlagEstado.Alterado;
				currentItem.RowSit = EnumFlagEstado.Alterado;
				dgvListagem.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.MistyRose;
			}
		}

		//--- AO PRESSIONAR A TECLA (ENTER) ENVIAR (TAB) NO DATAGRID
		private void dgvListagem_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
			{
				int iColumn = dgvListagem.CurrentCell.ColumnIndex;
				int iRow = dgvListagem.CurrentCell.RowIndex;

				e.SuppressKeyPress = true;
				e.Handled = true;

				try
				{
					if (iColumn == dgvListagem.ColumnCount - 2)
					{
						if (dgvListagem.RowCount > (iRow + 1))
						{
							dgvListagem.CurrentCell = dgvListagem[1, iRow + 1];
						}
						else
						{
							SelectNextControl(dgvListagem, true, false, true, true);
						}
					}
					else
					{
						dgvListagem.CurrentCell = dgvListagem[iColumn + 1, iRow];
					}
				}
				catch
				{

				}

			}
			else if (e.KeyCode == Keys.Delete)
			{
				e.SuppressKeyPress = true;
				e.Handled = true;

				classFuncao myItem = (classFuncao)dgvListagem.CurrentRow.DataBoundItem;

				if (myItem.RowSit == EnumFlagEstado.NovoRegistro)
				{
					dgvListagem.Rows.Remove(dgvListagem.CurrentRow);
				}

				if (!list.Exists(x => x.RowSit != EnumFlagEstado.RegistroSalvo))
				{
					Sit = EnumFlagEstado.RegistroSalvo;
				}

			}
		}

		// VALIDA CELL | PROCURA DUPLICADO
		private void dgvListagem_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
		{
			//--- verifica se a currenteCELL is Dirty
			if (!dgvListagem.IsCurrentCellDirty) return;

			if (e.ColumnIndex == 1)
			{
				if (String.IsNullOrEmpty(e.FormattedValue.ToString()))
				{
					e.Cancel = false;
					return;
				}

				if (ProcuraFuncaoDuplicada(e.FormattedValue.ToString()) == false)
				{
					dgvListagem.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = String.Empty;
					e.Cancel = true;
					return;
				}
			}
		}

		// PROCURA DUPLICADO congregacao NOME & congregacao NUMERO
		private bool ProcuraFuncaoDuplicada(string valor)
		{
			foreach (classFuncao funcao in bindList.List)
			{
				if (funcao.Funcao?.ToUpper() == valor.ToUpper())
				{
					AbrirDialog($"Função duplicada...\n A Função {valor.ToUpper()} já foi inserida.",
						"Duplicado",
						DialogType.OK,
						DialogIcon.Exclamation);
					return false;
				}
			}

			return true;
		}

		// ON CELL ENTER GOTO NEXT CELL
		/*
		private void DgvListagem_CellEnter(object sender, DataGridViewCellEventArgs e)
		{
			if (e.ColumnIndex == 0)
			{
				SendKeys.Send("{TAB}");
			}
			else if (e.ColumnIndex == 2)
			{
				SendKeys.Send("+{TAB}");
			}
		}
		*/

		#endregion // EDITING DATAGRID ITENS --- END

		//=================================================================================================
		// BUTTONS FUNCTION
		//=================================================================================================
		#region BUTTONS FUNCTION

		// FECHAR
		private void btnFechar_Click(object sender, EventArgs e)
		{
			Close();
			MostraMenuPrincipal();
		}

		// ADD NEW
		private void btnNovo_Click(object sender, EventArgs e)
		{
			bindList.AddNew();
			Sit = EnumFlagEstado.NovoRegistro;
			dgvListagem.CurrentCell = dgvListagem.CurrentRow.Cells[1];
			dgvListagem.BeginEdit(false);
		}

		// CANCEL
		private void btnCancelar_Click(object sender, EventArgs e)
		{
			ObterDados();
			Sit = EnumFlagEstado.RegistroSalvo;
			if (list.Count > 0)
			{
				dgvListagem.CurrentCell = dgvListagem.Rows[dgvListagem.CurrentRow.Index].Cells[1];
			}
		}

		#endregion // BUTTONS FUNCTION --- END

		//=================================================================================================
		// SALVAR REGISTRO
		//=================================================================================================
		#region SALVAR REGISTRO

		private void btnSalvar_Click(object sender, EventArgs e)
		{
			//--- Verifica os valores inseridos
			if (VerificaItems() == false) return;

			//--- verifica se é um ROW editado ou novo
			classFuncao myItem;
			bool everyOK = true;

			foreach (DataGridViewRow row in dgvListagem.Rows)
			{
				try
				{
					myItem = (classFuncao)row.DataBoundItem;

					if (myItem.RowSit == EnumFlagEstado.NovoRegistro || myItem.RowSit == EnumFlagEstado.Alterado)
					{
						if (myItem.RowSit == EnumFlagEstado.NovoRegistro)
						{
							var newItem = ItemInserir(myItem);
							myItem.IDFuncao = newItem;
							bindList.ResetBindings(false);
						}
						else if (myItem.RowSit == EnumFlagEstado.Alterado)
						{
							ItemAlterar(myItem);
						}

						myItem.RowSit = EnumFlagEstado.RegistroSalvo;
					}
				}
				catch
				{
					everyOK = false;
					continue;
				}

			}

			if (everyOK)
			{
				ObterDados();
				Sit = EnumFlagEstado.RegistroSalvo;
				Program.lstFuncao = new FuncaoBLL().GetListFuncao();
				AbrirDialog("Registros salvos com sucesso!", "Registros Salvos");
			}
		}

		//--- VERIFICACAO SE O ITEM ESTA PRONTO PARA SER INSERIDO OU ALTERADO
		private bool VerificaItems()
		{
			classFuncao Item = null;

			foreach (DataGridViewRow row in dgvListagem.Rows)
			{
				dgvListagem.EndEdit();

				try
				{
					Item = (classFuncao)row.DataBoundItem;
				}
				catch
				{
					continue;
				}

				if (string.IsNullOrEmpty(Item.Funcao))
				{
					dgvListagem.CurrentCell = row.Cells[1];
					MessageBox.Show("A descrição da Função não pode ficar vazia...",
									"Campo Vazio",
									MessageBoxButtons.OK,
									MessageBoxIcon.Information);
					return false;
				}

			}

			return true;
		}

		//--- INSERE NOVO ITEM NO TBL congregacao
		public byte ItemInserir(objFuncao funcao)
		{
			try
			{
				//--- Ampulheta ON
				Cursor = Cursors.WaitCursor;

				byte newID = fBLL.InsertFuncao(funcao);
				funcao.IDFuncao = newID;
				return newID;
			}
			catch (Exception ex)
			{
				MessageBox.Show("Ocorreu uma exceção ao inserir uma nova Função\n" +
								ex.Message, "Exceção",
								MessageBoxButtons.OK, MessageBoxIcon.Error);
				throw ex;
			}
			finally
			{
				//--- Ampulheta OFF
				Cursor = Cursors.Default;

			}
		}

		//--- INSERE NOVO ITEM NO TBL Funcao
		public void ItemAlterar(objFuncao funcao)
		{
			try
			{
				//--- Ampulheta ON
				Cursor = Cursors.WaitCursor;

				fBLL.UpdateFuncao(funcao);
			}
			catch (Exception ex)
			{
				MessageBox.Show("Ocorreu uma exceção ao atualizar a Função/n" +
								ex.Message, "Exceção",
								MessageBoxButtons.OK, MessageBoxIcon.Error);
				throw ex;
			}
			finally
			{
				//--- Ampulheta OFF
				Cursor = Cursors.Default;

			}
		}

		#endregion // SALVAR REGISTRO --- END

		//=================================================================================================
		// TOOLSTRIP MENU
		//=================================================================================================
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
				dgvListagem.Rows[hit.RowIndex].Cells[1].Selected = true;
				dgvListagem.Rows[hit.RowIndex].Selected = true;

				// mostra o MENU ativar e desativar
				if (dgvListagem.Columns[hit.ColumnIndex].Name == "Ativo")
				{
					objFuncao congregacao = (objFuncao)dgvListagem.Rows[hit.RowIndex].DataBoundItem;

					if (congregacao.Ativo == true)
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
		}

		private void AtivarDesativar_Click(object sender, EventArgs e)
		{
			//--- verifica se existe alguma cell 
			if (dgvListagem.SelectedCells.Count == 0) return;

			//--- Verifica o item
			objFuncao funcao = (objFuncao)dgvListagem.SelectedCells[0].OwningRow.DataBoundItem;

			//---pergunta ao usuário
			var reponse = AbrirDialog($"Deseja realmente {(funcao.Ativo ? "DESATIVAR " : "ATIVAR")} essa Função?\n" +
									  funcao.Funcao.ToUpper(), (funcao.Ativo ? "DESATIVAR " : "ATIVAR"),
									  DialogType.SIM_NAO, DialogIcon.Question);
			if (reponse == DialogResult.No) return;

			//--- altera o valor
			funcao.Ativo = !funcao.Ativo;

			//--- Salvar o Registro
			try
			{
				// --- Ampulheta ON
				Cursor.Current = Cursors.WaitCursor;

				fBLL.UpdateFuncao(funcao);

				//--- altera a imagem
				dgvListagem.Refresh();

			}
			catch (Exception ex)
			{
				AbrirDialog("Uma exceção ocorreu ao Alterar o registro da Função..." + "\n" +
							ex.Message, "Exceção", DialogType.OK, DialogIcon.Exclamation);
			}
			finally
			{
				// --- Ampulheta OFF
				Cursor.Current = Cursors.Default;
			}
		}

		#endregion // ATIVAR DESATIVAR MENU --- END

		private void btnSubir_Click(object sender, EventArgs e)
		{
			if (dgvListagem.Rows.Count == 0) return;

			if (dgvListagem.SelectedCells.Count == 0)
			{
				AbrirDialog("Selecione uma Função para alterar a posição...", "");
				return;
			}

			objFuncao funcao = (objFuncao)dgvListagem.SelectedCells[0].OwningRow.DataBoundItem;

			if (funcao.Posicao == 1) return;

			//--- get the old Funcao with posicao
			int selIndex = list.IndexOf((classFuncao)funcao);
			var oldFuncaoPos = list[selIndex - 1];

			//--- change alternate positions
			oldFuncaoPos.Posicao += 1;
			funcao.Posicao -= 1;

			try
			{
				// --- Ampulheta ON
				Cursor.Current = Cursors.WaitCursor;

				fBLL.UpdateFuncao(oldFuncaoPos);
				fBLL.UpdateFuncao(funcao);

				ObterDados();

				dgvListagem.CurrentCell = dgvListagem.Rows[funcao.Posicao - 1].Cells[1];

			}
			catch (Exception ex)
			{
				AbrirDialog("Uma exceção ocorreu ao Elevar a posição da Função..." + "\n" +
							ex.Message, "Exceção", DialogType.OK, DialogIcon.Exclamation);
			}
			finally
			{
				// --- Ampulheta OFF
				Cursor.Current = Cursors.Default;
			}
		}

		private void btnDescer_Click(object sender, EventArgs e)
		{
			if (dgvListagem.Rows.Count == 0) return;

			if (dgvListagem.SelectedCells.Count == 0)
			{
				AbrirDialog("Selecione uma Função para alterar a posição...", "");
				return;
			}

			objFuncao funcao = (objFuncao)dgvListagem.SelectedCells[0].OwningRow.DataBoundItem;

			//--- get max posicao
			var maxPos = list.Max(x => x.Posicao);

			if (funcao.Posicao == maxPos) return;

			//--- get the old Funcao with posicao
			int selIndex = list.IndexOf((classFuncao)funcao);
			var oldFuncaoPos = list[selIndex + 1];

			//--- change alternate positions
			oldFuncaoPos.Posicao -= 1;
			funcao.Posicao += 1;

			try
			{
				// --- Ampulheta ON
				Cursor.Current = Cursors.WaitCursor;

				fBLL.UpdateFuncao(oldFuncaoPos);
				fBLL.UpdateFuncao(funcao);

				ObterDados();

				dgvListagem.CurrentCell = dgvListagem.Rows[funcao.Posicao - 1].Cells[1];

			}
			catch (Exception ex)
			{
				AbrirDialog("Uma exceção ocorreu ao Sublevar a posição da Função..." + "\n" +
							ex.Message, "Exceção", DialogType.OK, DialogIcon.Exclamation);
			}
			finally
			{
				// --- Ampulheta OFF
				Cursor.Current = Cursors.Default;
			}
		}

		private void mnuExcluir_Click(object sender, EventArgs e)
		{
			//--- verifica se existe alguma cell 
			if (dgvListagem.SelectedCells.Count == 0) return;

			//--- Verifica o item
			objFuncao funcao = (objFuncao)dgvListagem.SelectedCells[0].OwningRow.DataBoundItem;

			//---pergunta ao usuário
			var reponse = AbrirDialog($"Deseja realmente EXCLUIR definitivamente essa Função?\n" +
									  funcao.Funcao.ToUpper(),
									  "Excluir",
									  DialogType.SIM_NAO,
									  DialogIcon.Question);
			if (reponse == DialogResult.No) return;

			//--- Salvar o Registro
			try
			{
				// --- Ampulheta ON
				Cursor.Current = Cursors.WaitCursor;

				fBLL.DeleteFuncao(funcao);

				//--- altera a imagem
				ObterDados();

			}
			catch (Exception ex)
			{
				AbrirDialog("Uma exceção ocorreu ao Excluir o registro da Função..." + "\n" +
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
