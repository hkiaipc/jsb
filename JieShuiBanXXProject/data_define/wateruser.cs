using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace data_define
{
    public class wateruser
    {
        public wateruser()
        {}
        #region 用水单位
        private int _wateruser_id;
        /// <summary>
        /// 用水单位id,唯一
        /// </summary>
        public int wateruser_id
        {
            get { return _wateruser_id; }
            set { _wateruser_id = value; }
        }

        private string _wateruser;
        /// <summary>
        /// 用水单位名称,唯一
        /// </summary>
        public string waterusername
        {
            get { return _wateruser; }
            set { _wateruser = value; }
        }

        private string _wateruser_num;
        /// <summary>
        /// 微机编号，唯一
        /// </summary>
        public string wateruser_num
        {
            get { return _wateruser_num; }
            set { _wateruser_num = value; }
        }

        private string _corporate;
        /// <summary>
        /// 法人
        /// </summary>
        public string corporate
        {
            get { return _corporate; }
            set { _corporate = value; }
        }

        private string _address;
        /// <summary>
        /// 地址
        /// </summary>
        public string address
        {
            get { return _address; }
            set { _address = value; }
        }

        private string _post;
        /// <summary>
        /// 邮编
        /// </summary>
        public string post
        {
            get { return _post; }
            set { _post = value; }
        }

        private string _fax;
        /// <summary>
        /// 传真
        /// </summary>
        public string fax
        {
            get { return _fax; }
            set { _fax = value; }
        }

        private string _email;
        public string email
        {
            get { return _email; }
            set { _email = value; }
        }

        private int _trade_id;
        /// <summary>
        /// 所属行业
        /// </summary>
        public int trade_id
        {
            get { return _trade_id; }
            set { _trade_id = value; }
        }

        private string _trade_name;
        /// <summary>
        /// 行业名称
        /// </summary>
        public string trade_name
        {
            get { return _trade_name; }
            set { _trade_name = value; }
        }

        private byte[] _photo;
        public byte[] photo
        {
            get { return _photo; }
            set { _photo = value; }
        }

        private string _product;
        /// <summary>
        /// 主要产品
        /// </summary>
        public string product
        {
            get { return _product; }
            set { _product = value; }
        }

        private string _is_economize;
        /// <summary>
        /// 是否节水单位
        /// </summary>
        public string is_economize
        {
            get { return _is_economize; }
            set { _is_economize = value; }
        }

        private int _test_year;
        /// <summary>
        /// 测试年份
        /// </summary>
        public int test_year
        {
            get { return _test_year; }
            set { _test_year = value; }
        }

        private int _getwater_kind_id;
        /// <summary>
        /// 用水性质
        /// </summary>
        public int getwater_kind_id
        {
            get { return _getwater_kind_id; }
            set { _getwater_kind_id = value; }
        }
        private string _getwater_kindname;
        /// <summary>
        /// 用水性质名称
        /// </summary>
        public string getwater_kindname
        {
            get { return _getwater_kindname; }
            set { _getwater_kindname = value; }
        }
        private string _getwater_num;
        /// <summary>
        /// 取水许可证号
        /// </summary>
        public string getwater_num
        {
            get { return _getwater_num; }
            set { _getwater_num = value; }
        }

        private string _waterbeed;
        /// <summary>
        /// 取水水源种类
        /// </summary>
        public string waterbeed
        {
            get { return _waterbeed; }
            set { _waterbeed = value; }
        }

        private int _watermeter_num;
        /// <summary>
        /// 一级水表总数
        /// </summary>
        public int watermeter_num
        {
            get { return _watermeter_num; }
            set { _watermeter_num = value; }
        }

        private int _waterpeople;
        /// <summary>
        /// 用水人数
        /// </summary>
        public int waterpeople
        {
            get { return _waterpeople; }
            set { _waterpeople = value; }
        }

        private string _waterpeople_unit;
        /// <summary>
        /// 用水人数单位
        /// </summary>
        public string waterpeople_unit
        {
            get { return _waterpeople_unit; }
            set { _waterpeople_unit = value; }
        }
        private int _year_output;
        /// <summary>
        /// 年产量
        /// </summary>
        public int year_output
        {
            get { return _year_output; }
            set { _year_output = value; }
        }
        private string _unit;
        /// <summary>
        /// 年产量单位
        /// </summary>
        public string unit
        {
            get { return _unit; }
            set { _unit = value; }
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
        /// <summary>
        /// 负责人
        /// </summary>
        private string _answername;
        public string answername
        {
            get { return _answername; }
            set { _answername = value; }
        }
        private string _answerbranch;
        public string answerbranch
        {
            get { return _answerbranch; }
            set { _answerbranch = value; }
        }
        private string _answerduty;
        public string answerduty
        {
            get { return _answerduty; }
            set { _answerduty = value; }
        }
        private string _answerphone;
        public string answerphone
        {
            get { return _answerphone; }
            set { _answerphone = value; }
        }
        private string _answerhandphone;
        public string answerhandphone
        {
            get { return _answerhandphone; }
            set { _answerhandphone = value; }
        }
        private string _answerisnote;
        public string answerisnote
        {
            get { return _answerisnote; }
            set { _answerisnote = value; }
        }
        /// <summary>
        /// 联系人
        /// </summary>
        private string _linkmanname;
        public string linkmanname
        {
            get { return _linkmanname; }
            set { _linkmanname = value; }
        }
        private string _linkmanbranch;
        public string linkmanbranch
        {
            get { return _linkmanbranch; }
            set { _linkmanbranch = value; }
        }
        private string _linkmanduty;
        public string linkmanduty
        {
            get { return _linkmanduty; }
            set { _linkmanduty = value; }
        }
        private string _linkmanphone;
        public string linkmanphone
        {
            get { return _linkmanphone; }
            set { _linkmanphone = value; }
        }
        private string _linkmanhandphone;
        public string linkmanhandphone
        {
            get { return _linkmanhandphone; }
            set { _linkmanhandphone = value; }
        }
        private string _linkmanisnote;
        public string linkmanisnote
        {
            get { return _linkmanisnote; }
            set { _linkmanisnote = value; }
        }
        #endregion
    }
    
}
