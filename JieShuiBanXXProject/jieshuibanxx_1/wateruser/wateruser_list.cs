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

namespace jieshuibanxx_1.wateruser
{
    public partial class wateruser_list : Common.ListForm
    {
        operation.o_wateruser data_wateruser = new operation.o_wateruser();
        private data_define.wateruser _wateruser = new data_define.wateruser();
        public wateruser_list()
        {
            InitializeComponent();
        }
        public override void AddCommands(List<ToolBarCommand> commands)
        {
            base.AddCommands(commands);
            commands.Insert(0, tbcAdd);
            commands.Insert(1, tbcModify);
            commands.Insert(2, tbcView);
            commands.Insert(3, tbcFind);
        }
        /// <summary>
        /// 绑定数据
        /// </summary>
        protected virtual void BindGridData()
        {

            DataTable dt = new DataTable();
            //data_define.type _type = new data_define.type();
            _wateruser.wateruser_id = 0;
            //_type.type_name = "";

            //this.dgMain.DataSource = new SortList(data_type.dt(_type));
            //DataGridStyleHelper.SetStyle(dgMain, typeof(data_define.type));
            //SetRecordsCount(dgMain);

        }
        protected override void dgMain_DoubleClick(object sender, EventArgs e)
        {
            GetSelectNode();
            //if (m_CurrentNode == null)
            {
                return;
            }

            //tbcView_Commanded(sender, e);
        }
        #region CommonMethod
        protected void GetSelectNode()
        {
            if (this.dgMain.DataSource == null)
            {
                //m_CurrentNode = null;
                return;
            }

            if (this.dgMain.CurrentRowIndex == -1)
            {
                //m_CurrentNode = null;
                return;
            }

            //m_CurrentNode = this.dgMain.BindingContext[this.dgMain.DataSource].Current;
        }
        #endregion
    }
}
