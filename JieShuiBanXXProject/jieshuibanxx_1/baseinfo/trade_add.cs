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
    public partial class trade_add : Common.DetailForm
    {
        protected operation.o_type oper_type = new operation.o_type();
        protected data_define.trade define_trade;
        public trade_add()
        {
            InitializeComponent();
            define_trade = new data_define.trade();
            this.type_name.DataSource = oper_type.type_dt(0).DefaultView;
            this.type_name.ValueMember = "type_id";
            this.type_name.DisplayMember = "type_name";
        }
        public override void AddCommands(List<ToolBarCommand> commands)
        {
            base.AddCommands(commands);
            commands.Insert(0, tbcCancel);
            commands.Insert(1, tbcSave);
        }
        public void GetFormToType()
        {
            define_trade.type_id = int.Parse(this.type_name.SelectedValue.ToString());
            define_trade.trade_name = this.trade_name.Text;
        }

        private void trade_add_Load(object sender, EventArgs e)
        {
            SetTitle("行业子类添加");
            AddRequiredTextItem(this.trade_name, "行业名称不能为空");
        }
        protected void SetReadonlyControl()
        {
            SetReadOnly(this.trade_name, true, Color.White);
        }

        private void tbcSave_Commanded(object sender, EventArgs e)
        {
            if (!base.Validate())
            {
                return;
            }
            GetFormToType();
            operation.o_trade oper_trade = new operation.o_trade();
            if (oper_trade.add(define_trade))
            {
                MsgHelper.ShowInformationMsgBox("添加行业成功！");
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                MsgHelper.ShowInformationMsgBox("添加行业失败！");
            }
        }
    }
}
