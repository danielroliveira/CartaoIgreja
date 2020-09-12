using CamadaDAL;
using CamadaDTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;

namespace CamadaBLL
{
	public class MembroBLL
	{
		string _DBPath;

		public MembroBLL(string DBPath)
		{
			_DBPath = DBPath;
		}

		// GET LIST OF
		//------------------------------------------------------------------------------------------------------------
		public List<objMembro> GetListMembro(string membro, byte? IDSituacao = null)
		{
			try
			{
				AcessoDados db = new AcessoDados(_DBPath);

				string query = "SELECT * FROM qryMembro";
				bool haveWhere = false;

				// add params
				db.LimparParametros();

				if (!string.IsNullOrEmpty(membro))
				{
					db.AdicionarParametros("@MembroNome", membro);
					query += " WHERE MembroNome LIKE '*'+@membro+'*' ";
					haveWhere = true;
				}

				if (IDSituacao != null)
				{
					db.AdicionarParametros("@IDSituacao", IDSituacao);
					if (haveWhere)
						query += " AND IDSituacao = @IDSituacao";
					else
						query += " WHERE IDSituacao = @IDSituacao";
				}

				query += " ORDER BY MembroNome";

				List<objMembro> listagem = new List<objMembro>();
				DataTable dt = db.ExecutarConsulta(CommandType.Text, query);

				if (dt.Rows.Count == 0)
				{
					return listagem;
				}

				foreach (DataRow row in dt.Rows)
				{
					listagem.Add(ConvertRowInClass(row));
				}

				return listagem;

			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		// GET MEMBRO
		//------------------------------------------------------------------------------------------------------------
		public objMembro GetMembro(int IDMembro)
		{
			try
			{
				AcessoDados db = new AcessoDados(_DBPath);

				string query = "SELECT * FROM qryMembro WHERE IDMembro = @IDMembro";
				db.LimparParametros();
				db.AdicionarParametros("@IDMembro", IDMembro);

				DataTable dt = db.ExecutarConsulta(CommandType.Text, query);

				return ConvertRowInClass(dt.Rows[0]);

			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		// CONVERT ROW IN CLASS
		//------------------------------------------------------------------------------------------------------------
		public objMembro ConvertRowInClass(DataRow row)
		{
			objMembro membro = new objMembro()
			{
				IDMembro = (byte?)row["IDMembro"],
				RGMembro = (byte?)row["RGMembro"],
				MembroNome = (string)row["MembroNome"],
				NascimentoData = row["NascimentoData"] == DBNull.Value ? null : (DateTime?)row["NascimentoData"],
				IDCongregacao = (byte)row["IDCongregacao"],
				Congregacao = (string)row["Congregacao"],
				Sexo = (byte)row["Sexo"],
				EmissaoData = row["EmissaoData"] == DBNull.Value ? null : (DateTime?)row["EmissaoData"],
				IDEstadoCivil = (byte)row["IDEstadoCivil"],
				EstadoCivil = (string)row["EstadoCivil"],
				IDFuncao = (byte)row["IDFuncao"],
				Funcao = (string)row["Funcao"],
				IDSituacao = (byte)row["IDSituacao"],
				Situacao = (string)row["Situacao"],
				MembresiaData = row["MembresiaData"] == DBNull.Value ? null : (DateTime?)row["MembresiaData"],
				ValidadeData = row["ValidadeData"] == DBNull.Value ? null : (DateTime?)row["ValidadeData"],
				Imprimir = (bool)row["Imprimir"],
				NaLista = (bool)row["NaLista"]
			};

			return membro;
		}

		// INSERT
		//------------------------------------------------------------------------------------------------------------
		public long InsertMembro(objMembro membro)
		{
			AcessoDados db = null;

			try
			{
				db = new AcessoDados(_DBPath);
				db.BeginTransaction();

				//--- check duplicated MEMBRO
				//------------------------------------------------------------------------------------------------------------
				db.LimparParametros();
				db.AdicionarParametros("@MembroNome", membro.MembroNome.ToLower());
				db.ConvertNullParams();

				//--- create and execute query
				string query = "SELECT * FROM tblMembro WHERE LCase(MembroNome) = @MembroNome";
				DataTable dt = db.ExecutarConsulta(CommandType.Text, query);

				if (dt.Rows.Count > 0)
				{
					throw new AppException("Já existe um Membro cadastrado que possui o mesmo nome...");
				}

				//--- check duplicated RG
				//------------------------------------------------------------------------------------------------------------
				db.LimparParametros();
				db.AdicionarParametros("@RGMembro", membro.RGMembro);
				db.ConvertNullParams();

				//--- create and execute query
				query = "SELECT * FROM tblMembro WHERE RGMembro = @RGMembro";
				dt = db.ExecutarConsulta(CommandType.Text, query);

				if (dt.Rows.Count > 0)
				{
					throw new AppException("Já existe um Membro cadastrado que possui o mesmo Número de Registro...");
				}

				// INSERT Membro
				//------------------------------------------------------------------------------------------------------------
				db.LimparParametros();

				//--- define Params
				db.AdicionarParametros("@RGMembro", membro.RGMembro);
				db.AdicionarParametros("@Membro", membro.MembroNome);
				db.AdicionarParametros("@NascimentoData", membro.NascimentoData);
				db.AdicionarParametros("@IDFuncao", membro.IDFuncao);
				db.AdicionarParametros("@Sexo", membro.Sexo);
				db.AdicionarParametros("@EmissaoData", membro.EmissaoData);
				db.AdicionarParametros("@MembresiaData", membro.MembresiaData);
				db.AdicionarParametros("@ValidadeData", membro.ValidadeData);
				db.AdicionarParametros("@IDEstadoCivil", membro.IDEstadoCivil);
				db.AdicionarParametros("@IDCongregacao", membro.IDCongregacao);
				db.AdicionarParametros("@IDSituacao", membro.IDSituacao);
				db.AdicionarParametros("@Imprimir", membro.Imprimir);
				db.AdicionarParametros("@Situacao", membro.Situacao);

				//--- convert null parameters
				db.ConvertNullParams();

				//--- create query
				query = db.CreateInsertSQL("tblMembro");

				//--- insert
				long newID = db.ExecutarInsertAndGetID(query);

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
		public bool UpdateMembro(objMembro membro)
		{
			AcessoDados db = null;

			try
			{
				db = new AcessoDados(_DBPath);
				db.BeginTransaction();

				//--- check duplicated MEMBRO
				//------------------------------------------------------------------------------------------------------------
				db.LimparParametros();
				db.AdicionarParametros("@MembroNome", membro.MembroNome);
				db.AdicionarParametros("@IDMembro", membro.IDMembro);
				db.ConvertNullParams();

				//--- create and execute query
				string query = "SELECT * FROM tblMembro WHERE Membro = @Membro AND IDMembro <> @IDMembro";
				DataTable dt = db.ExecutarConsulta(CommandType.Text, query);

				if (dt.Rows.Count > 0)
				{
					throw new AppException("Já existe um Membro cadastrado que possui o mesmo nome...");
				}

				//--- check duplicated RG
				//------------------------------------------------------------------------------------------------------------
				db.LimparParametros();
				db.AdicionarParametros("@RGMembro", membro.RGMembro);
				db.AdicionarParametros("@IDMembro", membro.IDMembro);
				db.ConvertNullParams();

				//--- create and execute query
				query = "SELECT * FROM tblMembro WHERE RGMembro = @RGMembro AND IDMembro <> @IDMembro";
				dt = db.ExecutarConsulta(CommandType.Text, query);

				if (dt.Rows.Count > 0)
				{
					throw new AppException("Já existe um Membro cadastrado que possui o mesmo Número de Registro...");
				}

				//--- UPDATE
				//------------------------------------------------------------------------------------------------------------//--- clear Params
				db.LimparParametros();

				//--- define Params
				db.AdicionarParametros("@IDMembro", membro.IDMembro);
				db.AdicionarParametros("@RGMembro", membro.RGMembro);
				db.AdicionarParametros("@Membro", membro.MembroNome);
				db.AdicionarParametros("@NascimentoData", membro.NascimentoData);
				db.AdicionarParametros("@IDFuncao", membro.IDFuncao);
				db.AdicionarParametros("@Sexo", membro.Sexo);
				db.AdicionarParametros("@EmissaoData", membro.EmissaoData);
				db.AdicionarParametros("@MembresiaData", membro.MembresiaData);
				db.AdicionarParametros("@ValidadeData", membro.ValidadeData);
				db.AdicionarParametros("@IDEstadoCivil", membro.IDEstadoCivil);
				db.AdicionarParametros("@IDCongregacao", membro.IDCongregacao);
				db.AdicionarParametros("@IDSituacao", membro.IDSituacao);
				db.AdicionarParametros("@Imprimir", membro.Imprimir);
				db.AdicionarParametros("@Situacao", membro.Situacao);

				//--- convert null parameters
				db.ConvertNullParams();

				//--- create query
				query = db.CreateUpdateSQL("tblMembro", "@IDMembro");

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
