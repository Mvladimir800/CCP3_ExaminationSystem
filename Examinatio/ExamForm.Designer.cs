using System.Drawing;
using System.Windows.Forms;

namespace ExaminationSystem
{
    partial class ExamForm
    {
        private System.ComponentModel.IContainer components = null;

        private Label lblQuestionNumber;
        private Label lblQuestion;
        private RadioButton rbA;
        private RadioButton rbB;
        private RadioButton rbC;
        private RadioButton rbD;
        private Button btnPrev;
        private Button btnNext;
        private Button btnSubmit;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            lblQuestionNumber = new Label();
            lblQuestion = new Label();
            rbA = new RadioButton();
            rbB = new RadioButton();
            rbC = new RadioButton();
            rbD = new RadioButton();
            btnPrev = new Button();
            btnNext = new Button();
            btnSubmit = new Button();
            SuspendLayout();
            // 
            // lblQuestionNumber
            // 
            lblQuestionNumber.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblQuestionNumber.Location = new Point(30, 20);
            lblQuestionNumber.Name = "lblQuestionNumber";
            lblQuestionNumber.Size = new Size(400, 30);
            lblQuestionNumber.TabIndex = 0;
            lblQuestionNumber.Text = "Question 0/0";
            // 
            // lblQuestion
            // 
            lblQuestion.Font = new Font("Segoe UI", 11F);
            lblQuestion.Location = new Point(30, 60);
            lblQuestion.Name = "lblQuestion";
            lblQuestion.Size = new Size(700, 60);
            lblQuestion.TabIndex = 1;
            lblQuestion.Text = "Please select a subject to begin.";
            // 
            // rbA
            // 
            rbA.Location = new Point(30, 140);
            rbA.Name = "rbA";
            rbA.Size = new Size(600, 25);
            rbA.TabIndex = 2;
            rbA.CheckedChanged += rbChoice_CheckedChanged;
            // 
            // rbB
            // 
            rbB.Location = new Point(30, 180);
            rbB.Name = "rbB";
            rbB.Size = new Size(600, 25);
            rbB.TabIndex = 3;
            rbB.CheckedChanged += rbChoice_CheckedChanged;
            // 
            // rbC
            // 
            rbC.Location = new Point(30, 220);
            rbC.Name = "rbC";
            rbC.Size = new Size(600, 25);
            rbC.TabIndex = 4;
            rbC.CheckedChanged += rbChoice_CheckedChanged;
            // 
            // rbD
            // 
            rbD.Location = new Point(30, 260);
            rbD.Name = "rbD";
            rbD.Size = new Size(600, 25);
            rbD.TabIndex = 5;
            rbD.CheckedChanged += rbChoice_CheckedChanged;
            // 
            // btnPrev
            // 
            btnPrev.Location = new Point(30, 310);
            btnPrev.Name = "btnPrev";
            btnPrev.Size = new Size(120, 40);
            btnPrev.TabIndex = 6;
            btnPrev.Text = "Previous";
            btnPrev.UseVisualStyleBackColor = true;
            btnPrev.Click += btnPrev_Click;
            // 
            // btnNext
            // 
            btnNext.Location = new Point(180, 310);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(120, 40);
            btnNext.TabIndex = 7;
            btnNext.Text = "Next";
            btnNext.UseVisualStyleBackColor = true;
            btnNext.Click += btnNext_Click;
            // 
            // btnSubmit
            // 
            btnSubmit.Location = new Point(570, 310);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(120, 40);
            btnSubmit.TabIndex = 8;
            btnSubmit.Text = "Submit";
            btnSubmit.UseVisualStyleBackColor = true;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // ExamForm
            // 
            ClientSize = new Size(800, 400);
            Controls.Add(lblQuestionNumber);
            Controls.Add(lblQuestion);
            Controls.Add(rbA);
            Controls.Add(rbB);
            Controls.Add(rbC);
            Controls.Add(rbD);
            Controls.Add(btnPrev);
            Controls.Add(btnNext);
            Controls.Add(btnSubmit);
            Name = "ExamForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Exam Form";
            Load += ExamForm_Load;
            ResumeLayout(false);
        }

    }
}
