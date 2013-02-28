using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using data_define;


namespace jieshuibanxx_1.Common
{
    /// <summary>
    /// 构成显示列
    /// </summary>
    class DataGridDictionary
    {
        private Dictionary<string, List<string>> dataGridPropertyDictionary;

        private Dictionary<string, string> dataGridPropertyTitleDictionary;

        #region Instance
        private DataGridDictionary()
        {
            LoadDictionary();
        }

        static DataGridDictionary instance;

        public static DataGridDictionary Instance
        {
            get
            {
                if (instance == null)
                {
                    lock (typeof(DataGridDictionary))
                    {
                        instance = new DataGridDictionary();
                    }
                }

                return instance;
            }
        }
        #endregion

        public string[] GetDataGridPropertys(string type)
        {
            if (dataGridPropertyDictionary.ContainsKey(type))
            {
                return dataGridPropertyDictionary[type].ToArray();
            }

            return new List<string>().ToArray();
        }

        public string GetDataGridPropertyTitle(string property)
        {
            if (dataGridPropertyTitleDictionary.ContainsKey(property))
            {
                return dataGridPropertyTitleDictionary[property];
            }

            return "未知";
        }

        private void LoadDictionary()
        {
            LoadDataGridProperty();
            LoadDataGridPropertyTitle();
        }

        private void LoadDataGridProperty()
        {
            dataGridPropertyDictionary = new Dictionary<string, List<string>>();
            LoadSystemManageDataGridProperty();
        }

        private void LoadDataGridPropertyTitle()
        {
            dataGridPropertyTitleDictionary = new Dictionary<string, string>();
            LoadSystemManageDataGridPropertyTitle();
        }

        /// <summary>
        /// 加载系统管理信息的显示属性
        /// </summary>
        private void LoadSystemManageDataGridProperty()
        {
            //行业大类
            string type = typeof(type).FullName;
            dataGridPropertyDictionary.Add(type, new List<string>());
            dataGridPropertyDictionary[type].Add("type_id");
            dataGridPropertyDictionary[type].Add("type_name");

            //行业子类
            string trade = typeof(trade).FullName;
            dataGridPropertyDictionary.Add(trade, new List<string>());
            dataGridPropertyDictionary[trade].Add("trade_id");
            dataGridPropertyDictionary[trade].Add("type_name");
            dataGridPropertyDictionary[trade].Add("trade_name");

            //取水性质
            string getwaterkind = typeof(getwater_kind).FullName;
            dataGridPropertyDictionary.Add(getwaterkind, new List<string>());
            dataGridPropertyDictionary[getwaterkind].Add("getwater_kind_id");
            dataGridPropertyDictionary[getwaterkind].Add("getwater_kind_name");

            //技改分类
            string makeoverclass = typeof(makeover_class).FullName;
            dataGridPropertyDictionary.Add(makeoverclass, new List<string>());
            dataGridPropertyDictionary[makeoverclass].Add("makeover_classid");
            dataGridPropertyDictionary[makeoverclass].Add("makeover_class_name");

            //技改类型
            string makeoverkind = typeof(makeover_kind).FullName;
            dataGridPropertyDictionary.Add(makeoverkind, new List<string>());
            dataGridPropertyDictionary[makeoverkind].Add("makeover_kindid");
            dataGridPropertyDictionary[makeoverkind].Add("makeover_kindname");

            //用水单位
            string wateruser = typeof(data_define.wateruser).FullName;
            dataGridPropertyDictionary.Add(wateruser, new List<string>());
            dataGridPropertyDictionary[wateruser].Add("wateruser_id");
            dataGridPropertyDictionary[wateruser].Add("waterusername");
            dataGridPropertyDictionary[wateruser].Add("wateruser_num");
            dataGridPropertyDictionary[wateruser].Add("corporate");
            dataGridPropertyDictionary[wateruser].Add("address");
            dataGridPropertyDictionary[wateruser].Add("post");
            dataGridPropertyDictionary[wateruser].Add("fax");
            dataGridPropertyDictionary[wateruser].Add("email");
            dataGridPropertyDictionary[wateruser].Add("product");
            dataGridPropertyDictionary[wateruser].Add("getwater_num");
            dataGridPropertyDictionary[wateruser].Add("watermeter_num");
            dataGridPropertyDictionary[wateruser].Add("waterpeople");
            dataGridPropertyDictionary[wateruser].Add("year_output");
            dataGridPropertyDictionary[wateruser].Add("unit");

        }

        /// <summary>
        /// 加载系统管理信息的显示属性标题
        /// </summary>
        private void LoadSystemManageDataGridPropertyTitle()
        {
            string type = typeof(type).FullName;
            //行业大类
            dataGridPropertyTitleDictionary.Add(string.Format("{0}.type_id", type), "行业编号");
            dataGridPropertyTitleDictionary.Add(string.Format("{0}.type_name", type), "行业大类名称");

            string trade = typeof(trade).FullName;
            //行业子类
            dataGridPropertyTitleDictionary.Add(string.Format("{0}.trade_id", trade), "行业子类编号");
            dataGridPropertyTitleDictionary.Add(string.Format("{0}.type_name", trade), "行业大类名称");
            dataGridPropertyTitleDictionary.Add(string.Format("{0}.trade_name", trade), "行业名称");

            string getwaterkind = typeof(getwater_kind).FullName;
            //取水性质
            dataGridPropertyTitleDictionary.Add(string.Format("{0}.getwater_kind_id", getwaterkind), "取水性质编号");
            dataGridPropertyTitleDictionary.Add(string.Format("{0}.getwater_kind_name", getwaterkind), "取水性质名称");

            string makeoverclass = typeof(makeover_class).FullName;
            //技改分类
            dataGridPropertyTitleDictionary.Add(string.Format("{0}.makeover_classid", makeoverclass), "技改分类编号");
            dataGridPropertyTitleDictionary.Add(string.Format("{0}.makeover_class_name", makeoverclass), "分类名称");

            string makeoverkind = typeof(makeover_kind).FullName;
            //技改分类
            dataGridPropertyTitleDictionary.Add(string.Format("{0}.makeover_kindid", makeoverkind), "技改类型编号");
            dataGridPropertyTitleDictionary.Add(string.Format("{0}.makeover_kindname", makeoverkind), "类型名称");

            string wateruser = typeof(data_define.wateruser).FullName;
            //技改分类
            dataGridPropertyTitleDictionary.Add(string.Format("{0}.wateruser_id", wateruser), "用水单位编号");
            dataGridPropertyTitleDictionary.Add(string.Format("{0}.waterusername", wateruser), "单位名称");
            dataGridPropertyTitleDictionary.Add(string.Format("{0}.wateruser_num", wateruser), "微机编号");
            dataGridPropertyTitleDictionary.Add(string.Format("{0}.corporate", wateruser), "法人");
            dataGridPropertyTitleDictionary.Add(string.Format("{0}.address", wateruser), "地址");
            dataGridPropertyTitleDictionary.Add(string.Format("{0}.post", wateruser), "邮编");
            dataGridPropertyTitleDictionary.Add(string.Format("{0}.fax", wateruser), "传真");
            dataGridPropertyTitleDictionary.Add(string.Format("{0}.email", wateruser), "email");
            dataGridPropertyTitleDictionary.Add(string.Format("{0}.product", wateruser), "主要产品");
            dataGridPropertyTitleDictionary.Add(string.Format("{0}.getwater_num", wateruser), "取水许可证号");
            dataGridPropertyTitleDictionary.Add(string.Format("{0}.watermeter_num", wateruser), "一级水表总数");
            dataGridPropertyTitleDictionary.Add(string.Format("{0}.year_output", wateruser), "产品设计年产量");
            dataGridPropertyTitleDictionary.Add(string.Format("{0}.unit", wateruser), "产量单位");
            
            
        }
    }
}
