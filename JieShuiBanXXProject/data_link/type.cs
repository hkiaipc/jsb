using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace data_link
{
    public class type
    {
        //sqlconn.DBIBase dbi = new sqlconn.DBIBase("");
        public bool add(data_define.type model)
        {
            string sql = string.Format("insert into t_type(type_name) values ('{0}')", model.type_name);
            return sqlconn.DBIBase.Instance.ExecuteNonQuery(sql);
        }
        public bool update(data_define.type model)
        {
            string sql = string.Format("update t_type set type_name='{0}' where type_id={1}", model.type_name, model.type_id);
            return sqlconn.DBIBase.Instance.ExecuteNonQuery(sql);
        }
        public bool exists(data_define.type model)
        {
            string str1 = "";
            if (model.type_id > 0)
            { str1 = "where t_type.type_id=" +model.type_id + ""; }
            else if (model.type_name.Length > 0)
            {
                if(str1.Length>0)
                {
                    str1 = str1 + " and t_type.type_name='" + model.type_name + "'";
                }
                else
                {
                    str1 = "where t_type.type_name=" + model.type_name + ""; 
                }
            }
            string sql = string.Format("select * from t_type " + str1);
            return sqlconn.DBIBase.Instance.ExecuteNonQuery(sql);
        }
        public List<data_define.type> type_listdt(data_define.type model)
        {
            string str1 = "";
            List<data_define.type> _listtype = new List<data_define.type>();
            if (model.type_id > 0)
            { str1 = "where t_type.type_id=" + model.type_id + ""; }
            else if (model.type_name.Length > 0)
            {
                if (str1.Length > 0)
                {
                    str1 = str1 + " and t_type.type_name='" + model.type_name + "'";
                }
                else
                {
                    str1 = "where t_type.type_name=" + model.type_name + "";
                }
            }
            string sql = string.Format("select * from t_type " + str1);
            DataTable ddt=sqlconn.DBIBase.Instance.ExecuteDataTable(sql);
            if(ddt.Rows.Count>0)
            {
                for(int i=0;i<ddt.Rows.Count;i++)
                {
                    data_define.type _model = new data_define.type();
                    _model.type_id=int.Parse(ddt.Rows[i]["type_id"].ToString());
                    _model.type_name=ddt.Rows[i]["type_name"].ToString();
                    _listtype.Add(_model);
                }
            }
            return _listtype;
        }
        public DataTable typedt(int type_id)
        {
            string str = "";
            if (type_id > 0)
            {
                str = "where t_type.type_id=" + type_id + "";
            }
            string sql = string.Format("select * from t_type " + str);
            DataTable ddt = sqlconn.DBIBase.Instance.ExecuteDataTable(sql);
            return ddt;
        }
        public bool delete(int type_id)
        {
            if (type_id > 0)
            {
                string sql = string.Format("delete t_type where " + type_id + "");
                return sqlconn.DBIBase.Instance.ExecuteNonQuery(sql);
            }
            else
            {
                return false;
            }
        }
    }
}
