using CamadaDAL;
using CamadaDTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace CamadaBLL
{
	public class FuncaoBLL
	{
		// GET LIST OF FUNCAO
		//------------------------------------------------------------------------------------------------------------
		public List<objFuncao> GetListFuncao()
		{
			try
			{
				AcessoDados db = new AcessoDados();

				string query = "SELECT * FROM tblFuncao";

				// add params
				db.LimparParametros();

				query += " ORDER BY Posicao";

				List<objFuncao> listagem = new List<objFuncao>();
				DataTable dt = db.ExecutarConsulta(CommandType.Text, query);

				if (dt.Rows.Count == 0)
				{
					return listagem;
				}

				foreach (DataRow row in dt.Rows)
				{
					objFuncao obj = new objFuncao();

					obj.IDFuncao = (byte)row["IDFuncao"];
					obj.Funcao = (string)row["Funcao"];
					obj.ImagemCartaoFrente = row["ImagemCartaoFrente"] == DBNull.Value ? string.Empty : (string)row["ImagemCartaoFrente"];
					obj.ImagemCartaoVerso = row["ImagemCartaoVerso"] == DBNull.Value ? string.Empty : (string)row["ImagemCartaoVerso"];
					obj.Ativo = (bool)row["Ativo"];
					obj.Posicao = (byte)row["Posicao"];

					listagem.Add(obj);
				}

				return listagem;

			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		// INSERT
		//------------------------------------------------------------------------------------------------------------
		public byte InsertFuncao(objFuncao func)
		{
			AcessoDados db = null;

			try
			{
				db = new AcessoDados();
				db.BeginTransaction();

				//--- check duplicated Funcao
				//------------------------------------------------------------------------------------------------------------
				db.LimparParametros();
				db.AdicionarParametros("@Funcao", func.Funcao.ToLower());
				db.ConvertNullParams();

				//--- create and execute query
				string query = "SELECT * FROM tblFuncao WHERE LCase(Funcao) = @Funcao";
				DataTable dt = db.ExecutarConsulta(CommandType.Text, query);

				if (dt.Rows.Count > 0)
				{
					throw new AppException("Já existe uma Funcao cadastrada que possui o mesmo nome...");
				}

				// GET POSITION FROM COUNT TO 
				//------------------------------------------------------------------------------------------------------------
				db.LimparParametros();

				//--- Create NewID = MaxID + 1
				int newPosition = 0;

				//--- create and execute query
				query = "SELECT COUNT(*) AS Total FROM tblFuncao";
				dt = db.ExecutarConsulta(CommandType.Text, query);

				if (dt.Rows.Count == 0)
				{
					throw new AppException("Houve uma exceção ao obter o número de registros...");
				}
				else
				{
					newPosition = (int)dt.Rows[0][0];
					newPosition += 1;
				}

				//--- GET LAST/MAX ID FUNCAO
				//------------------------------------------------------------------------------------------------------------
				db.LimparParametros();
				db.AdicionarParametros("@IDFuncao", func.IDFuncao);
				db.ConvertNullParams();

				//--- Create NewID = MaxID + 1
				int newID = 0;

				//--- create and execute query
				query = "SELECT MAX(IDFuncao) AS ID FROM tblFuncao";
				dt = db.ExecutarConsulta(CommandType.Text, query);

				if (dt.Rows.Count == 0)
				{
					newID = 1;
				}
				else
				{
					newID = (int)dt.Rows[0][0];
					newID += 1;
				}

				// INSERT NEW FUNCAO
				//------------------------------------------------------------------------------------------------------------
				db.LimparParametros();

				//--- define Params
				db.AdicionarParametros("@IDFuncao", newID);
				db.AdicionarParametros("@Funcao", func.Funcao);
				db.AdicionarParametros("@Ativo", true);
				db.AdicionarParametros("@Posicao", newPosition);

				//--- convert null parameters
				db.ConvertNullParams();

				//--- create query
				query = db.CreateInsertSQL("tblFuncao");

				//--- insert
				db.ExecutarManipulacao(CommandType.Text, query);

				//--- COMMIT and RETURN
				db.CommitTransaction();
				return (byte)newID;

			}
			catch (SqlException ex)
			{
				//--- ROLLBACK
				db.RollBackTransaction();
				throw new AppException(ex.Message);
			}
			catch (Exception ex)
			{
				//--- ROLLBACK
				db.RollBackTransaction();
				throw ex;
			}
		}

		// UPDATE
		//------------------------------------------------------------------------------------------------------------
		public bool UpdateFuncao(objFuncao func)
		{
			AcessoDados db = null;

			try
			{
				db = new AcessoDados();
				db.BeginTransaction();

				//--- check duplicated MEMBRO
				//------------------------------------------------------------------------------------------------------------
				db.LimparParametros();
				db.AdicionarParametros("@Funcao", func.Funcao);
				db.AdicionarParametros("@IDFuncao", func.IDFuncao);
				db.ConvertNullParams();

				//--- create and execute query
				string query = "SELECT * FROM tblFuncao WHERE Funcao = @Funcao AND IDFuncao <> @IDFuncao";
				DataTable dt = db.ExecutarConsulta(CommandType.Text, query);

				if (dt.Rows.Count > 0)
				{
					throw new AppException("Já existe uma Função cadastrada que possui o mesmo nome...");
				}

				//--- UPDATE
				//------------------------------------------------------------------------------------------------------------//--- clear Params
				db.LimparParametros();

				//--- define Params
				db.AdicionarParametros("@Funcao", func.Funcao);
				db.AdicionarParametros("@Ativo", func.Ativo);
				db.AdicionarParametros("@Posicao", func.Posicao);
				db.AdicionarParametros("@IDFuncao", func.IDFuncao);

				//--- convert null parameters
				db.ConvertNullParams();

				//--- create query
				query = db.CreateUpdateSQL("tblFuncao", "@IDFuncao");

				//--- update
				db.ExecutarManipulacao(CommandType.Text, query);

				db.CommitTransaction();
				return true;

			}
			catch (SqlException ex)
			{
				//--- ROLLBACK
				db.RollBackTransaction();
				throw new AppException(ex.Message);

			}
			catch (Exception ex)
			{
				//--- ROLLBACK
				db.RollBackTransaction();
				throw ex;
			}
		}

		// DELETE
		//------------------------------------------------------------------------------------------------------------
		public bool DeleteFuncao(objFuncao func)
		{
			AcessoDados db = null;

			try
			{
				db = new AcessoDados();
				db.BeginTransaction();

				//--- check IF used FUNCAO
				//------------------------------------------------------------------------------------------------------------
				db.LimparParametros();
				db.AdicionarParametros("@IDFuncao", func.IDFuncao);
				db.ConvertNullParams();

				//--- create and execute query
				string query = "SELECT Count(*) AS Total FROM tblMembro WHERE IDFuncao = @IDFuncao";
				DataTable dt = db.ExecutarConsulta(CommandType.Text, query);

				if (dt.Rows.Count == 0)
				{
					throw new AppException("Houve uma exceção ao acessar o Banco de Dados...");
				}
				else
				{
					int Total = (int)dt.Rows[0][0];

					if (Total > 0)
					{
						throw new AppException("Existem registros associados a essa função...\n" +
							"Favor alterar os registros associados para outra função antes de excluir.");
					}
				}

				//--- DELETE
				//------------------------------------------------------------------------------------------------------------//--- clear Params
				db.LimparParametros();

				//--- define Params
				db.AdicionarParametros("@IDFuncao", func.IDFuncao);

				//--- convert null parameters
				db.ConvertNullParams();

				//--- create query
				query = "DELETE * FROM tblFuncao WHERE IDFuncao = @IDFuncao";

				//--- update
				db.ExecutarManipulacao(CommandType.Text, query);

				db.CommitTransaction();

				// UPDATE POSICAO
				//------------------------------------------------------------------------------------------------------------
				List<objFuncao> list = GetListFuncao();
				byte i = 1;

				foreach (var funcao in list)
				{
					if (funcao.Posicao != i)
					{
						funcao.Posicao = i;
						UpdateFuncao(funcao);
					}

					i += 1;
				}

				return true;

			}
			catch (SqlException ex)
			{
				//--- ROLLBACK
				db.RollBackTransaction();
				throw new AppException(ex.Message);

			}
			catch (Exception ex)
			{
				//--- ROLLBACK
				db.RollBackTransaction();
				throw ex;
			}
		}
	}
}
