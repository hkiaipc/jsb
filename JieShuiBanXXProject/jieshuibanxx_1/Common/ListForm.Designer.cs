namespace jieshuibanxx_1.Common
{
    partial class ListForm
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
            this.tsTool = new System.Windows.Forms.ToolStrip();
            this.lblRecord = new System.Windows.Forms.Label();
            this.dgMain = new global::Common.Controls.QMDataGrid();
            ((System.ComponentModel.ISupportInitialize)(this.dgMain)).BeginInit();
            this.SuspendLayout();
            // 
            // tsTool
            // 
            this.tsTool.Location = new System.Drawing.Point(0, 0);
            this.tsTool.Name = "tsTool";
            this.tsTool.Size = new System.Drawing.Size(590, 25);
            this.tsTool.TabIndex = 0;
            this.tsTool.Text = "toolStrip1";
            // 
            // lblRecord
            // 
            this.lblRecord.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblRecord.AutoSize = true;
            this.lblRecord.Location = new System.Drawing.Point(435, 36);
            this.lblRecord.Name = "lblRecord";
            this.lblRecord.Size = new System.Drawing.Size(143, 12);
            this.lblRecord.TabIndex = 2;
            this.lblRecord.Text = "当前一共检索出   条记录";
            // 
            // dgMain
            // 
            this.dgMain.AlternatingBackColor = System.Drawing.Color.White;
            this.dgMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dgMain.BackColor = System.Drawing.Color.White;
            this.dgMain.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgMain.CaptionVisible = false;
            this.dgMain.DataMember = "";
            this.dgMain.Font = new System.Drawing.Font("Tahoma", 8F);
            this.dgMain.ForeColor = System.Drawing.Color.Black;
            this.dgMain.GridLineColor = System.Drawing.Color.Wheat;
            this.dgMain.HeaderBackColor = System.Drawing.Color.CadetBlue;
            this.dgMain.HeaderFont = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.dgMain.HeaderForeColor = System.Drawing.Color.White;
            this.dgMain.LinkColor = System.Drawing.Color.DarkSlateBlue;
            this.dgMain.Location = new System.Drawing.Point(0, 51);
            this.dgMain.Name = "dgMain";
            this.dgMain.ParentRowsBackColor = System.Drawing.Color.Ivory;
            this.dgMain.ParentRowsForeColor = System.Drawing.Color.Black;
            this.dgMain.RowHeadersVisible = false;
            this.dgMain.SelectionBackColor = System.Drawing.Color.Wheat;
            this.dgMain.SelectionForeColor = System.Drawing.Color.DarkSlateBlue;
            this.dgMain.Size = new System.Drawing.Size(741, 454);
            this.dgMain.TabIndex = 0;
            // 
            // ListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(590, 364);
            this.Controls.Add(this.dgMain);
            this.Controls.Add(this.lblRecord);
            this.Controls.Add(this.tsTool);
            this.Name = "ListForm";
            this.Text = "ListForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ListForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgMain)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.ToolStrip tsTool;
        public System.Windows.Forms.Label lblRecord;
        public global::Common.Controls.QMDataGrid dgMain;
    }
}