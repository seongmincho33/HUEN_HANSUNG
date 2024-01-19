using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RegistryViewer2023.UC
{
    public partial class RegistryValueGridControl : UserControl
    {
        public event EventHandler<DataRow> CheckBoxClicked;

        public DataTable dataTable { get; set; }

        public RegistryValueGridControl()
        {
            InitializeComponent();
            InitDataTableInGridView();
            dataGridView1.CellValueChanged += DataGridView1_CellValueChanged;
            dataGridView1.CellContentClick += DataGridView1_CellContentClick;
            this.btnCLearCheckbox.Click += BtnRefresh_Click;
        }

        private void BtnRefresh_Click(object? sender, EventArgs e)
        {
            foreach (DataRow row in dataTable.Rows)
            {
                foreach (DataColumn column in dataTable.Columns)
                {
                    if (column.DataType == typeof(bool))
                    {
                        row[column] = false;
                    }
                }
            }
        }

        private void DataGridView1_CellContentClick(object? sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                // Check if a checkbox cell is clicked
                if (dataGridView1.Columns[e.ColumnIndex] is DataGridViewCheckBoxColumn)
                {
                    // Get the clicked checkbox cell
                    DataGridViewCheckBoxCell cell = dataGridView1[e.ColumnIndex, e.RowIndex] as DataGridViewCheckBoxCell;

                    if (cell != null)
                    {
                        // Uncheck all checkboxes in the same row
                        foreach (DataGridViewCell otherCell in dataGridView1.Rows[e.RowIndex].Cells)
                        {
                            if (otherCell is DataGridViewCheckBoxCell && otherCell != cell)
                            {
                                otherCell.Value = false;
                            }
                        }
                    }
                }
            }
        }

        private void DataGridView1_CellValueChanged(object? sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                // Check if a checkbox cell's value changed
                if (dataGridView1.Columns[e.ColumnIndex] is DataGridViewCheckBoxColumn)
                {
                    // Get the new value of the checkbox
                    bool isChecked = (bool)dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;
                    // Check if a checkbox cell is clicked
                    if (isChecked)
                    {
                        DataRow row = ((DataRowView)dataGridView1.Rows[e.RowIndex].DataBoundItem).Row;

                        // Notify the main form or other component that a checkbox is clicked
                        CheckBoxClicked?.Invoke(this, row);
                    }
                }
            }
        }

        private void InitDataTableInGridView()
        {
            // Create a DataTable with the desired columns
            dataTable = DataTableFactory.CreateFromModel<RegistryModel>();

            // Set the DataGridView's DataSource property to the DataTable
            dataGridView1.DataSource = dataTable;

            // Set the AutoSizeMode property for each checkbox column
            dataGridView1.Columns["Red"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView1.Columns["Green"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView1.Columns["Blue"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView1.Columns["Yellow"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView1.Columns["ValueName"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView1.Columns["DataType"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView1.Columns["Data"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView1.Columns["RegistryKey"].Visible = false;
            dataGridView1.Columns["RegistryKeyPath"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

            dataGridView1.AllowUserToAddRows = false;            
        }

        public void BindValuesToDataGridView(RegistryKey key)
        {
            dataTable.Clear();
            foreach (string valueName in key.GetValueNames())
            {
                object value = key.GetValue(valueName);
                string dataType = key.GetValueKind(valueName).ToString();
                // Add a new row to the DataTable
                dataTable.Rows.Add(false, false, false, false, valueName, dataType, value, key, key.ToString());
            }
        }
    }
}
