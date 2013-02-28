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
    public partial class getwaterkind_update : Common.DetailForm
    {
        protected data_define.getwater_kind _definegetwaterkind;
        protected operation.o_getwaterkind oper_getwaterkind;
        public getwaterkind_update(data_define.getwater_kind define_getwaterkind)
        {
            InitializeComponent();
            oper_getwaterkind = new operation.o_getwaterkind();
            _definegetwaterkind = new data_define.getwater_kind();
            _definegetwaterkind = define_getwaterkind;
        }
        public override void AddCommands(List<ToolBarCommand> commands)
        {
            base.AddCommands(commands);
            commands.Insert(0, tbcCancel);
            commands.Insert(1, tbcUpdate);
        }
        public void GetFormToType()
        {
            _definegetwaterkind.getwater_kind_name = this.getwaterkind_name.Text;
        }
        protected void SetReadonlyControl()
        {
            SetReadOnly(this.getwaterkind_name, true, Color.White);
        }
        private void tbcUpdate_Commanded(object sender, EventArgs e)
        {
            if (!base.Validate())
            {
                return;
            }
            GetFormToType();
            if (oper_getwaterkind.update(_definegetwaterkind))
            {
                MsgHelper.ShowInformationMsgBox("修改取水性质成功！");
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                MsgHelper.ShowInformationMsgBox("修改取水性质失败！");
            }
        }

        private void getwaterkind_update_Load(object sender, EventArgs e)
        {
            SetTitle("取水性质");
            this.getwaterkind_name.Text = _definegetwaterkind.getwater_kind_name;
            AddRequiredTextItem(this.getwaterkind_name, "取水性质不能为空");
        }
    }
}
