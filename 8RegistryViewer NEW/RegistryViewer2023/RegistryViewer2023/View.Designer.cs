namespace RegistryViewer2023
{
    partial class View
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(View));
            resultBoxControl1 = new UC.ResultBoxControl();
            registryTreeControl1 = new UC.RegistryTreeControl();
            registryValueGridControl1 = new UC.RegistryValueGridControl();
            registryMonitorGridControl1 = new UC.RegistryMonitorGridControl();
            splitContainer1 = new SplitContainer();
            splitContainer2 = new SplitContainer();
            splitContainer3 = new SplitContainer();
            menuStrip1 = new MenuStrip();
            설정ToolStripMenuItem = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer2).BeginInit();
            splitContainer2.Panel1.SuspendLayout();
            splitContainer2.Panel2.SuspendLayout();
            splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer3).BeginInit();
            splitContainer3.Panel1.SuspendLayout();
            splitContainer3.Panel2.SuspendLayout();
            splitContainer3.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // resultBoxControl1
            // 
            resultBoxControl1.Dock = DockStyle.Fill;
            resultBoxControl1.Location = new Point(0, 0);
            resultBoxControl1.Name = "resultBoxControl1";
            resultBoxControl1.Size = new Size(1599, 363);
            resultBoxControl1.TabIndex = 2;
            // 
            // registryTreeControl1
            // 
            registryTreeControl1.Dock = DockStyle.Fill;
            registryTreeControl1.Location = new Point(0, 0);
            registryTreeControl1.Name = "registryTreeControl1";
            registryTreeControl1.Size = new Size(307, 569);
            registryTreeControl1.TabIndex = 4;
            // 
            // registryValueGridControl1
            // 
            registryValueGridControl1.Dock = DockStyle.Fill;
            registryValueGridControl1.Location = new Point(0, 0);
            registryValueGridControl1.Name = "registryValueGridControl1";
            registryValueGridControl1.Size = new Size(521, 569);
            registryValueGridControl1.TabIndex = 5;
            // 
            // registryMonitorGridControl1
            // 
            registryMonitorGridControl1.Dock = DockStyle.Fill;
            registryMonitorGridControl1.Location = new Point(0, 0);
            registryMonitorGridControl1.Name = "registryMonitorGridControl1";
            registryMonitorGridControl1.Size = new Size(763, 569);
            registryMonitorGridControl1.TabIndex = 6;
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(registryTreeControl1);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(splitContainer2);
            splitContainer1.Size = new Size(1599, 569);
            splitContainer1.SplitterDistance = 307;
            splitContainer1.TabIndex = 8;
            // 
            // splitContainer2
            // 
            splitContainer2.Dock = DockStyle.Fill;
            splitContainer2.Location = new Point(0, 0);
            splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            splitContainer2.Panel1.Controls.Add(registryValueGridControl1);
            // 
            // splitContainer2.Panel2
            // 
            splitContainer2.Panel2.Controls.Add(registryMonitorGridControl1);
            splitContainer2.Size = new Size(1288, 569);
            splitContainer2.SplitterDistance = 521;
            splitContainer2.TabIndex = 9;
            // 
            // splitContainer3
            // 
            splitContainer3.Dock = DockStyle.Fill;
            splitContainer3.Location = new Point(0, 24);
            splitContainer3.Name = "splitContainer3";
            splitContainer3.Orientation = Orientation.Horizontal;
            // 
            // splitContainer3.Panel1
            // 
            splitContainer3.Panel1.Controls.Add(splitContainer1);
            // 
            // splitContainer3.Panel2
            // 
            splitContainer3.Panel2.Controls.Add(resultBoxControl1);
            splitContainer3.Size = new Size(1599, 936);
            splitContainer3.SplitterDistance = 569;
            splitContainer3.TabIndex = 9;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { 설정ToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1599, 24);
            menuStrip1.TabIndex = 10;
            menuStrip1.Text = "menuStrip1";
            // 
            // 설정ToolStripMenuItem
            // 
            설정ToolStripMenuItem.Name = "설정ToolStripMenuItem";
            설정ToolStripMenuItem.Size = new Size(62, 20);
            설정ToolStripMenuItem.Text = "Settings";
            // 
            // View
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1599, 960);
            Controls.Add(splitContainer3);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "View";
            Text = "Registry Viewer";
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            splitContainer2.Panel1.ResumeLayout(false);
            splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer2).EndInit();
            splitContainer2.ResumeLayout(false);
            splitContainer3.Panel1.ResumeLayout(false);
            splitContainer3.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer3).EndInit();
            splitContainer3.ResumeLayout(false);
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private UC.ResultBoxControl resultBoxControl1;
        private UC.RegistryTreeControl registryTreeControl1;
        private UC.RegistryValueGridControl registryValueGridControl1;
        private UC.RegistryMonitorGridControl registryMonitorGridControl1;
        private SplitContainer splitContainer1;
        private SplitContainer splitContainer2;
        private SplitContainer splitContainer3;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem 설정ToolStripMenuItem;
    }
}