using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using data_define;
using Common;
using jieshuibanxx_1.Common;

namespace jieshuibanxx_1.baseinfo
{
    public partial class type_view : Common.DetailForm
    {
        protected data_define.type _definetype;
        protected operation.o_type oper_type;
        public type_view(data_define.type define_type)
        {
            InitializeComponent();
            oper_type = new operation.o_type();
            _definetype = new data_define.type();
            _definetype = define_type;
        }
        public override void AddCommands(List<ToolBarCommand> commands)
        {
            base.AddCommands(commands);
            commands.Insert(0, tbcCancel);
        }

        private void type_view_Load(object sender, EventArgs e)
        {
            SetTitle("行业大类查询");
            this.type_name.Text = _definetype.type_name;
        }
    }
}
