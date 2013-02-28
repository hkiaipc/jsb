using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace data_link
{
    public class d_makeoverkind
    {
        public bool add(data_define.makeover_kind model)
        {
            string sql = string.Format("insert into t_makeover_kind(makeover_kindname,remark) values ('{0}','{1}')", model.makeover_kindname, model.remark);
            return sqlconn.DBIBase.Instance.ExecuteNonQuery(sql);
        }
        public bool update(data_define.makeover_kind model)
        {
            string sql = string.Format("update t_makeover_kind set makeover_kindname='{0}',remark='{1}' where makeover_kindid={2}", model.makeover_kindname, model.remark, model.makeover_kindid);
            return sqlconn.DBIBase.Instance.ExecuteNonQuery(sql);
        }
        public List<data_define.makeover_kind> makeoverkind_listdt(data_define.makeover_kind model)
        {
            string str1 = "";
            List<data_define.makeover_kind> _listmakeoverkind = new List<data_define.makeover_kind>();
            if (model.makeover_kindid > 0)
            { str1 = "where t_makeover_kind.makeover_kindid=" + model.makeover_kindid + ""; }

            string sql = string.Format("select * from t_makeover_kind " + str1);
            DataTable ddt = sqlconn.DBIBase.Instance.ExecuteDataTable(sql);
            if (ddt.Rows.Count > 0)
            {
                for (int i = 0; i < ddt.Rows.Count; i++)
                {
                    data_define.makeover_kind _model = new data_define.makeover_kind();
                    _model.makeover_kindid = int.Parse(ddt.Rows[i]["makeover_kindid"].ToString());
                    _model.makeover_kindname = ddt.Rows[i]["makeover_kindname"].ToString();
                    _model.remark = ddt.Rows[i]["remark"].ToString();
                    _listmakeoverkind.Add(_model);
                }
            }
            return _listmakeoverkind;
        }
    }
}
