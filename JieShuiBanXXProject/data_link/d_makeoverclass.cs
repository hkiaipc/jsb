using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace data_link
{
    public class d_makeoverclass
    {
        public bool add(data_define.makeover_class model)
        {
            string sql = string.Format("insert into t_makeover_class(makeover_class_name,remark) values ('{0}','{1}')", model.makeover_class_name, model.remark);
            return sqlconn.DBIBase.Instance.ExecuteNonQuery(sql);
        }
        public bool update(data_define.makeover_class model)
        {
            string sql = string.Format("update t_makeover_class set makeover_class_name='{0}',remark='{1}' where makeover_class_id={2}", model.makeover_class_name, model.remark, model.makeover_classid);
            return sqlconn.DBIBase.Instance.ExecuteNonQuery(sql);
        }
        public List<data_define.makeover_class> makeoverclass_listdt(data_define.makeover_class model)
        {
            string str1 = "";
            List<data_define.makeover_class> _listmakeoverclass = new List<data_define.makeover_class>();
            if (model.makeover_classid> 0)
            { str1 = "where t_makeover_class.makeover_classid=" + model.makeover_classid + ""; }

            string sql = string.Format("select * from t_makeover_class " + str1);
            DataTable ddt = sqlconn.DBIBase.Instance.ExecuteDataTable(sql);
            if (ddt.Rows.Count > 0)
            {
                for (int i = 0; i < ddt.Rows.Count; i++)
                {
                    data_define.makeover_class _model = new data_define.makeover_class();
                    _model.makeover_classid= int.Parse(ddt.Rows[i]["makeover_classid"].ToString());
                    _model.makeover_class_name = ddt.Rows[i]["makeover_class_name"].ToString();
                    _model.remark = ddt.Rows[i]["remark"].ToString();
                    _listmakeoverclass.Add(_model);
                }
            }
            return _listmakeoverclass;
        }
    }
}
