using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;


namespace YearSummary
{
    /// <summary>
    /// frmYearSummary 的摘要说明。
    /// </summary>
    public class frmYearSummary : System.Windows.Forms.Form
    {
        #region Members

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.GroupBox gbText;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ListView lvDatas;
        private System.Windows.Forms.ColumnHeader chName;
        private System.Windows.Forms.ColumnHeader chlastS;
        private System.Windows.Forms.ColumnHeader chlastM;
        private System.Windows.Forms.ColumnHeader chSal;
        private System.Windows.Forms.ColumnHeader chWat;
        private System.Windows.Forms.ColumnHeader chSalUse;
        private System.Windows.Forms.ColumnHeader chWatUse;
        private System.Windows.Forms.ColumnHeader chRemark;
        private System.Windows.Forms.ColumnHeader chTime;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.TreeView tvNames;
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.Container components = null;
        private System.Windows.Forms.ListView lvSaleWater;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ListView lvUsedWater;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.ColumnHeader columnHeader12;
        private System.Windows.Forms.ColumnHeader columnHeader13;
        private System.Windows.Forms.ColumnHeader columnHeader14;
        private SqlQuery m_sql = null;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnQuery;
        private System.Windows.Forms.DateTimePicker dtpBegin;
        private System.Windows.Forms.DateTimePicker dtpEnd;
        private ColumnHeader chBeginDT;
        private System.Windows.Forms.ColumnHeader chSaleMoney;
        private System.Windows.Forms.ColumnHeader chSaleAmount;
        private System.Drawing.Printing.PrintDocument printDocument1;
        #endregion //

        public frmYearSummary()
        {
            //
            // Windows 窗体设计器支持所必需的
            //
            InitializeComponent();

            //
            //

        }

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (components != null)
                {
                    components.Dispose();
                }
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码
        /// <summary>
        /// 设计器支持所需的方法 - 不要使用代码编辑器修改
        /// 此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(frmYearSummary));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpEnd = new System.Windows.Forms.DateTimePicker();
            this.dtpBegin = new System.Windows.Forms.DateTimePicker();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnQuery = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.panel3 = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.lvSaleWater = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader5 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader8 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader9 = new System.Windows.Forms.ColumnHeader();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.lvUsedWater = new System.Windows.Forms.ListView();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader11 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader12 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader13 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader14 = new System.Windows.Forms.ColumnHeader();
            this.panel2 = new System.Windows.Forms.Panel();
            this.gbText = new System.Windows.Forms.GroupBox();
            this.lvDatas = new System.Windows.Forms.ListView();
            this.chName = new System.Windows.Forms.ColumnHeader();
            this.chlastM = new System.Windows.Forms.ColumnHeader();
            this.chlastS = new System.Windows.Forms.ColumnHeader();
            this.chSal = new System.Windows.Forms.ColumnHeader();
            this.chWat = new System.Windows.Forms.ColumnHeader();
            this.chSalUse = new System.Windows.Forms.ColumnHeader();
            this.chWatUse = new System.Windows.Forms.ColumnHeader();
            this.chBeginDT = new System.Windows.Forms.ColumnHeader();
            this.chTime = new System.Windows.Forms.ColumnHeader();
            this.chRemark = new System.Windows.Forms.ColumnHeader();
            this.panel4 = new System.Windows.Forms.Panel();
            this.tvNames = new System.Windows.Forms.TreeView();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.chSaleMoney = new System.Windows.Forms.ColumnHeader();
            this.chSaleAmount = new System.Windows.Forms.ColumnHeader();
            this.groupBox2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel3.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.panel2.SuspendLayout();
            this.gbText.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.dtpEnd);
            this.groupBox2.Controls.Add(this.dtpBegin);
            this.groupBox2.Controls.Add(this.btnPrint);
            this.groupBox2.Controls.Add(this.btnQuery);
            this.groupBox2.Location = new System.Drawing.Point(4, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(524, 52);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(168, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 12);
            this.label2.TabIndex = 9;
            this.label2.Text = "至";
            // 
            // dtpEnd
            // 
            this.dtpEnd.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.dtpEnd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpEnd.Location = new System.Drawing.Point(192, 16);
            this.dtpEnd.Name = "dtpEnd";
            this.dtpEnd.Size = new System.Drawing.Size(148, 21);
            this.dtpEnd.TabIndex = 8;
            // 
            // dtpBegin
            // 
            this.dtpBegin.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.dtpBegin.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpBegin.Location = new System.Drawing.Point(12, 16);
            this.dtpBegin.Name = "dtpBegin";
            this.dtpBegin.Size = new System.Drawing.Size(148, 21);
            this.dtpBegin.TabIndex = 7;
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(440, 16);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.TabIndex = 6;
            this.btnPrint.Text = "打印(&P)";
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnQuery
            // 
            this.btnQuery.Location = new System.Drawing.Point(352, 16);
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.TabIndex = 5;
            this.btnQuery.Text = "查询(&Q)";
            this.btnQuery.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
                | System.Windows.Forms.AnchorStyles.Left) 
                | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Location = new System.Drawing.Point(4, 64);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(788, 500);
            this.panel1.TabIndex = 2;
            // 
            // panel5
            // 
            this.panel5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
                | System.Windows.Forms.AnchorStyles.Left) 
                | System.Windows.Forms.AnchorStyles.Right)));
            this.panel5.Controls.Add(this.splitter1);
            this.panel5.Controls.Add(this.panel3);
            this.panel5.Controls.Add(this.panel2);
            this.panel5.Location = new System.Drawing.Point(188, 0);
            this.panel5.Name = "panel5";
            this.panel5.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.panel5.Size = new System.Drawing.Size(600, 500);
            this.panel5.TabIndex = 5;
            // 
            // splitter1
            // 
            this.splitter1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.splitter1.Location = new System.Drawing.Point(0, 324);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(600, 8);
            this.splitter1.TabIndex = 6;
            this.splitter1.TabStop = false;
            this.splitter1.SplitterMoved += new System.Windows.Forms.SplitterEventHandler(this.splitter1_SplitterMoved);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.tabControl1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 332);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(600, 168);
            this.panel3.TabIndex = 1;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(600, 168);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.lvSaleWater);
            this.tabPage1.Location = new System.Drawing.Point(4, 21);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(592, 143);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "售水明细";
            // 
            // lvSaleWater
            // 
            this.lvSaleWater.BackColor = System.Drawing.SystemColors.Info;
            this.lvSaleWater.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
                                                                                          this.columnHeader1,
                                                                                          this.columnHeader4,
                                                                                          this.columnHeader5,
                                                                                          this.chSaleMoney,
                                                                                          this.chSaleAmount,
                                                                                          this.columnHeader8,
                                                                                          this.columnHeader9});
            this.lvSaleWater.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvSaleWater.FullRowSelect = true;
            this.lvSaleWater.GridLines = true;
            this.lvSaleWater.Location = new System.Drawing.Point(0, 0);
            this.lvSaleWater.MultiSelect = false;
            this.lvSaleWater.Name = "lvSaleWater";
            this.lvSaleWater.Size = new System.Drawing.Size(592, 143);
            this.lvSaleWater.TabIndex = 1;
            this.lvSaleWater.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "监测站名称";
            this.columnHeader1.Width = 120;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "累计购水金额";
            this.columnHeader4.Width = 120;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "累计购水量";
            this.columnHeader5.Width = 120;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "单价";
            this.columnHeader8.Width = 67;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "时间";
            this.columnHeader9.Width = 150;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.lvUsedWater);
            this.tabPage2.Location = new System.Drawing.Point(4, 21);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(592, 143);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "用水明细";
            // 
            // lvUsedWater
            // 
            this.lvUsedWater.BackColor = System.Drawing.SystemColors.Info;
            this.lvUsedWater.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
                                                                                          this.columnHeader2,
                                                                                          this.columnHeader11,
                                                                                          this.columnHeader12,
                                                                                          this.columnHeader13,
                                                                                          this.columnHeader14});
            this.lvUsedWater.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvUsedWater.FullRowSelect = true;
            this.lvUsedWater.GridLines = true;
            this.lvUsedWater.Location = new System.Drawing.Point(0, 0);
            this.lvUsedWater.MultiSelect = false;
            this.lvUsedWater.Name = "lvUsedWater";
            this.lvUsedWater.Size = new System.Drawing.Size(592, 143);
            this.lvUsedWater.TabIndex = 1;
            this.lvUsedWater.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "监测站名称";
            this.columnHeader2.Width = 105;
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "累计用水金额";
            this.columnHeader11.Width = 105;
            // 
            // columnHeader12
            // 
            this.columnHeader12.Text = "累计用水量";
            this.columnHeader12.Width = 106;
            // 
            // columnHeader13
            // 
            this.columnHeader13.Text = "单价";
            this.columnHeader13.Width = 85;
            // 
            // columnHeader14
            // 
            this.columnHeader14.Text = "时间";
            this.columnHeader14.Width = 172;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
                | System.Windows.Forms.AnchorStyles.Left) 
                | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.gbText);
            this.panel2.Location = new System.Drawing.Point(4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(592, 320);
            this.panel2.TabIndex = 0;
            // 
            // gbText
            // 
            this.gbText.Controls.Add(this.lvDatas);
            this.gbText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbText.Location = new System.Drawing.Point(0, 0);
            this.gbText.Name = "gbText";
            this.gbText.Size = new System.Drawing.Size(592, 320);
            this.gbText.TabIndex = 0;
            this.gbText.TabStop = false;
            this.gbText.Text = "总账明细表";
            // 
            // lvDatas
            // 
            this.lvDatas.BackColor = System.Drawing.SystemColors.Info;
            this.lvDatas.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
                                                                                      this.chName,
                                                                                      this.chlastM,
                                                                                      this.chlastS,
                                                                                      this.chSal,
                                                                                      this.chWat,
                                                                                      this.chSalUse,
                                                                                      this.chWatUse,
                                                                                      this.chBeginDT,
                                                                                      this.chTime,
                                                                                      this.chRemark});
            this.lvDatas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvDatas.FullRowSelect = true;
            this.lvDatas.GridLines = true;
            this.lvDatas.Location = new System.Drawing.Point(3, 17);
            this.lvDatas.MultiSelect = false;
            this.lvDatas.Name = "lvDatas";
            this.lvDatas.Size = new System.Drawing.Size(586, 300);
            this.lvDatas.TabIndex = 0;
            this.lvDatas.View = System.Windows.Forms.View.Details;
            this.lvDatas.DoubleClick += new System.EventHandler(this.lvDatas_DoubleClick);
            this.lvDatas.SelectedIndexChanged += new System.EventHandler(this.lvDatas_SelectedIndexChanged);
            // 
            // chName
            // 
            this.chName.Text = "监测站名称";
            this.chName.Width = 140;
            // 
            // chlastM
            // 
            this.chlastM.Text = "剩余金额";
            this.chlastM.Width = 70;
            // 
            // chlastS
            // 
            this.chlastS.Text = "剩余水量";
            this.chlastS.Width = 70;
            // 
            // chSal
            // 
            this.chSal.Text = "累计购水金额";
            this.chSal.Width = 90;
            // 
            // chWat
            // 
            this.chWat.Text = "累计购水量";
            this.chWat.Width = 90;
            // 
            // chSalUse
            // 
            this.chSalUse.Text = "累计用水金额";
            this.chSalUse.Width = 90;
            // 
            // chWatUse
            // 
            this.chWatUse.Text = "累计用水量";
            this.chWatUse.Width = 90;
            // 
            // chBeginDT
            // 
            this.chBeginDT.Text = "开始时间";
            this.chBeginDT.Width = 140;
            // 
            // chTime
            // 
            this.chTime.Text = "截止时间";
            this.chTime.Width = 140;
            // 
            // chRemark
            // 
            this.chRemark.Text = "备注信息";
            this.chRemark.Width = 200;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.tvNames);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(184, 500);
            this.panel4.TabIndex = 3;
            // 
            // tvNames
            // 
            this.tvNames.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tvNames.ImageIndex = -1;
            this.tvNames.Location = new System.Drawing.Point(0, 0);
            this.tvNames.Name = "tvNames";
            this.tvNames.SelectedImageIndex = -1;
            this.tvNames.Size = new System.Drawing.Size(184, 500);
            this.tvNames.TabIndex = 0;
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Location = new System.Drawing.Point(281, 17);
            this.printPreviewDialog1.MinimumSize = new System.Drawing.Size(375, 250);
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.TransparencyKey = System.Drawing.Color.Empty;
            this.printPreviewDialog1.Visible = false;
            // 
            // printDocument1
            // 
            this.printDocument1.BeginPrint += new System.Drawing.Printing.PrintEventHandler(this.printDocument1_BeginPrint);
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // chSaleMoney
            // 
            this.chSaleMoney.Text = "本次购水金额";
            this.chSaleMoney.Width = 90;
            // 
            // chSaleAmount
            // 
            this.chSaleAmount.Text = "本次购水量";
            this.chSaleAmount.Width = 90;
            // 
            // frmYearSummary
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
            this.ClientSize = new System.Drawing.Size(798, 566);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox2);
            this.MinimizeBox = false;
            this.Name = "frmYearSummary";
            this.Text = "frmYearSummary";
            this.Load += new System.EventHandler(this.frmYearSummary_Load);
            this.groupBox2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.gbText.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }
        #endregion


        #region FillNodes
        /// <summary>
        /// 填充TreeView控件
        /// </summary>
        /// <remarks>
        /// Qu1
        ///     Unit1
        ///         Well1
        ///         Well2
        ///     Unit2
        ///         Well3
        ///         Well4
        /// Qu2 
        ///     ...
        ///     
        /// </remarks>
        private void FillNodes()
        {
            string[] quList = m_sql.GetQuName();
            for (int i = 0; i < quList.Length; i++)
            {
                TreeNode tn = new TreeNode(quList[i]);
                tn.Tag = NodeType.Qu;

                this.tvNames.Nodes.Add(tn);
                AddUnitNodes(quList[i], tn);
            }
        }
        #endregion //FillNodes

        /// <summary>
        /// 
        /// </summary>
        /// <param name="s"></param>
        private void ShowExclamationMsg(string s)
        {
            MessageBox.Show(s, "提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        #region button1_Click
        /// <summary>
        /// query
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, System.EventArgs e)
        {
            TreeNode selectedNode = this.tvNames.SelectedNode;
            if (selectedNode == null)
            {
                ShowExclamationMsg("请先选择站点!");
                return;
            }

            NodeType nt = (NodeType)selectedNode.Tag;
            string selectedText = selectedNode.Text;

            lvDatas.Items.Clear();
            LoadAllDatas(nt, selectedText);
            CalcTotalSum();

        }
        #endregion //button1_Click

        #region LoadAllDatas
        /// <summary>
        /// 
        /// </summary>
        /// <param name="nt"></param>
        /// <param name="selectedText"></param>
        private void LoadAllDatas(NodeType nt, string selectedText)
        {
            //if (tvNames.SelectedNode.Parent == null)
            if (nt == NodeType.Qu)
            {
                InitListViewForUnit(selectedText);
            }
            else if(nt==NodeType.Unit)
            {
                InitListViewForWell(selectedText);
            }
        }
        #endregion //LoadAllDatas


        #region InitListViewForUnit
        /// <summary>
        /// 根据单位初始化ListView
        /// </summary>
        /// <param name="uName"></param>
        private void InitListViewForUnit(string quName)
        {
            string[] unitNames = m_sql.GetUnitName(quName);
            for (int i = 0; i < unitNames.Length; i++)
            {
                InitListViewForWell(unitNames[i]);
            }
        }
        #endregion //InitListViewForUnit


        /// <summary>
        /// 
        /// </summary>
        private DateTime Begin
        {
            get { return this.dtpBegin.Value; }
        }

        /// <summary>
        /// 
        /// </summary>
        private DateTime End
        {
            get { return this.dtpEnd.Value; }
        }

        #region InitListViewForWell
        /// <summary>
        /// 根据Well初始化ListView
        /// </summary>
        /// <param name="wName"></param>
        private void InitListViewForWell(string unitName)
        {
            string[] wellNames = m_sql.GetWellName(unitName);
            WatAllDatas _wat;
            for (int i = 0; i < wellNames.Length; i++)
            {
                _wat = m_sql.GetAllDatas(wellNames[i], Begin, End);
                if (_wat != null)
                {
                    ListViewItem lvi = this.lvDatas.Items.Add(_wat.Name);

                    //string[] subItems = new string[] { _wat.ListSel, _wat.ListWat, _wat.AllSel, _wat.AllWat, _wat.SelUse, _wat.WatUse, _wat.DT, _wat.Remark };
                    string[] subItems = _wat.GetDataArray();

                    lvi.SubItems.AddRange(subItems);

                    this.lvDatas.Refresh();
                }
            }
            //CalcTotalSum();
        }
        #endregion //InitListViewForWell




        #region CalcTotalSum
        /// <summary>
        /// 
        /// </summary>
        private void CalcTotalSum()
        {
            if (lvDatas.Items.Count == 0)
                return;

            int minIndex = 1;
            int maxIndex = 6;

            int[] results = new int[maxIndex - minIndex + 1];
            foreach (ListViewItem lvi in this.lvDatas.Items)
            {
                for (int index = minIndex; index <= maxIndex; index++)
                {
                    int value = Convert.ToInt32(lvi.SubItems[index].Text);
                    results[index - minIndex] += value;
                }
            }
            string[] items = // new string[maxIndex - minIndex + 1];
                new string[this.lvDatas.Columns.Count - 1];

            items[0] = "合计";
            for (int i = 1; i < items.Length; i++)
            {
                if (i >= minIndex && i <= maxIndex)
                {
                    items[i] = results[i - minIndex].ToString();
                }
                else
                {
                    items[i] = string.Empty;
                }
            }
            ListViewItem sumLvi = new ListViewItem(items);
            sumLvi.Tag = ListViewItemType.Sum;

            this.lvDatas.Items.Add(sumLvi);

            //float sumLastM = 0;
            //float sumLastW = 0;
            //float sumSal = 0;
            //float sumWat = 0;
            //float sumSaluse = 0;
            //float sumWatuse = 0;
            //float[] temp = new float[6];
            //float[] zh = new float[6];
            //for (int i = 0; i < lvDatas.Items.Count; i++)
            //{
            //    zh[0] = float.Parse(lvDatas.Items[i].SubItems[1].Text);
            //    temp[0] = zh[0] + temp[0];
            //    sumLastM = temp[0];

            //    zh[1] = float.Parse(lvDatas.Items[i].SubItems[2].Text);
            //    temp[1] = zh[1] + temp[1];
            //    sumLastW = temp[1];

            //    zh[2] = float.Parse(lvDatas.Items[i].SubItems[3].Text);
            //    temp[2] = zh[2] + temp[2];
            //    sumSal = temp[2];

            //    zh[3] = float.Parse(lvDatas.Items[i].SubItems[4].Text);
            //    temp[3] = zh[3] + temp[3];
            //    sumWat = temp[3];

            //    zh[4] = float.Parse(lvDatas.Items[i].SubItems[5].Text);
            //    temp[4] = zh[4] + temp[4];
            //    sumSaluse = temp[4];

            //    zh[5] = float.Parse(lvDatas.Items[i].SubItems[6].Text);
            //    temp[5] = zh[5] + temp[5];
            //    sumWatuse = temp[5];
            //}

            ////this.lvDatas.Items.Add(new ListViewItem(
            ////    new String[] {(this.tvNames.SelectedNode.Text+"合计"), String.Format("{0:F2}", sumLastM.ToString()),String.Format("{0:F2}",sumLastW.ToString()),
            ////                                 String.Format("{0:F2}",sumSal.ToString()),String.Format("{0:F2}",sumWat.ToString()),
            ////                                 String.Format("{0:F2}",sumSaluse.ToString()),String.Format("{0:F2}",sumWatuse.ToString()),
            ////                                (this.numYear.Value.ToString()+"年度总账统计"),String.Format("")}));
        }
        #endregion //CalcTotalSum


        #region AddUnitNodes
        /// <summary>
        /// 
        /// </summary>
        /// <param name="unitName"></param>
        /// <param name="node"></param>
        private void AddUnitNodes(string quName, TreeNode node)
        {
            string[] unitName = m_sql.GetUnitName(quName);
            for (int i = 0; i < unitName.Length; i++)
            {
                TreeNode tn = new TreeNode(unitName[i]);
                tn.Tag = NodeType.Unit;

                node.Nodes.Add(tn);
                AddWellNodes(unitName[i], tn);
            }
        }
        #endregion //AddUnitNodes


        #region AddWellNodes
        /// <summary>
        /// 
        /// </summary>
        /// <param name="WellName"></param>
        /// <param name="node"></param>
        private void AddWellNodes(string unitName, TreeNode node)
        {
            string[] wellList = m_sql.GetWellName(unitName);
            for (int i = 0; i < wellList.Length; i++)
            {
                TreeNode tn = new TreeNode(wellList[i]);
                tn.Tag = NodeType.Well;

                node.Nodes.Add(tn);
            }
        }
        #endregion //AddWellNodes




        #region frmYearSummary_Load
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmYearSummary_Load(object sender, System.EventArgs e)
        {
            SetFormText();
            m_sql = new SqlQuery();
            InitDateTimePickers();
            FillNodes();
        }

        /// <summary>
        /// 
        /// </summary>
        private void SetFormText()
        {
            this.Text = string.Format("{0} V{1}",
                Application.ProductName , Application.ProductVersion);
        }
        #endregion //frmYearSummary_Load


        #region InitDateTimePickers
        /// <summary>
        /// 
        /// </summary>
        private void InitDateTimePickers()
        {
            string s = string.Format("{0}-1-1", DateTime.Today.Year);
            this.dtpBegin.Value = DateTime.Parse(s);
            this.dtpEnd.Value = DateTime.Now.Date;
        }
        #endregion //InitDateTimePickers


        #region splitter1_SplitterMoved
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void splitter1_SplitterMoved(object sender, System.Windows.Forms.SplitterEventArgs e)
        {
            this.panel2.Height = this.panel5.Height - this.panel3.Height - 20;
        }
        #endregion //splitter1_SplitterMoved


        #region GetGroupText
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        private string GetGroupText()
        {
            // TODO:
            //
            return "";
        }
        #endregion //GetGroupText


        #region lvDatas_DoubleClick
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lvDatas_DoubleClick(object sender, System.EventArgs e)
        {
            if (this.lvDatas.SelectedItems.Count == 0)
            {
                return;
            }

            if (this.lvDatas.SelectedItems[0].Tag != null)
            {
                return;
            }

            this.lvSaleWater.Items.Clear();
            this.lvUsedWater.Items.Clear();
            string selectWell = this.lvDatas.SelectedItems[0].SubItems[0].Text.Trim();

            DataTable dtUse = m_sql.GetUseWaterDatas(selectWell, this.Begin, this.End );

            DataTable dtSel = m_sql.GetSaleDatas(selectWell, this.Begin, this.End);

            float price = m_sql.GetPrice(selectWell);
            for (int i = 0; i < dtUse.Rows.Count; i++)
            {
                ListViewItem lvi = this.lvUsedWater.Items.Add(selectWell);
                float useMoney = float.Parse(dtUse.Rows[i]["allAmount"].ToString()) * price;
                string[] subItems = new string[] { 
                    useMoney.ToString(), 
                    dtUse.Rows[i]["allAmount"].ToString(), 
                    price.ToString(), 
                    dtUse.Rows[i]["time"].ToString() 
                };
                lvi.SubItems.AddRange(subItems);
            }
            this.lvUsedWater.Refresh();

            // 
            //
            for (int i = 0; i < dtSel.Rows.Count; i++)
            {
                DataRow row = dtSel.Rows[i];

                ListViewItem lvi = this.lvSaleWater.Items.Add(selectWell);
                float allMoney = float.Parse(dtSel.Rows[i]["allSalAmount"].ToString()) * (price);

                float saleMoney = Convert.ToSingle (row["salMony"]);
                float saleAmount = Convert.ToSingle (row["salAmount"]);

                string[] subItems = new string[] { 
                                                     allMoney.ToString(), 
                                                     dtSel.Rows[i]["allSalAmount"].ToString(), 
                                                     saleMoney.ToString(),
                                                     saleAmount.ToString(),
                                                     price.ToString(), 
                                                     dtSel.Rows[i]["time"].ToString() 
                                                 };
                lvi.SubItems.AddRange(subItems);
            }
            this.lvSaleWater.Refresh();
        }
        #endregion //lvDatas_DoubleClick


        /// <summary>
        /// 
        /// </summary>
        private PrintClass PC
        {
            get
            {
                if (_pc == null)
                    _pc = new PrintClass(this.lvDatas, lvDatas.Font);
                return _pc;
            }

        } PrintClass _pc;

        #region printDocument1_PrintPage
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            //PrintClass pc = new PrintClass(this.lvDatas, e, this.lvDatas.Font );
            PC.Print(e);
            return;

            StringFormat ss = new StringFormat();
            ss.Alignment = StringAlignment.Center;      //居中位置                        
            e.Graphics.DrawString("", new Font("Arial", 20, FontStyle.Bold), Brushes.Black, new Point(e.PageBounds.Width / 2, 20), ss);

            //显示双下划线
            e.Graphics.DrawLine(Pens.Black, new Point(e.PageBounds.Width / 2 - 200, 50), new Point(e.PageBounds.Width / 2 + 200, 50));
            e.Graphics.DrawLine(Pens.Black, new Point(e.PageBounds.Width / 2 - 200, 52), new Point(e.PageBounds.Width / 2 + 200, 52));

            //显示打印日期
            e.Graphics.DrawString("打印日期：" + DateTime.Now, new Font("Arial", 12, FontStyle.Bold), Brushes.Black, 500, 60);

            int l1 = 75;  //x的起始点
            //显示列标题
            for (int i = 0; i < 8; i++)
            {
                string str = this.lvDatas.Columns[i].Text;    //获取列中的标题文本内容
                if (i == 0)
                {
                    e.Graphics.DrawRectangle(Pens.Black, l1, 80, this.lvDatas.Columns[i].Width + 200, 25);
                    int l_w = (2 * l1 + this.lvDatas.Columns[i].Width + 180) / 2;          //框的中点
                    e.Graphics.DrawString(str, new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new Point(l_w, 80), ss);
                    l1 += this.lvDatas.Columns[i].Width + 200;
                }
                else
                {
                    e.Graphics.DrawRectangle(Pens.Black, l1, 80, this.lvDatas.Columns[i].Width + 20, 25);
                    int l_w = (2 * l1 + this.lvDatas.Columns[i].Width + 20) / 2;          //框的中点
                    e.Graphics.DrawString(str, new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new Point(l_w, 80), ss);
                    l1 += this.lvDatas.Columns[i].Width + 20;

                }
            }
            //显示列内容
            for (int i = 0; i <= this.lvDatas.Items.Count - 1; i++)
            {
                int l2 = 75; //x的起始点
                int sss = this.lvDatas.Items.Count;
                int fyz = 20;
                if (i == fyz)
                {
                    i++;
                    fyz = fyz + 20;
                    e.HasMorePages = true;
                    break;
                }
                else
                {
                    e.HasMorePages = false;
                }
                for (int j = 0; j < 8; j++)
                {
                    string str = this.lvDatas.Items[i].SubItems[j].Text;
                    if (j == 0)
                    {
                        e.Graphics.DrawRectangle(Pens.Black, l2, 105 + (25 * i), this.lvDatas.Columns[j].Width + 200, 25);
                        int l_w1 = (2 * l2 + this.lvDatas.Columns[j].Width + 190) / 2;  //框的中点
                        e.Graphics.DrawString(str, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(l_w1, 105 + (25 * i)), ss);
                        l2 += this.lvDatas.Columns[j].Width + 200;
                    }
                    else
                    {
                        e.Graphics.DrawRectangle(Pens.Black, l2, 105 + (25 * i), this.lvDatas.Columns[j].Width + 20, 25);
                        int l_w1 = (2 * l2 + this.lvDatas.Columns[j].Width + 20) / 2;      //框的中点
                        e.Graphics.DrawString(str, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(l_w1, 105 + (25 * i)), ss);
                        l2 += this.lvDatas.Columns[j].Width + 20;
                    }
                }
            }
        }
        #endregion //printDocument1_PrintPage


        #region btnPrint_Click
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPrint_Click(object sender, System.EventArgs e)
        {
            if (lvDatas.Items.Count == 0)
            {
                ShowExclamationMsg("没有可打印数据!");
                return;
            }

            printPreviewDialog1.Document = printDocument1;
            printDocument1.DefaultPageSettings.Landscape = true;
            //try
            //{

            PC.Init();


            printPreviewDialog1.ShowDialog();


            //}
            //catch(Exception ex)
            //{
            //      MessageBox.Show(ex.Message,"打印出错",MessageBoxButtons.OK,MessageBoxIcon.Error);

            //}

        }
        #endregion //btnPrint_Click

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void printDocument1_BeginPrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            this.PC.Init();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lvDatas_SelectedIndexChanged(object sender, System.EventArgs e)
        {
        
        }

    }

    /// <summary>
    /// 
    /// </summary>
    internal enum ListViewItemType
    {
        Sum,
    }


}
