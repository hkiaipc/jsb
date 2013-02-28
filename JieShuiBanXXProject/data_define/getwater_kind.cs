using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace data_define
{
    public class getwater_kind
    {
        public getwater_kind()
        { }

        private int _getwater_kindid;
        /// <summary>
        /// 取水性质id,唯一
        /// </summary>
        public int getwater_kind_id
        {
            get { return _getwater_kindid; }
            set { _getwater_kindid = value; }
        }
        private string _getwater_kind_name;
        /// <summary>
        /// 取水性质名称
        /// </summary>
        public string getwater_kind_name
        {
            get { return _getwater_kind_name; }
            set { _getwater_kind_name = value; }
        }
        private string _remark;
        /// <summary>
        /// 备注
        /// </summary>
        public string remark
        {
            get { return _remark; }
            set { _remark = value; }
        }
    }

}
