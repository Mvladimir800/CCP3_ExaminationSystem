namespace ExaminationSystem
{
    partial class ExamHistoryForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            dgvExamHistory = new DataGridView();
            btnBack = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvExamHistory).BeginInit();
            SuspendLayout();
            // 
            // dgvExamHistory
            // 
            dgvExamHistory.AllowUserToAddRows = false;
            dgvExamHistory.AllowUserToDeleteRows = false;
            dgvExamHistory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvExamHistory.Location = new Point(28, 30);
            dgvExamHistory.Name = "dgvExamHistory";
            dgvExamHistory.ReadOnly = true;
            dgvExamHistory.RowHeadersWidth = 51;
            dgvExamHistory.RowTemplate.Height = 24;
            dgvExamHistory.Size = new Size(740, 428);
            dgvExamHistory.TabIndex = 0;
            dgvExamHistory.CellContentClick += dgvExamHistory_CellContentClick;
            // 
            // btnBack
            // 
            btnBack.Location = new Point(28, 545);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(112, 32);
            btnBack.TabIndex = 1;
            btnBack.Text = "Return";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click; 
            // 
            // ExamHistoryForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 600);
            Controls.Add(btnBack);
            Controls.Add(dgvExamHistory);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "ExamHistoryForm";
            Text = "Exam History";
            Load += ExamHistoryForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvExamHistory).EndInit();
            ResumeLayout(false);
        }


        private DataGridView dgvExamHistory;
        private Button btnBack;
    }
}
