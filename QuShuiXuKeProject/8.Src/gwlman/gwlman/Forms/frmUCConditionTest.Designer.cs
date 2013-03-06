namespace gwlman
{
    partial class frmUCConditionTest
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
            this.ucCondition1 = new gwlman.UCCondition();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ucCondition1
            // 
            this.ucCondition1.Location = new System.Drawing.Point(16, 12);
            this.ucCondition1.Name = "ucCondition1";
            this.ucCondition1.Size = new System.Drawing.Size(264, 299);
            this.ucCondition1.TabIndex = 0;
            this.ucCondition1.Load += new System.EventHandler(this.ucCondition1_Load);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(365, 70);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmUCConditionTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(422, 472);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ucCondition1);
            this.Name = "frmUCConditionTest";
            this.Text = "frmUCConditionTest";
            this.ResumeLayout(false);

        }

        #endregion

        private UCCondition ucCondition1;
        private System.Windows.Forms.Button button1;
    }
}