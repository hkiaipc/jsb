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
    public partial class trade_view : Common.DetailForm
    {
        protected data_define.trade _definetrade;
        protected operation.o_trade oper_trade;
        public trade_view(data_define.trade define_trade)
        {
            InitializeComponent();
            _definetrade = new data_define.trade();
            _definetrade = define_trade;

            operation.o_type oper_type = new operation.o_type();
            //this
            this.type_name.DataSource = oper_type.type_dt(0).DefaultView;
            this.type_name.ValueMember = "type_id";
            this.type_name.DisplayMember = "type_name";
        }
        public override void AddCommands(List<ToolBarCommand> commands)
        {
            base.AddCommands(commands);
            commands.Insert(0, tbcCancel);
        }

        private void trade_view_Load(object sender, EventArgs e)
        {
            SetTitle("行业查看");
            this.type_name.SelectedValue = _definetrade.type_id;
            this.trade_name.Text = _definetrade.trade_name;
        }

        private void tbcCancel_Commanded(object sender, EventArgs e)
        {
            if (MsgHelper.ShowQuestionMsgBox("你要取消本次操作吗?") == DialogResult.Yes)
            {
                this.DialogResult = DialogResult.OK;
            }
        }
    }
}
