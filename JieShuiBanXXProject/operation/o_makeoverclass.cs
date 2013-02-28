using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace operation
{
    public class o_makeoverclass
    {
        data_link.d_makeoverclass data_makeoverclass = new data_link.d_makeoverclass();
        /// <summary>
        /// 添加
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public bool add(data_define.makeover_class model)
        {
            return data_makeoverclass.add(model);
        }
        public bool update(data_define.makeover_class model)
        {
            return data_makeoverclass.update(model);
        }

        public List<data_define.makeover_class> dt(data_define.makeover_class model)
        {
            //List<type> tt=new List<type>();

            return data_makeoverclass.makeoverclass_listdt(model);
        }
    }
}
