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
    public partial class trade_update : Common.DetailForm
    {
        protected data_define.trade _definetrade;
        protected operation.o_trade oper_trade;
        public trade_update(data_define.trade define_trade)
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
            commands.Insert(0, tblUpdate);
        }
        public void GetFormToType()
        {
            _definetrade.trade_name = this.trade_name.Text;
            _definetrade.type_id = int.Parse(this.type_name.SelectedValue.ToString());
        }
        protected void SetReadonlyControl()
        {
            SetReadOnly(this.trade_name, true, Color.White);
        }
        private void tblUpdate_Commanded(object sender, EventArgs e)
        {
            if (!base.Validate())
            {
                return;
            }
            GetFormToType();
            if (oper_trade.update(_definetrade))
            {
                MsgHelper.ShowInformationMsgBox("修改行业大类成功！");
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                MsgHelper.ShowInformationMsgBox("修改行业大类失败！");
            }
        }

        private void trade_update_Load(object sender, EventArgs e)
        {
            SetTitle("行业修改");
            this.type_name.SelectedValue = _definetrade.type_id;
            this.trade_name.Text = _definetrade.trade_name;
            AddRequiredTextItem(this.trade_name, "行业名称不能为空");
        }
    }
}
