using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraTreeList.Nodes;
using DevExpress.Spreadsheet;
using DevExpress.XtraSpreadsheet;
using DevExpress.XtraBars.Docking;
using DevExpress.XtraTreeList.Columns;
using System.IO;
using DevExpress.XtraBars.Docking2010;
using DevExpress.XtraBars.Docking2010.Views.Tabbed;
using DevExpress.XtraBars;

namespace ExcelViewer
{
    public partial class MainForm : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        ExcelLoader excelLoader { get; set; }

        public MainForm()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.SetControls();
            this.excelLoader = new ExcelLoader(this);
        }


        private void SetControls()
        {
            this.barBtn_ExcelImport.ItemClick += BarBtn_ExcelImport_ItemClick;
            this.barBtn_Explorer.ItemClick += BarBtn_Explorer_ItemClick;

            this.barToggleVertical.Checked = true;
            this.barToggleVertical.CheckedChanged += (s, e) => {
                BarToggleSwitchItem toggle = s as BarToggleSwitchItem;
                if (toggle.Checked == true)
                {
                    this.barToggleHorizontal.Checked = false;
                    this.excelLoader.excelDockingStyle = ExcelDockingStyle.Vertical;
                }
            };


            this.barToggleHorizontal.Checked = false;
            this.barToggleHorizontal.CheckedChanged += (s, e) => {
                BarToggleSwitchItem toggle = s as BarToggleSwitchItem;
                if (toggle.Checked == true)
                {
                    this.barToggleVertical.Checked = false;
                    this.excelLoader.excelDockingStyle = ExcelDockingStyle.Horizontal;
                }

            };

            this.uC_Explorer1.DoubleClicked += UC_Explorer1_DoubleClicked;

        }


        private void BarBtn_Explorer_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.dockPanelTreeList.Visibility = DockVisibility.Visible;
        }


        private void UC_Explorer1_DoubleClicked(object sender, ExplorerDoubleClickEventArgs e)
        {
            if(e.IS_SHEET == false)
            {
                this.excelLoader.LoadByFilePath(e.FILE_PATH);
            }
            else
            {
                this.excelLoader.LoadBySheetNames(e.FILE_PATH, new List<string>{ e.SHEET_NAME });
            }
        }


        private void BarBtn_ExcelImport_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.excelLoader.LoadByDialog();

            this.uC_Explorer1.treeDataSource = this.excelLoader.explorerTable;
        }
        
    }
}