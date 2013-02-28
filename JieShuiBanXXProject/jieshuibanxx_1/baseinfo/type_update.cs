using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using data_define;
using Common;
using jieshuibanxx_1.Common;

namespace jieshuibanxx_1.baseinfo
{
    public partial class type_update : Common.DetailForm
    {
        protected data_define.type _definetype;
        protected operation.o_type oper_type;
        public type_update(data_define.type define_type)
        {
            InitializeComponent();
            oper_type = new operation.o_type();
            _definetype=new data_define.type();
            _definetype = define_type;
        }
        private void type_update_Load(object sender, EventArgs e)
        {
            SetTitle("行业大类修改");
            this.type_name.Text = _definetype.type_name;
            AddRequiredTextItem(this.type_name, "行业大类不能为空");
        }
        public override void AddCommands(List<ToolBarCommand> commands)
        {
            base.AddCommands(commands);
            commands.Insert(0, tbcCancel);
            commands.Insert(1,tblUpdate);
        }
        protected void SetReadonlyControl()
        {
            SetReadOnly(this.type_name, true, Color.White);
        }
        public void GetFormToType()
        {
            _definetype.type_name = this.type_name.Text;
        }
        private void tblUpdate_Commanded(object sender, EventArgs e)
        {
            if (!base.Validate())
            {
                return;
            }
            GetFormToType();
            if (oper_type.update(_definetype))
            {
                MsgHelper.ShowInformationMsgBox("修改行业大类成功！");
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                MsgHelper.ShowInformationMsgBox("修改行业大类失败！");
            }
        }

        
    }
}
