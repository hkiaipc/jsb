using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace data_define
{
    /// <summary>
    /// 
    /// </summary>
    public class makeover_kind
    {
        public makeover_kind()
        {
        }
        private int _makeover_kindid;
        /// <summary>
        /// 技改类型id
        /// </summary>
        public int makeover_kindid
        {
            get { return _makeover_kindid; }
            set { _makeover_kindid = value; }
        }
        private string _makeover_kindname;
        /// <summary>
        /// 技改类型名称
        /// </summary>
        public string makeover_kindname
        {
            get { return _makeover_kindname; }
            set { _makeover_kindname = value; }
        }
        private string _remark;
        public string remark
        {
            get { return _remark; }
            set { _remark = value; }
        }
    }
}
