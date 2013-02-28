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
using System.IO;

namespace jieshuibanxx_1.wateruser
{
    public partial class wateruser_add : Common.DetailForm
    {
        protected data_define.wateruser define_wateruser;
        protected operation.o_wateruser oper_wateruser;
        protected operation.o_trade oper_trade;
        protected operation.o_getwaterkind oper_getwaterkind;
        protected operation.o_type oper_type;
        public wateruser_add()
        {
            InitializeComponent();
            define_wateruser = new data_define.wateruser();
            oper_wateruser = new operation.o_wateruser();
            oper_trade = new operation.o_trade();
            oper_getwaterkind = new operation.o_getwaterkind();
            oper_type = new operation.o_type();
        }
        public override void AddCommands(List<ToolBarCommand> commands)
        {
            base.AddCommands(commands);
            commands.Insert(0, tbcCancel);
            commands.Insert(1, tbcSave);
        }
        protected void SetReadonlyControl()
        {
            SetReadOnly(this.wateruser_num, true, Color.White);
            SetReadOnly(this.wateruser, true, Color.White);
            SetReadOnly(this.product, true, Color.White);
            SetReadOnly(this.year_output, true, Color.White);
            SetReadOnly(this.test_year, true, Color.White);
            SetReadOnly(this.waterpeople, true, Color.White);
            SetReadOnly(this.watermeter_num, true, Color.White);
            SetReadOnly(this.answer_name, true, Color.White);
            SetReadOnly(this.linkman_name, true, Color.White);

        }
        public void GetFormToType()
        {
            define_wateruser.wateruser_num = this.wateruser_num.Text;
            define_wateruser.waterusername = this.wateruser.Text;
            define_wateruser.corporate = this.corporate.Text;
            define_wateruser.address = this.address.Text;
            define_wateruser.post = this.post.Text;
            define_wateruser.fax = this.fax.Text;
            define_wateruser.email = this.email.Text;
            define_wateruser.product = this.product.Text;
            if (this.checkBox1.Checked)
            { define_wateruser.is_economize = "1"; }
            else
            {
                define_wateruser.is_economize = "0"; 
            }
            define_wateruser.test_year = int.Parse(this.test_year.Text);
            define_wateruser.getwater_num = this.getwater_num.Text;
            define_wateruser.trade_id = int.Parse(this.trade_id.SelectedValue.ToString());
            define_wateruser.watermeter_num = int.Parse(this.watermeter_num.Text);
            define_wateruser.waterpeople = int.Parse(this.waterpeople.Text);
            define_wateruser.waterpeople_unit = this.waterpeople_unit.Text;
            define_wateruser.year_output = int.Parse(this.year_output.Text);
            define_wateruser.unit = this.unit.Text;
            define_wateruser.remark = this.remark.Text;

            define_wateruser.answername = this.answer_name.Text;
            define_wateruser.answerbranch = this.answer_branch.Text;
            define_wateruser.answerduty = this.answer_duty.Text;
            define_wateruser.answerphone = this.answer_phone.Text;
            define_wateruser.answerhandphone = this.answer_handphone.Text;
            define_wateruser.answerisnote = this.answer_note.Text;
            define_wateruser.linkmanname = this.linkman_name.Text;
            define_wateruser.linkmanbranch = this.linkman_branch.Text;
            define_wateruser.linkmanduty = this.linkman_duty.Text;
            define_wateruser.linkmanphone = this.linkman_phone.Text;
            define_wateruser.linkmanhandphone = this.linkman_handphone.Text;
            define_wateruser.linkmanisnote = this.linkman_note.Text;

            //this.trade_id.DataSource=
            if (!string.IsNullOrEmpty(this.pictureBox1.ImageLocation))
            {
                FileStream fs = File.Open(this.pictureBox1.ImageLocation, FileMode.Open);
                byte[] MyData = new byte[fs.Length];
                fs.Read(MyData, 0, MyData.Length);
                define_wateruser.photo = MyData;
            }
            define_wateruser.waterbeed = return_waterbeed();
            define_wateruser.trade_id = int.Parse(this.trade_id.SelectedValue.ToString());
            define_wateruser.getwater_kind_id = int.Parse(this.getwater_kind_id.SelectedValue.ToString());
        }
        private string return_waterbeed()
        {
            string _waterbeed = "0000000";
            for (int i = 1; i < _waterbeed.Length; i++)
            {
                if (this.waterbeed.GetItemChecked(i))
                {
                    if (i == 1)
                    {
                        _waterbeed = "1" + _waterbeed.Substring(i + 1, _waterbeed.Length - i - 1);
                    }
                    else if (i == _waterbeed.Length)
                    {
                        _waterbeed = _waterbeed.Substring(0, i) + "1";
                    }
                    else
                    {
                        _waterbeed = _waterbeed.Substring(0, i) + "1" + _waterbeed.Substring(i + 1, _waterbeed.Length - i - 1);
                    }
                }
            }
            return _waterbeed;
        }
        private void wateruser_add_Load(object sender, EventArgs e)
        {
            SetTitle("用水单位基本信息添加");
            get_data();
            this.getwater_kind_id.DataSource = oper_getwaterkind._getwaterkinddt(0);
            this.getwater_kind_id.DisplayMember = "getwater_kind_name";
            this.getwater_kind_id.ValueMember = "getwater_kind_id";
            AddRequiredTextItem(this.wateruser_num, "请输入微机编号");
            AddRequiredTextItem(this.wateruser, "请输入单位名称");
            AddRequiredTextItem(this.product, "请输入主要产品");
            AddRequiredTextItem(this.year_output, "请输入产品设计年产量", @"^\d{1,5}$", "必须为数字!");
            AddRequiredTextItem(this.test_year, "请输入水平衡测试年", @"^\d{1,5}$", "必须为数字!");
            AddRequiredTextItem(this.waterpeople, "请输入用水人数!", @"^\d{1,5}$", "必须为数字!");
            AddRequiredTextItem(this.watermeter_num, "请输入一级水表总数!", @"^\d{1,5}$", "必须为数字!");
            AddRequiredTextItem(this.answer_name, "请输入负责人姓名");
            AddRequiredTextItem(this.linkman_name, "请输入联系人姓名");
        }
        private void get_data()
        {
            this.type_id.DataSource = oper_type.type_dt(0);
            this.type_id.DisplayMember = "type_name";
            this.type_id.ValueMember = "type_id";
            this.trade_id.DataSource=oper_trade._tradedt(int.Parse(this.type_id.SelectedValue.ToString()));
            this.trade_id.DisplayMember = "trade_name";
            this.trade_id.ValueMember = "trade_id";

        }
        private void tbcSave_Commanded(object sender, EventArgs e)
        {
            if (!base.Validate())
            {
                return;
            }
            GetFormToType();
            if (oper_wateruser.add(define_wateruser))
            {
                MsgHelper.ShowInformationMsgBox("添加用水单位成功！");
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                MsgHelper.ShowInformationMsgBox("添加用水单位失败！");
            }
        }

        private void type_id_SelectedIndexChanged(object sender, EventArgs e)
        {
            get_data();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.ImageLocation = ofd.FileName;
            }
        }
    }
}
