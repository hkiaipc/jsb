using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using sqlconn;

namespace jieshuibanxx_1
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            mainform main = new mainform();
            main.Show();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            string address = "server=192.168.1.32;initial catalog=jieshuibanxx_1;user=sa;password=sa";

            DBIBase dbi = new DBIBase(address);
            try
            {

                dbi.open();
            }
            catch
            {
                MessageBox.Show("数据库链接失败");
                this.Close();
            }
        }
    }
}
