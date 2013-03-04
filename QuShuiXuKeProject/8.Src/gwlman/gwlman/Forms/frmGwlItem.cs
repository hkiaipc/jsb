using System;
using System.Diagnostics;
using System.Data.Linq;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Xdgk.Common;
using gwlDB;

namespace gwlman
{
    using Path = System.IO.Path;
    public partial class frmGwlItem : Form, IAddEdit
    {
        private ADEStatus _adeStatus;
        private int _gwlID;
        private string _path;

        public frmGwlItem()
        {
            this._adeStatus = ADEStatus.Add;

            InitializeComponent();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        public frmGwlItem(int id)
        {
            this._adeStatus = ADEStatus.Edit;
            this._gwlID = id;

            InitializeComponent();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        private DB GetDB()
        {
            if (_db == null)
            {
                _db = DBFactory.GetDB();
            }
            return _db;
        } private DB _db;

        #region IAddEdit 成员

        public ADEStatus AdeStatus
        {
            get { return _adeStatus; }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public bool Add()
        {
            if (!CheckInput())
            {
                return false;
            }

            tblGwl g = GetGwl();

            g.Serial = txtSerial.Text;
            g.CompanyName = txtCompanyName.Text;
            g.CompanyAddress = txtCompanyAddress.Text;
            g.LegalPerson = txtLegalPerson.Text;
            g.Contact = txtContact.Text;
            g.Phone = txtPhone.Text;
            g.Email = txtEmail.Text;
            g.ValidDate = txtValidDate.Text;
            g.ApproveDate = txtApproveDate.Text;

            g.Usage = txtUsage.Text;
            g.AskingAmount = numAskingAmount.Value;
            g.GwAmount = numAskingAmount.Value;
            g.GwLocation = txtGwLocation.Text;
            g.GwMode = txtGwMode.Text;
            g.WaterSourceMode = txtWaterSourceMode.Text;

            g.BwLocation = txtBwLocation.Text;
            g.BwQuality = txtBwQuality.Text;
            g.BwMode = txtBwMode.Text;
            g.BwAmount = numBwAmount.Value;

            g.WellCount = (int)numWellCount.Value;

            g.Remark = txtRemark.Text;

            g.AttachmentFileName = txtAttachmentFileName.Text;
            g.Attachment = GetAttachmentBinary(_path);


            GetDB().tblGwl.InsertOnSubmit(g);
            GetDB().SubmitChanges();
            return true;

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        private System.Data.Linq.Binary GetAttachmentBinary(string path)
        {
            byte[] bs = File.ReadAllBytes(path);
            Binary binary = new Binary(bs);
            return binary;
        }

        public bool Edit()
        {
            return false;
        }

        #endregion

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOK_Click(object sender, EventArgs e)
        {
            bool r = false;
            if (this.AdeStatus == ADEStatus.Add)
            {
                r = Add();
            }
            else if (this.AdeStatus == ADEStatus.Edit)
            {
                r = Edit();
            }

            if (r)
            {
                this.DialogResult = DialogResult.OK;
                Close();
            }
        }

        #region IAddEdit 成员


        private tblGwl GetGwl()
        {
            if (_gwl == null)
            {
                DB db = GetDB();
                if (this._adeStatus == ADEStatus.Add)
                {
                    _gwl = new tblGwl();
                }
                else if (this._adeStatus == ADEStatus.Edit)
                {
                    _gwl = db.tblGwl.Single(c => c.GwlID == _gwlID);
                }
            }
            return _gwl;
        } private tblGwl _gwl = null;

        /// <summary>
        /// 
        /// </summary>
        public void Fill()
        {
            tblGwl g = GetGwl();

            txtSerial.Text = g.Serial;
            txtCompanyName.Text = g.CompanyName;
            txtCompanyAddress.Text = g.CompanyAddress;
            txtLegalPerson.Text = g.LegalPerson;
            txtContact.Text = g.Contact;
            txtPhone.Text = g.Phone;
            txtEmail.Text = g.Email;
            txtValidDate.Text = g.ValidDate;
            txtApproveDate.Text = g.ApproveDate;

            txtUsage.Text = g.Usage;
            numAskingAmount.Value = g.AskingAmount;
            numAskingAmount.Value = g.GwAmount;
            txtGwLocation.Text = g.GwLocation;
            txtGwMode.Text = g.GwMode;
            txtWaterSourceMode.Text = g.WaterSourceMode;

            txtBwLocation.Text = g.BwLocation;
            txtBwQuality.Text = g.BwQuality;
            txtBwMode.Text = g.BwMode;
            numBwAmount.Value = g.BwAmount;

            numWellCount.Value = g.WellCount;

            txtRemark.Text = g.Remark;

            txtAttachmentFileName.Text = g.AttachmentFileName;

            // 
            // 
            //dgvWell.DataSource = GetWellDataSource();
        }

        /// <summary>
        /// 
        /// </summary>
        private void RefreshWell()
        {
            dgvWell.DataSource = GetWellDataSource();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="entitySet"></param>
        /// <returns></returns>
        private object GetWellDataSource()
        {
            foreach (tblWell w in GetGwl ().tblWell )
            {
                
            }
            return null;
        }


        #endregion

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAddAttachment_Click(object sender, EventArgs e)
        {
            FileDialog fd = new OpenFileDialog();
            fd.Filter = "*.doc|*.doc";
            if (fd.ShowDialog() == DialogResult.OK)
            {
                _path = fd.FileName;
                string filename = Path.GetFileName(_path);
                this.txtAttachmentFileName.Text = filename;

                Binary binary = File.ReadAllBytes(_path);
                GetGwl().Attachment = binary;

                this.SetAttachmentButtonState();
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDeleteAttachment_Click(object sender, EventArgs e)
        {
            tblGwl g = GetGwl();
            DialogResult dr = NUnit.UiKit.UserMessage.Ask("确定删除附件吗?");
            if (dr == DialogResult.Yes)
            {
                g.Attachment = null;
                g.AttachmentFileName = string.Empty;

                this.txtAttachmentFileName.Clear();

                SetAttachmentButtonState();
            }
        }

        /// <summary>
        /// 
        /// </summary>
        void SetAttachmentButtonState()
        {
            tblGwl gwl = GetGwl();
            bool isNull = gwl.Attachment == null;
            this.btnDeleteAttachment.Enabled = !isNull;
            this.btnView.Enabled = !isNull;

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnView_Click(object sender, EventArgs e)
        {
            tblGwl g = GetGwl();
            if (g.Attachment != null)
            {
                byte[] bytes = g.Attachment.ToArray();
                string path = Xdgk.Common.Path.GetTempFileName("doc");
                File.WriteAllBytes(path, bytes);

                Process process = new Process();
                ProcessStartInfo si = new ProcessStartInfo(path);
                si.ErrorDialog = true;
                process.StartInfo = si;
                process.Start();
            }
            else
            {
                NUnit.UiKit.UserMessage.DisplayFailure("没有附件");
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmGwlItem_Load(object sender, EventArgs e)
        {
            this.SetAttachmentButtonState();
            this.AssociateControl();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        private bool CheckInput()
        {
            foreach (Control ctrl in this.GetNotEmptyControls())
            {
                if (ctrl is TextBox)
                {
                    TextBox txt = (TextBox)ctrl;
                    if (txt.Text.Trim().Length == 0)
                    {
                        //txt.Focus();
                        FocusControl(txt);
                        Debug.Assert(txt.Tag != null);

                        string message = GetNotEmptyMessage((Label)txt.Tag);
                        NUnit.UiKit.UserMessage.DisplayFailure(message + " 不能为空" );
                        return false;
                    }
                }
            }
            return true;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="control"></param>
        private void FocusControl(Control control)
        {
            foreach (TabPage tp in this.tabControl1.TabPages)
            {
                if ( tp.Controls.Contains ( control ))
                {
                    tabControl1.SelectedTab = tp;
                    control.Focus();
                    return;
                }
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="label"></param>
        /// <returns></returns>
        private string GetNotEmptyMessage(Label label)
        {
            string text = label.Text;
            text = text.Replace (":", string.Empty );
            int b = text.IndexOf('(');
            int e = text.LastIndexOf(')');

            if (e > b)
            {
                text = text.Remove(b, e - b + 1);
            }
            return text;
        }

        private void numGwAmount_ValueChanged(object sender, EventArgs e)
        {

        }

        private void txtAttachmentFileName_TextChanged(object sender, EventArgs e)
        {

        }

        private void AssociateControl()
        {
            txtSerial.Tag = lblSerial;
            txtCompanyName.Tag = lblCompanyName;
            txtCompanyAddress.Tag = lblCompanyAddress;
            txtLegalPerson.Tag = lblLegalPerson;
            txtContact.Tag = lblContact;
            txtPhone.Tag = lblPhone;
            txtEmail.Tag = lblEmail;
            txtValidDate.Tag = lblValidDate;
            txtApproveDate.Tag = lblApproveDate;

            txtUsage.Tag = lblUsage;
            txtGwLocation.Tag = lblGwLocation;
            txtGwMode.Tag = lblGwMode;
            txtWaterSourceMode.Tag = lblWaterSourceMode;
            txtBwLocation.Tag = lblBwLocation;
            txtBwQuality.Tag = lblBwQuality;
            txtBwMode.Tag = lblBwMode;

            numAskingAmount.Tag = lblAskingAmount;
            numGwAmount.Tag = lblGwAmount;
            numBwAmount.Tag = lblBwAmount;

            numWellCount.Tag = lblWellCount;

            txtRemark.Tag = lblRemark;

            txtAttachmentFileName.Tag = lblAttachment;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        private Control[] GetNotEmptyControls()
        {
            if (_notEmptyControls == null)
            {
                _notEmptyControls = new Control[] { 
                    txtSerial,
                    txtCompanyName,
                    txtCompanyAddress,
                    txtLegalPerson,
                    txtContact,txtPhone,
                    txtUsage,
                    txtGwLocation,
                    txtGwMode,
                    txtWaterSourceMode, };
            }
            return _notEmptyControls;
        } private Control[] _notEmptyControls = null;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnWellAdd_Click(object sender, EventArgs e)
        {
            frmWellItem f = new frmWellItem(GetDB());
            if (f.ShowDialog() == DialogResult.OK)
            {
                GetGwl().tblWell.Add(f.GetWell());

                // TODO: refresh well source
                //
                //dgvWell.DataSource = GetWellDataSource ();
            }
        }

        private void btnWellDelete_Click(object sender, EventArgs e)
        {
            tblWell well = GetSelectedWell();

            if (well != null)
            {
                GetGwl().tblWell.Remove(well);
            }

            // TODO: refresh well
            //
        }

        private tblWell GetSelectedWell()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnWellEdit_Click(object sender, EventArgs e)
        {
            tblWell well = GetSelectedWell();
            if (well != null)
            {
                frmWellItem f = new frmWellItem(GetDB(), well);
                if (f.ShowDialog() == DialogResult.OK)
                {
                    // TODO: refresh
                    //
                }
            }
        }
    }
}
