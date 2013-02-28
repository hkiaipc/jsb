using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace data_define
{
    public class ecnomize
    {
        /// <summary>
        /// 节水技改
        /// </summary>
        public ecnomize()
        { }
        private int _ecnomize_id;
        /// <summary>
        /// 节水技改id,yyyy+0000
        /// </summary>
        public int ecnomize_id
        {
            get { return _ecnomize_id; }
            set { _ecnomize_id = value; }
        }
        private int _wateruser_id;
        /// <summary>
        /// 用水单位
        /// </summary>
        public int wateruser_id
        {
            get { return _wateruser_id; }
            set { _wateruser_id = value; }
        }
        private string _ecnomize_name;
        /// <summary>
        /// 技改名称
        /// </summary>
        public string ecnomize_name
        {
            get { return _ecnomize_name; }
            set { _ecnomize_name = value; }
        }
        private DateTime _end_time;
        /// <summary>
        /// 技改完成时间
        /// </summary>
        public DateTime end_time
        {
            get { return _end_time; }
            set { _end_time = value; }
        }
        private float _self_money = float.Parse("0.00");
        /// <summary>
        /// 自筹资金
        /// </summary>
        public float self_money
        {
            get { return _self_money; }
            set { _self_money = value; }
        }
        private float _imburse_money = float.Parse("0.00");
        /// <summary>
        /// 资助资金
        /// </summary>
        public float imburse_money
        {
            get { return _imburse_money; }
            set { _imburse_money = value; }
        }
        private int _makeover_kindid;
        /// <summary>
        /// 技改类型
        /// </summary>
        public int makeover_kindid
        {
            get { return _makeover_kindid; }
            set { _makeover_kindid = value; }
        }
        private int _makeover_classid;
        /// <summary>
        /// 技改分类
        /// </summary>
        public int makeover_classid
        {
            get { return _makeover_classid; }
            set { _makeover_classid = value; }
        }
        private float _benefit = float.Parse("0.00");
        /// <summary>
        /// 节水效益
        /// </summary>
        public float benefit
        {
            get { return _benefit; }
            set { _benefit = value; }
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
