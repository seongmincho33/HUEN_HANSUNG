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
using DevExpress.XtraEditors.Controls;
using DevExpress.Spreadsheet;

namespace ExcelViewer
{
    public partial class ExcelSheetSelector : DevExpress.XtraEditors.XtraForm
    {
        public List<string> SelectedSheetNames { get; set; }


        public ExcelSheetSelector(string filePath)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;

            this.checkEdit_SelectAll.Checked = false;
            this.checkEdit_SelectAll.CheckedChanged += CheckEdit_SelectAll_CheckedChanged;
            this.checkListBox.Enabled = true;
            this.searchControl1.Client = this.checkListBox;
            this.btn_OK.Click += Btn_OK_Click;

            Workbook workbook = new Workbook();
            workbook.LoadDocument(filePath);

            foreach (Worksheet sheet in workbook.Worksheets)
            {
                this.checkListBox.Items.Add(sheet.Name);
            }
        }


        private void Btn_OK_Click(object sender, EventArgs e)
        {
            this.SelectedSheetNames = new List<string>();

            foreach (var sheetName in this.checkListBox.Items.GetCheckedValues())
            {
                this.SelectedSheetNames.Add(sheetName.ToString());
            }
            
            this.DialogResult = DialogResult.OK;
            this.Close();
        }


        private void CheckEdit_SelectAll_CheckedChanged(object sender, EventArgs e)
        {
            if(this.checkEdit_SelectAll.Checked == true)
            {

                this.checkListBox.Enabled = false;

                foreach (CheckedListBoxItem item in this.checkListBox.Items)
                {
                    item.CheckState = CheckState.Checked;
                }

            }
            else
            {
                this.checkListBox.Enabled = true;

                foreach (CheckedListBoxItem item in this.checkListBox.Items)
                {
                    item.CheckState = CheckState.Unchecked;
                }
            }
        }
    }
}