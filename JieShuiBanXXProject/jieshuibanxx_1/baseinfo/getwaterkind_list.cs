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
    public partial class getwaterkind_list : Common.ListForm
    {
        protected object m_CurrentNode;
        operation.o_getwaterkind data_getwaterkind = new operation.o_getwaterkind();
        private data_define.getwater_kind _getwaterkind = new data_define.getwater_kind();
        public getwaterkind_list()
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
            _getwaterkind.getwater_kind_id = 0;
            _getwaterkind.getwater_kind_name = "";

            this.dgMain.DataSource = new SortList(data_getwaterkind.dt(_getwaterkind));
            DataGridStyleHelper.SetStyle(dgMain, typeof(data_define.getwater_kind));
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
            getwaterkind_add _add = new getwaterkind_add();
            _add.ShowDialog();
            BindGridData();
        }

        private void tbcView_Commanded(object sender, EventArgs e)
        {
            GetSelectNode();

            if (m_CurrentNode == null)
            {
                return;
            }
            getwaterkind_view view = new getwaterkind_view(m_CurrentNode as data_define.getwater_kind);
            view.ShowDialog();
        }

        private void tbcModify_Commanded(object sender, EventArgs e)
        {
            GetSelectNode();

            if (m_CurrentNode == null)
            {
                return;
            }
            getwaterkind_update update = new getwaterkind_update(m_CurrentNode as data_define.getwater_kind);
            update.ShowDialog();
            BindGridData();
        }

        private void getwaterkind_list_Load(object sender, EventArgs e)
        {
            SetTitle("取水性质");
            BindGridData();
        }
    }
}
