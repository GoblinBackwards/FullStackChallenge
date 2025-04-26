namespace TimCoreyFullStackChallengeWinforms
{
    partial class FrmEmployeeDirectory
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
            lbxEmployees = new ListBox();
            label1 = new Label();
            btnReload = new Button();
            SuspendLayout();
            // 
            // lbxEmployees
            // 
            lbxEmployees.FormattingEnabled = true;
            lbxEmployees.Location = new Point(12, 44);
            lbxEmployees.Name = "lbxEmployees";
            lbxEmployees.Size = new Size(776, 394);
            lbxEmployees.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(176, 25);
            label1.TabIndex = 2;
            label1.Text = "Employee Directory";
            // 
            // btnReload
            // 
            btnReload.Location = new Point(684, 9);
            btnReload.Name = "btnReload";
            btnReload.Size = new Size(104, 29);
            btnReload.TabIndex = 3;
            btnReload.Text = "Reload";
            btnReload.UseVisualStyleBackColor = true;
            btnReload.Click += btnReload_Click;
            // 
            // FrmEmployeeDirectory
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnReload);
            Controls.Add(label1);
            Controls.Add(lbxEmployees);
            Name = "FrmEmployeeDirectory";
            Text = "FrmEmployeeDirectory";
            Load += FrmEmployeeDirectory_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ListBox lbxEmployees;
        private Label label1;
        private Button btnReload;
    }
}