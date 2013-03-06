namespace gwlman
{
    partial class UCCondition
    {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.lblConditionName = new System.Windows.Forms.Label();
            this.lblValue = new System.Windows.Forms.Label();
            this.cmbCondition1 = new System.Windows.Forms.ComboBox();
            this.txtValue1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(0, 50);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "添加";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(81, 50);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 1;
            this.btnDelete.Text = "删除";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // lblConditionName
            // 
            this.lblConditionName.Location = new System.Drawing.Point(0, 0);
            this.lblConditionName.Name = "lblConditionName";
            this.lblConditionName.Size = new System.Drawing.Size(100, 21);
            this.lblConditionName.TabIndex = 2;
            this.lblConditionName.Text = "名称";
            // 
            // lblValue
            // 
            this.lblValue.Location = new System.Drawing.Point(106, 0);
            this.lblValue.Name = "lblValue";
            this.lblValue.Size = new System.Drawing.Size(150, 21);
            this.lblValue.TabIndex = 3;
            this.lblValue.Text = "值";
            // 
            // cmbCondition1
            // 
            this.cmbCondition1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCondition1.FormattingEnabled = true;
            this.cmbCondition1.Location = new System.Drawing.Point(0, 24);
            this.cmbCondition1.Name = "cmbCondition1";
            this.cmbCondition1.Size = new System.Drawing.Size(100, 20);
            this.cmbCondition1.TabIndex = 4;
            // 
            // txtValue1
            // 
            this.txtValue1.Location = new System.Drawing.Point(106, 23);
            this.txtValue1.Name = "txtValue1";
            this.txtValue1.Size = new System.Drawing.Size(150, 21);
            this.txtValue1.TabIndex = 5;
            // 
            // UCCondition
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtValue1);
            this.Controls.Add(this.cmbCondition1);
            this.Controls.Add(this.lblValue);
            this.Controls.Add(this.lblConditionName);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Name = "UCCondition";
            this.Size = new System.Drawing.Size(264, 299);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label lblConditionName;
        private System.Windows.Forms.Label lblValue;
        private System.Windows.Forms.ComboBox cmbCondition1;
        private System.Windows.Forms.TextBox txtValue1;
    }
}
