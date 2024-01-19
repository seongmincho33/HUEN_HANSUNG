using PlannerView.Components.CalendarComponents;

namespace PlannerView.ChildFrame
{
    partial class Planner
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
            panel1 = new Panel();
            btnDeletePlan = new Button();
            btnNewPlan = new Button();
            panel2 = new Panel();
            treeView1 = new TreeView();
            splitContainer1 = new SplitContainer();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(btnDeletePlan);
            panel1.Controls.Add(btnNewPlan);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(693, 34);
            panel1.TabIndex = 1;
            // 
            // btnDeletePlan
            // 
            btnDeletePlan.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnDeletePlan.Location = new Point(615, 5);
            btnDeletePlan.Name = "btnDeletePlan";
            btnDeletePlan.Size = new Size(75, 23);
            btnDeletePlan.TabIndex = 3;
            btnDeletePlan.Text = "Delete";
            btnDeletePlan.UseVisualStyleBackColor = true;
            // 
            // btnNewPlan
            // 
            btnNewPlan.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnNewPlan.Location = new Point(534, 5);
            btnNewPlan.Name = "btnNewPlan";
            btnNewPlan.Size = new Size(75, 23);
            btnNewPlan.TabIndex = 2;
            btnNewPlan.Text = "New Plan";
            btnNewPlan.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 34);
            panel2.Name = "panel2";
            panel2.Size = new Size(693, 620);
            panel2.TabIndex = 2;
            // 
            // treeView1
            // 
            treeView1.Dock = DockStyle.Fill;
            treeView1.Location = new Point(0, 0);
            treeView1.Name = "treeView1";
            treeView1.Size = new Size(114, 654);
            treeView1.TabIndex = 0;
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(treeView1);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(panel2);
            splitContainer1.Panel2.Controls.Add(panel1);
            splitContainer1.Size = new Size(811, 654);
            splitContainer1.SplitterDistance = 114;
            splitContainer1.TabIndex = 0;
            // 
            // Planner
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(splitContainer1);
            Name = "Planner";
            Size = new Size(811, 654);
            panel1.ResumeLayout(false);
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Panel panel1;
        private Button btnNewPlan;
        private Panel panel2;
        private TreeView treeView1;
        private Button btnDeletePlan;
        private SplitContainer splitContainer1;
    }
}
