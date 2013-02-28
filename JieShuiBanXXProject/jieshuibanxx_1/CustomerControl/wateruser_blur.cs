using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace jieshuibanxx_1.CustomerControl
{
    public partial class wateruser_blur : UserControl
    {
        operation.o_wateruser data_wateruser = new operation.o_wateruser();
        private data_define.wateruser _wateruser = new data_define.wateruser();
        protected string _blurname = "";
        public string get_blurname
        {
            get { return _blurname; }
            set { _blurname = value; }
        }
        public wateruser_blur()
        {
            InitializeComponent();
            this.listBox1.Visible = false;

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //this.panel1.
            if (get_blurname == "wateruser")
            {
                _wateruser.address = "";
                _wateruser.waterusername = this.textBox1.Text;

            }
            else if (get_blurname == "address")
            {
                _wateruser.waterusername = "";
                _wateruser.address = this.textBox1.Text;
            }
            this.listBox1.DataSource = data_wateruser.dt(_wateruser);
            this.listBox1.ValueMember = get_blurname;
            this.listBox1.DisplayMember = get_blurname;
            this.listBox1.Visible = true;
            base.BringToFront();
            if (this.listBox1.Items.Count < 7)
            {
                this.listBox1.Height = (this.listBox1.Items.Count) * 20;
                base.Height = (this.listBox1.Height + this.textBox1.Height) + 2;

            }
            else
            {
                base.Height = 0 * 71;
            }
            this.listBox1.SelectionMode = SelectionMode.MultiExtended;


        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //this.textBox1.Text = this.listBox1.SelectedValue.ToString();
            //base.Height = 30;
            //this.listBox1.Visible = false;
        }

        private void listBox1_DoubleClick(object sender, EventArgs e)
        {
            this.textBox1.Text = this.listBox1.SelectedValue.ToString();
            base.Height = 30;
            this.listBox1.Visible = false;
        }
    }
}
