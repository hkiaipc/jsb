using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace data_define
{
    public class makeover_class
    {
        public makeover_class()
        {
        }
        private int _makeover_classid;
        /// <summary>
        /// 技改分类id
        /// </summary>
        public int makeover_classid
        {
            get { return _makeover_classid; }
            set { _makeover_classid = value; }
        }
        private string _makeover_classname;
        /// <summary>
        /// 技改分类名称
        /// </summary>
        public string makeover_class_name
        {
            get { return _makeover_classname; }
            set { _makeover_classname = value; }
        }
        private string _remark;
        public string remark
        {
            get { return _remark; }
            set { _remark = value; }
        }
    }
}
