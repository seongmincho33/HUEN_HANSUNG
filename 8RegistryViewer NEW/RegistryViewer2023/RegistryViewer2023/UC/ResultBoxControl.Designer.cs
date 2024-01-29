namespace RegistryViewer2023.UC
{
    partial class ResultBoxControl
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
            richTextBox1 = new RichTextBox();
            panel1 = new Panel();
            btnClear = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // richTextBox1
            // 
            richTextBox1.Dock = DockStyle.Fill;
            richTextBox1.Location = new Point(0, 35);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(943, 275);
            richTextBox1.TabIndex = 5;
            richTextBox1.Text = "";
            // 
            // panel1
            // 
            panel1.Controls.Add(btnClear);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(943, 35);
            panel1.TabIndex = 6;
            // 
            // btnClear
            // 
            btnClear.Dock = DockStyle.Right;
            btnClear.Location = new Point(806, 0);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(137, 35);
            btnClear.TabIndex = 7;
            btnClear.Text = "Clear Log.";
            btnClear.UseVisualStyleBackColor = true;
            // 
            // ResultBoxControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(richTextBox1);
            Controls.Add(panel1);
            Name = "ResultBoxControl";
            Size = new Size(943, 310);
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private RichTextBox richTextBox1;
        private Panel panel1;
        private Button btnClear;
    }
}
