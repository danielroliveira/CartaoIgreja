using BarcodeLib;
using CamadaDTO;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Printing;
using System.Windows.Forms;
using static CamadaUI.FuncoesGlobais;
using static CamadaUI.Utilidades;

namespace CamadaUI.Cartao
{
	public partial class frmCartaoReportVerso : CamadaUI.Models.frmModFinBorderSizeable
	{
		private List<objMembro> _MembroList;
		//private string TempFolder;
		private List<string> lstCodBarras = new List<string>();

		#region SUB NEW | CONSTRUCTOR

		public frmCartaoReportVerso(List<objMembro> MembroList)
		{
			InitializeComponent();

			List<objMembro> newOrganizedList = new List<objMembro>();

			//---ORGANIZE: inverse order to combine with FRONT CARD
			// -------------------------------------------------------------
			for (int i = 0; i < 10; i++)
			{
				if (i < 5)
				{
					newOrganizedList.Add(MembroList[i + 5]);
				}
				else
				{
					newOrganizedList.Add(MembroList[i - 5]);
				}
			}

			// --- define REPORT DATASOURCE
			// -------------------------------------------------------------
			_MembroList = newOrganizedList;
			ReportDataSource dst = new ReportDataSource("dstMembro", _MembroList);

			// --- define o REPORT
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

			//--- Get and Define Temp folder to save BARCODE files
			TempFolder = System.IO.Path.GetTempPath();

			// --- insert data
			EditParams();
			rptvPadrao.LocalReport.DataSources.Add(dst);

			//--- add Parameters
			//addParameters(dtInicial, dtFinal);

			// -- display
			rptvPadrao.LocalReport.EnableExternalImages = true;
			rptvPadrao.SetDisplayMode(DisplayMode.PrintLayout);
			rptvPadrao.RefreshReport();

			/*
			var pgSet = rptvPadrao.GetPageSettings();
			MessageBox.Show($"{pgSet.PaperSize.Height} {pgSet.PaperSize.Width}");
			PrinterSettings printer = new PrinterSettings();
			MessageBox.Show(printer.GetHdevmode(rptvPadrao.PrinterSettings.DefaultPageSettings).ToString());
			size.RawKind = (int)PaperKind.A4;
			*/

		}

		private void frmCartaoReportVerso_Load(object sender, EventArgs e)
		{
			//--- define o tamanho
			int tamMaxH = Screen.PrimaryScreen.Bounds.Height;
			Height = tamMaxH - (tamMaxH * 10) / 100;
			CenterToScreen();

			this.rptvPadrao.RefreshReport();
		}

		private void EditParams()
		{
			string Validade = ObterConfigValorNode("ValidadeAnos");

			int.TryParse(Validade, out int anos);

			foreach (objMembro membro in _MembroList)
			{
				membro.CodBarrasFile = "File:\\" + CreateBarCodeImage((int)membro.RGMembro, TempFolder);
				membro.ImagemCartaoVerso = "File:\\" + membro.ImagemCartaoVerso;
				membro.ValidadeData = DateTime.Today.AddYears(anos);
			}
		}

		private string CreateBarCodeImage(int RGMembro, string TempFolder)
		{
			try
			{
				// --- Ampulheta ON
				Cursor.Current = Cursors.WaitCursor;

				Barcode barcode = new Barcode();

				int width = 160;
				int height = 40;

				Image BarCodeImage = barcode.Encode(TYPE.CODE128, RGMembro.ToString(), Color.Black, Color.Transparent, width, height);

				//--- check folder default
				string newFile = TempFolder + $"\\barcode_{RGMembro}.jpg";
				lstCodBarras.Add(newFile);
				BarCodeImage.Save(newFile);

				return newFile;
			}
			catch (Exception ex)
			{
				AbrirDialog("Uma exceção ocorreu ao Criar a imagem do Cod. de Barras..." + "\n" +
							ex.Message, "Exceção", DialogType.OK, DialogIcon.Exclamation);
				return null;
			}
			finally
			{
				// --- Ampulheta OFF
				Cursor.Current = Cursors.Default;
			}

		}

		#endregion // SUB NEW --- END

		#region BUTTONS

		private void btnFechar_Click(object sender, EventArgs e)
		{
			Close();
		}

		#endregion // BUTTONS --- END

		#region FORM FUNCTIONS

		// DELETE BARCODE FILES AFTER CLOSE
		//------------------------------------------------------------------------------------------------------------
		private void frmCartaoReportVerso_FormClosed(object sender, FormClosedEventArgs e)
		{
			try
			{
				// --- Ampulheta ON
				Cursor.Current = Cursors.WaitCursor;

				foreach (string item in lstCodBarras)
				{
					System.IO.File.Delete(item);
				}

			}
			catch (Exception ex)
			{
				AbrirDialog("Uma exceção ocorreu ao limpar Cod. de Barras..." + "\n" +
							ex.Message, "Exceção", DialogType.OK, DialogIcon.Exclamation);
			}
			finally
			{
				// --- Ampulheta OFF
				Cursor.Current = Cursors.Default;
			}

		}

		#endregion // FORM FUNCTIONS --- END

	}
}
