using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using jieshuibanxx_1.Common;
using Common;

namespace jieshuibanxx_1.baseinfo
{
    public partial class makeoverclass_add : Common.DetailForm
    {
        protected data_define.makeover_class define_makeoverclass;
        protected operation.o_makeoverclass oper_makeoverclass;
        public makeoverclass_add()
        {
            InitializeComponent();
            define_makeoverclass = new data_define.makeover_class();
            oper_makeoverclass= new operation.o_makeoverclass();
        }
        public override void AddCommands(List<ToolBarCommand> commands)
        {
            base.AddCommands(commands);
            commands.Insert(0, tbcCancel);
            commands.Insert(1, tbcSave);
        }
        protected void SetReadonlyControl()
        {
            SetReadOnly(this.makeoverclass_name, true, Color.White);
        }
        public void GetFormToType()
        {
            define_makeoverclass.makeover_class_name = this.makeoverclass_name.Text;
        }

        private void tbcSave_Commanded(object sender, EventArgs e)
        {
            if (!base.Validate())
            {
                return;
            }
            GetFormToType();
            if (oper_makeoverclass.add(define_makeoverclass))
            {
                MsgHelper.ShowInformationMsgBox("添加技改分类成功！");
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                MsgHelper.ShowInformationMsgBox("添加技改分类失败！");
            }
        }

        private void makeoverclass_add_Load(object sender, EventArgs e)
        {
            SetTitle("技改分类添加");
            AddRequiredTextItem(this.makeoverclass_name, "技改分类不能为空");
        }

    }
}
