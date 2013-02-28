using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;


namespace operation
{
    public class o_type
    {
        data_link.type data_type = new data_link.type();
        /// <summary>
        /// 添加
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public bool add(data_define.type model)
        {
            return data_type.add(model);
        }
        public bool update(data_define.type model)
        {
            return data_type.update(model);
        }
        public bool exists(data_define.type model)
        {
            return data_type.exists(model);
        }
        public List<data_define.type> dt(data_define.type model)
        {
            //List<type> tt=new List<type>();

            return data_type.type_listdt(model);
        }
        public bool delete(int type_id)
        {
            return data_type.delete(type_id);
        }
        public DataTable type_dt(int type_id)
        {
            return data_type.typedt(type_id);
        }
    }
}
