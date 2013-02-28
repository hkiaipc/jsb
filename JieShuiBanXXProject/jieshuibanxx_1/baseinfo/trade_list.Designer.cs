namespace jieshuibanxx_1.baseinfo
{
    partial class trade_list
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
            this.tbcAdd = new jieshuibanxx_1.Common.ToolBarCommand();
            this.tbcModify = new jieshuibanxx_1.Common.ToolBarCommand();
            this.tbcView = new jieshuibanxx_1.Common.ToolBarCommand();
            ((System.ComponentModel.ISupportInitialize)(this.dgMain)).BeginInit();
            this.SuspendLayout();
            // 
            // tbcAdd
            // 
            this.tbcAdd.CommandName = "新建";
            this.tbcAdd.ImagePath = null;
            this.tbcAdd.IsEnable = true;
            this.tbcAdd.IsVisible = true;
            this.tbcAdd.Name = "新建";
            this.tbcAdd.Type = jieshuibanxx_1.Common.CommandType.New;
            this.tbcAdd.Commanded += new System.EventHandler(this.tbcAdd_Commanded);
            // 
            // tbcModify
            // 
            this.tbcModify.CommandName = "修改";
            this.tbcModify.ImagePath = null;
            this.tbcModify.IsEnable = true;
            this.tbcModify.IsVisible = true;
            this.tbcModify.Name = "修改";
            this.tbcModify.Type = jieshuibanxx_1.Common.CommandType.Modify;
            this.tbcModify.Commanded += new System.EventHandler(this.tbcModify_Commanded);
            // 
            // tbcView
            // 
            this.tbcView.CommandName = "查看";
            this.tbcView.ImagePath = null;
            this.tbcView.IsEnable = true;
            this.tbcView.IsVisible = true;
            this.tbcView.Name = "查看";
            this.tbcView.Type = jieshuibanxx_1.Common.CommandType.View;
            this.tbcView.Commanded += new System.EventHandler(this.tbcView_Commanded);
            // 
            // trade_list
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(590, 364);
            this.Name = "trade_list";
            this.Text = "trade_list";
            this.Load += new System.EventHandler(this.trade_list_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgMain)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private jieshuibanxx_1.Common.ToolBarCommand tbcAdd;
        private jieshuibanxx_1.Common.ToolBarCommand tbcModify;
        private jieshuibanxx_1.Common.ToolBarCommand tbcView;
    }
}