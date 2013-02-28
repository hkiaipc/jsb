using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Common;

namespace jieshuibanxx_1.Common
{
    public partial class DetailForm : BaseForm
    {
        public DetailForm()
        {
            InitializeComponent();
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

        private void DetailForm_Load(object sender, EventArgs e)
        {
            RefreshCommands();
        }
        protected void SetReadOnly(TextBox control, bool isWrite, Color colors)
        {
            control.ReadOnly = isWrite;
            control.BackColor = colors;
        }
        protected void SetEnable(Control control, bool isEnable)
        {
            control.Enabled = isEnable;
        }

        private void tbcCancel_Commanded(object sender, EventArgs e)
        {
            if (MsgHelper.ShowQuestionMsgBox("你要取消本次操作吗?")==DialogResult.Yes)
            {
                this.DialogResult = DialogResult.OK;
            }
        }

    }
}
