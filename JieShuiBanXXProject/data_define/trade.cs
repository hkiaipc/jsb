using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace data_define
{
    public class trade
    {
        /// <summary>
        /// 行业子类
        /// </summary>
        public trade()
        { }
        private int _trade_id;
        /// <summary>
        /// 子类id,唯一
        /// </summary>
        public int trade_id
        {
            get { return _trade_id; }
            set { _trade_id = value; }
        }
        private int _type_id;
        /// <summary>
        /// 行业大类id
        /// </summary>
        public int type_id
        {
            get { return _type_id; }
            set { _type_id = value; }
        }
        private string _trade_name;
        /// <summary>
        /// 子类名称
        /// </summary>
        public string trade_name
        {
            get { return _trade_name; }
            set { _trade_name = value; }
        }
        private string _type_name;
        public string type_name
        {
            get { return _type_name; }
            set { _type_name = value; }
        }
    }

}
