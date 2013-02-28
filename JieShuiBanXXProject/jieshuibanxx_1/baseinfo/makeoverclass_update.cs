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
    public partial class makeoverclass_update : Common.DetailForm
    {
        protected data_define.makeover_class _definemakeoverclass;
        protected operation.o_makeoverclass oper_makeoverclass;
        public makeoverclass_update(data_define.makeover_class define_makeoverclass)
        {
            InitializeComponent();
            oper_makeoverclass= new operation.o_makeoverclass();
            _definemakeoverclass = new data_define.makeover_class();
            _definemakeoverclass = define_makeoverclass;
        }
        public override void AddCommands(List<ToolBarCommand> commands)
        {
            base.AddCommands(commands);
            commands.Insert(0, tbcCancel);
            commands.Insert(1, tbcUpdate);
        }
        public void GetFormToType()
        {
            _definemakeoverclass.makeover_class_name = this.makeoverclass_name.Text;
        }
        protected void SetReadonlyControl()
        {
            SetReadOnly(this.makeoverclass_name, true, Color.White);
        }
        private void makeoverclass_update_Load(object sender, EventArgs e)
        {
            SetTitle("技改分类");
            this.makeoverclass_name.Text = _definemakeoverclass.makeover_class_name;
            AddRequiredTextItem(this.makeoverclass_name, "技改分类不能为空");
        }

        private void tbcUpdate_Commanded(object sender, EventArgs e)
        {
            if (!base.Validate())
            {
                return;
            }
            GetFormToType();
            if (oper_makeoverclass.update(_definemakeoverclass))
            {
                MsgHelper.ShowInformationMsgBox("修改技改分类成功！");
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                MsgHelper.ShowInformationMsgBox("修改技改分类失败！");
            }
        }
    }
}
