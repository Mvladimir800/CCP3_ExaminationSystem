using System;
using System.Windows.Forms;

namespace ExaminationSystem
{
    public partial class StudentExamChoice : Form
    {
        private int studentId;
        private string studentName;

        public StudentExamChoice(int studentId, string studentName)
        {
            InitializeComponent();
            this.studentId = studentId;
            this.studentName = studentName;
        }

        private void btnMath_Click(object sender, EventArgs e)
        {
            OpenExam("Mathematics");
        }

        private void btnScience_Click(object sender, EventArgs e)
        {
            OpenExam("Science");
        }

        private void btnEnglish_Click(object sender, EventArgs e)
        {
            OpenExam("English");
        }

        private void btnHistory_Click(object sender, EventArgs e)
        {
            OpenExam("History");
        }

        private void OpenExam(string subject)
        {
            ExamForm examForm = new ExamForm(studentId, studentName, subject);
            examForm.ShowDialog();
        }

       
        private void StudentExamChoice_Load_1(object sender, EventArgs e)
        {
            
        }
    }
}
