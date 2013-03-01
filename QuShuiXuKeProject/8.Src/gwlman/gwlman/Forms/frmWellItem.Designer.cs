namespace gwlman
{
    partial class frmWellItem
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
            this.label17 = new System.Windows.Forms.Label();
            this.txtRemark = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.txtWaterSourceLocation = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtSerial = new System.Windows.Forms.TextBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.numDepth = new System.Windows.Forms.NumericUpDown();
            this.numDiameter = new System.Windows.Forms.NumericUpDown();
            this.numExtractAmount = new System.Windows.Forms.NumericUpDown();
            this.numEffluentAmount = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numDepth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDiameter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numExtractAmount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numEffluentAmount)).BeginInit();
            this.SuspendLayout();
            // 
            // label17
            // 
            this.label17.Location = new System.Drawing.Point(5, 170);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(100, 23);
            this.label17.TabIndex = 12;
            this.label17.Text = "备注:";
            // 
            // txtRemark
            // 
            this.txtRemark.Location = new System.Drawing.Point(111, 167);
            this.txtRemark.Multiline = true;
            this.txtRemark.Name = "txtRemark";
            this.txtRemark.Size = new System.Drawing.Size(200, 100);
            this.txtRemark.TabIndex = 13;
            // 
            // label10
            // 
            this.label10.Location = new System.Drawing.Point(5, 143);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(100, 23);
            this.label10.TabIndex = 10;
            this.label10.Text = "出水流量(m3/s):";
            // 
            // label11
            // 
            this.label11.Location = new System.Drawing.Point(5, 116);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(100, 23);
            this.label11.TabIndex = 8;
            this.label11.Text = "年开采量(m3):";
            // 
            // label12
            // 
            this.label12.Location = new System.Drawing.Point(5, 89);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(100, 23);
            this.label12.TabIndex = 6;
            this.label12.Text = "孔径(m):";
            // 
            // label13
            // 
            this.label13.Location = new System.Drawing.Point(5, 62);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(100, 23);
            this.label13.TabIndex = 4;
            this.label13.Text = "凿井深(m):";
            // 
            // label14
            // 
            this.label14.Location = new System.Drawing.Point(5, 35);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(100, 23);
            this.label14.TabIndex = 2;
            this.label14.Text = "水源地点:";
            // 
            // txtWaterSourceLocation
            // 
            this.txtWaterSourceLocation.Location = new System.Drawing.Point(111, 32);
            this.txtWaterSourceLocation.Name = "txtWaterSourceLocation";
            this.txtWaterSourceLocation.Size = new System.Drawing.Size(200, 21);
            this.txtWaterSourceLocation.TabIndex = 3;
            // 
            // label15
            // 
            this.label15.Location = new System.Drawing.Point(5, 8);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(100, 23);
            this.label15.TabIndex = 0;
            this.label15.Text = "水井编号:";
            // 
            // txtSerial
            // 
            this.txtSerial.Location = new System.Drawing.Point(111, 5);
            this.txtSerial.Name = "txtSerial";
            this.txtSerial.Size = new System.Drawing.Size(200, 21);
            this.txtSerial.TabIndex = 1;
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(155, 273);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 14;
            this.btnOK.Text = "确定";
            this.btnOK.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(236, 273);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 15;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // numDepth
            // 
            this.numDepth.DecimalPlaces = 2;
            this.numDepth.Location = new System.Drawing.Point(111, 60);
            this.numDepth.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.numDepth.Name = "numDepth";
            this.numDepth.Size = new System.Drawing.Size(200, 21);
            this.numDepth.TabIndex = 5;
            // 
            // numDiameter
            // 
            this.numDiameter.DecimalPlaces = 2;
            this.numDiameter.Location = new System.Drawing.Point(111, 87);
            this.numDiameter.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.numDiameter.Name = "numDiameter";
            this.numDiameter.Size = new System.Drawing.Size(200, 21);
            this.numDiameter.TabIndex = 7;
            // 
            // numExtractAmount
            // 
            this.numExtractAmount.DecimalPlaces = 2;
            this.numExtractAmount.Location = new System.Drawing.Point(111, 114);
            this.numExtractAmount.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.numExtractAmount.Name = "numExtractAmount";
            this.numExtractAmount.Size = new System.Drawing.Size(200, 21);
            this.numExtractAmount.TabIndex = 9;
            // 
            // numEffluentAmount
            // 
            this.numEffluentAmount.DecimalPlaces = 2;
            this.numEffluentAmount.Location = new System.Drawing.Point(111, 141);
            this.numEffluentAmount.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.numEffluentAmount.Name = "numEffluentAmount";
            this.numEffluentAmount.Size = new System.Drawing.Size(200, 21);
            this.numEffluentAmount.TabIndex = 11;
            // 
            // frmWellItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(321, 306);
            this.Controls.Add(this.numEffluentAmount);
            this.Controls.Add(this.numExtractAmount);
            this.Controls.Add(this.numDiameter);
            this.Controls.Add(this.numDepth);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.txtRemark);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.txtWaterSourceLocation);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.txtSerial);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmWellItem";
            this.Text = "水井";
            ((System.ComponentModel.ISupportInitialize)(this.numDepth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDiameter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numExtractAmount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numEffluentAmount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtRemark;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtWaterSourceLocation;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtSerial;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.NumericUpDown numDepth;
        private System.Windows.Forms.NumericUpDown numDiameter;
        private System.Windows.Forms.NumericUpDown numExtractAmount;
        private System.Windows.Forms.NumericUpDown numEffluentAmount;

    }
}