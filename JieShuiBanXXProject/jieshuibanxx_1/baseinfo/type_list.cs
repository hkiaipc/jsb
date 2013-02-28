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
using data_define;
using operation;

namespace jieshuibanxx_1.baseinfo
{
    public partial class type_list:Common.ListForm
    {
        protected object m_CurrentNode;
        operation.o_type data_type = new operation.o_type();
        private data_define.type _type = new data_define.type();
        public type_list()
        {
            InitializeComponent();
        }

        private void type_list_Load(object sender, EventArgs e)
        {
            SetTitle("行业大类");
            BindGridData();
        }
        public override void AddCommands(List<ToolBarCommand> commands)
        {
            base.AddCommands(commands);
            commands.Insert(0, tbcAdd);
            commands.Insert(1, tbcModify);
            commands.Insert(2, tbcView);
        }

        private void tbcAdd_Commanded(object sender, EventArgs e)
        {
            type_add cc = new type_add();
            cc.ShowDialog();
            BindGridData();
        }

        /// <summary>
        /// 绑定数据
        /// </summary>
        protected virtual void BindGridData()
        {

            DataTable dt=new DataTable();
            //data_define.type _type = new data_define.type();
            _type.type_id=0;
            _type.type_name = "";

            this.dgMain.DataSource = new SortList(data_type.dt(_type));
            DataGridStyleHelper.SetStyle(dgMain, typeof(data_define.type));
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

        private void tbcModify_Commanded(object sender, EventArgs e)
        {
            GetSelectNode();

            if (m_CurrentNode == null)
            {
                return;
            }
            type_update update = new type_update(m_CurrentNode as data_define.type);
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
            type_view view = new type_view(m_CurrentNode as data_define.type);
            view.ShowDialog();
        }
    }
}
