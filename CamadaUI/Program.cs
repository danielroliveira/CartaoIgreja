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
			var serverAccess = CheckServerAccess();

			if (!serverAccess.Result)
			{
				AbrirDialog("Não foi possível conectar com o servidor de dados...\n" +
					$"{serverAccess.Message}",
					"Conexão com Servidor", 
					DialogType.OK, 
					DialogIcon.Exclamation);
				Application.Exit();
				return;
			}

			Application.Run(new frmPrincipal());
		}

		//--- VERIFICA SE EXISTE SERVER CONFIG TO GET CONN STRING
		//------------------------------------------------------------------------------------------------------------
		private static CommandResult CheckServerAccess()
		{
			string TestAcesso = new AcessoControlBLL().GetConnString();

			//--- open FRMCONNSTRING: to define the string de conexao
			if (string.IsNullOrEmpty(TestAcesso))
			{
				Main.frmConnString fcString = new Main.frmConnString();
				fcString.ShowDialog();

				if (fcString.DialogResult != DialogResult.OK)
				{
					return new CommandResult(false, "Não foi encontrada a Chave de Conexão...");
				}
			}

			//--- create new Acesso and Transaction
			var acesso = new AcessoControlBLL();
			var dbTran = acesso.GetNewAcessoWithTransaction();

			try
			{
				// --- Ampulheta ON
				Cursor.Current = Cursors.WaitCursor;

				//--- get database name from Connexion String
				var builder = new System.Data.SqlClient.SqlConnectionStringBuilder(TestAcesso);

				string server = builder.DataSource;
				string database = builder.InitialCatalog;

				//--- check if database exists
				var DBExists = DBCheckBLL.CheckDatabaseExists(database, dbTran);

				if (!DBExists)
				{
					acesso.RollbackAcessoWithTransaction(dbTran);
					return new CommandResult(false, "Não foi possível conectar com o servidor de dados...");
				}

				//--- check table Usuario
				var UserExists = DBCheckBLL.CheckTableExists("tblUsuario", dbTran);

				if (!UserExists)
				{
					acesso.RollbackAcessoWithTransaction(dbTran);
					return new CommandResult(false, "Ainda não existe a tabela de usuários...");
				}

				//--- Commit and Return
				acesso.CommitAcessoWithTransaction(dbTran);
				return new CommandResult(true, "Conexão com o servidor OK...");
			}
			catch (Exception ex)
			{
				acesso.RollbackAcessoWithTransaction(dbTran);

				AbrirDialog("Uma exceção ocorreu ao Tentar Verificar o Acesso..." + "\n" +
							ex.Message, "Exceção", DialogType.OK, DialogIcon.Exclamation);

				return new CommandResult(false, "Erro ao tentar verificar o acesso..." +
					$"{ex.Message}");
			}
			finally
			{
				// --- Ampulheta OFF
				Cursor.Current = Cursors.Default;
			}
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
