using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace data_define
{
    public class photo
    {
        /// <summary>
        /// 自备井或用水设备照片
        /// </summary>
        public photo()
        {
        }
        private int _photo_id;
        /// <summary>
        /// 照片id,唯一
        /// </summary>
        public int photo_id
        {
            get { return _photo_id; }
            set { _photo_id = value; }
        }
        private string _type;
        /// <summary>
        /// 照片类型
        /// </summary>
        public string type
        {
            get { return _type; }
            set { _type = value; }
        }
        private int _id;
        /// <summary>
        /// 对应id
        /// </summary>
        public int id
        {
            get { return _id; }
            set { _id = value; }
        }
        private string _photo_name;
        /// <summary>
        /// 照片名称
        /// </summary>
        public string photo_name
        {
            get { return _photo_name; }
            set { _photo_name = value; }
        }
        private string _photo;
        /// <summary>
        /// 照片内容
        /// </summary>
        public string photoinfo
        {
            get { return _photo; }
            set { _photo = value; }
        }
        private string _remark;
        private string remark
        {
            get { return _remark; }
            set { _remark = value; }
        }

    }
}
