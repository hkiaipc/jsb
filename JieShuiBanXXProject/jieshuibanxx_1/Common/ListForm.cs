using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace jieshuibanxx_1.Common
{
    public partial class ListForm : BaseForm
    {
        public ListForm()
        {
            InitializeComponent();
        }
        private void Init()
        {
            dgMain.CurrentCellChanged += new EventHandler(dgMain_CurrentCellChanged);
            dgMain.MouseDown += new MouseEventHandler(dgMain_MouseDown);
            dgMain.DoubleClick += new EventHandler(dgMain_DoubleClick);
            RefreshCommands();
        }
        public virtual void RefreshCommands()
        {
            this.tsTool.SuspendLayout();
            this.tsTool.Items.Clear();
            ToolBarCommand[] commands = this.GetCommands();
            if (commands != null)
            {
                foreach (ToolBarCommand command in commands)
                {
                    if (command == null)
                    {
                        ToolStripSeparator tss = new ToolStripSeparator();
                        tss.Margin = new Padding(10, 0, 10, 0);
                        this.tsTool.Items.Add(tss);
                        continue;
                    }
                    ToolStripButton tbc = ToolStripButtonBuilder.BuildToolStripButton(command);
                    tbc.Click += new EventHandler(tbc_Click);
                    this.tsTool.Items.Add(tbc);
                }
            }
            this.tsTool.ResumeLayout();
        }
        public virtual ToolBarCommand[] GetCommands()
        {
            List<ToolBarCommand> commands = new List<ToolBarCommand>();
            AddCommands(commands);
            return commands.ToArray();
        }
        public virtual void AddCommands(List<ToolBarCommand> commands)
        {

        }
        private void tbc_Click(object sender, EventArgs e)
        {
            ((ToolBarCommand)((ToolStripButton)sender).Tag).Command();
        }
        private void dgMain_CurrentCellChanged(object sender, EventArgs e)
        {
            this.SetLogic();
        }

        private void dgMain_MouseDown(object sender, MouseEventArgs e)
        {
            if (dgMain.CurrentRowIndex == 0)
                SetLogic();
        }

        protected virtual void SetLogic()
        {
        }

        protected virtual void dgMain_DoubleClick(object sender, EventArgs e)
        {

        }

        protected void SetRecordsCount(int recordCount)
        {
            lblRecord.Text = string.Format("当前一共检索出 {0} 条记录", recordCount);
        }

        private void ListForm_Load(object sender, EventArgs e)
        {
            Init();
        }

        
    }
}
