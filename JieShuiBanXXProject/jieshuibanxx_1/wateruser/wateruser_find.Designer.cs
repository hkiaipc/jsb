namespace jieshuibanxx_1.wateruser
{
    partial class wateruser_find
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
            this.wateruser_blur1 = new jieshuibanxx_1.CustomerControl.wateruser_blur();
            this.wateruser_blur2 = new jieshuibanxx_1.CustomerControl.wateruser_blur();
            this.SuspendLayout();
            // 
            // wateruser_blur1
            // 
            this.wateruser_blur1.BackColor = System.Drawing.Color.Transparent;
            this.wateruser_blur1.get_blurname = "wateruser";
            this.wateruser_blur1.Location = new System.Drawing.Point(12, 37);
            this.wateruser_blur1.Name = "wateruser_blur1";
            this.wateruser_blur1.Size = new System.Drawing.Size(213, 30);
            this.wateruser_blur1.TabIndex = 1;
            // 
            // wateruser_blur2
            // 
            this.wateruser_blur2.BackColor = System.Drawing.Color.Transparent;
            this.wateruser_blur2.get_blurname = "address";
            this.wateruser_blur2.Location = new System.Drawing.Point(13, 74);
            this.wateruser_blur2.Name = "wateruser_blur2";
            this.wateruser_blur2.Size = new System.Drawing.Size(213, 30);
            this.wateruser_blur2.TabIndex = 2;
            // 
            // wateruser_find
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 273);
            this.Controls.Add(this.wateruser_blur2);
            this.Controls.Add(this.wateruser_blur1);
            this.Name = "wateruser_find";
            this.Text = "wateruser_find";
            this.Load += new System.EventHandler(this.wateruser_find_Load);
            this.Controls.SetChildIndex(this.wateruser_blur1, 0);
            this.Controls.SetChildIndex(this.wateruser_blur2, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private jieshuibanxx_1.CustomerControl.wateruser_blur wateruser_blur1;
        private jieshuibanxx_1.CustomerControl.wateruser_blur wateruser_blur2;





    }
}