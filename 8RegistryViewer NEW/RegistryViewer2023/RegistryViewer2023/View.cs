using RegistryViewer2023.UC;
using System.Data;

namespace RegistryViewer2023
{
    public partial class View : Form
    {
        public View()
        {
            InitializeComponent();

            StartPosition = FormStartPosition.CenterScreen;

            registryTreeControl1.NodeClicked += RegistryTreeControl1_NodeClicked;

            registryMonitorGridControl1.RegistryValueChanged += RegistryMonitorGridControl1_RegistryValueChanged;

            registryMonitorGridControl1.btnGetRows.Click += BtnGetRows_Click;

            menuStrip1.Click += MenuStrip1_Click;
        }

        private void MenuStrip1_Click(object? sender, EventArgs e)
        {
            FormUserSettings settingForm = new FormUserSettings();
            settingForm.Show();
        }

        private void BtnGetRows_Click(object? sender, EventArgs e)
        {
            foreach (DataRow dr in registryValueGridControl1.dataTable.Rows)
            {
                if ((bool)dr["Red"] == true
                    || (bool)dr["Green"] == true
                    || (bool)dr["Yellow"] == true
                    || (bool)dr["Blue"] == true)
                {
                    registryMonitorGridControl1.AddDataRowToDataTable(dr);
                }
            }
        }

        private void RegistryMonitorGridControl1_RegistryValueChanged(RegistryValueChangedEventArgs obj)
        {
            this.resultBoxControl1.AppendText(
                $"""
                Key Path : {obj.RegistryKeyPath}
                Value Name : {obj.ValueName}
                
                    Previous Data : {obj.PreviousValueData}

                    Current Data : {obj.CurrentValueData}
                """,
                registryMonitorGridControl1.GetRegistryTextColor(obj.RegistryKeyPath, obj.ValueName));
        }

        private void RegistryTreeControl1_NodeClicked(Microsoft.Win32.RegistryKey registryKey)
        {
            this.registryValueGridControl1.BindValuesToDataGridView(registryKey);
        }
    }
}