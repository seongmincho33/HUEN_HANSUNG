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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace RegistryViewer2023.UC
{
    public partial class RegistryMonitorGridControl : UserControl
    {
        DataTable dataTable { get; set; }

        List<RegistryValueDataMonitor> Monitors = new List<RegistryValueDataMonitor>();

        public event Action<RegistryValueChangedEventArgs> RegistryValueChanged;

        public RegistryMonitorGridControl()
        {
            InitializeComponent();
            InitDataTableInGridView();
            this.btnClear.Click += BtnClear_Click;
            this.dataGridView1.CellContentClick += DataGridView1_CellContentClick;
            this.btnStart.Enabled = true;
            this.btnStop.Enabled = false;
            this.btnStart.Click += BtnStart_Click;
            this.btnStop.Click += BtnStop_Click;
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

        private void BtnClear_Click(object? sender, EventArgs e)
        {
            if(dataTable.Rows.Count >= 0)
            {
                DialogResult result = MessageBox.Show("Are you sure you want to clear the Monitored Data? This will Stop Monitoring too.", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    this.dataTable.Clear();
                    InitDataTableInGridView();
                    this.btnStop.PerformClick();
                }
            }
            else
            {
                MessageBox.Show("No Data to Monitor...");
            }            
        }

        private void InitDataTableInGridView()
        {
            // Create a DataTable with the desired columns            s
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

        public void AddDataRowToDataTable(DataRow dr)
        {
            DataRow newRow = dataTable.NewRow();
            newRow.ItemArray = dr.ItemArray;
            dataTable.Rows.Add(newRow);
            dataTable.AcceptChanges();
        }

        public Color GetRegistryTextColor(string registryKeyPath, string valueName)
        {
            var matchingRow = dataTable.AsEnumerable()
             .FirstOrDefault(row =>
                 row.Field<string>("RegistryKeyPath") == registryKeyPath &&
                 row.Field<string>("ValueName") == valueName &&
                 (row.Field<bool>("Red") || row.Field<bool>("Green") || row.Field<bool>("Yellow") || row.Field<bool>("Blue"))
            );

            if (matchingRow != null)
            {
                if (matchingRow.Field<bool>("Red"))
                {
                    return Color.Red;
                }
                else if (matchingRow.Field<bool>("Green"))
                {
                    return Color.Green;
                }
                else if (matchingRow.Field<bool>("Yellow"))
                {
                    return Color.Yellow;
                }
                else if (matchingRow.Field<bool>("Blue"))
                {
                    return Color.Blue;
                }
            }
            else
            {
                return Color.Black;
            }
            return Color.Black;
        }

        private void BtnStart_Click(object? sender, EventArgs e)
        {
            if(dataTable.Rows.Count > 0)
            {
                // Disable the Start button.
                btnStart.Enabled = false;
                // Enable the Stop button.
                btnStop.Enabled = true;

                foreach (DataRow dr in dataTable.Rows)
                {
                    var registryKeyPath = dr["RegistryKeyPath"] as string;
                    var valueName = dr["ValueName"] as string;
                    if (registryKeyPath != null)
                    {
                        RegistryValueDataMonitor registryMonitor = new RegistryValueDataMonitor(registryKeyPath, valueName);
                        registryMonitor.RegistryValueChanged += RegistryMonitor_RegistryValueChanged;
                        this.Monitors.Add(registryMonitor);
                    }
                }

                // Marquee 스타일            
                progressBar1.Style = ProgressBarStyle.Marquee;
                progressBar1.Enabled = true;

                label1.Text = "Monitoring...";
            }
            else
            {
                MessageBox.Show("No Data to Monitor...");
            }           
        }

        private void RegistryMonitor_RegistryValueChanged(object? sender, RegistryValueChangedEventArgs e)
        {
            this.RegistryValueChanged?.Invoke(new RegistryValueChangedEventArgs(e.RegistryKeyPath, e.ValueName, e.CurrentValueData, e.PreviousValueData));
        }

        private void BtnStop_Click(object? sender, EventArgs e)
        {
            // Disable the Start button.
            btnStart.Enabled = true;
            // Enable the Stop button.
            btnStop.Enabled = false;

            if (Monitors.Count > 0)
            {
                foreach (var monitor in Monitors)
                {
                    monitor.Dispose();
                }

                Monitors.Clear();
            }

            progressBar1.Style = ProgressBarStyle.Blocks;
            progressBar1.Enabled = false;

            label1.Text = "Waiting...";
        }
    }
}
