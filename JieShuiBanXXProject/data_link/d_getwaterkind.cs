using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace data_link
{
    public class d_getwaterkind
    {
        public bool add(data_define.getwater_kind model)
        {
            string sql = string.Format("insert into t_getwater_kind(getwater_kind_name,remark) values ('{0}','{1}')", model.getwater_kind_name,model.remark);
            return sqlconn.DBIBase.Instance.ExecuteNonQuery(sql);
        }
        public bool update(data_define.getwater_kind model)
        {

            string sql = string.Format("update t_getwater_kind set getwater_kind_name='{0}',remark='{1}' where getwater_kind_id={2}", model.getwater_kind_name,model.remark,model.getwater_kind_id);
            return sqlconn.DBIBase.Instance.ExecuteNonQuery(sql);
        }
        public List<data_define.getwater_kind> getwaterkind_listdt(data_define.getwater_kind model)
        {
            string str1 = "";
            List<data_define.getwater_kind> _listgetwaterkind = new List<data_define.getwater_kind>();
            if (model.getwater_kind_id > 0)
            { str1 = "where t_getwater_kind.getwater_kind_id=" + model.getwater_kind_id + ""; }
            
            string sql = string.Format("select * from t_getwater_kind " + str1);
            DataTable ddt = sqlconn.DBIBase.Instance.ExecuteDataTable(sql);
            if (ddt.Rows.Count > 0)
            {
                for (int i = 0; i < ddt.Rows.Count; i++)
                {
                    data_define.getwater_kind _model = new data_define.getwater_kind();
                    _model.getwater_kind_id = int.Parse(ddt.Rows[i]["getwater_kind_id"].ToString());
                    _model.getwater_kind_name= ddt.Rows[i]["getwater_kind_name"].ToString();
                    _model.remark = ddt.Rows[i]["remark"].ToString();
                    _listgetwaterkind.Add(_model);
                }
            }
            return _listgetwaterkind;
        }
        public DataTable getwaterkinddt(int kind_id)
        {
            string str = "";
            if (kind_id > 0)
            {
                str = "where t_getwater_kind.getwater_kind_id=" + kind_id + "";
            }
            string sql = string.Format("select * from t_getwater_kind " + str);
            DataTable ddt = sqlconn.DBIBase.Instance.ExecuteDataTable(sql);
            return ddt;
        }
    }
}
