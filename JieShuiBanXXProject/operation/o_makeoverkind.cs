using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace operation
{
    public class o_makeoverkind
    {
        data_link.d_makeoverkind data_makeoverkind = new data_link.d_makeoverkind();
        /// <summary>
        /// 添加
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public bool add(data_define.makeover_kind model)
        {
            return data_makeoverkind.add(model);
        }
        public bool update(data_define.makeover_kind model)
        {
            return data_makeoverkind.update(model);
        }

        public List<data_define.makeover_kind> dt(data_define.makeover_kind model)
        {
            //List<type> tt=new List<type>();

            return data_makeoverkind.makeoverkind_listdt(model);
        }
    }
}
