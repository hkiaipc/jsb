using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace operation
{
    public class o_getwaterkind
    {
        data_link.d_getwaterkind data_getwaterkind = new data_link.d_getwaterkind();
        /// <summary>
        /// 添加
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public bool add(data_define.getwater_kind model)
        {
            return data_getwaterkind.add(model);
        }
        public bool update(data_define.getwater_kind model)
        {
            return data_getwaterkind.update(model);
        }

        public List<data_define.getwater_kind> dt(data_define.getwater_kind model)
        {
            //List<type> tt=new List<type>();

            return data_getwaterkind.getwaterkind_listdt(model);
        }
        public DataTable _getwaterkinddt(int kind_id)
        {
            return data_getwaterkind.getwaterkinddt(kind_id);
        }
    }
}
