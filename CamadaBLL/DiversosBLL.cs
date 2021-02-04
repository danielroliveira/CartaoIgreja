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
					obj.EstadoCivilM = (string)row["EstadoCivilM"];
					obj.EstadoCivilF = (string)row["EstadoCivilF"];

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
