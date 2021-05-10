using CamadaDAL;
using CamadaDTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;

namespace CamadaBLL
{
	public class CongregacaoBLL
	{
		private string _DBPath;

		public CongregacaoBLL(string DBPath)
		{
			_DBPath = DBPath;
		}

		// GET LIST OF CONGREGACAO
		//------------------------------------------------------------------------------------------------------------
		public List<objCongregacao> GetListCongregacao()
		{
			try
			{
				AcessoDados db = new AcessoDados(_DBPath);

				string query = "SELECT * FROM tblCongregacao";

				// add params
				db.LimparParametros();

				query += " ORDER BY Congregacao";

				List<objCongregacao> listagem = new List<objCongregacao>();
				DataTable dt = db.ExecutarConsulta(CommandType.Text, query);

				if (dt.Rows.Count == 0)
				{
					return listagem;
				}

				foreach (DataRow row in dt.Rows)
				{
					objCongregacao obj = new objCongregacao();

					obj.IDCongregacao = (byte)row["IDCongregacao"];
					obj.Congregacao = (string)row["Congregacao"];
					obj.Ativo = (bool)row["Ativo"];

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
		public byte InsertCongregacao(objCongregacao cong)
		{
			AcessoDados db = null;

			try
			{
				db = new AcessoDados(_DBPath);
				db.BeginTransaction();

				//--- check duplicated cong
				//------------------------------------------------------------------------------------------------------------
				db.LimparParametros();
				db.AdicionarParametros("@Congregacao", cong.Congregacao.ToLower());
				db.ConvertNullParams();

				//--- create and execute query
				string query = "SELECT * FROM tblCongregacao WHERE LCase(Congregacao) = @Congregacao";
				DataTable dt = db.ExecutarConsulta(CommandType.Text, query);

				if (dt.Rows.Count > 0)
				{
					throw new AppException("Já existe um cong cadastrado que possui o mesmo nome...");
				}

				// INSERT CONGREGACAO
				//------------------------------------------------------------------------------------------------------------
				db.LimparParametros();

				//--- define Params
				db.AdicionarParametros("@Congregacao", cong.Congregacao);
				db.AdicionarParametros("@Ativo", cong.Ativo);
				db.AdicionarParametros("@IDCongregacao", cong.IDCongregacao);

				//--- convert null parameters
				db.ConvertNullParams();

				//--- create query
				query = db.CreateInsertSQL("tblCongregacao");

				//--- insert
				byte newID = (byte)db.ExecutarInsertAndGetID(query);

				//--- COMMIT and RETURN
				db.CommitTransaction();
				return newID;

			}
			catch (OleDbException ex)
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
		public bool UpdateCongregacao(objCongregacao cong)
		{
			AcessoDados db = null;

			try
			{
				db = new AcessoDados(_DBPath);
				db.BeginTransaction();

				//--- check duplicated MEMBRO
				//------------------------------------------------------------------------------------------------------------
				db.LimparParametros();
				db.AdicionarParametros("@Congregacao", cong.Congregacao);
				db.AdicionarParametros("@IDCongregacao", cong.IDCongregacao);
				db.ConvertNullParams();

				//--- create and execute query
				string query = "SELECT * FROM tblCongregacao WHERE Congregacao = @Congregacao AND IDCongregacao <> @IDCongregacao";
				DataTable dt = db.ExecutarConsulta(CommandType.Text, query);

				if (dt.Rows.Count > 0)
				{
					throw new AppException("Já existe uma Congregação cadastrada que possui o mesmo nome...");
				}

				//--- UPDATE
				//------------------------------------------------------------------------------------------------------------//--- clear Params
				db.LimparParametros();

				//--- define Params
				db.AdicionarParametros("@Congregacao", cong.Congregacao);
				db.AdicionarParametros("@Ativo", cong.Ativo);
				db.AdicionarParametros("@IDCongregacao", cong.IDCongregacao);

				//--- convert null parameters
				db.ConvertNullParams();

				//--- create query
				query = db.CreateUpdateSQL("tblCongregacao", "@IDCongregacao");

				//--- update
				db.ExecutarManipulacao(CommandType.Text, query);

				db.CommitTransaction();
				return true;

			}
			catch (OleDbException ex)
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
