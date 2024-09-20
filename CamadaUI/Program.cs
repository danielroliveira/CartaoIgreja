using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using CamadaBLL;
using CamadaDTO;
using CamadaUI.Main;
using static CamadaUI.FuncoesGlobais;
using static CamadaUI.Utilidades;

namespace CamadaUI
{
	static class Program
	{
		public static objUsuario usuarioAtual;

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
			//Este código deve ser executado antes de criar qualquer elemento da UI
			Application.SetUnhandledExceptionMode(UnhandledExceptionMode.CatchException);
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);

			//--- Check Opened Application
			if (CheckOpenedInstances())
			{
				Application.Exit();
				return;
			}

			//--- Check Server Access
			if (!CheckServerAccess())
			{
				Application.Exit();
				return;
			}

			Application.Run(new frmPrincipal());
		}

		//--- VERIFICA SE EXISTE SERVER CONFIG TO GET CONN STRING
		//------------------------------------------------------------------------------------------------------------
		private static bool CheckServerAccess()
		{
			string TestAcesso = new AcessoControlBLL().GetConnString();

			//--- open FRMCONNSTRING: to define the string de conexao
			if (string.IsNullOrEmpty(TestAcesso))
			{
				Main.frmConnString fcString = new Main.frmConnString();
				fcString.ShowDialog();

				if (fcString.DialogResult != DialogResult.OK)
				{
					return false;
				}

				return true;
			}

			return true;
		}

		// VERIFICA SE JA EXISTE OUTRA INSTANCIA ABERTA
		//------------------------------------------------------------------------------------------------------------
		private static bool CheckOpenedInstances()
		{
			var processo = System.Diagnostics.Process.GetCurrentProcess();
			bool rodando = System.Diagnostics.Process.GetProcessesByName(processo.ProcessName)
				.Any(p => p.Id != processo.Id);

			if (rodando)
			{
				MessageBox.Show("Uma instância da Aplicação já está aberta neste computador...",
					"Tesouraria");
			}

			return rodando;
		}
	}
}
