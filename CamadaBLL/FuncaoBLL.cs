using CamadaDAL;
using CamadaDTO;
using System;
using System.Collections.Generic;
using System.Data;

namespace CamadaBLL
{
	public class FuncaoBLL
	{
		private string _DBPath;

		public FuncaoBLL(string DBPath)
		{
			_DBPath = DBPath;
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

	}
}
