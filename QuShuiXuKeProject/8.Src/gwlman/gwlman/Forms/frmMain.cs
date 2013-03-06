using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using gwlDB;
using Xdgk.Common;

namespace gwlman
{
    public partial class frmMain : Form
    {
        /// <summary>
        /// 
        /// </summary>
        public frmMain()
        {
            InitializeComponent();
            this.ucConditionWrapper1.SearchEvent += new EventHandler(ucConditionWrapper1_SearchEvent);
            this.ucConditionWrapper1.Visible = tsbFind.Checked;
            this.Text = System.Configuration.ConfigurationSettings.AppSettings["Text"];
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void ucConditionWrapper1_SearchEvent(object sender, EventArgs e)
        {
            Fill();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mnuAbout_Click(object sender, EventArgs e)
        {
            string msg = string.Format("{0}\r\n\r\nV{1}", 
                System.Configuration.ConfigurationSettings.AppSettings["Text"],
                Application.ProductVersion);
            NUnit.UiKit.UserMessage.DisplayInfo(msg);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mnuExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsbAdd_Click(object sender, EventArgs e)
        {
            frmGwlItem f = new frmGwlItem();
            if (f.ShowDialog() == DialogResult.OK)
            {
                Fill();
            }
        }

        /// <summary>
        /// 
        /// </summary>
        private void Fill()
        {
            DB db = DBFactory.CreateDB();

            this.dataGridView1.DataSource = GetGwlDataSource(db);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        private object GetGwlDataSource(DB db)
        {
            var q = from s in db.tblGwl
                    select s;

            List<tblGwl> list = q.ToList();
            if (tsbFind.Checked)
            {
                KeyValueCollection kvs = ucConditionWrapper1.GetConditionKeyValues();
                list = Match(list, kvs);
            }
            return list;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="list"></param>
        /// <param name="kvs"></param>
        /// <returns></returns>
        private List<tblGwl> Match(List<tblGwl> list, KeyValueCollection kvs)
        {
            List<tblGwl> r = new List<tblGwl>();
            foreach (tblGwl item in list)
            {
                if (Match(item, kvs))
                {
                    r.Add(item);
                }
            }
            return r;

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="item"></param>
        /// <param name="kvs"></param>
        /// <returns></returns>
        private bool Match(tblGwl gwl, KeyValueCollection kvs)
        {
            foreach (KeyValue kv in kvs)
            {
                if (Match(gwl, kv.Key, kv.Value.ToString()))
                {

                }
                else
                {
                    return false;
                }
            }
            return true;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="gwl"></param>
        /// <param name="propertyName"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        private bool Match(tblGwl gwl, string propertyName, string value)
        {
            string propertyValue = ReflectionHelper.GetPropertyValue(gwl, propertyName).ToString();
            if (propertyValue.Contains(value))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        private void SetDataGridViewColumns()
        {
            Debug.Assert(this.dataGridView1.Columns.Count == 0);
            object[] list = new object[] {
                "Serial", "编号", typeof(string),
                "CompanyName", "单位名称", typeof(string),
                "CompanyAddress", "单位地址", typeof(string),
                "LegalPerson", "法人", typeof(string),
                "Contact", "联系人", typeof(string),
                "Phone", "联系电话", typeof(string),
                "Email", "电子邮箱", typeof(string),
                "Usage", "用途", typeof(string),
                "AskingAmount", "年申请取水量(万m3)", typeof(string),
                "GwAmount", "取水量(万m3)", typeof(string),
                "GwLocation", "取水地点", typeof(string),
                "GwMode", "取水方式", typeof(string),
                "WaterSourceMode", "水源类型", typeof(string),
                "BwLocation", "退水地点", typeof(string),
                "BwMode", "退水方式", typeof(string),
                "BwAmount", "退水量(d/t)", typeof(string),
                "BwQuality", "退水质量要求", typeof(string),
                "WellCount", "井数", typeof(string),
            };

            for (int i = 0; i < list.Length; i += 3)
            {
                DataGridViewTextBoxColumn col = new DataGridViewTextBoxColumn();
                col.HeaderText = list[i + 1].ToString();
                col.DataPropertyName = list[i].ToString();
                this.dataGridView1.Columns.Add(col);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmMain_Load(object sender, EventArgs e)
        {
            this.dataGridView1.AutoGenerateColumns = false;
            SetDataGridViewColumns();
            Fill();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        private tblGwl SelectedGwl()
        {
            if (this.dataGridView1.SelectedCells.Count > 0)
            {
                int rowIndex = this.dataGridView1.SelectedCells[0].RowIndex;
                tblGwl gwl = (tblGwl)this.dataGridView1.Rows[rowIndex].DataBoundItem;
                return gwl;
            }
            return null;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsbEdit_Click(object sender, EventArgs e)
        {
            tblGwl gwl = SelectedGwl();

            if (gwl != null)
            {
                frmGwlItem f = new frmGwlItem(gwl.GwlID);
                if (f.ShowDialog() == DialogResult.OK)
                {
                    Fill();
                }
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsbDelete_Click(object sender, EventArgs e)
        {
            tblGwl gwl = SelectedGwl();
            if (gwl != null)
            {
                if (NUnit.UiKit.UserMessage.Ask("确定删除吗?") == DialogResult.Yes)
                {
                    DB db = DBFactory.CreateDB();
                    db.tblGwl.DeleteOnSubmit(db.tblGwl.Single(c => c.GwlID == gwl.GwlID));
                    db.SubmitChanges();

                    Fill();
                }
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsbFind_Click(object sender, EventArgs e)
        {
            this.tsbFind.Checked = !this.tsbFind.Checked;
            this.ucConditionWrapper1.Visible = this.tsbFind.Checked;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsbRefresh_Click(object sender, EventArgs e)
        {
            Fill();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            tsbEdit_Click(null, null);
        }
    }
}
