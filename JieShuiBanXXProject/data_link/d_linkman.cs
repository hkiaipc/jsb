using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace data_link
{
    public class d_linkman
    {

        public bool add(data_define.linkman model)
        {
            string sql = string.Format("insert into t_linkman(wateruser_id,is_check,name,branch,duty,phone,handphone,isnote)"
            + " values({0},'{1}','{2}','{3}','{4}','{5}','{6}','{7}')",model.wateruser_id,model.is_check,model.name,model.branch,model.duty,model.phone,model.handphone,model.isnote);
            return sqlconn.DBIBase.Instance.ExecuteNonQuery(sql);
        }
    }
}
