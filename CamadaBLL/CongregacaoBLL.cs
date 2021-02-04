using CamadaDAL;
using CamadaDTO;
using System;
using System.Collections.Generic;
using System.Data;

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
	}
}
