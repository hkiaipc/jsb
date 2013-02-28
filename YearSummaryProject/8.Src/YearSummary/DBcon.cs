using System;
using System.Data;
using System.Data.SqlClient;
using System.Xml;
namespace YearSummary
{
	/// <summary>
	/// DBcon 的摘要说明。
	/// </summary>
	public class DBcon
	{
		private SqlConnection con;
		private string str = null;

		public DBcon()
		{
		}


		#region SqlCon
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
		public SqlConnection GetConnection()
		{
            con = DataBase();
            if (con.State != ConnectionState.Open)
            {
                con.Open();
            }
            return con;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
		public SqlConnection DataBase()
		{
            if (sqlcon == null)
            {
                XmlDocument XDoc = new XmlDocument();
                XDoc.Load("DataBase.xml");
                XmlNode XNode = XDoc.DocumentElement.SelectSingleNode("./SqlCon");
                for (int i = 0; i < XNode.ChildNodes.Count; i++)
                {
                    str = str + XNode.ChildNodes[i].Name;
                    str = str + "=";
                    str = str + XNode.ChildNodes[i].InnerText.Trim();
                    str = str + ";";
                }
                sqlcon = new SqlConnection(str);
                return sqlcon;
            }
            return sqlcon;
		}

        /// <summary>
        /// 
        /// </summary>
        private SqlConnection sqlcon;
		#endregion
	}
}
