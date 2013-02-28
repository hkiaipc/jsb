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
    public partial class makeoverkind_view : Common.DetailForm
    {
        protected data_define.makeover_kind _definemakeoverkind;
        protected operation.o_makeoverkind oper_makeoverkind;
        public makeoverkind_view(data_define.makeover_kind define_makeoverkind)
        {
            InitializeComponent();
            oper_makeoverkind = new operation.o_makeoverkind();
            _definemakeoverkind = new data_define.makeover_kind();
            _definemakeoverkind = define_makeoverkind;
        }
        public override void AddCommands(List<ToolBarCommand> commands)
        {
            base.AddCommands(commands);
            commands.Insert(0, tbcCancel);

        }
        public void GetFormToType()
        {
            _definemakeoverkind.makeover_kindname = this.makeoverkind_name.Text;
        }
        protected void SetReadonlyControl()
        {
            SetReadOnly(this.makeoverkind_name, false, Color.White);
        }

        private void makeoverkind_view_Load(object sender, EventArgs e)
        {
            SetTitle("技改类型");
            this.makeoverkind_name.Text = _definemakeoverkind.makeover_kindname;
        }
    }
}
