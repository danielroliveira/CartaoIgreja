using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;

namespace CamadaDAL
{
    public class AcessoDados
    {
        // -------------------------------------------------------------------------------------------------------
        // DECLARAÇÃO DAS VARIÁVEIS
        // -------------------------------------------------------------------------------------------------------
        private OleDbConnection conn;
        private OleDbCommand cmd;
        private OleDbTransaction trans;
        private readonly List<OleDbParameter> ParamList = new List<OleDbParameter>();
		private string _dataBasePath;

		// NEW CONSTRUCTOR
		public AcessoDados(string dataBasePath)
        {
			_dataBasePath = dataBasePath; // backup DATABASE path

			if (!Connect(dataBasePath))
            {
                return;
            }
        }
        
        // OPEN CONNECTION
        private bool Connect(string dataBasePath)
        {
            //string connstr = "Provider=Microsoft.ACE.OLEDB.12.0; Data Source=" + dataBasePath;
            string connstr = "Provider=Microsoft.Jet.OleDb.4.0; Data Source=" + dataBasePath;
            bool bln = false;
            
            if (conn == null) {
                try
                {
                    //connstr = GetConnectionString();
                    if (connstr != string.Empty)
                    {
                        conn = new OleDbConnection(connstr);
                        bln = true;
                    }
                    else
                    {
                        bln = false;
                    }
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
            
            if (conn.State == ConnectionState.Closed)
            {
                try
                {
                    conn.Open();
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }

            return bln;

        }

        // CLOSE CONNECTION
        public void CloseConn()
        {
            if (conn.State != ConnectionState.Closed)
            {
                conn.Close();
            }
        }

        // CLEAR PARAMETERS
        public void LimparParametros()
        {
            ParamList.Clear();
        }
        
        // ADD PARAMETERS
        public void AdicionarParametros(string nomeParametro, object valorParametro)
        {
            ParamList.Add(new OleDbParameter(nomeParametro, valorParametro));
        }

        // TRANSFORM NULL PARAMETERS
        public void ConvertNullParams()
        {
            foreach (OleDbParameter parameter in ParamList)
            {
                if (parameter.Value == null)
                {
                    parameter.Value = DBNull.Value;
                }
                else if (parameter.Value is string && (string)parameter.Value == "")
                {
                    parameter.Value = DBNull.Value;
                }
            }

        }

        // ==============================================================================
        #region DATABASE CRUD COMMANDS

        // EXECUTAR MANIPULACAO
        public void ExecutarManipulacao(CommandType commandType, string nomeStoredProcedureOuTextoSQL)
        {
            try
            {
				if (conn.State == ConnectionState.Closed)
				{
					// try connect
					Connect(_dataBasePath);
					// Check Again
					if (conn.State == ConnectionState.Closed)
						throw new Exception("Sem conexão ao Database...");
				}

				cmd = new OleDbConnection().CreateCommand();
                cmd.Connection = conn;
                cmd.CommandType = commandType;
                cmd.CommandText = nomeStoredProcedureOuTextoSQL;
                cmd.CommandTimeout = 7200;

                ParamList.ForEach(p => cmd.Parameters.Add(p));

                if (!isTran)
                {
                    cmd.ExecuteScalar();
                    CloseConn();
                }
                else
                {
                    cmd.Transaction = trans;
                    cmd.ExecuteScalar();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataTable ExecutarConsulta(CommandType commandType, string nomeStoredProcedureOuTextoSQL)
        {
            try
            {
                if (conn.State == ConnectionState.Closed)
                {
					// try connect
					Connect(_dataBasePath);
					// Check Again
					if (conn.State == ConnectionState.Closed)
						throw new Exception("Sem conexão ao Database...");
				}

				cmd = new OleDbConnection().CreateCommand();
                cmd.Connection = conn;
                cmd.CommandType = commandType;
                cmd.CommandText = nomeStoredProcedureOuTextoSQL;
                cmd.CommandTimeout = 7200;

                if (isTran) cmd.Transaction = trans;

                ParamList.ForEach(p => cmd.Parameters.Add(p));

                OleDbDataAdapter da = new OleDbDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                if (!isTran) CloseConn();

                return dt;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        // EXECUTAR INSERT AND RETURN NEW ID
        //------------------------------------------------------------------------------------------------------------
        public long ExecutarInsertAndGetID(string query)
        {
            try
            {
                if (conn.State == ConnectionState.Closed)
                {
                    // try connect
                    Connect(_dataBasePath);
                    // Check Again
                    if (conn.State == ConnectionState.Closed)
                        throw new Exception("Sem conexão ao Database...");
                }

                cmd = new OleDbConnection().CreateCommand();
                cmd.Connection = conn;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = query;
                cmd.CommandTimeout = 7200;

                ParamList.ForEach(p => cmd.Parameters.Add(p));

                if (!isTran)
                {
                    //--- EXECUTE
                    cmd.ExecuteScalar();

                    //--- GET NEW ID
                    long? obj = GetNewID();

                    //--- CLOSE DB CONNECTION
                    CloseConn();

                    if (obj == null)
                    {
                        throw new Exception("Não foi retornado novo ID...");
                    }

                    //--- RETURN
                    return (long)obj;
                }
                else
                {
                    //--- ADD TRANSACTION TO COMMAND
                    cmd.Transaction = trans;

                    //--- EXECUTE
                    cmd.ExecuteScalar();

                    //--- GET NEW ID
                    long? obj = GetNewID();

                    if (obj == null)
                    {
                        throw new Exception("Não foi retornado novo ID...");
                    }

                    //--- RETURN
                    return (long)obj;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        // GET NEW ID OF INSERT
        //------------------------------------------------------------------------------------------------------------
        private long? GetNewID()
        {
            //--- obter NewID
            LimparParametros();
            string myQuery = "SELECT @@IDENTITY As LastID";
            DataTable dt = ExecutarConsulta(CommandType.Text, myQuery);

            if (dt.Rows.Count == 0)
            {
                return null;
            }

            object newID = dt.Rows[0][0];

            if (long.TryParse(newID.ToString(), out long j))
            {
                return j;
            }
            else
            {
                throw new Exception(newID.ToString());
            }

        }

        #endregion

        // ==============================================================================
        #region TRANSACTION

        // BEGIN TRANSACTION
        public void BeginTransaction()
        {
            if (isTran) return;

            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }

            trans = conn.BeginTransaction();
            isTran = true;

        }

        // COMMIT TRANSACTION
        public void CommitTransaction()
        {
            if (!isTran) return;
            trans.Commit();
            conn.Close();
            trans = null;
            isTran = false;
        }

        // ROOLBACK TRANSACTION
        public void RollBackTransaction()
        {
            if (!isTran) return;
            trans.Rollback();
            conn.Close();
            trans = null;
            isTran = false;
        }

        // PROPERTY ISTRAN
        public bool isTran { get; set; }

        #endregion

        // ==============================================================================
        #region RETURN STRINGS INSERT | UPDATE

        // CREATE INSERT STRING SQL
        //------------------------------------------------------------------------------------------------------------
        public string CreateInsertSQL(string tableName)
        {
            string sql = $"INSERT INTO {tableName} (";
            string filds = "";
            string pars = "";

            // add fields and params
            foreach (var param in ParamList)
            {
                filds += param.ParameterName.Replace("@", "") + ", ";
                pars += param.ParameterName + ", ";
            }

            // create SQL string
            sql += filds.Remove(filds.Length - 2, 2) + ") VALUES (" + pars.Remove(pars.Length - 2, 2) + ")";

            // return
            return sql;
        }

        // CREATE UPDATE STRING SQL
        //------------------------------------------------------------------------------------------------------------
        public string CreateUpdateSQL(string tableName, string IDParamName)
        {
            string sql = $"UPDATE {tableName} SET ";
            string filds = "";

            // add fields and params
            foreach (var param in ParamList)
            {
                if (param.ParameterName.Replace("@", "") != IDParamName.Replace("@", ""))
                {
                    filds += $"{param.ParameterName.Replace("@", "")} = {param.ParameterName}, ";
                }
            }

            // create SQL string
            IDParamName = IDParamName.Replace("@", "");
            sql += $"{filds.Remove(filds.Length - 2, 2)} WHERE {IDParamName} = @{IDParamName}";

            // return
            return sql;
        }

        #endregion // RETURN STRINGS INSERT | UPDATE --- END

    }
}
