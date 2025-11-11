namespace ExaminationSystem
{
    partial class StudentExamChoice
    {
        private System.ComponentModel.IContainer components = null;
        private Button btnMath;
        private Button btnScience;
        private Button btnEnglish;
        private Button btnHistory;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            btnMath = new Button();
            btnScience = new Button();
            btnEnglish = new Button();
            btnHistory = new Button();
            label1 = new Label();
            button2 = new Button();
            SuspendLayout();
            // 
            // btnMath
            // 
            btnMath.Location = new Point(252, 114);
            btnMath.Name = "btnMath";
            btnMath.Size = new Size(200, 50);
            btnMath.TabIndex = 0;
            btnMath.Text = "Mathematics";
            btnMath.Click += btnMath_Click;
            // 
            // btnScience
            // 
            btnScience.Location = new Point(252, 179);
            btnScience.Name = "btnScience";
            btnScience.Size = new Size(200, 50);
            btnScience.TabIndex = 1;
            btnScience.Text = "Science";
            btnScience.Click += btnScience_Click;
            // 
            // btnEnglish
            // 
            btnEnglish.Location = new Point(252, 246);
            btnEnglish.Name = "btnEnglish";
            btnEnglish.Size = new Size(200, 50);
            btnEnglish.TabIndex = 2;
            btnEnglish.Text = "English";
            btnEnglish.Click += btnEnglish_Click;
            // 
            // btnHistory
            // 
            btnHistory.Location = new Point(252, 313);
            btnHistory.Name = "btnHistory";
            btnHistory.Size = new Size(200, 50);
            btnHistory.TabIndex = 3;
            btnHistory.Text = "History";
            btnHistory.Click += btnHistory_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(234, 29);
            label1.Name = "label1";
            label1.Size = new Size(251, 41);
            label1.TabIndex = 13;
            label1.Text = "Taking an Exam?";
            // 
            // button2
            // 
            button2.Location = new Point(25, 425);
            button2.Name = "button2";
            button2.Size = new Size(109, 29);
            button2.TabIndex = 15;
            button2.Text = "Return";
            button2.UseVisualStyleBackColor = true;
            // 
            // StudentExamChoice
            // 
            ClientSize = new Size(683, 466);
            Controls.Add(button2);
            Controls.Add(label1);
            Controls.Add(btnMath);
            Controls.Add(btnScience);
            Controls.Add(btnEnglish);
            Controls.Add(btnHistory);
            Name = "StudentExamChoice";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Select a Subject";
            Load += this.StudentExamChoice_Load_1;
            ResumeLayout(false);
            PerformLayout();
        }
        private Label label1;
        private Button button2;
    }
}
