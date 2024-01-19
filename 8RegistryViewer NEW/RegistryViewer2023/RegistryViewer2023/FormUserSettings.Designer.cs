namespace RegistryViewer2023
{
    partial class FormUserSettings
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
            txtMonitorTimeInterval = new TextBox();
            btnSave = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(29, 67);
            label1.Name = "label1";
            label1.Size = new Size(128, 15);
            label1.TabIndex = 0;
            label1.Text = "Monitor time interval :";
            // 
            // txtMonitorTimeInterval
            // 
            txtMonitorTimeInterval.Location = new Point(163, 64);
            txtMonitorTimeInterval.Name = "txtMonitorTimeInterval";
            txtMonitorTimeInterval.Size = new Size(100, 23);
            txtMonitorTimeInterval.TabIndex = 1;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(204, 202);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 23);
            btnSave.TabIndex = 2;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            // 
            // FormUserSettings
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(291, 237);
            Controls.Add(btnSave);
            Controls.Add(txtMonitorTimeInterval);
            Controls.Add(label1);
            Name = "FormUserSettings";
            Text = "Settings";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtMonitorTimeInterval;
        private Button btnSave;
    }
}