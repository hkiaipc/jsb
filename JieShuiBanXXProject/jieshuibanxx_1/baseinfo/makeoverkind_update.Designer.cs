﻿namespace jieshuibanxx_1.baseinfo
{
    partial class makeoverkind_update
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
            this.makeoverkind_name = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbcUpdate = new jieshuibanxx_1.Common.ToolBarCommand();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.makeoverkind_name);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(2, 39);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(389, 114);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "技改类型";
            // 
            // makeoverkind_name
            // 
            this.makeoverkind_name.Location = new System.Drawing.Point(97, 45);
            this.makeoverkind_name.Name = "makeoverkind_name";
            this.makeoverkind_name.Size = new System.Drawing.Size(280, 21);
            this.makeoverkind_name.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "类型名称：";
            // 
            // tbcUpdate
            // 
            this.tbcUpdate.CommandName = "修改";
            this.tbcUpdate.ImagePath = null;
            this.tbcUpdate.IsEnable = true;
            this.tbcUpdate.IsVisible = true;
            this.tbcUpdate.Name = "修改";
            this.tbcUpdate.Type = jieshuibanxx_1.Common.CommandType.Update;
            this.tbcUpdate.Commanded += new System.EventHandler(this.tbcUpdate_Commanded);
            // 
            // makeoverkind_update
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(390, 156);
            this.Controls.Add(this.groupBox1);
            this.Name = "makeoverkind_update";
            this.Text = "makeoverkind_update";
            this.Load += new System.EventHandler(this.makeoverkind_update_Load);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox makeoverkind_name;
        private System.Windows.Forms.Label label1;
        private jieshuibanxx_1.Common.ToolBarCommand tbcUpdate;
    }
}