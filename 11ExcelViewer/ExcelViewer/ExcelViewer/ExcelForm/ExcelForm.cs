using DevExpress.Spreadsheet;
using DevExpress.XtraBars.Docking;
using DevExpress.XtraSpreadsheet;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExcelViewer
{
    public partial class ExcelForm : Form
    {
        ExcelDockingStyle excelDockingStyle { get; set; }

        public ExcelForm(ExcelDockingStyle style)
        {
            InitializeComponent();
            this.excelDockingStyle = style;
        }


        public void CreateAllDockingSheet(string filePath)
        {
            Workbook workbook = new Workbook();
            workbook.LoadDocument(filePath);

            int dockHeight = this.Size.Height / workbook.Worksheets.Count();
            int dockWidth = this.Size.Width / workbook.Worksheets.Count();

            foreach (Worksheet sheet in workbook.Worksheets)
            {
                SpreadsheetControl spreadsheetControl = new SpreadsheetControl();
                spreadsheetControl.Dock = DockStyle.Fill;
                spreadsheetControl.LoadDocument(filePath);
                //spreadsheetControl.BringToFront();

                int index = 0;
                foreach(Worksheet sheet2 in workbook.Worksheets)
                {
                    if(sheet != sheet2)
                    {
                        spreadsheetControl.Document.Worksheets.RemoveAt(index);
                    }
                    else
                    {
                        index++;
                    }
                }

                DockingStyle style = DockingStyle.Left;
                if(excelDockingStyle == ExcelDockingStyle.Horizontal)
                {
                    style = DockingStyle.Left;
                }
                else if(excelDockingStyle == ExcelDockingStyle.Vertical)
                {
                    style = DockingStyle.Top;
                }

                DockPanel dockPanel = this.dockManager1.AddPanel(style);
                dockPanel.Text = sheet.Name;
                dockPanel.Controls.Add(spreadsheetControl);

                dockPanel.Height = dockHeight;
                dockPanel.Width = dockWidth;
            }
        }


        public void CreateDockingSheet(string filePath, List<string> sheetNames)
        {
            Workbook workbook = new Workbook();
            workbook.LoadDocument(filePath);

            int dockHeight = this.Size.Height / sheetNames.Count();
            int dockWidth = this.Size.Width / sheetNames.Count();

            foreach (Worksheet sheet in workbook.Worksheets)
            {
                if(sheetNames.AsEnumerable().Where(r => r.ToString() == sheet.Name).Any())
                {
                    SpreadsheetControl spreadsheetControl = new SpreadsheetControl();
                    spreadsheetControl.Dock = DockStyle.Fill;
                    spreadsheetControl.LoadDocument(filePath);
                    //spreadsheetControl.BringToFront();

                    int index = 0;
                    foreach (Worksheet sheet2 in workbook.Worksheets)
                    {
                        if (sheet != sheet2)
                        {
                            spreadsheetControl.Document.Worksheets.RemoveAt(index);
                        }
                        else
                        {
                            index++;
                        }
                    }

                    DockingStyle style = DockingStyle.Left;
                    if (excelDockingStyle == ExcelDockingStyle.Horizontal)
                    {
                        style = DockingStyle.Left;
                    }
                    else if (excelDockingStyle == ExcelDockingStyle.Vertical)
                    {
                        style = DockingStyle.Top;
                    }

                    DockPanel dockPanel = this.dockManager1.AddPanel(style);
                    dockPanel.Text = sheet.Name;
                    dockPanel.Controls.Add(spreadsheetControl);

                    dockPanel.Height = dockHeight;
                    dockPanel.Width = dockWidth;
                }
                
            }
        }
    }
}
