using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using CamadaDTO;
using static CamadaUI.FuncoesGlobais;
using static CamadaUI.Utilidades;

namespace CamadaUI
{
	static class Program
	{
		public static List<objCongregacao> lstCongregacao;
		public static List<objFuncao> lstFuncao;
		public static List<objEstadoCivil> lstEstadoCivil;
		public static List<objSituacao> lstSituacao;

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);

			// check and create Config XML
			if (!VerificaConfigXML())
			{
				CriarConfigXML();
			}

			Application.Run(new Main.frmPrincipal());
		}
	}
}
