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
    public partial class makeoverkind_list : Common.ListForm
    {
        protected object m_CurrentNode;
        operation.o_makeoverkind data_makeoverkind = new operation.o_makeoverkind();
        private data_define.makeover_kind _makeoverkind = new data_define.makeover_kind();
        public makeoverkind_list()
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
        protected virtual void BindGridData()
        {

            DataTable dt = new DataTable();
            //data_define.type _type = new data_define.type();
            _makeoverkind.makeover_kindid = 0;
            _makeoverkind.makeover_kindname = "";

            this.dgMain.DataSource = new SortList(data_makeoverkind.dt(_makeoverkind));
            DataGridStyleHelper.SetStyle(dgMain, typeof(data_define.makeover_kind));
            SetRecordsCount((dgMain.DataSource as SortList).Count);
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
            makeoverkind_add _add = new makeoverkind_add();
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
            makeoverkind_update update = new makeoverkind_update(m_CurrentNode as data_define.makeover_kind);
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
            makeoverkind_view view = new makeoverkind_view(m_CurrentNode as data_define.makeover_kind);
            view.ShowDialog();
        }

        private void makeoverkind_list_Load(object sender, EventArgs e)
        {
            SetTitle("技改类型");
            BindGridData();
        }
    }
}
