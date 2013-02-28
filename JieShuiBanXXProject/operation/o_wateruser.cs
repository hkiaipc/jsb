using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace operation
{
    public class o_wateruser
    {
        data_link.d_wateruser data_wateruser = new data_link.d_wateruser();
        /// <summary>
        /// 添加
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public bool add(data_define.wateruser model)
        {
            return data_wateruser.add(model);
        }
        public DataTable dt(data_define.wateruser model)
        {
            return data_wateruser.wateruserdt(model);
        }
    }
}
