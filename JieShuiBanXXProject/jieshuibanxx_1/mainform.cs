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
    public partial class mainform : Form
    {
        private int childFormNumber = 0;

        public mainform()
        {
            InitializeComponent();
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "窗口 " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "文本文件(*.txt)|*.txt|所有文件(*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "文本文件(*.txt)|*.txt|所有文件(*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void ToolBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void 行业大类ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            baseinfo.type_list type = new jieshuibanxx_1.baseinfo.type_list();
            type.Show();
        }

        private void 所属行业ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            baseinfo.trade_list trade = new jieshuibanxx_1.baseinfo.trade_list();
            trade.ShowDialog();
        }

        private void 取水性质ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            baseinfo.getwaterkind_list getwaterkind = new jieshuibanxx_1.baseinfo.getwaterkind_list();
            getwaterkind.ShowDialog();
        }

        private void 技改分类ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            baseinfo.makeoverclass_list makeoverclass = new jieshuibanxx_1.baseinfo.makeoverclass_list();
            makeoverclass.ShowDialog();
        }

        private void 技改类型ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            baseinfo.makeoverkind_list makeoverkind = new jieshuibanxx_1.baseinfo.makeoverkind_list();
            makeoverkind.ShowDialog();
        }

        private void 基本信息维护ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            wateruser.wateruser_find wateruserfind = new jieshuibanxx_1.wateruser.wateruser_find();
            wateruserfind.ShowDialog();
        }

        private void 单位联系人维护ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            wateruser.wateruser_list f = new jieshuibanxx_1.wateruser.wateruser_list();
            f.ShowDialog();
        }

        private void 节水ToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }
    }
}
