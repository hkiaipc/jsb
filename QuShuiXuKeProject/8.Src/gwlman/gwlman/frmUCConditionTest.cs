using System;
using Xdgk.Common;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace gwlman
{
    public partial class frmUCConditionTest : Form
    {
        public frmUCConditionTest()
        {
            InitializeComponent();
        }

        private void ucCondition1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            KeyValueCollection kvs = this.ucCondition1.GetConditionKeyValues();
            foreach (KeyValue k in kvs)
            {
                Console.WriteLine(k.Key + " : " + k.Value);
            }
        }
    }
}
