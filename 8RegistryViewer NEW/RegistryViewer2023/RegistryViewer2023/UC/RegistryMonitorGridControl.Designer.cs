namespace RegistryViewer2023.UC
{
    partial class RegistryMonitorGridControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dataGridView1 = new DataGridView();
            panel1 = new Panel();
            btnGetRows = new Button();
            btnStart = new Button();
            btnStop = new Button();
            btnClear = new Button();
            label1 = new Label();
            progressBar1 = new ProgressBar();
            tableLayoutPanel1 = new TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(0, 35);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(516, 383);
            dataGridView1.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.Controls.Add(btnGetRows);
            panel1.Controls.Add(btnStart);
            panel1.Controls.Add(btnStop);
            panel1.Controls.Add(btnClear);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(516, 35);
            panel1.TabIndex = 1;
            // 
            // btnGetRows
            // 
            btnGetRows.Dock = DockStyle.Right;
            btnGetRows.Location = new Point(24, 0);
            btnGetRows.Name = "btnGetRows";
            btnGetRows.Size = new Size(123, 35);
            btnGetRows.TabIndex = 3;
            btnGetRows.Text = "Get Rows";
            btnGetRows.UseVisualStyleBackColor = true;
            // 
            // btnStart
            // 
            btnStart.Dock = DockStyle.Right;
            btnStart.Location = new Point(147, 0);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(123, 35);
            btnStart.TabIndex = 2;
            btnStart.Text = "Start Monitor";
            btnStart.UseVisualStyleBackColor = true;
            // 
            // btnStop
            // 
            btnStop.Dock = DockStyle.Right;
            btnStop.Location = new Point(270, 0);
            btnStop.Name = "btnStop";
            btnStop.Size = new Size(123, 35);
            btnStop.TabIndex = 1;
            btnStop.Text = "Stop";
            btnStop.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            btnClear.Dock = DockStyle.Right;
            btnClear.Location = new Point(393, 0);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(123, 35);
            btnClear.TabIndex = 0;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Fill;
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(97, 21);
            label1.TabIndex = 1;
            label1.Text = "Waiting...";
            // 
            // progressBar1
            // 
            progressBar1.Dock = DockStyle.Fill;
            progressBar1.Location = new Point(106, 3);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(407, 15);
            progressBar1.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 19.96124F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 80.03876F));
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Controls.Add(progressBar1, 1, 0);
            tableLayoutPanel1.Dock = DockStyle.Bottom;
            tableLayoutPanel1.Location = new Point(0, 418);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(516, 21);
            tableLayoutPanel1.TabIndex = 2;
            // 
            // RegistryMonitorGridControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(dataGridView1);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(panel1);
            Name = "RegistryMonitorGridControl";
            Size = new Size(516, 439);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private Panel panel1;
        private Button btnClear;
        private Button btnStop;
        private Button btnStart;
        public Button btnGetRows;
        private ProgressBar progressBar1;
        private Label label1;
        private TableLayoutPanel tableLayoutPanel1;
    }
}
