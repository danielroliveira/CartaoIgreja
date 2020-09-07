using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CamadaUI.Main
{
	public partial class frmDateGet : CamadaUI.Models.frmModFinBorder
	{
		private Form _formOrigem;
		public DateTime? propDataInfo { get; set; }

		#region SUB NEW | CONSTRUCTOR

		// SUB NEW | CONSTRUCTOR
		//------------------------------------------------------------------------------------------------------------
		public frmDateGet(string SubTitulo, EnumDataTipo myDataTipo, DateTime DataPadrao, Form formOrigem)
		{
			InitializeComponent();

			propDataInfo = null;

			lblSubTitulo.Text = SubTitulo;
			DefinirDataLimite(myDataTipo);

			if (DataPadrao > dtpDateInfo.MaxDate)
			{
				dtpDateInfo.Value = dtpDateInfo.MaxDate;
			}
			else if (DataPadrao < dtpDateInfo.MinDate)
			{
				dtpDateInfo.Value = dtpDateInfo.MinDate;
			}
			else
			{
				dtpDateInfo.Value = DataPadrao;
			}

			_formOrigem = formOrigem;
		}

		//--- DEFINIR AS DATAS LIMITES PELO DataTipo
		private void DefinirDataLimite(EnumDataTipo dataTipo)
		{
			switch (dataTipo)
			{
				case EnumDataTipo.PassadoOuFuturo:
					break;
				case EnumDataTipo.Passado:
					dtpDateInfo.MaxDate = DateTime.Today.AddDays(-1);
					break;
				case EnumDataTipo.PassadoPresente:
					dtpDateInfo.MaxDate = DateTime.Today;
					break;
				case EnumDataTipo.Futuro:
					dtpDateInfo.MinDate = DateTime.Today.AddDays(1);
					break;
				case EnumDataTipo.FuturoPresente:
					dtpDateInfo.MinDate = DateTime.Today;
					break;
				default:
					dtpDateInfo.MaxDate = DateTime.Today.AddYears(10);
					dtpDateInfo.MinDate = DateTime.Today.AddYears(-10);
					break;
			}
		}

		#endregion // SUB NEW | CONSTRUCTOR --- END

		#region BUTTONS FUNCTION

		private void btnOK_Click(object sender, EventArgs e)
		{
			propDataInfo = dtpDateInfo.Value;
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
		private void frmDateGet_Activated(object sender, EventArgs e)
		{
			if (_formOrigem != null)
			{
				Panel pnl = (Panel)_formOrigem.Controls["Panel1"];
				pnl.BackColor = Color.Silver;
			}
		}

		private void frmDateGet_FormClosed(object sender, FormClosedEventArgs e)
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
