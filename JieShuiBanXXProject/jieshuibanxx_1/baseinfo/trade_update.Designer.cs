namespace jieshuibanxx_1.baseinfo
{
    partial class trade_update
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.trade_name = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.type_name = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tblUpdate = new jieshuibanxx_1.Common.ToolBarCommand();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.trade_name);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.type_name);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(1, 52);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(389, 149);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "行业修改";
            // 
            // trade_name
            // 
            this.trade_name.Location = new System.Drawing.Point(87, 81);
            this.trade_name.Name = "trade_name";
            this.trade_name.Size = new System.Drawing.Size(277, 21);
            this.trade_name.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "行业名称：";
            // 
            // type_name
            // 
            this.type_name.FormattingEnabled = true;
            this.type_name.Location = new System.Drawing.Point(87, 35);
            this.type_name.Name = "type_name";
            this.type_name.Size = new System.Drawing.Size(277, 20);
            this.type_name.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "行业大类：";
            // 
            // tblUpdate
            // 
            this.tblUpdate.CommandName = "更新";
            this.tblUpdate.ImagePath = null;
            this.tblUpdate.IsEnable = true;
            this.tblUpdate.IsVisible = true;
            this.tblUpdate.Name = "更新";
            this.tblUpdate.Type = jieshuibanxx_1.Common.CommandType.Update;
            this.tblUpdate.Commanded += new System.EventHandler(this.tblUpdate_Commanded);
            // 
            // trade_update
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(396, 205);
            this.Controls.Add(this.groupBox1);
            this.Name = "trade_update";
            this.Text = "trade_update";
            this.Load += new System.EventHandler(this.trade_update_Load);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox trade_name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox type_name;
        private System.Windows.Forms.Label label1;
        private jieshuibanxx_1.Common.ToolBarCommand tblUpdate;
    }
}