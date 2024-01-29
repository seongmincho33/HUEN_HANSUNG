using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraTreeList.Columns;
using DevExpress.XtraTreeList;

namespace ExcelViewer
{
    public partial class UC_Explorer : DevExpress.XtraEditors.XtraUserControl
    {
        private ExplorerTable explorerTable = new ExplorerTable();

        public DataTable treeDataSource
        {
            set
            {
                this.treeList1.DataSource = value;
            }
        }

        public event EventHandler<ExplorerDoubleClickEventArgs> DoubleClicked;

        public UC_Explorer()
        {
            InitializeComponent();
            InitTreeList();
            this.treeList1.DoubleClick += TreeList1_DoubleClick;
        }


        private void TreeList1_DoubleClick(object sender, EventArgs e)
        {
            TreeList tree = sender as TreeList;
            TreeListHitInfo hi = tree.CalcHitInfo(tree.PointToClient(Control.MousePosition));
            if (hi.Node != null)
            {

                ExplorerDoubleClickEventArgs eventArgs = new ExplorerDoubleClickEventArgs();

                eventArgs.KEY = (Guid)hi.Node[this.explorerTable.column1];
                eventArgs.PARENT_KEY = (Guid)hi.Node[this.explorerTable.column2];
                eventArgs.NODE_NAME = (string)hi.Node[this.explorerTable.column3];
                eventArgs.FILE_PATH = (string)hi.Node[this.explorerTable.column4];
                eventArgs.IS_SHEET = (bool)hi.Node[this.explorerTable.column5];
                eventArgs.SHEET_NAME = (string)hi.Node[this.explorerTable.column6];

                if (DoubleClicked != null)
                {
                    DoubleClicked.Invoke(this.treeList1, eventArgs);
                }

            }
        }


        private void InitTreeList()
        {
            TreeListColumn tc = treeList1.Columns.Add();

            tc.FieldName = this.explorerTable.column3;

            tc.Caption = "Node"; // 엑셀파일 또는 시트

            tc.VisibleIndex = 1;

            tc.Visible = true;

            TreeListColumn tc2 = treeList1.Columns.Add();

            tc2.FieldName = this.explorerTable.column4;

            tc2.Caption = "File Path"; 

            tc2.VisibleIndex = 2;

            tc2.Visible = false;

            treeList1.KeyFieldName = this.explorerTable.column1;

            treeList1.ParentFieldName = this.explorerTable.column2;

            treeList1.ShowingEditor += (s, e) => { e.Cancel = true; };
        }

    }


    
}
