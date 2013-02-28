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
    public partial class makeoverclass_list : Common.ListForm
    {
        protected object m_CurrentNode;
        operation.o_makeoverclass data_makeoverclass = new operation.o_makeoverclass();
        private data_define.makeover_class _makeoverclass = new data_define.makeover_class();
        public makeoverclass_list()
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
            _makeoverclass.makeover_classid = 0;
            _makeoverclass.makeover_class_name = "";

            this.dgMain.DataSource = new SortList(data_makeoverclass.dt(_makeoverclass));
            DataGridStyleHelper.SetStyle(dgMain, typeof(data_define.makeover_class));
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

        private void tbcView_Commanded(object sender, EventArgs e)
        {
            GetSelectNode();

            if (m_CurrentNode == null)
            {
                return;
            }
            makeoverclass_view view = new makeoverclass_view(m_CurrentNode as data_define.makeover_class);
            view.ShowDialog();
        }

        private void tbcModify_Commanded(object sender, EventArgs e)
        {
            GetSelectNode();

            if (m_CurrentNode == null)
            {
                return;
            }
            makeoverclass_update update = new makeoverclass_update(m_CurrentNode as data_define.makeover_class);
            update.ShowDialog();
            BindGridData();
        }

        private void tbcAdd_Commanded(object sender, EventArgs e)
        {
            makeoverclass_add _add = new makeoverclass_add();
            _add.ShowDialog();
            BindGridData();
        }

        private void makeoverclass_list_Load(object sender, EventArgs e)
        {
            SetTitle("技改分类");
            BindGridData();
        }
    }
}
