using CamadaDTO;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using static CamadaUI.FuncoesGlobais;

namespace CamadaUI.Cartao
{
	public partial class frmCartaoReport : CamadaUI.Models.frmModFinBorderSizeable
	{
		private List<objMembro> _MembroList;

		#region SUB NEW | CONSTRUCTOR

		public frmCartaoReport(List<objMembro> MembroList)
		{
			InitializeComponent();

			_MembroList = MembroList;

			ReportDataSource dst = new ReportDataSource("dstMembro", _MembroList);

			// --- define o relatório
			// -------------------------------------------------------------
			// --- clear dataSources
			rptvPadrao.LocalReport.DataSources.Clear();

			// --- insert data
			MembroList.ForEach(mem => mem.ImagemCartaoFrente = "File:\\" + mem.ImagemCartaoFrente);
			rptvPadrao.LocalReport.DataSources.Add(dst);

			//--- add Parameters
			//addParameters(dtInicial, dtFinal);

			// -- display
			rptvPadrao.LocalReport.EnableExternalImages = true;
			rptvPadrao.SetDisplayMode(DisplayMode.PrintLayout);
			rptvPadrao.RefreshReport();

		}

		private void frmCartaoReport_Load(object sender, EventArgs e)
		{
			//--- define o tamanho
			int tamMaxH = Screen.PrimaryScreen.Bounds.Height;
			Height = tamMaxH - (tamMaxH * 10) / 100;
			CenterToScreen();

			this.rptvPadrao.RefreshReport();
		}

		#endregion // SUB NEW --- END

		#region PARAMETERS

		private void addParameters(DateTime dtInicial, DateTime dtFinal)
		{
			List<ReportParameter> @params = new List<ReportParameter>();

			// obter Dados da Igreja
			objDadosIgreja dadosIgreja = ObterDadosIgreja();

			//--- set Periodo
			setPeriodo(dtInicial, dtFinal, @params);

			//--- set Logo Path
			setLogo(dadosIgreja.ArquivoLogoMono, @params);

			//--- add Parameters
			rptvPadrao.LocalReport.SetParameters(@params);
			rptvPadrao.LocalReport.Refresh();
		}

		private void setLogo(string path, List<ReportParameter> @params)
		{
			rptvPadrao.LocalReport.EnableExternalImages = true;
			ReportParameter parameterLogo = new ReportParameter("LogoPath", @"file://" + path);

			@params.Add(parameterLogo);
		}

		private void setPeriodo(DateTime dtInicial, DateTime dtFinal, List<ReportParameter> @params)
		{
			ReportParameter DataInicial = new ReportParameter("dtInicial", dtInicial.ToShortDateString());
			ReportParameter DataFinal = new ReportParameter("dtFinal", dtFinal.ToShortDateString());

			@params.Add(DataInicial);
			@params.Add(DataFinal);
		}

		#endregion // PARAMETERS --- END

		#region BUTTONS

		private void btnFechar_Click(object sender, EventArgs e)
		{
			Close();
		}

		#endregion // BUTTONS --- END
	}
}
