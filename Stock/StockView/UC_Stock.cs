using StockController;
using StockModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.Xml;
using System.Xml.Linq;

namespace StockView
{
    public partial class UC_Stock : UserControl, IkoreanStockView
    {
        KoreanStockController koreanStockController { get; set; }
        public bool IsStockPrice { get; set; }
        public bool IsStockIssueInfo { get; set; }
        public bool IsStockDividend { get; set; }
        public bool IsStockFinalStat { get; set; }

        public UC_Stock()
        {
            InitializeComponent();
            this.btn_Search.Click += Btn_Search_Click;
            this.btn_DataToChart.Click += Btn_DataToChart_Click;
            this.treeView1.NodeMouseDoubleClick += TreeView1_NodeMouseDoubleClick;
            IsStockPrice = this.checkBox_StockPrice.Checked;
            IsStockIssueInfo = this.checkBox_StockInfo.Checked;
            IsStockDividend = this.checkBox_Dividend.Checked;
            IsStockFinalStat = this.checkBox_FinalStat.Checked;
            this.checkBox_StockPrice.CheckedChanged += CheckBox_CheckedChanged;
            this.checkBox_StockInfo.CheckedChanged += CheckBox_CheckedChanged;
            this.checkBox_Dividend.CheckedChanged += CheckBox_CheckedChanged;
            this.checkBox_FinalStat.CheckedChanged += CheckBox_CheckedChanged;
            this.btn_treeViewClear.Click += Btn_treeViewClear_Click;
            this.btn_DataTableToGridView.Click += Btn_DataTableToGridView_Click;
            this.radio_basDt_1.CheckedChanged += Radio_basDt_CheckedChanged;
            this.radio_basDt_2.CheckedChanged += Radio_basDt_CheckedChanged;
            this.radio_basDt_3.CheckedChanged += Radio_basDt_CheckedChanged;
            this.date_beginBasDt.Value = DateTime.Now.AddYears(-1);
            this.date_endBasDt.Value = DateTime.Today;
        }

        private void Btn_DataToChart_Click(object sender, EventArgs e)
        {
            TreeNode selectedNode = this.treeView1.SelectedNode;
            if (selectedNode.Tag != null)
            {
                if (selectedNode.Tag.GetType() == typeof(DataTable))
                {
                    FormSetChartDomain frm = new FormSetChartDomain((DataTable)selectedNode.Tag);
                    frm.StartPosition = FormStartPosition.CenterScreen;                    
                    if (frm.ShowDialog() == DialogResult.OK)
                    {
                        DataTableToChart((DataTable)selectedNode.Tag, selectedNode.FullPath, frm.XDomainName, frm.YDomainName);
                        this.tabControl1.TabPages[1].Select();
                    }
                }
            }
            else
            {
                MessageBox.Show("데이터를 하나 선택해주세요.");
            }
        }

        private void Radio_basDt_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton btn = sender as RadioButton;
            if(btn.Checked == true)
            {
                if (btn.Name == this.radio_basDt_1.Name)
                {
                    this.date_endBasDt.Enabled = false;
                }
                else if (btn.Name == this.radio_basDt_2.Name)
                {
                    this.date_endBasDt.Enabled = false;
                }
                else if (btn.Name == this.radio_basDt_3.Name)
                {
                    this.date_endBasDt.Enabled = true;
                }
            }
           
        }

        private void Btn_DataTableToGridView_Click(object sender, EventArgs e)
        {
            if (this.treeView1.SelectedNode != null)
            {
                if(this.treeView1.SelectedNode.Tag != null)
                {
                    if (this.treeView1.SelectedNode.Tag.GetType() == typeof(DataTable))
                    {
                        DataTableToGridView((DataTable)this.treeView1.SelectedNode.Tag);
                    }
                }                
            }
        }

        private void Btn_treeViewClear_Click(object sender, EventArgs e)
        {
            this.treeView1.Nodes.Clear();
        }

        private void CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            IsStockPrice = this.checkBox_StockPrice.Checked;
            IsStockIssueInfo = this.checkBox_StockInfo.Checked;
            IsStockDividend = this.checkBox_Dividend.Checked;
            IsStockFinalStat = this.checkBox_FinalStat.Checked;
        }

        private void TreeView1_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (e.Node.Tag != null)
            {
                if (e.Node.Tag.GetType() == typeof(DataTable))
                {                    
                    DataTableToGridView((DataTable)e.Node.Tag);                                                                
                }
            }
        }

        private void DataTableToGridView(DataTable dt)
        {
            this.dataGridView.DataSource = dt;
            this.dataGridView_Vertical.DataSource = FlipDataTable(dt);
        }

        private void DataTableToChart(DataTable dt, string series_name, string xColumnName, string yColumnName)
        {
            chart1.Series.Clear();
            Series series = new Series(series_name);
            chart1.Series.Add(series);
            
            chart1.DataSource = dt;
            series.XValueMember = xColumnName;
            series.YValueMembers = yColumnName;            
            chart1.DataBind();
        }

        private DataTable FlipDataTable(DataTable my_dataTable)
        {
            DataTable table = new DataTable();

            for (int i = 0; i <= my_dataTable.Rows.Count; i++)
            { 
                table.Columns.Add(Convert.ToString(i)); 
            }

            DataRow r;
            for (int k = 0; k < my_dataTable.Columns.Count; k++)
            {
                r = table.NewRow();
                r[0] = my_dataTable.Columns[k].ToString();
                for (int j = 1; j <= my_dataTable.Rows.Count; j++)
                { 
                    r[j] = my_dataTable.Rows[j - 1][k]; 
                }
                table.Rows.Add(r);
            }
            return table;
        }

        /// <summary>
        /// TextBox들로부터 RequestMessageInfo를 완성해서 컨트롤러에게 보내주기
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btn_Search_Click(object sender, EventArgs e)
        {
            try
            {
                if (Validation())
                {
                    System.Windows.Forms.Cursor.Current = Cursors.WaitCursor;
                    Int64.TryParse(this.txt_PageNumber.Text, out Int64 pageNo);
                    Int64.TryParse(this.txt_PageRowCount.Text, out Int64 numOfRows);
                    Int64.TryParse(this.txt_crno.Text, out Int64 crno);
                    Int64.TryParse(this.date_beginBasDt.Value.ToString("yyyyMMdd"), out Int64 beginBasDt);
                    Int64.TryParse(this.date_endBasDt.Value.ToString("yyyyMMdd"), out Int64 endBasDt);
                    Int64.TryParse(this.txt_likeSrtnCd.Text, out Int64 likeSrtnCd);
                    Decimal.TryParse(this.txt_beginVs.Text, out decimal beginVs);
                    Decimal.TryParse(this.txt_endVs.Text, out decimal endVs);
                    Decimal.TryParse(this.txt_beginFltRt.Text, out decimal beginFltRt);
                    Decimal.TryParse(this.txt_endFltRt.Text, out decimal endFltRt);
                    Int64.TryParse(this.txt_beginTrqu.Text, out Int64 beginTrqu);
                    Int64.TryParse(this.txt_endTrqu.Text, out Int64 endTrqu);
                    Int64.TryParse(this.txt_beginTrPrc.Text, out Int64 beginTrPrc);
                    Int64.TryParse(this.txt_endTrPrc.Text, out Int64 endTrPrc);
                    Int64.TryParse(this.txt_beginLstgStCnt.Text, out Int64 beginLstgStCnt);
                    Int64.TryParse(this.txt_endLstgStCnt.Text, out Int64 endLstgStCnt);
                    Int64.TryParse(this.txt_beginMrktTotAmt.Text, out Int64 beginMrktToAmt);
                    Int64.TryParse(this.txt_endMrktTotAmt.Text, out Int64 endMrktToAmt);
                    Int64.TryParse(this.txt_bizYear.Text, out Int64 bizYear);

                    #region 메세지 생성
                    RequestMessageInfo messageInfo = new RequestMessageInfo();

                    messageInfo.pageNo = pageNo;
                    messageInfo.numOfRows = numOfRows;

                    if (crno == 0)
                    {
                        messageInfo.crno = null;
                    }
                    else
                    {
                        messageInfo.crno = crno;
                    }

                    if (this.radio_StockName_1.Checked == true)
                    {
                        messageInfo.itmsNm = this.txt_StockItemName.Text;
                        messageInfo.stckIssuCmpyNm = this.txt_StockItemName.Text;
                    }
                    else if (this.radio_StockName_2.Checked == true)
                    {
                        messageInfo.likeItmsNm = this.txt_StockItemName.Text;
                        messageInfo.stckIssuCmpyNm = this.txt_StockItemName.Text;
                    }

                    if (this.radio_basDt_1.Checked == true)
                    {
                        messageInfo.basDt = beginBasDt;
                    }
                    else if (this.radio_basDt_2.Checked == true)
                    {
                        messageInfo.basDt = beginBasDt;
                        messageInfo.likeBasDt = beginBasDt;
                    }
                    else if (this.radio_basDt_3.Checked == true)
                    {
                        messageInfo.basDt = beginBasDt;
                        messageInfo.beginBasDt = beginBasDt;
                        messageInfo.endBasDt = endBasDt;
                    }

                    messageInfo.likeSrtnCd = likeSrtnCd;
                    if (this.radio_ISIN_1.Checked == true)
                    {
                        messageInfo.isinCd = this.txt_isinCd.Text;
                    }
                    else if (this.radio_ISIN_2.Checked == true)
                    {
                        messageInfo.likeIsinCd = this.txt_isinCd.Text;
                    }
                    messageInfo.mrktCls = this.txt_mrktCls.Text;
                    messageInfo.beginVs = beginVs;
                    messageInfo.endVs = endVs;
                    messageInfo.beginFltRt = beginFltRt;
                    messageInfo.endFltRt = endFltRt;
                    messageInfo.beginTrqu = beginTrqu;
                    messageInfo.endTrqu = endTrqu;
                    messageInfo.beginTrPrc = beginTrPrc;
                    messageInfo.endTrPrc = endTrPrc;
                    messageInfo.beginLstgStCnt = beginLstgStCnt;
                    messageInfo.endLstgStCnt = endLstgStCnt;
                    messageInfo.beginMrktTotAmt = beginMrktToAmt;
                    messageInfo.endMrktTotAmt = endMrktToAmt;
                    messageInfo.bizYear = bizYear;
                    #endregion

                    this.koreanStockController.Search(messageInfo);
                    System.Windows.Forms.Cursor.Current = Cursors.Default;
                }             
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private bool Validation()
        {
            bool success = true;
            if(this.txt_PageNumber.Text != null 
                && this.txt_PageNumber.Text != ""
                && this.txt_PageNumber.Text != "0")
            {
                success = true;
            }
            else
            {
                MessageBox.Show("1개 이상의 페이지 수를 정해주세요.");
                success = false;
                return success;
            }

            if (this.txt_PageRowCount.Text != null
                && this.txt_PageRowCount.Text != ""
                && this.txt_PageRowCount.Text != "0")
            {
                success = true;
            }
            else
            {
                MessageBox.Show("1개 이상의 결과값을 정해주세요.");
                success = false;
                return success;
            }

            if (this.checkBox_StockPrice.Checked
                    || this.checkBox_StockInfo.Checked
                    || this.checkBox_Dividend.Checked
                    || this.checkBox_FinalStat.Checked)
            {
                if (this.checkBox_FinalStat.Checked)
                {
                    if (this.txt_crno.Text != "" 
                        && this.txt_crno.Text != null
                        && this.txt_crno.Text != "0")
                    {
                        success = true;
                    }
                    else
                    {
                        MessageBox.Show("재무정보는 반드시 \"법인등록번호\"를 입력 해야 합니다.");
                        success = false;
                    }
                }
            }
            else
            {
                MessageBox.Show("하나 이상의 정보를 검색에 포함시켜 주세요.");
                success = false;
            }

            return success;
        }

        public void SetController(KoreanStockController controller)
        {
            this.koreanStockController = controller;
        }

        public void ClearView()
        {
            this.dataGridView.DataSource = null;
            this.dataGridView.DataBindings.Clear();
        }             

        public void SetDataSetsToTreeList(List<DataSet> dsList)
        {
            TreeNode treeName = new TreeNode(this.txt_StockItemName.Text);
            this.treeView1.Nodes.Add(treeName);
            foreach(DataSet ds in dsList)
            {
                TreeNode ds_treeNode = new TreeNode(ds.DataSetName);
                ds_treeNode.ForeColor = Color.Blue;
                foreach(DataTable dt in ds.Tables)
                {
                    TreeNode dt_treeNode = new TreeNode(dt.TableName);
                    dt_treeNode.Tag = dt;
                    dt_treeNode.ForeColor = Color.Red;
                    ds_treeNode.Nodes.Add(dt_treeNode);
                }
                treeName.Nodes.Add(ds_treeNode);
            }
        }       
    }
}
