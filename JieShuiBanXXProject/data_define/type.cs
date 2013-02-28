using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace data_define
{
    /// <summary>
    /// 行业大类
    /// </summary>
    public class type
    {
        public type()
        {}
        private int _type_id;
        /// <summary>
        /// 大类id,唯一
        /// </summary>
        public int type_id
        {
            get { return _type_id; }
            set { _type_id = value; }
        }
        private string _type_name;
        /// <summary>
        /// 大类名称
        /// </summary>
        public string type_name
        {
            get { return _type_name; }
            set { _type_name = value; }
        }
    }
}
