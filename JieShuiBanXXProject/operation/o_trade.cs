using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace operation
{
    public class o_trade
    {
        data_link.d_trade data_trade = new data_link.d_trade();
        /// <summary>
        /// 添加
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public bool add(data_define.trade model)
        {
            return data_trade.add(model);
        }
        public bool update(data_define.trade model)
        {
            return data_trade.update(model);
        }
        
        public List<data_define.trade> dt(data_define.trade model)
        {
            //List<type> tt=new List<type>();

            return data_trade.trade_listdt(model);
        }
        public DataTable _tradedt(int type_id)
        {
            return data_trade.tradedt(type_id);
        }
    }
}
