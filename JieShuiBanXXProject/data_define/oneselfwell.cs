using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace data_define
{
    public class oneselfwell
    {
        /// <summary>
        /// 自备井
        /// </summary>
        public oneselfwell()
        { }
        private int _oneselfwell_id;
        /// <summary>
        /// 自备井id
        /// </summary>
        public int oneselfwell_id
        {
            get { return _oneselfwell_id; }
            set { _oneselfwell_id = value; }
        }
        private int _wateruser_id;
        /// <summary>
        /// 用户id
        /// </summary>
        public int wateruser_id
        {
            get { return _wateruser_id; }
            set { _wateruser_id = value; }
        }
        private DateTime _constitute_date;
        /// <summary>
        /// 成井时间
        /// </summary>
        public DateTime constitute_date
        {
            get { return _constitute_date; }
            set { _constitute_date = value; }
        }
        private int _getwater_kindid;
        /// <summary>
        /// 取水性质id
        /// </summary>
        public int getwater_kindid
        {
            get { return _getwater_kindid; }
            set { _getwater_kindid = value; }
        }
        private int _well_location;
        /// <summary>
        /// 井位
        /// </summary>
        public int well_location
        {
            get { return _well_location; }
            set { _well_location = value; }
        }
        private int _well_deepness;
        /// <summary>
        /// 井深
        /// </summary>
        public int well_deepness
        {
            get { return _well_deepness; }
            set { _well_deepness = value; }
        }
        private int _well_diameter;
        /// <summary>
        /// 井径
        /// </summary>
        public int well_diameter
        {
            get { return _well_diameter; }
            set { _well_diameter = value; }
        }
        private string _well_material;
        /// <summary>
        /// 井壁材质
        /// </summary>
        public string well_material
        {
            get { return _well_material; }
            set { _well_material = value; }
        }
        private string _pump_model;
        /// <summary>
        /// 水泵型号
        /// </summary>
        public string pump_model
        {
            get { return _pump_model; }
            set { _pump_model = value; }
        }
        private int _design_outwater;
        /// <summary>
        /// 设计出水量
        /// </summary>
        public int design_outwater
        {
            get { return _design_outwater; }
            set { _design_outwater = value; }
        }
        private int _fact_outwater;
        /// <summary>
        /// 实际出水量
        /// </summary>
        public int fact_outwater
        {
            get { return _fact_outwater; }
            set { _fact_outwater = value; }
        }
        private string _model;
        /// <summary>
        /// 装裱型号
        /// </summary>
        public string model
        {
            get { return _model; }
            set { _model = value; }
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
