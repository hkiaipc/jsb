using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace data_define
{
    public class linkman
    {
        /// <summary>
        /// 联系人
        /// </summary>
        public linkman()
        { }
        private int _linkman_id;
        /// <summary>
        /// 联系人id
        /// </summary>
        public int linkman_id
        {
            get { return _linkman_id; }
            set { _linkman_id = value; }
        }
        private int _wateruser_id;
        /// <summary>
        /// 用水单位id
        /// </summary>
        public int wateruser_id
        {
            get { return _wateruser_id; }
            set { _wateruser_id = value; }
        }
        private string _is_check;
        /// <summary>
        /// 是节水负责人/联系人
        /// </summary>
        public string is_check
        {
            get { return _is_check; }
            set { _is_check = value; }
        }
        private string _name;
        /// <summary>
        /// 姓名
        /// </summary>
        public string name
        {
            get { return _name; }
            set { _name = value; }
        }
        private string _duty;
        /// <summary>
        /// 职务
        /// </summary>
        public string duty
        {
            get { return _duty; }
            set { _duty = value; }
        }
        private string _branch;
        /// <summary>
        /// 部门
        /// </summary>
        public string branch
        {
            get { return _branch; }
            set { _branch = value; }
        }
        private string _phone;
        /// <summary>
        /// 电话
        /// </summary>
        public string phone
        {
            get { return _phone; }
            set { _phone = value; }
        }
        private string _handphone;
        /// <summary>
        /// 手机
        /// </summary>
        public string handphone
        {
            get { return _handphone; }
            set { _handphone = value; }
        }
        private string _isnote;
        /// <summary>
        /// 是否接收短信
        /// </summary>
        public string isnote
        {
            get { return _isnote; }
            set { _isnote = value; }
        }
    }
}
