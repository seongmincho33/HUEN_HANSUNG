namespace PlannerView.Components
{
    partial class Pop_PlannerCreator
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            groupBox1 = new GroupBox();
            txtTitle = new TextBox();
            btnConfirm = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(22, 38);
            label1.Name = "label1";
            label1.Size = new Size(42, 15);
            label1.TabIndex = 0;
            label1.Text = "제목 : ";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtTitle);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(222, 199);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "초기 설정";
            // 
            // txtTitle
            // 
            txtTitle.Location = new Point(70, 35);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(100, 23);
            txtTitle.TabIndex = 1;
            // 
            // btnConfirm
            // 
            btnConfirm.Location = new Point(177, 283);
            btnConfirm.Name = "btnConfirm";
            btnConfirm.Size = new Size(57, 28);
            btnConfirm.TabIndex = 2;
            btnConfirm.Text = "확인";
            btnConfirm.UseVisualStyleBackColor = true;
            // 
            // Pop_PlannerCreator
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(246, 323);
            Controls.Add(btnConfirm);
            Controls.Add(groupBox1);
            Name = "Pop_PlannerCreator";
            Text = "Pop_PlannerCreator";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private GroupBox groupBox1;
        private TextBox txtTitle;
        private Button btnConfirm;
    }
}