namespace RegistryViewer2023.UC
{
    partial class RegistryTreeControl
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
            treeViewRegistry = new TreeView();
            btnSearch = new Button();
            txtKey = new TextBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // treeViewRegistry
            // 
            treeViewRegistry.Dock = DockStyle.Fill;
            treeViewRegistry.Location = new Point(0, 30);
            treeViewRegistry.Name = "treeViewRegistry";
            treeViewRegistry.Size = new Size(501, 367);
            treeViewRegistry.TabIndex = 0;
            // 
            // btnSearch
            // 
            btnSearch.Dock = DockStyle.Fill;
            btnSearch.Location = new Point(403, 3);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(95, 24);
            btnSearch.TabIndex = 1;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            // 
            // txtKey
            // 
            txtKey.Dock = DockStyle.Fill;
            txtKey.Location = new Point(3, 3);
            txtKey.Name = "txtKey";
            txtKey.Size = new Size(394, 23);
            txtKey.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 80F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.Controls.Add(txtKey, 0, 0);
            tableLayoutPanel1.Controls.Add(btnSearch, 1, 0);
            tableLayoutPanel1.Dock = DockStyle.Top;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(501, 30);
            tableLayoutPanel1.TabIndex = 2;
            // 
            // RegistryTreeControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(treeViewRegistry);
            Controls.Add(tableLayoutPanel1);
            Name = "RegistryTreeControl";
            Size = new Size(501, 397);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TreeView treeViewRegistry;
        private Button btnSearch;
        private TextBox txtKey;
        private TableLayoutPanel tableLayoutPanel1;
    }
}
