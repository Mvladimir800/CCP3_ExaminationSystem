namespace ExaminationSystem
{
    partial class StudentPerformance
    {
        private System.ComponentModel.IContainer components = null;
        private Label lblWelcome;
        private DataGridView dataGridViewPerformance;
        private Button btnBack;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            lblWelcome = new Label();
            dataGridViewPerformance = new DataGridView();
            btnBack = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewPerformance).BeginInit();
            SuspendLayout();

            // lblWelcome
            lblWelcome.AutoSize = true;
            lblWelcome.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            lblWelcome.Location = new System.Drawing.Point(20, 20);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new System.Drawing.Size(200, 28);

            // dataGridViewPerformance
            dataGridViewPerformance.Location = new System.Drawing.Point(20, 60);
            dataGridViewPerformance.Name = "dataGridViewPerformance";
            dataGridViewPerformance.Size = new System.Drawing.Size(600, 300);
            dataGridViewPerformance.TabIndex = 1;

            // btnBack
            btnBack.Location = new System.Drawing.Point(500, 370);
            btnBack.Name = "btnBack";
            btnBack.Size = new System.Drawing.Size(120, 35);
            btnBack.Text = "Back";
            btnBack.Click += btnBack_Click;

            // StudentPerformance
            ClientSize = new System.Drawing.Size(650, 420);
            Controls.Add(lblWelcome);
            Controls.Add(dataGridViewPerformance);
            Controls.Add(btnBack);
            Name = "StudentPerformance";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Student Performance";
            Load += StudentPerformance_Load;

            ((System.ComponentModel.ISupportInitialize)dataGridViewPerformance).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
