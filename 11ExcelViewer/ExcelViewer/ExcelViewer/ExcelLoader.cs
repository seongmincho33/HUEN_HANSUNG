using DevExpress.Spreadsheet;
using DevExpress.XtraBars.Ribbon;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExcelViewer
{
    public class ExcelLoader
    {
        private ExcelFormFactory excelFormFactory { get; set; }

        public ExcelDockingStyle excelDockingStyle { get; set; }

        public ExplorerTable explorerTable { get; set; }

        public ExcelLoader(RibbonForm mainForm)
        {
            this.excelFormFactory = new ExcelFormFactory(mainForm);

            this.explorerTable = new ExplorerTable();

            this.excelDockingStyle = ExcelDockingStyle.Vertical;
        }


        public void LoadByDialog()
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Excel Files|*.xls;*.xlsx";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = openFileDialog.FileName;

                    //1.
                    this.excelFormFactory.AddChildForm(filePath, this.excelDockingStyle);

                    //2.
                    this.AddRowToExplorerTable(filePath);
                }
            }
        }


        public void LoadByFilePath(string filePath)
        {
            this.excelFormFactory.AddChildForm(filePath, this.excelDockingStyle);
        }


        public void LoadBySheetNames(string filePath, List<string> sheetNames)
        {
            this.excelFormFactory.AddChildForm(filePath, sheetNames, this.excelDockingStyle);
        }


        //----------------------------- private -----------------------------


        private void AddRowToExplorerTable(string filePath)
        {
            Workbook workbook = new Workbook();
            workbook.LoadDocument(filePath);

            Guid fileKey = Guid.NewGuid();
            this.explorerTable.AddRow(fileKey, Guid.NewGuid(), Path.GetFileName(filePath), filePath);

            foreach (Worksheet sheet in workbook.Worksheets)
            {
                this.explorerTable.AddRow(Guid.NewGuid(), fileKey, sheet.Name, filePath, true, sheet.Name);
            }
        }
    }
}
