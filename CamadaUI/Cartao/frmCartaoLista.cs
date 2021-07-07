using CamadaBLL;
using CamadaDTO;
using CamadaUI.Main;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using static CamadaUI.FuncoesGlobais;
using static CamadaUI.Utilidades;

namespace CamadaUI.Cartao
{
	public partial class frmCartaoLista : CamadaUI.Models.frmModFinBorder
	{
		private List<objMembro> lstMembros = new List<objMembro>();
		private Form _formOrigem;
		private MembroBLL mBLL = new MembroBLL(DBPath());

		#region NEW | OPEN FUNCTIONS

		public frmCartaoLista(Form formOrigem = null)
		{
			InitializeComponent();

			//--- Add any initialization after the InitializeComponent() call.
			_formOrigem = formOrigem;
			ObterDados();
			ObterMarcados();
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
				lstMembros = mBLL.GetListMembroToPrint();
				dgvListagem.DataSource = lstMembros;
				AtualizarNaLista();
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

		private void ObterMarcados()
		{
			try
			{
				// --- Ampulheta ON
				Cursor.Current = Cursors.WaitCursor;
				int marcados = mBLL.CountMarcados();

				if (marcados == 0)
				{
					lblMarcados.Text = "Nenhum Membro foi marcado para impressão";
				}
				else if (marcados == 1)
				{
					lblMarcados.Text = "Um Membro marcado para impressão";
				}
				else
				{
					lblMarcados.Text = $"{marcados:D2} Membros marcados para impressão";
				}

			}
			catch (Exception ex)
			{
				AbrirDialog("Uma exceção ocorreu ao Obter a quantidade de membros marcados para impressão..." + "\n" +
							ex.Message, "Exceção", DialogType.OK, DialogIcon.Exclamation);
			}
			finally
			{
				// --- Ampulheta OFF
				Cursor.Current = Cursors.Default;
			}

		}

		private int AtualizarNaLista()
		{
			int count = lstMembros.Count();

			if (count == 0)
			{
				lblNaLista.Text = "Nenhum Membro foi inserido na lista de impressão";
				lblNaLista.ForeColor = Color.Black;
				lblNaLista.Font = new Font("Pathway Gothic One", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
				btnRemover.Enabled = false;
				btnAdicionar.Enabled = true;
			}
			else if (count == 1)
			{
				lblNaLista.Text = "Um Membro foi inserido na lista de impressão";
				lblNaLista.ForeColor = Color.Black;
				lblNaLista.Font = new Font("Pathway Gothic One", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
				btnRemover.Enabled = true;
				btnAdicionar.Enabled = true;
			}
			else if (count >= 10)
			{
				lblNaLista.Text = "(!) LISTA DE IMPRESSÃO COMPLETA";
				lblNaLista.ForeColor = Color.Red;
				lblNaLista.Font = new Font("Pathway Gothic One", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
				btnRemover.Enabled = true;
				btnAdicionar.Enabled = false;
			}
			else
			{
				lblNaLista.Text = $"{count:D2} Membros foram inseridos na lista de impressão";
				lblNaLista.ForeColor = Color.Black;
				lblNaLista.Font = new Font("Pathway Gothic One", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
				btnRemover.Enabled = true;
				btnAdicionar.Enabled = true;
			}

			return count;
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

		// FECHAR
		//------------------------------------------------------------------------------------------------------------
		private void btnFechar_Click(object sender, EventArgs e)
		{
			Close();
			MostraMenuPrincipal();
		}

		// INSERT MEMBRO LIST
		//------------------------------------------------------------------------------------------------------------
		private void btnAdicionar_Click(object sender, EventArgs e)
		{
			try
			{
				// --- Ampulheta ON
				Cursor.Current = Cursors.WaitCursor;

				Membros.frmMembroListagem frm = new Membros.frmMembroListagem(this);
				frm.ShowDialog();

				if (frm.DialogResult != DialogResult.OK) return;

				objMembro membro = frm.propEscolha;

				if (membro.NaLista)
				{
					AbrirDialog("O membro escolhido:\n" +
						membro.MembroNome.ToUpper() + "\n" +
						"já está na listagem de impressão...", "Na Lista");
					return;
				}

				if (!membro.Imprimir)
				{
					var resp = AbrirDialog("O membro escolhido:\n" +
						membro.MembroNome.ToUpper() + "\n" +
						"não está marcado para imprimir\n" +
						"Deseja marcar para impressão e inserir na listagem?", "Marcar para Impressão",
						DialogType.SIM_NAO, DialogIcon.Question);

					if (resp == DialogResult.No) return;

					membro.Imprimir = true;
				}

				//--- save membro
				membro.NaLista = true;
				mBLL.UpdateMembro(membro);

				//--- Get Data
				ObterDados();

				foreach (DataGridViewRow row in dgvListagem.Rows)
				{
					if ((int)row.Cells[0].Value == membro.RGMembro)
					{
						row.Selected = true;
					}
					else
					{
						row.Selected = false;
					}
				}
			}
			catch (Exception ex)
			{
				AbrirDialog("Uma exceção ocorreu ao Adicionar Membro na lista de impressão..." + "\n" +
							ex.Message, "Exceção", DialogType.OK, DialogIcon.Exclamation);
			}
			finally
			{
				// --- Ampulheta OFF
				Cursor.Current = Cursors.Default;
			}
		}

		// REMOVE MEMBRO LIST
		//------------------------------------------------------------------------------------------------------------
		private void btnRemover_Click(object sender, EventArgs e)
		{
			try
			{
				// --- Ampulheta ON
				Cursor.Current = Cursors.WaitCursor;

				//--- check selected item
				if (dgvListagem.SelectedRows.Count == 0)
				{
					AbrirDialog("Favor selecionar um registro para Editar...",
						"Selecionar Registro", DialogType.OK, DialogIcon.Information);
					return;
				}

				//--- get Selected item
				objMembro item = (objMembro)dgvListagem.SelectedRows[0].DataBoundItem;

				var resp = AbrirDialog("Deseja realmente remover o membro:\n" +
					item.MembroNome.ToUpper() + "\n" +
					"da lista de impressão?", "Remover Impressão",
					DialogType.SIM_NAO, DialogIcon.Question, DialogDefaultButton.Second);

				if (resp == DialogResult.No) return;

				//--- save membro
				item.NaLista = false;
				mBLL.UpdateMembro(item);

				//--- Get Data
				ObterDados();

			}
			catch (Exception ex)
			{
				AbrirDialog("Uma exceção ocorreu ao Remover Membro na lista de impressão..." + "\n" +
							ex.Message, "Exceção", DialogType.OK, DialogIcon.Exclamation);
			}
			finally
			{
				// --- Ampulheta OFF
				Cursor.Current = Cursors.Default;
			}
		}

		// EDIT MEMBRO DATA
		//------------------------------------------------------------------------------------------------------------
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
			Membros.frmMembro frm = new Membros.frmMembro(item, this);
			frm.MdiParent = Application.OpenForms.OfType<Main.frmPrincipal>().FirstOrDefault();
			DesativaMenuPrincipal();
			frm.Show();
		}

		private Task Teste()
		{
			return new Task(() =>
			{
				var lblTeste = new Label();

				lblTeste.AutoSize = true;
				lblTeste.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
				lblTeste.ForeColor = System.Drawing.Color.Red;
				lblTeste.Location = new System.Drawing.Point(650, 509);
				lblTeste.Name = "lblAguarde";
				lblTeste.Size = new System.Drawing.Size(172, 32);
				lblTeste.TabIndex = 11;
				lblTeste.Text = "Aguarde...";
				lblTeste.Visible = false;
				lblTeste.Blink(50, 500);

			});

		}

		private void btnPrintFrente_Click(object sender, EventArgs e)
		{
			ObterDados();

			try
			{
				// --- Ampulheta ON
				Cursor.Current = Cursors.WaitCursor;

				lblAguarde.Visible = true;

				//--- Checking
				if (!CheckQuantidade()) return;
				if (!CheckModelos()) return;

				//--- check fotos
				var task = Task.Run(async () => await CheckAndGetFotosFromServer());
				var result = task.Result;
				if (!result) return;

				//--- open print form
				new frmCartaoReport(lstMembros).ShowDialog();

				//--- delete temporary fotos
				DeleteTemporaryPhotos();

				lblAguarde.Visible = false;

			}
			catch (Exception ex)
			{
				AbrirDialog("Uma exceção ocorreu ao Abrir formulário de impressão..." + "\n" +
							ex.Message, "Exceção", DialogType.OK, DialogIcon.Exclamation);
			}
			finally
			{
				// --- Ampulheta OFF
				Cursor.Current = Cursors.Default;
			}
		}

		private void btnPrintAtras_Click(object sender, EventArgs e)
		{
			ObterDados();

			if (!CheckQuantidade()) return;
			if (!CheckModelos()) return;

			try
			{
				// --- Ampulheta ON
				Cursor.Current = Cursors.WaitCursor;

				new frmCartaoReportVerso(lstMembros).ShowDialog();
			}
			catch (Exception ex)
			{
				AbrirDialog("Uma exceção ocorreu ao Abrir formulário de impressão..." + "\n" +
							ex.Message, "Exceção", DialogType.OK, DialogIcon.Exclamation);
			}
			finally
			{
				// --- Ampulheta OFF
				Cursor.Current = Cursors.Default;
			}
		}

		private void btnPrintConcluido_Click(object sender, EventArgs e)
		{
			if (!CheckQuantidade()) return;
		}

		// VERIFY QUANTITY TO PRINT
		//------------------------------------------------------------------------------------------------------------
		private bool CheckQuantidade()
		{
			if (AtualizarNaLista() != 10)
			{
				AbrirDialog("É necessário pelo menos 10 membros inseridos na lista de impressão...",
					"Lista Incompleta", DialogType.OK, DialogIcon.Exclamation);
				return false;
			}

			return true;
		}

		// VERIFICA FOTOS AUSENTES
		//------------------------------------------------------------------------------------------------------------
		private bool CheckFotosLocal()
		{
			string FotosFolder = ObterConfigValorNode("FotosImageFolder");

			if (string.IsNullOrEmpty(FotosFolder))
			{
				AbrirDialog("Ainda não existe a pasta de imagens de fotos na configuração\n" +
					$"Favor definir a pasta de imagens de fotos antes de imprimir.",
					"Pasta de Imagens Ausente", DialogType.OK, DialogIcon.Exclamation);
				return false;
			}

			string newFile;

			foreach (objMembro membro in lstMembros)
			{
				//--- check folder default
				newFile = FotosFolder + $"\\{membro.RGMembro}.jpg";

				var file = new FileInfo(newFile);

				if (!file.Exists)
				{
					AbrirDialog($"{membro.MembroNome.ToUpper()}\n" +
						$"ainda não possui foto anexada...\n" +
						$"Favor anexar a foto do membro antes de imprimir.",
						"Foto Ausente", DialogType.OK, DialogIcon.Exclamation);
					return false;
				}

				membro.ImagemFoto = newFile;

			}

			return true;
		}

		// CHECK FOTOS FORM SERVER
		//------------------------------------------------------------------------------------------------------------
		private async Task<bool> CheckAndGetFotosFromServer()
		{
			//--- Get Directory to Download
			string appDataSavePath = Environment.GetFolderPath(
				Environment.SpecialFolder.ApplicationData)
				+ "\\CartaoIgreja\\PrintFotos";

			if (!Directory.Exists(appDataSavePath))
			{
				Directory.CreateDirectory(appDataSavePath);
			}

			try
			{
				// --- Ampulheta ON
				Cursor.Current = Cursors.WaitCursor;

				foreach (objMembro membro in lstMembros)
				{
					try
					{
						await GDriveControl.DownloadImageAndSaveLocal($"{membro.RGMembro}.jpg", appDataSavePath);
						membro.ImagemFoto = Path.Combine(appDataSavePath, $"{membro.RGMembro}.jpg");
					}
					catch (AppException)
					{
						AbrirDialog("Ainda não existe a foto do Membro no GoogleDrive:\n" +
								$"{membro.MembroNome}.",
								"Imagem/Foto Ausente", DialogType.OK, DialogIcon.Exclamation);
						return false;
					}
					catch (Exception ex)
					{
						AbrirDialog("Uma exceção ocorreu ao Obter as Fotos do Servidor..." + "\n" +
									ex.Message, "Exceção", DialogType.OK, DialogIcon.Exclamation);
						break;
					}

				}
			}
			catch (Exception ex)
			{
				AbrirDialog("Uma exceção ocorreu ao Obter as Fotos do Servidor..." + "\n" +
							ex.Message, "Exceção", DialogType.OK, DialogIcon.Exclamation);
			}
			finally
			{
				// --- Ampulheta OFF
				Cursor.Current = Cursors.Default;
			}

			return true;
		}

		// DELETE TEMPORARY PHOTOS FROM DEFAULT FOLDER
		//------------------------------------------------------------------------------------------------------------
		private void DeleteTemporaryPhotos()
		{
			//--- Get Directory to Download
			string appDataSavePath = Environment.GetFolderPath(
				Environment.SpecialFolder.ApplicationData)
				+ "\\CartaoIgreja\\PrintFotos";

			if (!Directory.Exists(appDataSavePath))
			{
				return;
			}

			try
			{
				var dir = new DirectoryInfo(appDataSavePath);

				foreach (var file in dir.GetFiles())
				{
					file.Delete();
				}
			}
			catch (Exception ex)
			{
				AbrirDialog("Uma exceção ocorreu ao Obter as Fotos do Servidor..." + "\n" +
							ex.Message, "Exceção", DialogType.OK, DialogIcon.Exclamation);
			}
			finally
			{
				// --- Ampulheta OFF
				Cursor.Current = Cursors.Default;
			}

		}

		// VERIFICA MODELOS AUSENTES
		//------------------------------------------------------------------------------------------------------------
		private bool CheckModelos()
		{
			//--- check FOLDER
			string ModelosFolder = ObterConfigValorNode("DesignImageFolder");

			if (string.IsNullOrEmpty(ModelosFolder))
			{
				AbrirDialog("Ainda não existe a pasta de imagens de modelos dos cartões na configuração\n" +
					$"Favor definir a pasta de imagens de modelos antes de imprimir.",
					"Pasta de Modelos Ausente", DialogType.OK, DialogIcon.Exclamation);
				return false;
			}

			//--- check Files models
			string newFile;

			foreach (objMembro membro in lstMembros)
			{
				//--- check model definition
				if (string.IsNullOrEmpty(membro.ImagemCartaoFrente) || string.IsNullOrEmpty(membro.ImagemCartaoVerso))
				{
					AbrirDialog($"{membro.Funcao.ToUpper()} " +
						$"ainda não possui um modelo de cartão definido...\n" +
						$"Favor definir um modelo de cartão da função no BD antes de imprimir.",
						"Modelo Não Definido", DialogType.OK, DialogIcon.Exclamation);
					return false;
				}

				//--- check modelo file FRENTE
				newFile = ModelosFolder + $"\\{membro.ImagemCartaoFrente}.jpg";

				var filefrente = new FileInfo(newFile);

				if (!filefrente.Exists)
				{
					AbrirDialog($"O modelo da FRENTE do cartão da função:\n" +
						$"{membro.Funcao.ToUpper()}\n" +
						$"Está ausente..." +
						$"Comunique ao administrador do sistema",
						"Modelo Ausente", DialogType.OK, DialogIcon.Exclamation);
					return false;
				}
				else
				{
					membro.ImagemCartaoFrente = newFile;
				}

				//--- check modelo file VERSO
				newFile = ModelosFolder + $"\\{membro.ImagemCartaoVerso}.jpg";

				var fileverso = new FileInfo(newFile);

				if (!fileverso.Exists)
				{
					AbrirDialog($"O modelo da VERSO do cartão da função:\n" +
						$"{membro.Funcao.ToUpper()}\n" +
						$"Está ausente..." +
						$"Comunique ao administrador do sistema",
						"Modelo Ausente", DialogType.OK, DialogIcon.Exclamation);
					return false;
				}
				else
				{
					membro.ImagemCartaoVerso = newFile;
				}
			}

			return true;
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

				// revela menu
				MenuListagem.Show(c.PointToScreen(e.Location));
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
	}
}
