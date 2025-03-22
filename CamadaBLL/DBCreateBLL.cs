using CamadaDAL;
using System;
using System.Data;

namespace CamadaBLL
{
	//=================================================================================================
	// CHECK DATABASE AND TABLE EXISTS - STATIC
	//=================================================================================================
	public static class DBCheckBLL
	{
		// CHECK IF DATABASE EXISTS
		//------------------------------------------------------------------------------------------------------------
		public static bool CheckDatabaseExists(string DatabaseName, object dbTran)
		{
			try
			{
				var db = (AcessoDados)dbTran;

				db.LimparParametros();
				string query = "SELECT * FROM sys.databases WHERE name = @DatabaseName";
				db.AdicionarParametros("@DatabaseName", DatabaseName);
				DataTable dt = db.ExecutarConsulta(CommandType.Text, query);

				if (dt.Rows.Count > 0)
				{
					return true;
				}
				else
				{
					return false;
				}
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		// CHECK IF TABLE EXISTS
		//------------------------------------------------------------------------------------------------------------
		public static bool CheckTableExists(string tableName, object dbTran)
		{
			try
			{
				var db = (AcessoDados)dbTran;

				db.LimparParametros();
				string query = "SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = @tableName";
				db.AdicionarParametros("@tableName", tableName);
				DataTable dt = db.ExecutarConsulta(CommandType.Text, query);
				
				if (dt.Rows.Count > 0)
				{
					return true;
				}
				else
				{
					return false;
				}
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
	}
}
