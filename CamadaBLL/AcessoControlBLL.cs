using System;
using System.Data;
using CamadaDAL;
using CamadaDTO;

namespace CamadaBLL
{
	public class AcessoControlBLL
	{
		public int TentativasAcesso { get; set; }

		public AcessoControlBLL()
		{
			TentativasAcesso = 0;
		}

		//=================================================================================================
		// GET NEW LOGIN ACESSO
		//=================================================================================================
		public objUsuario GetAuthorization(
			string UsuarioApelido,
			string UsuarioSenha,
			EnumAcessoTipo UsuarioAcesso = EnumAcessoTipo.Usuario_Local, // usuario_local = 4
			string AuthDescription = "Acesso Login"
			)
		{
			AcessoDados db = new AcessoDados();

			db.LimparParametros();
			db.AdicionarParametros("@UsuarioApelido", UsuarioApelido);
			db.AdicionarParametros("@UsuarioSenha", UsuarioSenha);
			db.AdicionarParametros("@UsuarioAcesso", UsuarioAcesso);
			db.AdicionarParametros("@AuthDescription", AuthDescription);
			db.AdicionarParametros("@AuthDate", DateTime.Now);

			try
			{
				DataTable dt = db.ExecutarConsulta(CommandType.StoredProcedure, "uspUserGetAuthorization");

				if (dt.Rows.Count == 0)
				{
					TentativasAcesso += 1;
					throw new AppException("Não há Usuários no sistema, comunique com o administrador...");
				}

				DataRow row = dt.Rows[0];

				if (row.ItemArray.Length == 1)
				{
					TentativasAcesso += 1;
					throw new AppException(dt.Rows[0].ItemArray[0].ToString());
				}

				objUsuario UsuarioAtual = new objUsuario((int)row["IDUsuario"])
				{
					UsuarioAcesso = (byte)row["UsuarioAcesso"],
					UsuarioApelido = (string)row["UsuarioApelido"]
				};

				return UsuarioAtual;
			}
			catch (AppException ex)
			{
				throw ex;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		//=================================================================================================
		// REGISTER USER LOGIN EXIT
		//=================================================================================================
		public void SaveUserExitProgram(string UsuarioApelido, string motivo)
		{
			AcessoDados db = new AcessoDados();

			db.LimparParametros();
			db.AdicionarParametros("@UsuarioApelido", UsuarioApelido);
			db.AdicionarParametros("@AuthDescription", motivo);
			db.AdicionarParametros("@AuthDate", DateTime.Now);

			try
			{
				db.ExecutarConsulta(CommandType.StoredProcedure, "uspUserExitRegister");
			}
			catch (AppException ex)
			{
				throw ex;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		//=================================================================================================
		// SAVE STRING CONNECTION
		//=================================================================================================
		public bool SaveConnString(string SourceXMLFile, string stringName)
		{
			try
			{
				GetConnection conn = new GetConnection();
				conn.SaveConnectionStringLocation(SourceXMLFile, stringName);
				return true;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		//=================================================================================================
		// GET STRING CONNECTION TO VISUALIZATION
		//=================================================================================================
		public string GetConnString()
		{
			try
			{
				return AcessoDados.GetConnectionString();
			}
			catch
			{
				return null;
			}
		}

		//=================================================================================================
		// GET ACESSO + TRANSACTION
		//=================================================================================================
		public object GetNewAcessoWithTransaction()
		{
			AcessoDados myDB = new AcessoDados();
			myDB.BeginTransaction();

			//return
			return myDB;
		}

		//=================================================================================================
		// COMMIT ACESSO + TRANSACTION
		//=================================================================================================
		public bool CommitAcessoWithTransaction(object myDB)
		{
			if (myDB.GetType() == typeof(AcessoDados))
			{
				AcessoDados DB = (AcessoDados)myDB;
				DB.CommitTransaction();

				// return
				return true;
			}
			else
			{
				return false;
			}
		}

		//=================================================================================================
		// ROLLBACK ACESSO + TRANSACTION 
		//=================================================================================================
		public bool RollbackAcessoWithTransaction(object myDB)
		{
			if (myDB.GetType() == typeof(AcessoDados))
			{
				AcessoDados DB = (AcessoDados)myDB;
				DB.RollBackTransaction();

				// return
				return true;
			}
			else
			{
				return false;
			}
		}

		//=================================================================================================
		// GET CONFIG DB - CONNECTION XML PATH
		//=================================================================================================
		public string GetConfigXMLPath()
		{
			try
			{
				return AcessoDados.GetConfigXMLPath();
			}
			catch
			{
				return null;
			}
		}

		//=================================================================================================
		// EXECUTE SQL STRING
		//=================================================================================================
		public bool ExecuteSQLString(string SQLQuery)
		{
			try
			{
				//--- check string
				//------------------------------------------------------------------------------------------------------------

				//--- IS NULL
				if (string.IsNullOrEmpty(SQLQuery))
				{
					throw new Exception("SQL Query Vazia...");
				}

				//--- remove ANY INJECTS
				SQLQuery = SQLQuery.Trim().Replace(";", "");

				if (SQLQuery.IndexOf("UPDATE") > 0 || SQLQuery.IndexOf("DELETE") > 0)
				{
					throw new Exception("Detectado injeção de SQL...");
				}

				//--- get TYPE of SQL
				string queryType = SQLQuery.Substring(0, 6).ToUpper();

				//--- IS SELECT
				if (queryType == "SELECT")
				{
					throw new Exception("SQL Query não pode ser um tipo SELECT...");
				}
				//--- IS UPDATE or DELETE without WHERE
				else if (queryType == "UPDATE" || queryType == "DELETE")
				{
					if (!SQLQuery.ToUpper().Contains("WHERE"))
					{
						throw new Exception("SQL Query UPDATE or INSERT sem cláusula WHERE...");
					}
				}
				else if (queryType != "INSERT")
				{
					throw new Exception("SQL Query não é INSERT, UPDATE ou DELETE ");
				}

				//--- execute
				new AcessoDados().ExecutarManipulacao(CommandType.Text, SQLQuery);

				return true;
			}
			catch
			{
				throw;
			}
		}

		//=================================================================================================
		// CHECK COMPATIBLE VERSION
		//=================================================================================================
		public bool CheckVersion(string version)
		{
			try
			{
				AcessoDados db = new AcessoDados();
				var query = "SELECT * from tblPropriedades";

				var dt = db.ExecutarConsulta(CommandType.Text, query);

				if (dt != null && dt.Rows.Count > 0)
				{
					string VersionAutorizated = (string)dt.Rows[0][1];

					var listVA = VersionAutorizated.Split('.');
					var actualVer = version.Split('.');

					if (actualVer.Length != 4)
					{
						throw new AppException("A Versão no aplicativo está com o formato incorreto.");
					}

					if (listVA.Length != 4)
					{
						throw new AppException("A Versão de propriedades do BD está com o formato incorreto.");
					}

					for (int i = 0; i <= 3; i++)
					{
						if (byte.TryParse(listVA[i], out byte aut))
						{
							if (byte.TryParse(actualVer[i], out byte actual))
							{
								if (aut > actual)
								{
									return false;
								}
								if (aut < actual)
								{
									return true;
								}
							}
							else
							{
								throw new AppException("A Versão no aplicativo está com o formato incorreto.");
							}
						}
						else
						{
							throw new AppException("A Versão de propriedades do BD está com o formato incorreto.");
						}
					}
				}
				else
				{
					throw new AppException("O arquivo de propriedades não foi atualizado no BD");
				}

				return true;
			}
			catch (AppException ex)
			{
				throw ex;
			}
			catch (Exception ex)
			{
				throw new Exception("Uma exceção ocorreu ao checar a Versão do Autorizada..." +
					"\n" + ex.Message);
			}
		}
	}
}