﻿namespace jieshuibanxx_1.baseinfo
{
    partial class type_update
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
            this.type_name = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tblUpdate = new jieshuibanxx_1.Common.ToolBarCommand();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbcCancel
            // 
            //this.tbcCancel.Commanded += new System.EventHandler(this.tbcCancel_Commanded);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.type_name);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(-3, 44);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(392, 114);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "行业大类";
            // 
            // type_name
            // 
            this.type_name.Location = new System.Drawing.Point(97, 45);
            this.type_name.Name = "type_name";
            this.type_name.Size = new System.Drawing.Size(280, 21);
            this.type_name.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "行业大类名称：";
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
            // type_update
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(389, 160);
            this.Controls.Add(this.groupBox1);
            this.Name = "type_update";
            this.Text = "type_update";
            this.Load += new System.EventHandler(this.type_update_Load);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox type_name;
        private System.Windows.Forms.Label label1;
        private jieshuibanxx_1.Common.ToolBarCommand tblUpdate;
    }
}