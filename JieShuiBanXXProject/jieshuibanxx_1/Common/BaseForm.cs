using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Common.Validate;
using Common;

namespace jieshuibanxx_1.Common
{
    public partial class BaseForm : Form
    {
        protected Validater validater;
        public BaseForm()
        {
            InitializeComponent();
            validater = new Validater();
            this.FormClosing+=new FormClosingEventHandler(BaseForm_FormClosing);
        }
        void BaseForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
        #region 验证方法
        public void AddRequiredTextItem(Control control, string requiredErrorMessage)
        {
            validater.AddRequiredTextItem(control, requiredErrorMessage);
        }
        public void AddRequiredTextItem(Control control, string requiredErrorMessage, string regex, string regexErrorMessage)
        {
            validater.AddRequiredTextItem(control, requiredErrorMessage, regex, regexErrorMessage);
        }
        public void AddUnRequriedTextItem(Control control, string regex, string regexErrorMessage)
        {
            validater.AddUnRequiredTextItem(control, regex, regexErrorMessage);
        }

        public void AddCustomValidator(ExecuteValidate validateExecuter)
        {
            validater.AddCustomValidater(validateExecuter);
        }

        public new bool Validate()
        {
            string errorMessage;
            if (!validater.Validate(out errorMessage))
            {
                MsgHelper.ShowInformationMsgBox(errorMessage);
                return false;
            }
            return true;
        }
        #endregion

        private void BaseForm_Load(object sender, EventArgs e)
        {
            this.BackColor = System.Drawing.Color.WhiteSmoke;
        }
        /// <summary>
        /// 设置标题
        /// </summary>
        /// <param name="title"></param>
        public void SetTitle(string title)
        {
            this.Text = title;
        }

    }
}
