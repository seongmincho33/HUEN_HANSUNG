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
    public partial class ResultBoxControl : UserControl
    {
        public ResultBoxControl()
        {
            InitializeComponent();
            this.btnClear.Click += BtnClear_Click;
        }

        private void BtnClear_Click(object? sender, EventArgs e)
        {
            richTextBox1.Clear();
        }

        public void AppendText(string text, Color color)
        {
            if (richTextBox1.InvokeRequired)
            {
                richTextBox1.Invoke(new MethodInvoker(delegate
                {
                    richTextBox1.SelectionColor = color; // Set the text color
                    richTextBox1.AppendText(text + "\n\n");
                    richTextBox1.SelectionStart = richTextBox1.Text.Length;
                    richTextBox1.ScrollToCaret();
                    richTextBox1.SelectionColor = richTextBox1.ForeColor; // Reset the text color to the default
                }));
            }
        }
    }
}
