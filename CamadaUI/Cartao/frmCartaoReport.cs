using CamadaDTO;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.Drawing.Printing;
using System.Windows.Forms;

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

			//--- Define Page Settings
			PageSettings pg = new PageSettings();
			pg.Margins.Top = 10;
			pg.Margins.Bottom = 10;
			pg.Margins.Left = 30;
			pg.Margins.Right = 10;

			PaperSize size = new PaperSize("Cartao Membro", 787, 1181);
			pg.PaperSize = size;
			rptvPadrao.SetPageSettings(pg);
			rptvPadrao.RefreshReport();

			// --- clear dataSources
			rptvPadrao.LocalReport.DataSources.Clear();

			// --- insert data
			MembroList.ForEach(mem => mem.ImagemCartaoFrente = "File:\\" + mem.ImagemCartaoFrente);
			MembroList.ForEach(mem => mem.ImagemFoto = "File:\\" + mem.ImagemFoto);
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

		#region BUTTONS

		private void btnFechar_Click(object sender, EventArgs e)
		{
			Close();
		}

		#endregion // BUTTONS --- END
	}
}
