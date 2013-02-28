using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data;
using System.Drawing;
using Common.Controls;
using System.Reflection;
using System.Collections;
using System.ComponentModel;


namespace jieshuibanxx_1.Common
{
    public class DataGridStyleHelper
    {
        public static void SetStyle(DataGrid grid, Type rowObjectType)
        {
            if (grid == null || grid.DataSource == null)
                return;

            SetStyle(grid, grid.DataSource, DataGridDictionary.Instance.GetDataGridPropertys(rowObjectType.FullName), rowObjectType);
        }

        public static void SetStyle(DataGrid grid, object dataSource, string[] displayPropertyNames, Type objectType)
        {
            DataGridTableStyle dgts = QMDataGrid.GenerateCommonDataGridTableStyle();
            dgts.SelectionBackColor = System.Drawing.Color.Orange;
            dgts.SelectionForeColor = System.Drawing.Color.White;
            dgts.RowHeadersVisible = false;
            grid.TableStyles.Clear();
            grid.TableStyles.Add(dgts);
            if (displayPropertyNames == null || dataSource == null)
                return;

            IList listSource = null;

            IList list = dataSource as IList;
            if (list != null)
            {
                listSource = list;
            }

            IListSource listS = dataSource as IListSource;
            if (listS != null)
            {
                listSource = listS.GetList();
            }

            if (listSource != null)
            {
                PropertyInfo[] propertyInfos = objectType.GetProperties();
                foreach (string displayPropertyName in displayPropertyNames)
                {
                    foreach (PropertyInfo property in propertyInfos)
                    {
                        if (property.Name != displayPropertyName)
                            continue;
                        else
                        {
                            DataGridColumnStyle dgcs = null;
                            string headText = DataGridDictionary.Instance.GetDataGridPropertyTitle(string.Format("{0}.{1}", objectType.FullName, property.Name));
                            if (property.PropertyType == typeof(bool))
                            {
                                dgcs = new DataGridBoolColumn();
                                dgcs.Width = GetColumnWidth(grid, property, listSource, headText);
                                dgcs.HeaderText = headText;
                            }
                            else
                            {
                                dgcs = new DataGridTextBoxColumn();
                                dgcs.Width = GetColumnWidth(grid, property, listSource, headText);
                                dgcs.HeaderText = headText;
                            }
                            dgcs.MappingName = property.Name;

                            dgcs.Alignment = HorizontalAlignment.Center;

                            dgts.GridColumnStyles.Add(dgcs);
                            break;
                        }
                    }
                }
                dgts.MappingName = listSource.GetType().Name;
            }
        }

        public static int GetColumnWidth(DataGrid grid, PropertyInfo proInfo, IList listSource, string headerText)
        {
            int maxWidth = 0;
            int headWidth = (int)grid.CreateGraphics().MeasureString(headerText, grid.HeaderFont).Width;
            if (headWidth > maxWidth)
                maxWidth = headWidth;
            foreach (object obj in listSource)
            {
                int width = 40;
                object v = proInfo.GetValue(obj, null);
                if (v != null)
                {
                    SizeF size = grid.CreateGraphics().MeasureString(v.ToString(), grid.Font);
                    width = (int)size.Width;
                }
                if (width > maxWidth)
                    maxWidth = width;

            }
            return maxWidth + 40;
        }

        public static DataGridTableStyle GenerateStyle(Type t, string[] displayPropertyNames)
        {
            DataGridTableStyle dgts = QMDataGrid.GenerateCommonDataGridTableStyle();
            if (displayPropertyNames != null)
            {
                PropertyInfo[] propertyInfos = t.GetProperties();
                foreach (string displayPropertyName in displayPropertyNames)
                {
                    foreach (PropertyInfo property in propertyInfos)
                    {
                        if (property.Name != displayPropertyName)
                            continue;
                        else
                        {
                            DataGridColumnStyle dgcs = null;
                            if (property.PropertyType == typeof(bool))
                            {
                                dgcs = new DataGridBoolColumn();
                            }
                            else
                            {
                                dgcs = new DataGridTextBoxColumn();
                                dgcs.Width = 200;
                            }
                            dgcs.MappingName = property.Name;
                            dgcs.HeaderText = DataGridDictionary.Instance.GetDataGridPropertyTitle(string.Format("{0}.{1}", t.FullName, property.Name));

                            dgts.GridColumnStyles.Add(dgcs);
                            break;
                        }
                    }
                }
            }

            return dgts;
        }
    }
}
