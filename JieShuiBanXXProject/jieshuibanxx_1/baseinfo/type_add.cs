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
    public partial class type_add :Common.DetailForm
    {
        protected data_define.type define_type;
        protected operation.o_type oper_type;
        public type_add()
        {
            InitializeComponent();
            define_type = new data_define.type();
            oper_type = new operation.o_type();
        }
        public override void AddCommands(List<ToolBarCommand> commands)
        {
            base.AddCommands(commands);
            commands.Insert(0, tbcCancel);
            commands.Insert(1, tbcSave);
        }
        private void type_add_Load(object sender, EventArgs e)
        {
            SetTitle("行业大类添加");
            AddRequiredTextItem(this.type_name, "行业大类不能为空");
        }
        protected void SetReadonlyControl()
        {
            SetReadOnly(this.type_name,true, Color.White);
        }
        public void GetFormToType()
        {
            define_type.type_name = this.type_name.Text;
        }

        private void tbcSave_Commanded(object sender, EventArgs e)
        {
            if (!base.Validate())
            {
                return;
            }
            GetFormToType();
            if (oper_type.add(define_type))
            {
                MsgHelper.ShowInformationMsgBox("添加行业大类成功！");
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                MsgHelper.ShowInformationMsgBox("添加行业大类失败！");
            }
        }

    }
}
