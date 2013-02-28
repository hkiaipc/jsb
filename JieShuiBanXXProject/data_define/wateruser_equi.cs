using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace data_define
{
    public class wateruser_equi
    {
        /// <summary>
        /// 用水设备
        /// </summary>
        public wateruser_equi()
        { }
        private int _equi_id;
        /// <summary>
        /// 用水设备id,唯一
        /// </summary>
        public int equi_id
        {
            get { return _equi_id; }
            set { _equi_id = value; }
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
        private string _equi_name;
        /// <summary>
        ///设备名称 
        /// </summary>
        public string equi_name
        {
            get { return _equi_name; }
            set { _equi_name = value; }
        }
        private DateTime _use_time;
        /// <summary>
        /// 投入使用时间
        /// </summary>
        public DateTime use_time
        {
            get { return _use_time; }
            set { _use_time = value; }
        }

        private string _info;
        /// <summary>
        /// 名牌信息
        /// </summary>
        public string info
        {
            get { return _info; }
            set { _info = value; }
        }
        private string _getwater_class;
        /// <summary>
        /// 取水类型
        /// </summary>
        public string getwater_class
        {
            get { return _getwater_class; }
            set { _getwater_class = value; }
        }

        private float _cyc_num;
        /// <summary>
        /// 循环量
        /// </summary>
        public float cyc_num
        {
            get { return _cyc_num; }
            set { _cyc_num = value; }
        }
        private float _cyc_rate;
        /// <summary>
        /// 循环率
        /// </summary>
        public float cyc_rate
        {
            get { return _cyc_rate; }
            set { _cyc_rate = value; }

        }
        private string _application;
        /// <summary>
        /// 用途
        /// </summary>
        public string application
        {
            get { return _application; }
            set { _application = value; }
        }
        private string _remark;
        public string remark
        {
            get { return _remark; }
            set { _remark = value; }
        }
    }
}
