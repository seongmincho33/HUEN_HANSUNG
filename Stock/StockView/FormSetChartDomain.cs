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

namespace StockView
{
    public partial class FormSetChartDomain : Form
    {
        public string XDomainName { get; set; }

        public string YDomainName { get; set; }

        private DataTable Data { get; set; }
        public FormSetChartDomain(DataTable dt)
        {
            InitializeComponent();
            this.Data = dt;
            this.SetDtColumnsToRadioButtons(dt);
            this.btn_Confirm.Click += Btn_Confirm_Click;
            this.btn_Cancel.Click += Btn_Cancel_Click;
            this.btn_DataTableToChart.Click += Btn_DataTableToChart_Click;
            this.chart1.MouseWheel += Chart_MouseWheel;
        }

        private void Chart_MouseWheel(object sender, MouseEventArgs e)
        {
            var chart = (Chart)sender;
            var xAxis = chart.ChartAreas[0].AxisX;
            var yAxis = chart.ChartAreas[0].AxisY;
            try
            {
                if (e.Delta < 0)
                {
                    xAxis.ScaleView.ZoomReset();
                    yAxis.ScaleView.ZoomReset();
                }
                else if (e.Delta > 0)
                {
                    var xMin = xAxis.ScaleView.ViewMinimum;
                    var xMax = xAxis.ScaleView.ViewMaximum;
                    var yMin = yAxis.ScaleView.ViewMinimum;
                    var yMax = yAxis.ScaleView.ViewMaximum;

                    var posXStart = xAxis.PixelPositionToValue(e.Location.X) - (xMax - xMin) / 4;
                    var posXFinish = xAxis.PixelPositionToValue(e.Location.X) + (xMax - xMin) / 4;
                    var posYStart = yAxis.PixelPositionToValue(e.Location.Y) - (yMax - yMin) / 4;
                    var posYFinish = yAxis.PixelPositionToValue(e.Location.Y) + (yMax - yMin) / 4;

                    xAxis.ScaleView.Zoom(posXStart, posXFinish);
                    yAxis.ScaleView.Zoom(posYStart, posYFinish);
                }
            }
            catch { }
        }


        private void Btn_DataTableToChart_Click(object sender, EventArgs e)
        {
            if (this.Validation())
            {
                this.DataTableToChart(Data, "", XDomainName, YDomainName);
            }
        }

        private void Btn_Cancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void Btn_Confirm_Click(object sender, EventArgs e)
        {
            if(this.Validation())
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }            
        }

        private void SetDtColumnsToRadioButtons(DataTable dt)
        {
            for (int k = 0; k < dt.Columns.Count; k++)
            {
                RadioButton rd1 = new RadioButton();
                rd1.Name = dt.Columns[k].ToString() + "_X";
                rd1.Text = dt.Columns[k].ToString();
                this.flowLayoutPanel1.Controls.Add(rd1);

                RadioButton rd2 = new RadioButton();
                rd2.Name = dt.Columns[k].ToString() + "_Y";
                rd2.Text = dt.Columns[k].ToString();
                this.flowLayoutPanel2.Controls.Add(rd2);
            }
        }       

        private bool Validation()
        {
            bool success = false;
            
            if(CheckXDomain() && CheckYDomain())
            {
                success = true;
            }

            return success;

            bool CheckXDomain() 
            {
                foreach (RadioButton radio in this.flowLayoutPanel1.Controls)
                {
                    if (radio.Checked)
                    {
                        this.XDomainName = radio.Text;
                        return success = true;
                    }
                }
                MessageBox.Show("X축을 선택해 주세요.");
                return false;
            }

            bool CheckYDomain()
            {
                foreach (RadioButton radio in this.flowLayoutPanel2.Controls)
                {
                    if (radio.Checked)
                    {
                        this.YDomainName = radio.Text;
                        return success = true;
                    }
                }
                MessageBox.Show("Y축을 선택해 주세요.");
                return false;
            }
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
    }
}
