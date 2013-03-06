using System;
using System.Reflection;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xdgk.Common;

namespace gwlman
{

    /// <summary>
    /// 
    /// </summary>
    public class ReflectionHelper
    {

        #region ReflectionHelper
        /// <summary>
        /// 
        /// </summary>
        private ReflectionHelper()
        {

        }
        #endregion //ReflectionHelper

        #region GetPropertyValue
        /// <summary>
        /// 
        /// </summary>
        /// <param name="obj"></param>
        /// <param name="propertyName"></param>
        /// <returns></returns>
        static public object GetPropertyValue(object obj, string propertyName)
        {
            if (obj == null)
            {
                throw new ArgumentNullException("obj");
            }

            if (string.IsNullOrEmpty(propertyName))
            {
                throw new ArgumentException("propertyName");
            }

            PropertyInfo pi = GetPropertyInfo(obj, propertyName);
            object r = pi.GetValue(obj, null);
            return r;
        }
        #endregion //GetPropertyValue

        #region SetPropertyValue
        /// <summary>
        /// 
        /// </summary>
        /// <param name="obj"></param>
        /// <param name="propertyName"></param>
        /// <param name="value"></param>
        static public void SetPropertyValue(object obj, string propertyName, object value)
        {
            if (obj == null)
            {
                throw new ArgumentNullException("obj");
            }

            if (string.IsNullOrEmpty(propertyName))
            {
                throw new ArgumentException("propertyName");
            }

            PropertyInfo pi = GetPropertyInfo(obj, propertyName);
            pi.SetValue(obj, value, null);
        }
        #endregion //SetPropertyValue

        #region HasProperty
        /// <summary>
        /// 
        /// </summary>
        /// <param name="obj"></param>
        /// <param name="propertyName"></param>
        /// <returns></returns>
        static public bool HasProperty(object obj, string propertyName)
        {
            if (obj == null)
            {
                throw new ArgumentNullException("obj");
            }

            if (string.IsNullOrEmpty(propertyName))
            {
                throw new ArgumentException("propertyName");
            }


            Type type = obj.GetType();
            PropertyInfo pi = type.GetProperty(propertyName);
            return pi != null;
        }
        #endregion //HasProperty

        #region GetPropertyInfo
        /// <summary>
        /// 
        /// </summary>
        /// <param name="obj"></param>
        /// <param name="propertyName"></param>
        /// <returns></returns>
        private static PropertyInfo GetPropertyInfo(object obj, string propertyName)
        {
            Type type = obj.GetType();
            PropertyInfo pi = type.GetProperty(propertyName);
            if (pi == null)
            {
                string msg = string.Format(
                    "not find property by name '{0}' from type '{1}'",
                    propertyName, obj.GetType().Name);
                throw new ArgumentException(msg);
            }
            return pi;
        }
        #endregion //GetPropertyInfo
    }

    /// <summary>
    /// 
    /// </summary>
    public class ConditionDataSourceProvider
    {

        static public KeyValueCollection CreateDataSource()
        {
            KeyValueCollection kvs = new KeyValueCollection();
            kvs = new KeyValueCollection();
            kvs.Add(new KeyValue("编号", "Serial"));
            kvs.Add(new KeyValue("单位名称", "CompanyName"));
            kvs.Add(new KeyValue("单位地址", "CompanyAddress"));
            kvs.Add(new KeyValue("联系人", "Contact"));
            kvs.Add(new KeyValue("联系电话", "Phone"));
            kvs.Add(new KeyValue("电子邮箱", "Email"));
            kvs.Add(new KeyValue("年申请取水量", "AskingAmount"));
            //_kvs.Add(new KeyValue("水源地点", ""));
            kvs.Add(new KeyValue("年取水量", "GwAmount"));
            kvs.Add(new KeyValue("退水量", "BwAmount"));
            return kvs;
        }
    }
}

