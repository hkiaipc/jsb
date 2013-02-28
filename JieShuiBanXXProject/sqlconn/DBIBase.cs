using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace sqlconn
{
    public class DBIBase
    {
        static private DBIBase _DBIBase;
        static public DBIBase Instance
        {
            get
            {
                return _DBIBase;
            }
        }
        private string _connstring;
        public DBIBase(string connstring)
        {
            this._connstring = connstring;
            _DBIBase = this;
        }
        public SqlConnection Connection
		{
			get { return _connection; }
         } private SqlConnection _connection;

        public void open()
        {
            this._connection = new SqlConnection(_connstring);
            this._connection.Open();
        }
        public void Close()
        {
            this._connection.Close();
        }
        #region ExecuteDataTable
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        public DataTable ExecuteDataTable(string sql)
        {
            //SqlCommand cmd = this._connection.CreateCommand();
            SqlCommand cmd = new SqlCommand(sql);
            return ExecuteDataTable(cmd);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="cmd"></param>
        /// <returns></returns>
        public DataTable ExecuteDataTable(SqlCommand cmd)
        {
            cmd.Connection = this.Connection;
            DataSet ds = new DataSet();
            SqlDataAdapter sqlda = new SqlDataAdapter(cmd);
            sqlda.Fill(ds);
            return ds.Tables[0];
        }
        #endregion //ExecuteDataTable

        #region ExecuteScalar
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        public object ExecuteScalar(string sql)
        {
            SqlCommand cmd = this.Connection.CreateCommand();
            cmd.CommandText = sql;
            return ExecuteScalar(cmd);
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="cmd"></param>
        /// <returns></returns>
        public object ExecuteScalar(SqlCommand cmd)
        {
            cmd.Connection = this.Connection;
            return cmd.ExecuteScalar();
        }
        #endregion //ExecuteScalar

        #region ExecuteNonQuery
        public bool ExecuteNonQuery(string sql)
        {
            SqlCommand cmd = this.Connection.CreateCommand();
            cmd.CommandText = sql;
            return ExecuteNonQuery(cmd);
        }
        public bool ExecuteNonQuery(SqlCommand cmd)
        {
            cmd.Connection = this.Connection;
            if (cmd.ExecuteNonQuery() == 1)
                return true;
            else
                return false;
        }
        #endregion
    }
}
