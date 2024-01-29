namespace StockView
{
    partial class UC_Stock
    {
        /// <summary> 
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 구성 요소 디자이너에서 생성한 코드

        /// <summary> 
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.btn_Search = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label26 = new System.Windows.Forms.Label();
            this.txt_endVs = new System.Windows.Forms.TextBox();
            this.txt_endMrktTotAmt = new System.Windows.Forms.TextBox();
            this.txt_endLstgStCnt = new System.Windows.Forms.TextBox();
            this.txt_endTrPrc = new System.Windows.Forms.TextBox();
            this.txt_endTrqu = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_likeSrtnCd = new System.Windows.Forms.TextBox();
            this.txt_endFltRt = new System.Windows.Forms.TextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txt_beginMrktTotAmt = new System.Windows.Forms.TextBox();
            this.txt_beginLstgStCnt = new System.Windows.Forms.TextBox();
            this.txt_beginTrPrc = new System.Windows.Forms.TextBox();
            this.txt_beginTrqu = new System.Windows.Forms.TextBox();
            this.txt_beginFltRt = new System.Windows.Forms.TextBox();
            this.groupBox_basDt = new System.Windows.Forms.GroupBox();
            this.date_endBasDt = new System.Windows.Forms.DateTimePicker();
            this.date_beginBasDt = new System.Windows.Forms.DateTimePicker();
            this.label25 = new System.Windows.Forms.Label();
            this.radio_basDt_3 = new System.Windows.Forms.RadioButton();
            this.radio_basDt_2 = new System.Windows.Forms.RadioButton();
            this.radio_basDt_1 = new System.Windows.Forms.RadioButton();
            this.txt_beginVs = new System.Windows.Forms.TextBox();
            this.groupBox_ISIN = new System.Windows.Forms.GroupBox();
            this.radio_ISIN_2 = new System.Windows.Forms.RadioButton();
            this.txt_isinCd = new System.Windows.Forms.TextBox();
            this.radio_ISIN_1 = new System.Windows.Forms.RadioButton();
            this.txt_mrktCls = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.txt_bizYear = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txt_crno = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.checkBox_Dividend = new System.Windows.Forms.CheckBox();
            this.checkBox_StockInfo = new System.Windows.Forms.CheckBox();
            this.checkBox_StockPrice = new System.Windows.Forms.CheckBox();
            this.groupBox_StockName = new System.Windows.Forms.GroupBox();
            this.radio_StockName_2 = new System.Windows.Forms.RadioButton();
            this.radio_StockName_1 = new System.Windows.Forms.RadioButton();
            this.txt_StockItemName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_PageRowCount = new System.Windows.Forms.TextBox();
            this.checkBox_FinalStat = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_PageNumber = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.btn_treeViewClear = new System.Windows.Forms.Button();
            this.btn_DataTableToGridView = new System.Windows.Forms.Button();
            this.btn_DataToChart = new System.Windows.Forms.Button();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.dataGridView_Vertical = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tabPage7 = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label28 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.groupBox_basDt.SuspendLayout();
            this.groupBox_ISIN.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.tabPage6.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox_StockName.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Vertical)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.tabPage7.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView.Location = new System.Drawing.Point(0, 0);
            this.dataGridView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersWidth = 51;
            this.dataGridView.RowTemplate.Height = 27;
            this.dataGridView.Size = new System.Drawing.Size(408, 705);
            this.dataGridView.TabIndex = 0;
            // 
            // btn_Search
            // 
            this.btn_Search.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btn_Search.Location = new System.Drawing.Point(0, 657);
            this.btn_Search.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(403, 48);
            this.btn_Search.TabIndex = 9;
            this.btn_Search.Text = "검색";
            this.btn_Search.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage7);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1308, 735);
            this.tabControl1.TabIndex = 4;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.splitContainer1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage1.Size = new System.Drawing.Size(1300, 709);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "주식 정보 입력";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(3, 2);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.splitContainer3);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(1294, 705);
            this.splitContainer1.SplitterDistance = 677;
            this.splitContainer1.SplitterWidth = 9;
            this.splitContainer1.TabIndex = 8;
            // 
            // splitContainer3
            // 
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.Location = new System.Drawing.Point(0, 0);
            this.splitContainer3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.splitContainer3.Name = "splitContainer3";
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.groupBox2);
            this.splitContainer3.Panel1.Controls.Add(this.groupBox5);
            this.splitContainer3.Panel1.Controls.Add(this.btn_Search);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.groupBox1);
            this.splitContainer3.Size = new System.Drawing.Size(677, 705);
            this.splitContainer3.SplitterDistance = 403;
            this.splitContainer3.SplitterWidth = 18;
            this.splitContainer3.TabIndex = 10;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tabControl2);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 234);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(403, 423);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "상세정보 입력";
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tabPage3);
            this.tabControl2.Controls.Add(this.tabPage4);
            this.tabControl2.Controls.Add(this.tabPage5);
            this.tabControl2.Controls.Add(this.tabPage6);
            this.tabControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl2.Location = new System.Drawing.Point(3, 17);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(397, 403);
            this.tabControl2.TabIndex = 18;
            // 
            // tabPage3
            // 
            this.tabPage3.AutoScroll = true;
            this.tabPage3.Controls.Add(this.label26);
            this.tabPage3.Controls.Add(this.txt_endVs);
            this.tabPage3.Controls.Add(this.txt_endMrktTotAmt);
            this.tabPage3.Controls.Add(this.txt_endLstgStCnt);
            this.tabPage3.Controls.Add(this.txt_endTrPrc);
            this.tabPage3.Controls.Add(this.txt_endTrqu);
            this.tabPage3.Controls.Add(this.label5);
            this.tabPage3.Controls.Add(this.txt_likeSrtnCd);
            this.tabPage3.Controls.Add(this.txt_endFltRt);
            this.tabPage3.Controls.Add(this.label24);
            this.tabPage3.Controls.Add(this.label23);
            this.tabPage3.Controls.Add(this.label15);
            this.tabPage3.Controls.Add(this.label14);
            this.tabPage3.Controls.Add(this.label12);
            this.tabPage3.Controls.Add(this.txt_beginMrktTotAmt);
            this.tabPage3.Controls.Add(this.txt_beginLstgStCnt);
            this.tabPage3.Controls.Add(this.txt_beginTrPrc);
            this.tabPage3.Controls.Add(this.txt_beginTrqu);
            this.tabPage3.Controls.Add(this.txt_beginFltRt);
            this.tabPage3.Controls.Add(this.groupBox_basDt);
            this.tabPage3.Controls.Add(this.txt_beginVs);
            this.tabPage3.Controls.Add(this.groupBox_ISIN);
            this.tabPage3.Controls.Add(this.txt_mrktCls);
            this.tabPage3.Controls.Add(this.label22);
            this.tabPage3.Controls.Add(this.label21);
            this.tabPage3.Controls.Add(this.label20);
            this.tabPage3.Controls.Add(this.label19);
            this.tabPage3.Controls.Add(this.label18);
            this.tabPage3.Controls.Add(this.label17);
            this.tabPage3.Controls.Add(this.label16);
            this.tabPage3.Controls.Add(this.label9);
            this.tabPage3.Controls.Add(this.label4);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(389, 377);
            this.tabPage3.TabIndex = 0;
            this.tabPage3.Text = "시세정보";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(220, 204);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(14, 12);
            this.label26.TabIndex = 82;
            this.label26.Text = "~";
            // 
            // txt_endVs
            // 
            this.txt_endVs.Location = new System.Drawing.Point(240, 201);
            this.txt_endVs.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_endVs.Name = "txt_endVs";
            this.txt_endVs.Size = new System.Drawing.Size(130, 21);
            this.txt_endVs.TabIndex = 81;
            // 
            // txt_endMrktTotAmt
            // 
            this.txt_endMrktTotAmt.Location = new System.Drawing.Point(240, 326);
            this.txt_endMrktTotAmt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_endMrktTotAmt.Name = "txt_endMrktTotAmt";
            this.txt_endMrktTotAmt.Size = new System.Drawing.Size(130, 21);
            this.txt_endMrktTotAmt.TabIndex = 80;
            // 
            // txt_endLstgStCnt
            // 
            this.txt_endLstgStCnt.Location = new System.Drawing.Point(240, 301);
            this.txt_endLstgStCnt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_endLstgStCnt.Name = "txt_endLstgStCnt";
            this.txt_endLstgStCnt.Size = new System.Drawing.Size(130, 21);
            this.txt_endLstgStCnt.TabIndex = 79;
            // 
            // txt_endTrPrc
            // 
            this.txt_endTrPrc.Location = new System.Drawing.Point(240, 276);
            this.txt_endTrPrc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_endTrPrc.Name = "txt_endTrPrc";
            this.txt_endTrPrc.Size = new System.Drawing.Size(130, 21);
            this.txt_endTrPrc.TabIndex = 78;
            // 
            // txt_endTrqu
            // 
            this.txt_endTrqu.Location = new System.Drawing.Point(240, 251);
            this.txt_endTrqu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_endTrqu.Name = "txt_endTrqu";
            this.txt_endTrqu.Size = new System.Drawing.Size(130, 21);
            this.txt_endTrqu.TabIndex = 77;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 154);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 12);
            this.label5.TabIndex = 47;
            this.label5.Text = "단축코드 : ";
            // 
            // txt_likeSrtnCd
            // 
            this.txt_likeSrtnCd.Location = new System.Drawing.Point(84, 151);
            this.txt_likeSrtnCd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_likeSrtnCd.Name = "txt_likeSrtnCd";
            this.txt_likeSrtnCd.Size = new System.Drawing.Size(130, 21);
            this.txt_likeSrtnCd.TabIndex = 56;
            // 
            // txt_endFltRt
            // 
            this.txt_endFltRt.Location = new System.Drawing.Point(240, 226);
            this.txt_endFltRt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_endFltRt.Name = "txt_endFltRt";
            this.txt_endFltRt.Size = new System.Drawing.Size(130, 21);
            this.txt_endFltRt.TabIndex = 76;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(220, 331);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(14, 12);
            this.label24.TabIndex = 75;
            this.label24.Text = "~";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(220, 306);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(14, 12);
            this.label23.TabIndex = 74;
            this.label23.Text = "~";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(220, 281);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(14, 12);
            this.label15.TabIndex = 73;
            this.label15.Text = "~";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(220, 256);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(14, 12);
            this.label14.TabIndex = 72;
            this.label14.Text = "~";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(220, 231);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(14, 12);
            this.label12.TabIndex = 71;
            this.label12.Text = "~";
            // 
            // txt_beginMrktTotAmt
            // 
            this.txt_beginMrktTotAmt.Location = new System.Drawing.Point(84, 326);
            this.txt_beginMrktTotAmt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_beginMrktTotAmt.Name = "txt_beginMrktTotAmt";
            this.txt_beginMrktTotAmt.Size = new System.Drawing.Size(130, 21);
            this.txt_beginMrktTotAmt.TabIndex = 69;
            // 
            // txt_beginLstgStCnt
            // 
            this.txt_beginLstgStCnt.Location = new System.Drawing.Point(84, 301);
            this.txt_beginLstgStCnt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_beginLstgStCnt.Name = "txt_beginLstgStCnt";
            this.txt_beginLstgStCnt.Size = new System.Drawing.Size(130, 21);
            this.txt_beginLstgStCnt.TabIndex = 68;
            // 
            // txt_beginTrPrc
            // 
            this.txt_beginTrPrc.Location = new System.Drawing.Point(84, 276);
            this.txt_beginTrPrc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_beginTrPrc.Name = "txt_beginTrPrc";
            this.txt_beginTrPrc.Size = new System.Drawing.Size(130, 21);
            this.txt_beginTrPrc.TabIndex = 67;
            // 
            // txt_beginTrqu
            // 
            this.txt_beginTrqu.Location = new System.Drawing.Point(84, 251);
            this.txt_beginTrqu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_beginTrqu.Name = "txt_beginTrqu";
            this.txt_beginTrqu.Size = new System.Drawing.Size(130, 21);
            this.txt_beginTrqu.TabIndex = 66;
            // 
            // txt_beginFltRt
            // 
            this.txt_beginFltRt.Location = new System.Drawing.Point(84, 226);
            this.txt_beginFltRt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_beginFltRt.Name = "txt_beginFltRt";
            this.txt_beginFltRt.Size = new System.Drawing.Size(130, 21);
            this.txt_beginFltRt.TabIndex = 65;
            // 
            // groupBox_basDt
            // 
            this.groupBox_basDt.Controls.Add(this.date_endBasDt);
            this.groupBox_basDt.Controls.Add(this.date_beginBasDt);
            this.groupBox_basDt.Controls.Add(this.label25);
            this.groupBox_basDt.Controls.Add(this.radio_basDt_3);
            this.groupBox_basDt.Controls.Add(this.radio_basDt_2);
            this.groupBox_basDt.Controls.Add(this.radio_basDt_1);
            this.groupBox_basDt.Location = new System.Drawing.Point(78, 3);
            this.groupBox_basDt.Name = "groupBox_basDt";
            this.groupBox_basDt.Size = new System.Drawing.Size(301, 71);
            this.groupBox_basDt.TabIndex = 62;
            this.groupBox_basDt.TabStop = false;
            // 
            // date_endBasDt
            // 
            this.date_endBasDt.Location = new System.Drawing.Point(144, 42);
            this.date_endBasDt.Name = "date_endBasDt";
            this.date_endBasDt.Size = new System.Drawing.Size(117, 21);
            this.date_endBasDt.TabIndex = 84;
            // 
            // date_beginBasDt
            // 
            this.date_beginBasDt.Location = new System.Drawing.Point(6, 42);
            this.date_beginBasDt.Name = "date_beginBasDt";
            this.date_beginBasDt.Size = new System.Drawing.Size(117, 21);
            this.date_beginBasDt.TabIndex = 83;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(129, 48);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(14, 12);
            this.label25.TabIndex = 81;
            this.label25.Text = "~";
            // 
            // radio_basDt_3
            // 
            this.radio_basDt_3.AutoSize = true;
            this.radio_basDt_3.Checked = true;
            this.radio_basDt_3.Location = new System.Drawing.Point(109, 20);
            this.radio_basDt_3.Name = "radio_basDt_3";
            this.radio_basDt_3.Size = new System.Drawing.Size(47, 16);
            this.radio_basDt_3.TabIndex = 40;
            this.radio_basDt_3.TabStop = true;
            this.radio_basDt_3.Text = "범위";
            this.radio_basDt_3.UseVisualStyleBackColor = true;
            // 
            // radio_basDt_2
            // 
            this.radio_basDt_2.AutoSize = true;
            this.radio_basDt_2.Location = new System.Drawing.Point(59, 20);
            this.radio_basDt_2.Name = "radio_basDt_2";
            this.radio_basDt_2.Size = new System.Drawing.Size(47, 16);
            this.radio_basDt_2.TabIndex = 38;
            this.radio_basDt_2.TabStop = true;
            this.radio_basDt_2.Text = "포함";
            this.radio_basDt_2.UseVisualStyleBackColor = true;
            // 
            // radio_basDt_1
            // 
            this.radio_basDt_1.AutoSize = true;
            this.radio_basDt_1.Location = new System.Drawing.Point(6, 20);
            this.radio_basDt_1.Name = "radio_basDt_1";
            this.radio_basDt_1.Size = new System.Drawing.Size(47, 16);
            this.radio_basDt_1.TabIndex = 37;
            this.radio_basDt_1.Text = "일치";
            this.radio_basDt_1.UseVisualStyleBackColor = true;
            // 
            // txt_beginVs
            // 
            this.txt_beginVs.Location = new System.Drawing.Point(84, 201);
            this.txt_beginVs.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_beginVs.Name = "txt_beginVs";
            this.txt_beginVs.Size = new System.Drawing.Size(130, 21);
            this.txt_beginVs.TabIndex = 34;
            // 
            // groupBox_ISIN
            // 
            this.groupBox_ISIN.Controls.Add(this.radio_ISIN_2);
            this.groupBox_ISIN.Controls.Add(this.txt_isinCd);
            this.groupBox_ISIN.Controls.Add(this.radio_ISIN_1);
            this.groupBox_ISIN.Location = new System.Drawing.Point(78, 80);
            this.groupBox_ISIN.Name = "groupBox_ISIN";
            this.groupBox_ISIN.Size = new System.Drawing.Size(301, 66);
            this.groupBox_ISIN.TabIndex = 60;
            this.groupBox_ISIN.TabStop = false;
            // 
            // radio_ISIN_2
            // 
            this.radio_ISIN_2.AutoSize = true;
            this.radio_ISIN_2.Location = new System.Drawing.Point(59, 18);
            this.radio_ISIN_2.Name = "radio_ISIN_2";
            this.radio_ISIN_2.Size = new System.Drawing.Size(47, 16);
            this.radio_ISIN_2.TabIndex = 38;
            this.radio_ISIN_2.TabStop = true;
            this.radio_ISIN_2.Text = "포함";
            this.radio_ISIN_2.UseVisualStyleBackColor = true;
            // 
            // txt_isinCd
            // 
            this.txt_isinCd.Location = new System.Drawing.Point(6, 39);
            this.txt_isinCd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_isinCd.Name = "txt_isinCd";
            this.txt_isinCd.Size = new System.Drawing.Size(130, 21);
            this.txt_isinCd.TabIndex = 34;
            // 
            // radio_ISIN_1
            // 
            this.radio_ISIN_1.AutoSize = true;
            this.radio_ISIN_1.Checked = true;
            this.radio_ISIN_1.Location = new System.Drawing.Point(6, 18);
            this.radio_ISIN_1.Name = "radio_ISIN_1";
            this.radio_ISIN_1.Size = new System.Drawing.Size(47, 16);
            this.radio_ISIN_1.TabIndex = 37;
            this.radio_ISIN_1.TabStop = true;
            this.radio_ISIN_1.Text = "일치";
            this.radio_ISIN_1.UseVisualStyleBackColor = true;
            // 
            // txt_mrktCls
            // 
            this.txt_mrktCls.Location = new System.Drawing.Point(84, 176);
            this.txt_mrktCls.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_mrktCls.Name = "txt_mrktCls";
            this.txt_mrktCls.Size = new System.Drawing.Size(130, 21);
            this.txt_mrktCls.TabIndex = 57;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(1, 306);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(77, 12);
            this.label22.TabIndex = 55;
            this.label22.Text = "상장주식수 : ";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(13, 331);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(65, 12);
            this.label21.TabIndex = 54;
            this.label21.Text = "시가총액 : ";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(13, 281);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(65, 12);
            this.label20.TabIndex = 53;
            this.label20.Text = "거래대금 : ";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(25, 256);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(53, 12);
            this.label19.TabIndex = 52;
            this.label19.Text = "거래량 : ";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(25, 231);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(53, 12);
            this.label18.TabIndex = 51;
            this.label18.Text = "등락률 : ";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(37, 204);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(41, 12);
            this.label17.TabIndex = 50;
            this.label17.Text = "대비 : ";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(13, 179);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(65, 12);
            this.label16.TabIndex = 49;
            this.label16.Text = "시장구분 : ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(14, 102);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(64, 12);
            this.label9.TabIndex = 48;
            this.label9.Text = "ISIN코드 : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 46;
            this.label4.Text = "기준일자 : ";
            // 
            // tabPage4
            // 
            this.tabPage4.AutoScroll = true;
            this.tabPage4.Controls.Add(this.dateTimePicker1);
            this.tabPage4.Controls.Add(this.textBox2);
            this.tabPage4.Controls.Add(this.label7);
            this.tabPage4.Controls.Add(this.label6);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(389, 377);
            this.tabPage4.TabIndex = 1;
            this.tabPage4.Text = "발행정보";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(104, 6);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(117, 21);
            this.dateTimePicker1.TabIndex = 84;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(104, 30);
            this.textBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(130, 21);
            this.textBox2.TabIndex = 70;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 33);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 12);
            this.label7.TabIndex = 69;
            this.label7.Text = "법인등록번호 : ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(33, 8);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 12);
            this.label6.TabIndex = 68;
            this.label6.Text = "기준일자 : ";
            // 
            // tabPage5
            // 
            this.tabPage5.AutoScroll = true;
            this.tabPage5.Controls.Add(this.dateTimePicker2);
            this.tabPage5.Controls.Add(this.textBox3);
            this.tabPage5.Controls.Add(this.label8);
            this.tabPage5.Controls.Add(this.label10);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(389, 377);
            this.tabPage5.TabIndex = 2;
            this.tabPage5.Text = "배당정보";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(104, 6);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(117, 21);
            this.dateTimePicker2.TabIndex = 84;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(104, 30);
            this.textBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(130, 21);
            this.textBox3.TabIndex = 74;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(9, 33);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(89, 12);
            this.label8.TabIndex = 73;
            this.label8.Text = "법인등록번호 : ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(33, 8);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(65, 12);
            this.label10.TabIndex = 72;
            this.label10.Text = "기준일자 : ";
            // 
            // tabPage6
            // 
            this.tabPage6.AutoScroll = true;
            this.tabPage6.Controls.Add(this.txt_bizYear);
            this.tabPage6.Controls.Add(this.label11);
            this.tabPage6.Controls.Add(this.txt_crno);
            this.tabPage6.Controls.Add(this.label13);
            this.tabPage6.Location = new System.Drawing.Point(4, 22);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage6.Size = new System.Drawing.Size(389, 377);
            this.tabPage6.TabIndex = 3;
            this.tabPage6.Text = "재무정보";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // txt_bizYear
            // 
            this.txt_bizYear.Location = new System.Drawing.Point(103, 30);
            this.txt_bizYear.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_bizYear.Name = "txt_bizYear";
            this.txt_bizYear.Size = new System.Drawing.Size(130, 21);
            this.txt_bizYear.TabIndex = 79;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(32, 33);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(65, 12);
            this.label11.TabIndex = 78;
            this.label11.Text = "사업연도 : ";
            // 
            // txt_crno
            // 
            this.txt_crno.Location = new System.Drawing.Point(103, 5);
            this.txt_crno.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_crno.Name = "txt_crno";
            this.txt_crno.Size = new System.Drawing.Size(130, 21);
            this.txt_crno.TabIndex = 77;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.ForeColor = System.Drawing.Color.Red;
            this.label13.Location = new System.Drawing.Point(8, 8);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(89, 12);
            this.label13.TabIndex = 76;
            this.label13.Text = "법인등록번호 : ";
            // 
            // groupBox5
            // 
            this.groupBox5.AutoSize = true;
            this.groupBox5.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox5.Controls.Add(this.checkBox_Dividend);
            this.groupBox5.Controls.Add(this.checkBox_StockInfo);
            this.groupBox5.Controls.Add(this.checkBox_StockPrice);
            this.groupBox5.Controls.Add(this.groupBox_StockName);
            this.groupBox5.Controls.Add(this.label1);
            this.groupBox5.Controls.Add(this.txt_PageRowCount);
            this.groupBox5.Controls.Add(this.checkBox_FinalStat);
            this.groupBox5.Controls.Add(this.label2);
            this.groupBox5.Controls.Add(this.txt_PageNumber);
            this.groupBox5.Controls.Add(this.label3);
            this.groupBox5.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox5.Location = new System.Drawing.Point(0, 0);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.groupBox5.Size = new System.Drawing.Size(403, 234);
            this.groupBox5.TabIndex = 49;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "공통정보 입력";
            // 
            // checkBox_Dividend
            // 
            this.checkBox_Dividend.AutoSize = true;
            this.checkBox_Dividend.Location = new System.Drawing.Point(87, 176);
            this.checkBox_Dividend.Name = "checkBox_Dividend";
            this.checkBox_Dividend.Size = new System.Drawing.Size(196, 16);
            this.checkBox_Dividend.TabIndex = 7;
            this.checkBox_Dividend.Text = "주식 배당 정보 검색에 포함하기";
            this.checkBox_Dividend.UseVisualStyleBackColor = true;
            // 
            // checkBox_StockInfo
            // 
            this.checkBox_StockInfo.AutoSize = true;
            this.checkBox_StockInfo.Location = new System.Drawing.Point(88, 154);
            this.checkBox_StockInfo.Name = "checkBox_StockInfo";
            this.checkBox_StockInfo.Size = new System.Drawing.Size(196, 16);
            this.checkBox_StockInfo.TabIndex = 6;
            this.checkBox_StockInfo.Text = "주식 발행 정보 검색에 포함하기";
            this.checkBox_StockInfo.UseVisualStyleBackColor = true;
            // 
            // checkBox_StockPrice
            // 
            this.checkBox_StockPrice.AutoSize = true;
            this.checkBox_StockPrice.Checked = true;
            this.checkBox_StockPrice.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_StockPrice.Location = new System.Drawing.Point(88, 132);
            this.checkBox_StockPrice.Name = "checkBox_StockPrice";
            this.checkBox_StockPrice.Size = new System.Drawing.Size(196, 16);
            this.checkBox_StockPrice.TabIndex = 5;
            this.checkBox_StockPrice.Text = "주식 시세 정보 검색에 포함하기";
            this.checkBox_StockPrice.UseVisualStyleBackColor = true;
            // 
            // groupBox_StockName
            // 
            this.groupBox_StockName.Controls.Add(this.radio_StockName_2);
            this.groupBox_StockName.Controls.Add(this.radio_StockName_1);
            this.groupBox_StockName.Controls.Add(this.txt_StockItemName);
            this.groupBox_StockName.Location = new System.Drawing.Point(82, 10);
            this.groupBox_StockName.Name = "groupBox_StockName";
            this.groupBox_StockName.Size = new System.Drawing.Size(197, 66);
            this.groupBox_StockName.TabIndex = 48;
            this.groupBox_StockName.TabStop = false;
            // 
            // radio_StockName_2
            // 
            this.radio_StockName_2.AutoSize = true;
            this.radio_StockName_2.Location = new System.Drawing.Point(142, 42);
            this.radio_StockName_2.Name = "radio_StockName_2";
            this.radio_StockName_2.Size = new System.Drawing.Size(47, 16);
            this.radio_StockName_2.TabIndex = 38;
            this.radio_StockName_2.TabStop = true;
            this.radio_StockName_2.Text = "포함";
            this.radio_StockName_2.UseVisualStyleBackColor = true;
            // 
            // radio_StockName_1
            // 
            this.radio_StockName_1.AutoSize = true;
            this.radio_StockName_1.Checked = true;
            this.radio_StockName_1.Location = new System.Drawing.Point(142, 20);
            this.radio_StockName_1.Name = "radio_StockName_1";
            this.radio_StockName_1.Size = new System.Drawing.Size(47, 16);
            this.radio_StockName_1.TabIndex = 37;
            this.radio_StockName_1.TabStop = true;
            this.radio_StockName_1.Text = "일치";
            this.radio_StockName_1.UseVisualStyleBackColor = true;
            // 
            // txt_StockItemName
            // 
            this.txt_StockItemName.Location = new System.Drawing.Point(6, 19);
            this.txt_StockItemName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_StockItemName.Name = "txt_StockItemName";
            this.txt_StockItemName.Size = new System.Drawing.Size(130, 21);
            this.txt_StockItemName.TabIndex = 1;
            this.txt_StockItemName.Text = "삼성전자";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(29, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 43;
            this.label1.Text = "종목명 : ";
            // 
            // txt_PageRowCount
            // 
            this.txt_PageRowCount.Location = new System.Drawing.Point(88, 106);
            this.txt_PageRowCount.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_PageRowCount.Name = "txt_PageRowCount";
            this.txt_PageRowCount.Size = new System.Drawing.Size(130, 21);
            this.txt_PageRowCount.TabIndex = 45;
            this.txt_PageRowCount.Text = "100";
            // 
            // checkBox_FinalStat
            // 
            this.checkBox_FinalStat.AutoSize = true;
            this.checkBox_FinalStat.Location = new System.Drawing.Point(87, 198);
            this.checkBox_FinalStat.Name = "checkBox_FinalStat";
            this.checkBox_FinalStat.Size = new System.Drawing.Size(196, 16);
            this.checkBox_FinalStat.TabIndex = 8;
            this.checkBox_FinalStat.Text = "주식 재무 정보 검색에 포함하기";
            this.checkBox_FinalStat.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(1, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 12);
            this.label2.TabIndex = 46;
            this.label2.Text = "페이지 번호 : ";
            // 
            // txt_PageNumber
            // 
            this.txt_PageNumber.Location = new System.Drawing.Point(88, 81);
            this.txt_PageNumber.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_PageNumber.Name = "txt_PageNumber";
            this.txt_PageNumber.Size = new System.Drawing.Size(130, 21);
            this.txt_PageNumber.TabIndex = 44;
            this.txt_PageNumber.Text = "1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(25, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 12);
            this.label3.TabIndex = 47;
            this.label3.Text = "결과 수 : ";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.treeView1);
            this.groupBox1.Controls.Add(this.btn_treeViewClear);
            this.groupBox1.Controls.Add(this.btn_DataTableToGridView);
            this.groupBox1.Controls.Add(this.btn_DataToChart);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(256, 705);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "데이터";
            // 
            // treeView1
            // 
            this.treeView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeView1.Location = new System.Drawing.Point(3, 107);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(250, 595);
            this.treeView1.TabIndex = 6;
            // 
            // btn_treeViewClear
            // 
            this.btn_treeViewClear.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_treeViewClear.Location = new System.Drawing.Point(3, 77);
            this.btn_treeViewClear.Name = "btn_treeViewClear";
            this.btn_treeViewClear.Size = new System.Drawing.Size(250, 30);
            this.btn_treeViewClear.TabIndex = 11;
            this.btn_treeViewClear.Text = "검색기록 지우기";
            this.btn_treeViewClear.UseVisualStyleBackColor = true;
            // 
            // btn_DataTableToGridView
            // 
            this.btn_DataTableToGridView.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_DataTableToGridView.Location = new System.Drawing.Point(3, 47);
            this.btn_DataTableToGridView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_DataTableToGridView.Name = "btn_DataTableToGridView";
            this.btn_DataTableToGridView.Size = new System.Drawing.Size(250, 30);
            this.btn_DataTableToGridView.TabIndex = 9;
            this.btn_DataTableToGridView.Text = "그리드 뷰로 보기";
            this.btn_DataTableToGridView.UseVisualStyleBackColor = true;
            // 
            // btn_DataToChart
            // 
            this.btn_DataToChart.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_DataToChart.Location = new System.Drawing.Point(3, 17);
            this.btn_DataToChart.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_DataToChart.Name = "btn_DataToChart";
            this.btn_DataToChart.Size = new System.Drawing.Size(250, 30);
            this.btn_DataToChart.TabIndex = 11;
            this.btn_DataToChart.Text = "차트로 보기";
            this.btn_DataToChart.UseVisualStyleBackColor = true;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.dataGridView);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.dataGridView_Vertical);
            this.splitContainer2.Size = new System.Drawing.Size(608, 705);
            this.splitContainer2.SplitterDistance = 408;
            this.splitContainer2.TabIndex = 9;
            // 
            // dataGridView_Vertical
            // 
            this.dataGridView_Vertical.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Vertical.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_Vertical.Location = new System.Drawing.Point(0, 0);
            this.dataGridView_Vertical.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView_Vertical.Name = "dataGridView_Vertical";
            this.dataGridView_Vertical.RowHeadersWidth = 51;
            this.dataGridView_Vertical.RowTemplate.Height = 27;
            this.dataGridView_Vertical.Size = new System.Drawing.Size(196, 705);
            this.dataGridView_Vertical.TabIndex = 10;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.chart1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage2.Size = new System.Drawing.Size(1300, 709);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "주식 차트 정보";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(3, 2);
            this.chart1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chart1.Name = "chart1";
            this.chart1.Size = new System.Drawing.Size(1294, 705);
            this.chart1.TabIndex = 2;
            this.chart1.Text = "chart1";
            // 
            // tabPage7
            // 
            this.tabPage7.Controls.Add(this.dataGridView1);
            this.tabPage7.Controls.Add(this.groupBox3);
            this.tabPage7.Controls.Add(this.button1);
            this.tabPage7.Location = new System.Drawing.Point(4, 22);
            this.tabPage7.Name = "tabPage7";
            this.tabPage7.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage7.Size = new System.Drawing.Size(1300, 709);
            this.tabPage7.TabIndex = 2;
            this.tabPage7.Text = "개인 수익";
            this.tabPage7.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.textBox4);
            this.groupBox3.Controls.Add(this.label28);
            this.groupBox3.Controls.Add(this.label27);
            this.groupBox3.Controls.Add(this.textBox1);
            this.groupBox3.Location = new System.Drawing.Point(6, 6);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(308, 106);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "현황";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(69, 53);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(217, 21);
            this.textBox4.TabIndex = 5;
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(10, 56);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(53, 12);
            this.label28.TabIndex = 1;
            this.label28.Text = "순수익 : ";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(10, 35);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(57, 12);
            this.label27.TabIndex = 0;
            this.label27.Text = "총 자산 : ";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(69, 26);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(217, 21);
            this.textBox1.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(320, 15);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "은행 추가";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(140, 203);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(240, 150);
            this.dataGridView1.TabIndex = 5;
            // 
            // UC_Stock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "UC_Stock";
            this.Size = new System.Drawing.Size(1308, 735);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel1.PerformLayout();
            this.splitContainer3.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.tabControl2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.groupBox_basDt.ResumeLayout(false);
            this.groupBox_basDt.PerformLayout();
            this.groupBox_ISIN.ResumeLayout(false);
            this.groupBox_ISIN.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            this.tabPage6.ResumeLayout(false);
            this.tabPage6.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox_StockName.ResumeLayout(false);
            this.groupBox_StockName.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Vertical)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.tabPage7.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox checkBox_Dividend;
        private System.Windows.Forms.CheckBox checkBox_StockInfo;
        private System.Windows.Forms.CheckBox checkBox_StockPrice;
        private System.Windows.Forms.Button btn_treeViewClear;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.DataGridView dataGridView_Vertical;
        private System.Windows.Forms.Button btn_DataTableToGridView;
        private System.Windows.Forms.CheckBox checkBox_FinalStat;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox_StockName;
        private System.Windows.Forms.RadioButton radio_StockName_2;
        private System.Windows.Forms.RadioButton radio_StockName_1;
        private System.Windows.Forms.TextBox txt_StockItemName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_PageRowCount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_PageNumber;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox_basDt;
        private System.Windows.Forms.RadioButton radio_basDt_3;
        private System.Windows.Forms.RadioButton radio_basDt_2;
        private System.Windows.Forms.RadioButton radio_basDt_1;
        private System.Windows.Forms.GroupBox groupBox_ISIN;
        private System.Windows.Forms.RadioButton radio_ISIN_2;
        private System.Windows.Forms.TextBox txt_isinCd;
        private System.Windows.Forms.RadioButton radio_ISIN_1;
        private System.Windows.Forms.TextBox txt_beginVs;
        private System.Windows.Forms.TextBox txt_mrktCls;
        private System.Windows.Forms.TextBox txt_likeSrtnCd;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txt_bizYear;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txt_crno;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txt_beginTrPrc;
        private System.Windows.Forms.TextBox txt_beginTrqu;
        private System.Windows.Forms.TextBox txt_beginFltRt;
        private System.Windows.Forms.TextBox txt_endMrktTotAmt;
        private System.Windows.Forms.TextBox txt_endLstgStCnt;
        private System.Windows.Forms.TextBox txt_endTrPrc;
        private System.Windows.Forms.TextBox txt_endTrqu;
        private System.Windows.Forms.TextBox txt_endFltRt;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txt_beginMrktTotAmt;
        private System.Windows.Forms.TextBox txt_beginLstgStCnt;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.TextBox txt_endVs;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.DateTimePicker date_endBasDt;
        private System.Windows.Forms.DateTimePicker date_beginBasDt;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Button btn_DataToChart;
        private System.Windows.Forms.TabPage tabPage7;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}
