using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
using System.Data.SqlClient;
using System.Collections;
using System.Data;

namespace sqlconn
{
    public class sqlconn
    {
        private static void AttachParameters(SqlCommand command, SqlParameter[] commandParameters)
        {
            foreach (SqlParameter p in commandParameters)
            {
                //check for derived output value with no value assigned
                if ((p.Direction == ParameterDirection.InputOutput) && (p.Value == null))
                {
                    p.Value = DBNull.Value;
                }

                command.Parameters.Add(p);
            }
        }
        private static void AssignParameterValues(SqlParameter[] commandParameters, object[] parameterValues)
        {
            if ((commandParameters == null) || (parameterValues == null))
            {
                //do nothing if we get no data
                return;
            }

            // we must have the same number of values as we pave parameters to put them in
            if (commandParameters.Length != parameterValues.Length)
            {
                throw new ArgumentException("Parameter count does not match Parameter Value count.");
            }

            //iterate through the SqlParameters, assigning the values from the corresponding position in the 
            //value array
            for (int i = 0, j = commandParameters.Length; i < j; i++)
            {
                commandParameters[i].Value = parameterValues[i];
            }
        }
        private static void PrepareCommand(SqlCommand command, SqlConnection connection, SqlTransaction transaction, CommandType commandType, string commandText, SqlParameter[] commandParameters)
        {
            //if the provided connection is not open, we will open it
            if (connection.State != ConnectionState.Open)
            {
                connection.Open();
            }

            //associate the connection with the command
            command.Connection = connection;
            command.CommandTimeout = 50;

            //set the command text (stored procedure name or SQL statement)
            command.CommandText = commandText;

            //if we were provided a transaction, assign it.
            if (transaction != null)
            {
                command.Transaction = transaction;
            }

            //set the command type
            command.CommandType = commandType;

            //attach the command parameters if they are provided
            if (commandParameters != null)
            {
                AttachParameters(command, commandParameters);
            }

            return;
        }
        public static int ExecuteNonQuery(string commandtext)
        {

            string connectionString = ConfigurationSettings.AppSettings["ConnectionString"];

            //create & open a SqlConnection, and dispose of it after we are done.
            using (SqlConnection cn = new SqlConnection(connectionString))
            {
                cn.Open();

                SqlCommand sCmd = new SqlCommand();
                sCmd.CommandText = commandtext;
                sCmd.Connection = cn;
                sCmd.ExecuteNonQuery();

                //call the overload that takes a connection in place of the connection string
                //return ExecuteNonQuery(cn, commandtype, commandtext, commandParameters);
            }
            return 0;
        }
        public static int ExecuteNonQuery(string connectionString, string commandtext)
        {

            //string connectionString = ConfigurationSettings.AppSettings["ConnectionString"];

            //create & open a SqlConnection, and dispose of it after we are done.
            using (SqlConnection cn = new SqlConnection(connectionString))
            {
                cn.Open();

                SqlCommand sCmd = new SqlCommand();
                sCmd.CommandText = commandtext;
                sCmd.Connection = cn;
                sCmd.ExecuteNonQuery();

                //call the overload that takes a connection in place of the connection string
                //return ExecuteNonQuery(cn, commandtype, commandtext, commandParameters);
            }
            return 0;
        }
        public static int ExecuteNonQuery(string connectionString, CommandType commandtype, string commandtext, params SqlParameter[] commandParameters)
        {
            //create & open a SqlConnection, and dispose of it after we are done.
            using (SqlConnection cn = new SqlConnection(connectionString))
            {
                cn.Open();

                //call the overload that takes a connection in place of the connection string
                return ExecuteNonQuery(cn, commandtype, commandtext, commandParameters);
            }
        }

        public static int ExecuteNonQuery(string connectionString, string spName, params object[] parameterValues)
        {
            if ((parameterValues != null) && (parameterValues.Length > 0))
            {
                //pull the parameters for this stored procedure from the parameter cache (or discover them & populate the cache)
                SqlParameter[] commandParameters = SqlHelperParameterCache.GetSpParameterSet(connectionString, spName);

                //assign the provided values to these parameters based on parameter order
                AssignParameterValues(commandParameters, parameterValues);

                //call the overload that takes an array of SqlParameters
                return ExecuteNonQuery(connectionString, CommandType.StoredProcedure, spName, commandParameters);
            }
            //otherwise we can just call the SP without params
            else
            {
                return ExecuteNonQuery(connectionString, CommandType.StoredProcedure, spName);
            }
        }
        public static int ExecuteNonQuery(SqlConnection connection, CommandType commandType, string commandText, params SqlParameter[] commandParameters)
        {
            //create a command and prepare it for execution
            SqlCommand cmd = new SqlCommand();
            PrepareCommand(cmd, connection, (SqlTransaction)null, commandType, commandText, commandParameters);

            //finally, execute the command.
            int retval = cmd.ExecuteNonQuery();

            // detach the SqlParameters from the command object, so they can be used again.
            cmd.Parameters.Clear();
            return retval;
        }

        public static string checkUsers(string connectionString, string strSql, string strUserID, string strPwd)
        {
            using (SqlConnection cn = new SqlConnection(connectionString))
            {
                cn.Open();
            }
            return "true";
        }

        public static DataTable getTable(string strSql)
        {
            DataSet ds = ExecuteDataset(ConfigurationSettings.AppSettings["ConnectionString"], strSql);

            if (ds == null)
            {
                return new DataTable();
            }
            else
            {
                return ds.Tables[0];
            }

        }
        public static bool Exists(string strsql)
        {
            DataTable dt = getTable(strsql);
            if (dt.Rows.Count == 0)
            {
                return false;
            }
            else
            {
                return true;
            }

        }
        public static DataTable getTable1(string connectionString, string strSql)
        {
            //			using (SqlConnection cn = new SqlConnection(connectionString))
            //			{
            //				cn.Open();
            //				//call the overload that takes a connection in place of the connection string
            //				
            //			}

            DataSet ds = ExecuteDataset(connectionString, strSql);
            if (ds == null)
            {
                return new DataTable();
            }
            else
            {
                return ds.Tables[0];
            }

        }
        public static DataTable getTableProc(string spName, params object[] parameterValues)
        {
            DataSet ds = ExecuteDataset(ConfigurationSettings.AppSettings["ConnectionString"], spName, parameterValues);

            if (ds == null)
            {
                return new DataTable();
            }
            else
            {
                if (ds.Tables.Count == 0)
                {
                    return new DataTable();
                }
                return ds.Tables[0];
            }
        }

        public static DataSet ExecuteDataset(string connectionString, CommandType commandType, string commandText, params SqlParameter[] commandParameters)
        {
            //create & open a SqlConnection, and dispose of it after we are done.
            using (SqlConnection cn = new SqlConnection(connectionString))
            {
                cn.Open();
                //call the overload that takes a connection in place of the connection string
                return ExecuteDataset(cn, commandType, commandText, commandParameters);
            }
        }
        public static DataSet ExecuteDataset(string connectionString, string spName, params object[] parameterValues)
        {
            //if we receive parameter values, we need to figure out where they go
            if ((parameterValues != null) && (parameterValues.Length > 0))
            {
                //pull the parameters for this stored procedure from the parameter cache (or discover them & populate the cache)
                SqlParameter[] commandParameters = SqlHelperParameterCache.GetSpParameterSet(connectionString, spName);

                //assign the provided values to these parameters based on parameter order
                AssignParameterValues(commandParameters, parameterValues);

                //call the overload that takes an array of SqlParameters
                return ExecuteDataset(connectionString, CommandType.StoredProcedure, spName, commandParameters);
            }
            //otherwise we can just call the SP without params
            else
            {
                return ExecuteDataset(connectionString, CommandType.Text, spName);
            }
        }
        public static DataSet ExecuteDataset(SqlConnection connection, CommandType commandType, string commandText, params SqlParameter[] commandParameters)
        {
            //create a command and prepare it for execution
            SqlCommand cmd = new SqlCommand();
            PrepareCommand(cmd, connection, (SqlTransaction)null, commandType, commandText, commandParameters);

            //create the DataAdapter & DataSet
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();

            //fill the DataSet using default values for DataTable names, etc.
            da.Fill(ds);

            // detach the SqlParameters from the command object, so they can be used again.			
            cmd.Parameters.Clear();

            //return the dataset
            return ds;
        }
        //Peng
        public static void Sqlexecute(string str)
        {
            SqlConnection cn = new SqlConnection(ConfigurationSettings.AppSettings["ConnectionString"]);

            cn.Open();

            SqlCommand w_cmd = new SqlCommand(str, cn);
            w_cmd.ExecuteNonQuery();
            w_cmd.Dispose();
        }
        //
        public static object ExecuteScalar(string connectionString, CommandType commandType, string commandText, params SqlParameter[] commandParameters)
        {
            //create & open a SqlConnection, and dispose of it after we are done.
            using (SqlConnection cn = new SqlConnection(connectionString))
            {
                cn.Open();

                //call the overload that takes a connection in place of the connection string
                return ExecuteScalar(cn, commandType, commandText, commandParameters);
            }
        }
        public static object ExecuteScalar(string spName, params object[] parameterValues)
        {
            //if we receive parameter values, we need to figure out where they go
            if ((parameterValues != null) && (parameterValues.Length > 0))
            {
                //pull the parameters for this stored procedure from the parameter cache (or discover them & populate the cache)
                SqlParameter[] commandParameters = SqlHelperParameterCache.GetSpParameterSet(ConfigurationSettings.AppSettings["ConnectionString"], spName);

                //assign the provided values to these parameters based on parameter order
                AssignParameterValues(commandParameters, parameterValues);

                //call the overload that takes an array of SqlParameters
                return ExecuteScalar(ConfigurationSettings.AppSettings["ConnectionString"], CommandType.StoredProcedure, spName, commandParameters);
            }
            //otherwise we can just call the SP without params
            else
            {
                return ExecuteScalar(ConfigurationSettings.AppSettings["ConnectionString"], CommandType.Text, spName);
            }
        }
        public static object ExecuteScalar(SqlConnection connection, CommandType commandType, string commandText, params SqlParameter[] commandParameters)
        {
            //create a command and prepare it for execution
            SqlCommand cmd = new SqlCommand();
            PrepareCommand(cmd, connection, (SqlTransaction)null, commandType, commandText, commandParameters);

            //execute the command & return the results
            object retval = cmd.ExecuteScalar();

            // detach the SqlParameters from the command object, so they can be used again.
            cmd.Parameters.Clear();
            return retval;

        }
        //取存储过程参数过程
        public sealed class SqlHelperParameterCache
        {
            //要支持一个或多个编写器，Hashtable 上的所有操作都必须通过 Synchronized 方法返回的包装执行
            private static Hashtable paramCache = Hashtable.Synchronized(new Hashtable());
            private SqlHelperParameterCache() { }

            public static SqlParameter[] GetSpParameterSet(string connectionString, string spName)
            {
                return GetSpParameterSet(connectionString, spName, false);
            }

            public static SqlParameter[] GetSpParameterSet(string connectionString, string spName, bool includeReturnValueParameter)
            {
                string c = (includeReturnValueParameter ? ":include ReturnValue Parameter" : "");
                string hashKey = connectionString + ":" + spName + (includeReturnValueParameter ? ":include ReturnValue Parameter" : "");

                SqlParameter[] cachedParameters;

                cachedParameters = (SqlParameter[])paramCache[hashKey];

                if (cachedParameters == null)
                {
                    cachedParameters = (SqlParameter[])(paramCache[hashKey] = DiscoverSpParameterSet(connectionString, spName, includeReturnValueParameter));
                }

                return CloneParameters(cachedParameters);
            }
            private static SqlParameter[] DiscoverSpParameterSet(string connectionString, string spName, bool includeReturnValueParameter)
            {
                using (SqlConnection cn = new SqlConnection(connectionString))
                using (SqlCommand cmd = new SqlCommand(spName, cn))
                {
                    cn.Open();
                    cmd.CommandType = CommandType.StoredProcedure;

                    SqlCommandBuilder.DeriveParameters(cmd);
                    if (!includeReturnValueParameter)
                    {
                        cmd.Parameters.RemoveAt(0);
                    }
                    SqlParameter[] discoveredParameters = new SqlParameter[cmd.Parameters.Count];

                    cmd.Parameters.CopyTo(discoveredParameters, 0);

                    return discoveredParameters;
                }
            }
            private static SqlParameter[] CloneParameters(SqlParameter[] originalParameters)
            {
                //deep copy of cached SqlParameter array
                SqlParameter[] clonedParameters = new SqlParameter[originalParameters.Length];

                for (int i = 0, j = originalParameters.Length; i < j; i++)
                {
                    clonedParameters[i] = (SqlParameter)((ICloneable)originalParameters[i]).Clone();
                    string ccc = clonedParameters[i].ToString();
                    //					string aaa;
                }

                return clonedParameters;
            }


        }

    }
}
