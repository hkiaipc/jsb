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
    public partial class getwaterkind_add : Common.DetailForm
    {
        protected data_define.getwater_kind define_getwaterkind;
        protected operation.o_getwaterkind oper_getwaterkind;
        public getwaterkind_add()
        {
            InitializeComponent();
            define_getwaterkind = new data_define.getwater_kind();
            oper_getwaterkind = new operation.o_getwaterkind();
        }
        public override void AddCommands(List<ToolBarCommand> commands)
        {
            base.AddCommands(commands);
            commands.Insert(0, tbcCancel);
            commands.Insert(1, tbcSave);
        }
        protected void SetReadonlyControl()
        {
            SetReadOnly(this.getwaterkind_name, true, Color.White);
        }
        public void GetFormToType()
        {
            define_getwaterkind.getwater_kind_name =this.getwaterkind_name.Text;
        }

        private void tbcSave_Commanded(object sender, EventArgs e)
        {
            if (!base.Validate())
            {
                return;
            }
            GetFormToType();
            if (oper_getwaterkind.add(define_getwaterkind))
            {
                MsgHelper.ShowInformationMsgBox("添加取水性质成功！");
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                MsgHelper.ShowInformationMsgBox("添加取水性质失败！");
            }
        }

        private void getwaterkind_add_Load(object sender, EventArgs e)
        {
            SetTitle("取水性质添加");
            AddRequiredTextItem(this.getwaterkind_name, "取水性质不能为空");
        }
    }
}
