namespace PlannerView
{
    partial class MainFrame
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
            PublicChildFramePanel = new Panel();
            SuspendLayout();
            // 
            // PublicChildFramePanel
            // 
            PublicChildFramePanel.Dock = DockStyle.Fill;
            PublicChildFramePanel.Location = new Point(0, 0);
            PublicChildFramePanel.Name = "PublicChildFramePanel";
            PublicChildFramePanel.Size = new Size(1157, 907);
            PublicChildFramePanel.TabIndex = 0;
            // 
            // MainFrame
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1157, 907);
            Controls.Add(PublicChildFramePanel);
            Name = "MainFrame";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        public Panel PublicChildFramePanel;
    }
}
