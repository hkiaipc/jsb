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
            this.lblRemark = new System.Windows.Forms.Label();
            this.txtRemark = new System.Windows.Forms.TextBox();
            this.lblEffluentAmount = new System.Windows.Forms.Label();
            this.lblExtractAmount = new System.Windows.Forms.Label();
            this.lblDiameter = new System.Windows.Forms.Label();
            this.lblDepth = new System.Windows.Forms.Label();
            this.lblWaterSourceLocation = new System.Windows.Forms.Label();
            this.txtWaterSourceLocation = new System.Windows.Forms.TextBox();
            this.lblSerial = new System.Windows.Forms.Label();
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
            // lblRemark
            // 
            this.lblRemark.Location = new System.Drawing.Point(5, 170);
            this.lblRemark.Name = "lblRemark";
            this.lblRemark.Size = new System.Drawing.Size(100, 23);
            this.lblRemark.TabIndex = 12;
            this.lblRemark.Text = "备注:";
            // 
            // txtRemark
            // 
            this.txtRemark.Location = new System.Drawing.Point(111, 167);
            this.txtRemark.Multiline = true;
            this.txtRemark.Name = "txtRemark";
            this.txtRemark.Size = new System.Drawing.Size(200, 100);
            this.txtRemark.TabIndex = 13;
            // 
            // lblEffluentAmount
            // 
            this.lblEffluentAmount.Location = new System.Drawing.Point(5, 143);
            this.lblEffluentAmount.Name = "lblEffluentAmount";
            this.lblEffluentAmount.Size = new System.Drawing.Size(100, 23);
            this.lblEffluentAmount.TabIndex = 10;
            this.lblEffluentAmount.Text = "出水流量(m3/s):";
            // 
            // lblExtractAmount
            // 
            this.lblExtractAmount.Location = new System.Drawing.Point(5, 116);
            this.lblExtractAmount.Name = "lblExtractAmount";
            this.lblExtractAmount.Size = new System.Drawing.Size(100, 23);
            this.lblExtractAmount.TabIndex = 8;
            this.lblExtractAmount.Text = "年开采量(m3):";
            // 
            // lblDiameter
            // 
            this.lblDiameter.Location = new System.Drawing.Point(5, 89);
            this.lblDiameter.Name = "lblDiameter";
            this.lblDiameter.Size = new System.Drawing.Size(100, 23);
            this.lblDiameter.TabIndex = 6;
            this.lblDiameter.Text = "孔径(m):";
            // 
            // lblDepth
            // 
            this.lblDepth.Location = new System.Drawing.Point(5, 62);
            this.lblDepth.Name = "lblDepth";
            this.lblDepth.Size = new System.Drawing.Size(100, 23);
            this.lblDepth.TabIndex = 4;
            this.lblDepth.Text = "凿井深(m):";
            // 
            // lblWaterSourceLocation
            // 
            this.lblWaterSourceLocation.Location = new System.Drawing.Point(5, 35);
            this.lblWaterSourceLocation.Name = "lblWaterSourceLocation";
            this.lblWaterSourceLocation.Size = new System.Drawing.Size(100, 23);
            this.lblWaterSourceLocation.TabIndex = 2;
            this.lblWaterSourceLocation.Text = "水源地点:";
            // 
            // txtWaterSourceLocation
            // 
            this.txtWaterSourceLocation.Location = new System.Drawing.Point(111, 32);
            this.txtWaterSourceLocation.Name = "txtWaterSourceLocation";
            this.txtWaterSourceLocation.Size = new System.Drawing.Size(200, 21);
            this.txtWaterSourceLocation.TabIndex = 3;
            // 
            // lblSerial
            // 
            this.lblSerial.Location = new System.Drawing.Point(5, 8);
            this.lblSerial.Name = "lblSerial";
            this.lblSerial.Size = new System.Drawing.Size(100, 23);
            this.lblSerial.TabIndex = 0;
            this.lblSerial.Text = "水井编号:";
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
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
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
            this.Controls.Add(this.lblRemark);
            this.Controls.Add(this.txtRemark);
            this.Controls.Add(this.lblEffluentAmount);
            this.Controls.Add(this.lblExtractAmount);
            this.Controls.Add(this.lblDiameter);
            this.Controls.Add(this.lblDepth);
            this.Controls.Add(this.lblWaterSourceLocation);
            this.Controls.Add(this.txtWaterSourceLocation);
            this.Controls.Add(this.lblSerial);
            this.Controls.Add(this.txtSerial);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmWellItem";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "水井";
            ((System.ComponentModel.ISupportInitialize)(this.numDepth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDiameter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numExtractAmount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numEffluentAmount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRemark;
        private System.Windows.Forms.TextBox txtRemark;
        private System.Windows.Forms.Label lblEffluentAmount;
        private System.Windows.Forms.Label lblExtractAmount;
        private System.Windows.Forms.Label lblDiameter;
        private System.Windows.Forms.Label lblDepth;
        private System.Windows.Forms.Label lblWaterSourceLocation;
        private System.Windows.Forms.TextBox txtWaterSourceLocation;
        private System.Windows.Forms.Label lblSerial;
        private System.Windows.Forms.TextBox txtSerial;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.NumericUpDown numDepth;
        private System.Windows.Forms.NumericUpDown numDiameter;
        private System.Windows.Forms.NumericUpDown numExtractAmount;
        private System.Windows.Forms.NumericUpDown numEffluentAmount;

    }
}