namespace Calculator
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panelTop = new Panel();
            panelFill = new Panel();
            SuspendLayout();
            // 
            // panelTop
            // 
            panelTop.Dock = DockStyle.Top;
            panelTop.Location = new Point(10, 10);
            panelTop.Name = "panelTop";
            panelTop.Size = new Size(280, 106);
            panelTop.TabIndex = 0;
            // 
            // panelFill
            // 
            panelFill.Dock = DockStyle.Fill;
            panelFill.Location = new Point(10, 116);
            panelFill.Name = "panelFill";
            panelFill.Size = new Size(280, 375);
            panelFill.TabIndex = 1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(300, 501);
            Controls.Add(panelFill);
            Controls.Add(panelTop);
            Name = "Form1";
            Padding = new Padding(10);
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Panel panelTop;
        private Panel panelFill;
    }
}
