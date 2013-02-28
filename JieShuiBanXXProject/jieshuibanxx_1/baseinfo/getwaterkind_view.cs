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
    public partial class getwaterkind_view : Common.DetailForm
    {
        protected data_define.getwater_kind _definegetwaterkind;
        protected operation.o_getwaterkind oper_getwaterkind;
        public getwaterkind_view(data_define.getwater_kind define_getwaterkind)
        {
            InitializeComponent();
            oper_getwaterkind = new operation.o_getwaterkind();
            _definegetwaterkind = new data_define.getwater_kind();
            _definegetwaterkind = define_getwaterkind;
        }
        public override void AddCommands(List<ToolBarCommand> commands)
        {
            base.AddCommands(commands);
            commands.Insert(0, tbcCancel);
        }
        public void GetFormToType()
        {
            _definegetwaterkind.getwater_kind_name = this.getwaterkind_name.Text;
        }
        private void getwaterkind_view_Load(object sender, EventArgs e)
        {
            SetTitle("取水性质");
            this.getwaterkind_name.Text = _definegetwaterkind.getwater_kind_name;
        }
    }
}
