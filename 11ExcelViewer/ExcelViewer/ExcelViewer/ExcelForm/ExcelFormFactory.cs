using DevExpress.XtraBars.Docking2010;
using DevExpress.XtraBars.Docking2010.Views.Tabbed;
using DevExpress.XtraBars.Ribbon;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcelViewer
{
    public class ExcelFormFactory
    {
        RibbonForm MainForm { get; set; }

        public ExcelFormFactory(RibbonForm mainForm)
        {
            this.MainForm = mainForm;
            this.AddDocumentManager();
        }


        public void AddDocumentManager()
        {
            DocumentManager manager = new DocumentManager();
            manager.MdiParent = this.MainForm;
            manager.View = new TabbedView();
        }


        public void AddChildForm(string filePath, ExcelDockingStyle style)
        {
            ExcelForm childForm = new ExcelForm(style);
            childForm.Text = Path.GetFileName(filePath);
            childForm.Left = 0;
            childForm.Top = 0;
            childForm.Size = this.MainForm.ClientRectangle.Size;
            childForm.MdiParent = this.MainForm;
            ExcelSheetSelector excelSheetSelector = new ExcelSheetSelector(filePath);

            if (excelSheetSelector.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                //childForm.Shown += (s, e) => childForm.CreateAllDockingSheet(filePath);
                childForm.Shown += (s, e) => childForm.CreateDockingSheet(filePath, excelSheetSelector.SelectedSheetNames);
                childForm.Show();
            }
        }

        public void AddChildForm(string filePath, List<string> sheetNames, ExcelDockingStyle style)
        {
            ExcelForm childForm = new ExcelForm(style);
            childForm.Text = Path.GetFileName(filePath);
            childForm.Left = 0;
            childForm.Top = 0;
            childForm.Size = this.MainForm.ClientRectangle.Size;
            childForm.MdiParent = this.MainForm;
            childForm.Shown += (s, e) => childForm.CreateDockingSheet(filePath, sheetNames);
            childForm.Show();
        }
    }
}
