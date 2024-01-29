using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RegistryViewer2023
{
    public partial class FormUserSettings : Form
    {
        private int MonitorInterval => UserSettings.Instance.MonitorInterval;
        public FormUserSettings()
        {
            InitializeComponent();

            StartPosition = FormStartPosition.CenterScreen;

            this.txtMonitorTimeInterval.Text = MonitorInterval.ToString();

            this.btnSave.Click += BtnSave_Click;
        }

        private void BtnSave_Click(object? sender, EventArgs e)
        {
            try
            {
                UserSettings.Instance.MonitorInterval = Convert.ToInt32(this.txtMonitorTimeInterval.Text);

                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please Set Integer Value.");
            }
        }
    }
}
