using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

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
                cmb.DataSource = GetConditionDataSource();
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

        private Point GetTxtLocation(int n)
        {
            return new Point(
                txtValue1.Location.X ,
                txtValue1.Location.Y + (n - 1) * _height);
        }

        private Point GetConditionLocation(int n)
        {
            return new Point(
                cmbCondition1.Location.X ,
                cmbCondition1.Location.Y + (n - 1) * _height 
                );
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        private object GetConditionDataSource()
        {
            //throw new NotImplementedException();
            return null;
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
    }
}
