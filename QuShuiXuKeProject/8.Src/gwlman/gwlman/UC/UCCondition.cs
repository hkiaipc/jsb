using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Xdgk.Common;

namespace gwlman
{
    public partial class UCCondition : UserControl
    {
        private int _conditionCount = 1;
        private string _cmbBaseName = "cmbCondition";
        private string _txtBaseName = "txtValue";
        private int _height = -1;
        private int _min = 1;
        private int _max = 5;

        /// <summary>
        /// 
        /// </summary>
        public UCCondition()
        {
            InitializeComponent();
            _height = txtValue1.Size.Height + 4;
            SetCmbConditionDataSource(this.cmbCondition1);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (_conditionCount < _max)
            {
                // create cmb and text
                //
                ComboBox cmb = new ComboBox();
                _conditionCount++;
                cmb.Name = _cmbBaseName + _conditionCount;
                SetCmbConditionDataSource(cmb);
                cmb.Size = cmbCondition1.Size;
                cmb.Location = GetConditionLocation(_conditionCount);
                cmb.DropDownStyle = ComboBoxStyle.DropDownList;
                this.Controls.Add(cmb);

                TextBox txt = new TextBox();
                txt.Name = _txtBaseName + _conditionCount;
                txt.Size = txtValue1.Size;
                txt.Location = GetTxtLocation(_conditionCount);
                this.Controls.Add(txt);

                // set control position
                //

                // set btn position 
                //
                btnAdd.Location = new Point(btnAdd.Location.X, btnAdd.Location.Y + _height);
                btnDelete.Location = new Point(btnDelete.Location.X, btnDelete.Location.Y + _height);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="cmb"></param>
        private void SetCmbConditionDataSource(ComboBox cmb)
        {
            cmb.DisplayMember = "Key";
            cmb.ValueMember = "Value";
            cmb.DataSource = GetConditionDataSource();
        }

        private Point GetTxtLocation(int n)
        {
            return new Point(
                txtValue1.Location.X,
                txtValue1.Location.Y + (n - 1) * _height);
        }

        private Point GetConditionLocation(int n)
        {
            return new Point(
                cmbCondition1.Location.X,
                cmbCondition1.Location.Y + (n - 1) * _height
                );
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        private object GetConditionDataSource()
        {
            return ConditionDataSourceProvider.CreateDataSource();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (_conditionCount > _min)
            {
                string cmbKey = _cmbBaseName + _conditionCount;
                Control[] cs = this.Controls.Find(cmbKey, false);

                if (cs.Length > 0)
                {
                    this.Controls.Remove(cs[0]);
                }

                string txtKey = _txtBaseName + _conditionCount;
                cs = this.Controls.Find(txtKey, false);
                if (cs.Length > 0)
                {
                    this.Controls.Remove(cs[0]);
                }
                _conditionCount--;

                btnAdd.Location = new Point(btnAdd.Location.X, btnAdd.Location.Y - _height);
                btnDelete.Location = new Point(btnDelete.Location.X, btnDelete.Location.Y - _height);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public KeyValueCollection GetConditionKeyValues()
        {
            KeyValueCollection kvs = new KeyValueCollection();
            for (int i = 1; i <= _conditionCount; i++)
            {
                ComboBox cmb = (ComboBox)this.Controls.Find(_cmbBaseName + i, false)[0];
                TextBox txt = (TextBox)this.Controls.Find(_txtBaseName + i, false)[0];
                if (txt.Text.Trim().Length > 0)
                {
                    if (!ExistKey(kvs, cmb.SelectedValue.ToString()))
                    {
                        kvs.Add(new KeyValue(cmb.SelectedValue.ToString(), txt.Text.Trim()));
                    }
                }
            }
            return kvs;
        }

        private bool ExistKey(KeyValueCollection kvs, string key)
        {
            foreach (KeyValue kv in kvs)
            {
                if (kv.Key == key)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
