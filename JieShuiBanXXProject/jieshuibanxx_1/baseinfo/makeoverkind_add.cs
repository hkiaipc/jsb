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
    public partial class makeoverkind_add : Common.DetailForm
    {
        protected data_define.makeover_kind define_makeoverkind;
        protected operation.o_makeoverkind oper_makeoverkind;
        public makeoverkind_add()
        {
            InitializeComponent();
            define_makeoverkind = new data_define.makeover_kind();
            oper_makeoverkind = new operation.o_makeoverkind();
        }
        public override void AddCommands(List<ToolBarCommand> commands)
        {
            base.AddCommands(commands);
            commands.Insert(0, tbcCancel);
            commands.Insert(1, tbcSave);
        }
        protected void SetReadonlyControl()
        {
            SetReadOnly(this.makeoverkind_name, true, Color.White);
        }
        public void GetFormToType()
        {
            define_makeoverkind.makeover_kindname = this.makeoverkind_name.Text;
        }

        private void tbcSave_Commanded(object sender, EventArgs e)
        {
            if (!base.Validate())
            {
                return;
            }
            GetFormToType();
            if (oper_makeoverkind.add(define_makeoverkind))
            {
                MsgHelper.ShowInformationMsgBox("添加技改分类成功！");
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                MsgHelper.ShowInformationMsgBox("添加技改分类失败！");
            }
        }

        private void makeoverkind_add_Load(object sender, EventArgs e)
        {
            SetTitle("技改类型添加");
            AddRequiredTextItem(this.makeoverkind_name, "技改类型不能为空");
        }
    }
}
