using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcelViewer
{
    public class ExplorerTable : DataTable
    {
        public readonly string column1 = "KEY";

        public readonly string column2 = "PARENT_KEY";

        public readonly string column3 = "NODE_NAME";

        public readonly string column4 = "FILE_PATH";

        public readonly string column5 = "IS_SHEET";

        public readonly string column6 = "SHEET_NAME";

        public ExplorerTable() : base()
        {
            // Initialize your custom DataTable here
            // For example, add specific columns
            this.Columns.Add(column1, typeof(Guid));
            this.Columns.Add(column2, typeof(Guid));
            this.Columns.Add(column3, typeof(string));
            this.Columns.Add(column4, typeof(string));
            this.Columns.Add(column5, typeof(bool));
            this.Columns.Add(column6, typeof(string));
        }

        public void AddRow(Guid key, Guid parent_key, string node_name, string file_path, bool is_sheet = false, string sheet_name = "")
        {
            DataRow row = this.NewRow();
            row[column1] = key;
            row[column2] = parent_key;
            row[column3] = node_name;
            row[column4] = file_path;
            row[column5] = is_sheet;
            row[column6] = sheet_name;
            this.Rows.Add(row);
        }


        protected override void OnRowChanged(DataRowChangeEventArgs e)
        {
            base.OnRowChanged(e);
            // Custom logic on row change
        }
    }
}
