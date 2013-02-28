using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace data_define
{
    public class use_water
    {
        /// <summary>
        /// 用水信息
        /// </summary>
        public use_water()
        { }
        private int _usewater_id;
        /// <summary>
        /// 用水id,唯一
        /// </summary>
        public int usewater_id
        {
            get { return _usewater_id; }
            set { _usewater_id = value; }
        }
        private int _wateruser_id;
        /// <summary>
        /// 用水户id
        /// </summary>
        public int wateruser_id
        {
            get { return _usewater_id; }
            set { _wateruser_id = value; }
        }
        private int _year;
        /// <summary>
        /// 用水年份
        /// </summary>
        public int year
        {
            get { return _year; }
            set { _year = value; }
        }
        private float _year_const;
        /// <summary>
        /// 年产值
        /// </summary>
        public float year_const
        {
            get { return _year_const; }
            set { _year_const = value; }
        }
        private int _getwater;
        /// <summary>
        /// 自来水用水量
        /// </summary>
        public int getwater
        {
            get { return _getwater; }
            set { _getwater = value; }
        }
        private string _getwater_remark;
        /// <summary>
        /// 自来水备注
        /// </summary>
        public string getwater_remark
        {
            get { return _getwater_remark; }
            set { _getwater_remark = value; }
        }
        private int _sparewater;
        /// <summary>
        /// 自备水量
        /// </summary>
        public int sparewater
        {
            get { return _sparewater; }
            set { _sparewater = value; }
        }
        private string _sparewater_remark;
        /// <summary>
        /// 自备水备注
        /// </summary>
        public string sparewater_remark
        {
            get { return _sparewater_remark; }
            set { _sparewater_remark = value; }
        }
        private int _river_water;
        /// <summary>
        /// 河水量
        /// </summary>
        public int river_water
        {
            get { return _river_water; }
            set { _river_water = value; }
        }
        private string _river_remark;
        /// <summary>
        /// 河水备注
        /// </summary>
        public string river_remark
        {
            get { return _river_remark; }
            set { _river_remark = value; }
        }
        private int _midstream_water;
        /// <summary>
        /// 中水量
        /// </summary>
        public int midstream_water
        {
            get { return _midstream_water; }
            set { _midstream_water = value; }
        }
        private string _midstream_remark;
        /// <summary>
        /// 中水备注
        /// </summary>
        public string midstream_remark
        {
            get { return _midstream_remark; }
            set { _midstream_remark = value; }
        }
        private int _mine_water;
        /// <summary>
        /// 矿井疏干水
        /// </summary>
        public int mine_water
        {
            get { return _mine_water; }
            set { _mine_water = value; }
        }
        private string _mine_remark;
        /// <summary>
        /// 矿井疏干备注
        /// </summary>
        public string mine_remark
        {
            get { return _mine_remark; }
            set { _mine_remark = value; }
        }
        private int _rain_water;
        /// <summary>
        /// 雨水量
        /// </summary>
        public int rain_water
        {
            get { return _rain_water; }
            set { _rain_water = value; }
        }
        private string _rain_remark;
        /// <summary>
        /// 雨水备注
        /// </summary>
        public string rain_remark
        {
            get { return _rain_remark; }
            set { _rain_remark = value; }
        }
        private int _other;
        /// <summary>
        /// 其它用水量
        /// </summary>
        public int other
        {
            get { return _other; }
            set { _other = value; }
        }
        private string _other_remark;
        /// <summary>
        /// 其它用水备注
        /// </summary>
        public string other_remark
        {
            get { return _other_remark; }
            set { _other_remark = value; }
        }
    }
}
