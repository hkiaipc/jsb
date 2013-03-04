using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Xdgk.Common ;
using gwlDB;

namespace gwlman
{
    public partial class frmWellItem : Form , IAddEdit 
    {
        private tblWell _well;
        private DB _db;
        public frmWellItem(DB db )
        {
            InitializeComponent();
            _db = db;
            _adeStatus = ADEStatus.Add;
        }

        public frmWellItem(DB db, tblWell well)
        {
            _well = well;
            Fill();
        }

        public tblWell GetWell()
        {
            if (_well == null)
            {
                _well = new tblWell();
            }
            return _well;
        }

        #region IAddEdit 成员

        public Xdgk.Common.ADEStatus AdeStatus
        {
            get { return _adeStatus; }
        } private ADEStatus _adeStatus;

        public bool Add()
        {
            return AddOrEdit();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        private bool AddOrEdit ()
        {
            if (!CheckInput())
            {
                return false;
            }

            tblWell w = this.GetWell();
            w.WellSerial = txtSerial.Text.Trim();
            w.WellLocation = txtWaterSourceLocation.Text.Trim();
            w.WellRemark = txtRemark.Text.Trim();
            w.WellDepth = numDepth.Value;
            w.WellDiameter = numDiameter.Value;
            w.WellEffluentAmount = numEffluentAmount.Value;
            w.WellExtractAmount = numExtractAmount.Value;

            return true;
        }


        private bool CheckInput()
        {
            if (txtSerial.Text.Trim().Length ==0)
            {
                NUnit.UiKit.UserMessage.DisplayFailure("水井编号 不能为空");
                return false;
            }

            if (txtWaterSourceLocation.Text.Trim().Length == 0)
            {
                NUnit.UiKit.UserMessage.DisplayFailure("水源地点 不能为空");
                return false;
            }
            return true;
        }

        public bool Edit()
        {
            return AddOrEdit();
        }

        /// <summary>
        /// 
        /// </summary>
        public void Fill()
        {
            tblWell w =  GetWell();
            this.txtSerial.Text = w.WellSerial;
            txtWaterSourceLocation.Text = w.WellLocation;
            txtRemark.Text = w.WellRemark;

            numDepth.Value = w.WellDepth;
            numDiameter.Value = w.WellDiameter;
            numEffluentAmount.Value = w.WellEffluentAmount;
            numExtractAmount.Value = w.WellExtractAmount;
        }

        #endregion

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOK_Click(object sender, EventArgs e)
        {
            if (this._adeStatus == ADEStatus.Add)
            {
                Add();
            }
            else if (this._adeStatus == ADEStatus.Edit)
            {
                Edit();
            }

            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
