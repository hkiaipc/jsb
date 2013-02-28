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
    public partial class makeoverclass_view : Common.DetailForm
    {
        protected data_define.makeover_class _definemakeoverclass;
        protected operation.o_makeoverclass oper_makeoverclass;
        public makeoverclass_view(data_define.makeover_class define_makeoverclass)
        {
            InitializeComponent();
            oper_makeoverclass = new operation.o_makeoverclass();
            _definemakeoverclass = new data_define.makeover_class();
            _definemakeoverclass = define_makeoverclass;
        }
        public override void AddCommands(List<ToolBarCommand> commands)
        {
            base.AddCommands(commands);
            commands.Insert(0, tbcCancel);
            
        }
        public void GetFormToType()
        {
            _definemakeoverclass.makeover_class_name = this.makeoverclass_name.Text;
        }
        protected void SetReadonlyControl()
        {
            SetReadOnly(this.makeoverclass_name, false, Color.White);
        }

        private void makeoverclass_view_Load(object sender, EventArgs e)
        {
            SetTitle("技改分类");
            this.makeoverclass_name.Text = _definemakeoverclass.makeover_class_name;
        }
    }
}
