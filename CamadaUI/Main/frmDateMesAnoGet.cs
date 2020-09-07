using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using static CamadaUI.Utilidades;

namespace CamadaUI.Main
{
	public partial class frmDateMesAnoGet : CamadaUI.Models.frmModFinBorder
	{
		private Form _formOrigem;

		private EnumDataTipo _DataTipo = EnumDataTipo.PassadoPresente;
		public DateTime? propDataInfo { get; set; }

		#region SUB NEW | CONSTRUCTOR

		// SUB NEW | CONSTRUCTOR
		//------------------------------------------------------------------------------------------------------------
		public frmDateMesAnoGet(string SubTitulo, EnumDataTipo myDataTipo, DateTime DataPadrao, Form formOrigem)
		{
			InitializeComponent();

			_formOrigem = formOrigem;
			propDataInfo = null;

			lblSubTitulo.Text = SubTitulo;
			DefinirDataLimite(myDataTipo);
			CarregaComboMes();

			numAno.Value = DataPadrao.Year;
			cmbMes.SelectedValue = DataPadrao.Month;

			numAno.KeyDown += control_KeyDown;
			cmbMes.KeyDown += control_KeyDown;
		}

		//--- DEFINIR AS DATAS LIMITES PELO DataTipo
		private void DefinirDataLimite(EnumDataTipo dataTipo)
		{
			switch (dataTipo)
			{
				case EnumDataTipo.PassadoOuFuturo:
					break;
				case EnumDataTipo.Passado:
				case EnumDataTipo.PassadoPresente:
					numAno.Minimum = 1900;
					numAno.Maximum = DateTime.Today.Year;
					break;
				case EnumDataTipo.Futuro:
				case EnumDataTipo.FuturoPresente:
					numAno.Minimum = DateTime.Today.Year;
					numAno.Maximum = DateTime.Today.Year + 100;
					break;
				default:
					numAno.Minimum = DateTime.Today.Year - 100;
					numAno.Maximum = DateTime.Today.Year + 100;
					break;
			}
		}

		// CARREGA COMBO
		//------------------------------------------------------------------------------------------------------------
		private void CarregaComboMes()
		{
			//--- Create DataTable
			DataTable dtMeses = new DataTable();
			dtMeses.Columns.Add("ID", typeof(int));
			dtMeses.Columns.Add("Mes");

			// get values of EnumAgendaRecorrencia
			string[] EnumValues = new System.Globalization.CultureInfo("pt-BR").DateTimeFormat.MonthNames;
			int i = 1;

			// insert all item of EnumAgendaRecorrencia in datatable
			foreach (var mes in EnumValues)
			{
				if (string.IsNullOrEmpty(mes)) continue;
				dtMeses.Rows.Add(new object[] { i, mes });
				i++;
			}

			//--- Set DataTable
			cmbMes.DataSource = dtMeses;
			cmbMes.ValueMember = "ID";
			cmbMes.DisplayMember = "Mes";
		}

		private void control_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
			{
				e.SuppressKeyPress = true;
				SendKeys.Send("{Tab}");
			};
		}

		#endregion // SUB NEW | CONSTRUCTOR --- END

		#region BUTTONS FUNCTION

		private void btnOK_Click(object sender, EventArgs e)
		{
			int anoAtual = DateTime.Today.Year;
			int mesAtual = DateTime.Today.Month;
			string cancel = string.Empty;

			// check composition Mes/Ano
			switch (_DataTipo)
			{
				case EnumDataTipo.Passado:
				case EnumDataTipo.PassadoPresente: // lower than actual date

					if (numAno.Value > anoAtual)
					{
						cancel = "o ANO escolhido precisa ser MENOR que o da data atual.";
					}
					else
					{
						if ((int)cmbMes.SelectedValue > mesAtual)
						{
							cancel = "o MÊS escolhido precisa ser MENOR que o da data atual.";
						}
					}

					break;
				case EnumDataTipo.Futuro:
				case EnumDataTipo.FuturoPresente: // bigger than actual date

					if (numAno.Value < anoAtual)
					{
						cancel = "o ANO escolhido precisa ser MAIOR que o da data atual."; ;
					}
					else
					{
						if ((int)cmbMes.SelectedValue < mesAtual)
						{
							cancel = "o MÊS escolhido precisa ser MAIOR que o da data atual.";
						}
					}

					break;
				case EnumDataTipo.PassadoOuFuturo:
				default:
					break;
			}

			if (cancel.Length > 0)
			{
				AbrirDialog("Mês e/ou Ano inválidos...\n" + cancel, "Inválido");
				return;
			}

			propDataInfo = new DateTime((int)numAno.Value, (int)cmbMes.SelectedValue, 1);
			DialogResult = DialogResult.OK;
		}

		private void btnCancelar_Click(object sender, EventArgs e)
		{
			propDataInfo = null;
			DialogResult = DialogResult.Cancel;
		}

		#endregion // BUTTONS FUNCTION --- END

		#region VISUAL EFFECTS

		//-------------------------------------------------------------------------------------------------
		//---  CRIAR EFEITO VISUAL DE FORM SELECIONADO
		//-------------------------------------------------------------------------------------------------
		private void frmDateMesAnoGet_Activated(object sender, EventArgs e)
		{
			if (_formOrigem != null)
			{
				Panel pnl = (Panel)_formOrigem.Controls["Panel1"];
				pnl.BackColor = Color.Silver;
			}
		}

		private void frmDateMesAnoGet_FormClosed(object sender, FormClosedEventArgs e)
		{
			if (_formOrigem != null)
			{
				Panel pnl = (Panel)_formOrigem.Controls["Panel1"];
				pnl.BackColor = Color.SlateGray;
			}
		}

		#endregion // VISUAL EFFECTS --- END

	}
}
