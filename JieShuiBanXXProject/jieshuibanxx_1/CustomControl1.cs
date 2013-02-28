using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace jieshuibanxx_1
{
    public partial class CustomControl1 :DataGridView
    {
        public CustomControl1()
        {
            InitializeComponent();
            CustomControl1 cc = new CustomControl1();
            this.label1.Text = "aa";
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
        }
       
    }
}
