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
    public partial class trade_list :Common.ListForm
    {
        protected object m_CurrentNode;
        operation.o_trade data_trade = new operation.o_trade();
        private data_define.trade _trade = new data_define.trade();
        public trade_list()
        {
            InitializeComponent();
        }
        public override void AddCommands(List<ToolBarCommand> commands)
        {
            base.AddCommands(commands);
            commands.Insert(0, tbcAdd);
            commands.Insert(1, tbcModify);
            commands.Insert(2, tbcView);
        }

        private void trade_list_Load(object sender, EventArgs e)
        {
            SetTitle("行业子类");
            BindGridData();
        }
        protected virtual void BindGridData()
        {

            DataTable dt = new DataTable();
            //data_define.type _type = new data_define.type();
            _trade.trade_id = 0;
            _trade.type_id = 0;
            _trade.trade_name= "";

            this.dgMain.DataSource = new SortList(data_trade.dt(_trade));
            DataGridStyleHelper.SetStyle(dgMain, typeof(data_define.trade));
            SetRecordsCount(dt.Rows.Count);
        }
        protected override void dgMain_DoubleClick(object sender, EventArgs e)
        {
            GetSelectNode();
            if (m_CurrentNode == null)
            {
                return;
            }

            tbcView_Commanded(sender, e);
        }
        #region CommonMethod
        protected void GetSelectNode()
        {
            if (this.dgMain.DataSource == null)
            {
                m_CurrentNode = null;
                return;
            }

            if (this.dgMain.CurrentRowIndex == -1)
            {
                m_CurrentNode = null;
                return;
            }

            m_CurrentNode = this.dgMain.BindingContext[this.dgMain.DataSource].Current;
        }
        #endregion
        private void tbcAdd_Commanded(object sender, EventArgs e)
        {
            trade_add _add = new trade_add();
            _add.ShowDialog();
            BindGridData();
        }

        private void tbcModify_Commanded(object sender, EventArgs e)
        {
            GetSelectNode();

            if (m_CurrentNode == null)
            {
                return;
            }
            trade_update update = new trade_update(m_CurrentNode as data_define.trade);
            update.ShowDialog();
            BindGridData();
        }

        private void tbcView_Commanded(object sender, EventArgs e)
        {
            GetSelectNode();

            if (m_CurrentNode == null)
            {
                return;
            }
            trade_view view = new trade_view(m_CurrentNode as data_define.trade);
            view.ShowDialog();
        }

    }
}
