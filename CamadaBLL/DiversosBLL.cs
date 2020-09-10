using CamadaDAL;
using CamadaDTO;
using System;
using System.Collections.Generic;
using System.Data;

namespace CamadaBLL
{
	public class DiversosBLL
	{
		private string _DBPath;

		public DiversosBLL(string DBPath)
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

					listagem.Add(obj);
				}

				return listagem;

			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		// GET LIST OF FUNCAO
		//------------------------------------------------------------------------------------------------------------
		public List<objFuncao> GetListFuncao()
		{
			try
			{
				AcessoDados db = new AcessoDados(_DBPath);

				string query = "SELECT * FROM tblFuncao";

				// add params
				db.LimparParametros();

				query += " ORDER BY IDFuncao";

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

					listagem.Add(obj);
				}

				return listagem;

			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		// GET LIST OF ESTADO CIVIL
		//------------------------------------------------------------------------------------------------------------
		public List<objEstadoCivil> GetListEstadoCivil()
		{
			try
			{
				AcessoDados db = new AcessoDados(_DBPath);

				string query = "SELECT * FROM tblEstadoCivil";

				// add params
				db.LimparParametros();

				query += " ORDER BY IDEstadoCivil";

				List<objEstadoCivil> listagem = new List<objEstadoCivil>();
				DataTable dt = db.ExecutarConsulta(CommandType.Text, query);

				if (dt.Rows.Count == 0)
				{
					return listagem;
				}

				foreach (DataRow row in dt.Rows)
				{
					objEstadoCivil obj = new objEstadoCivil();

					obj.IDEstadoCivil = (byte)row["IDEstadoCivil"];
					obj.EstadoCivil = (string)row["EstadoCivil"];

					listagem.Add(obj);
				}

				return listagem;

			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		// GET LIST OF SITUACAO
		//------------------------------------------------------------------------------------------------------------
		public List<objSituacao> GetListSituacao()
		{
			try
			{
				AcessoDados db = new AcessoDados(_DBPath);

				string query = "SELECT * FROM tblSituacao";

				// add params
				db.LimparParametros();

				query += " ORDER BY IDSituacao";

				List<objSituacao> listagem = new List<objSituacao>();
				DataTable dt = db.ExecutarConsulta(CommandType.Text, query);

				if (dt.Rows.Count == 0)
				{
					return listagem;
				}

				foreach (DataRow row in dt.Rows)
				{
					objSituacao obj = new objSituacao();

					obj.IDSituacao = (byte)row["IDSituacao"];
					obj.Situacao = (string)row["Situacao"];

					listagem.Add(obj);
				}

				return listagem;

			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
	}

}
