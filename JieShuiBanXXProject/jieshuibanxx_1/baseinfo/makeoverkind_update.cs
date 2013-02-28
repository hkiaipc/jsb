using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Common;
using jieshuibanxx_1.Common;

namespace jieshuibanxx_1.baseinfo
{
    public partial class makeoverkind_update : Common.DetailForm
    {
        protected data_define.makeover_kind _definemakeoverkind;
        protected operation.o_makeoverkind oper_makeoverkind;
        public makeoverkind_update(data_define.makeover_kind define_makeoverkind)
        {
            InitializeComponent();
            oper_makeoverkind = new operation.o_makeoverkind();
            _definemakeoverkind = new data_define.makeover_kind();
            _definemakeoverkind = define_makeoverkind;
        }
        public override void AddCommands(List<ToolBarCommand> commands)
        {
            base.AddCommands(commands);
            commands.Insert(0, tbcCancel);
            commands.Insert(1, tbcUpdate);
        }
        public void GetFormToType()
        {
            _definemakeoverkind.makeover_kindname = this.makeoverkind_name.Text;
        }
        protected void SetReadonlyControl()
        {
            SetReadOnly(this.makeoverkind_name, true, Color.White);
        }
        private void tbcUpdate_Commanded(object sender, EventArgs e)
        {
            if (!base.Validate())
            {
                return;
            }
            GetFormToType();
            if (oper_makeoverkind.update(_definemakeoverkind))
            {
                MsgHelper.ShowInformationMsgBox("修改技改类型成功！");
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                MsgHelper.ShowInformationMsgBox("修改技改类型失败！");
            }
        }

        private void makeoverkind_update_Load(object sender, EventArgs e)
        {
            SetTitle("技改类型");
            this.makeoverkind_name.Text = _definemakeoverkind.makeover_kindname;
            AddRequiredTextItem(this.makeoverkind_name, "技改类型不能为空");
        }
    }
}
