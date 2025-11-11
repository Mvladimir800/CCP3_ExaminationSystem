using System;
using System.Windows.Forms;

namespace ExaminationSystem
{
    public partial class StudentDashboard : Form
    {
        private int studentId;
        private string studentName;

        public StudentDashboard(int id, string name)
        {
            InitializeComponent();
            studentId = id;
            studentName = name;
            this.Text = $"{name}'s Student Dashboard";
        }

        private void StudentDashboard_Load(object sender, EventArgs e)
        {
            // Display student's name
            label3.Text = studentName;
        }

        // Logout button
        private void btnLogout_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Are you sure you want to logout?",
                                         "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Hide();
                LoginForm loginForm = new LoginForm();
                loginForm.Show();
            }
        }

        // Take Exam button
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                StudentExamChoice choiceForm = new StudentExamChoice(studentId, studentName);
                choiceForm.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to open Exam Selection.\n\nDetails: {ex.Message}",
                                "Form Load Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // View Score button (opens StudentPerformance)
        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                StudentPerformance performanceForm = new StudentPerformance(studentId, studentName);
                performanceForm.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to open Student Performance.\n\nDetails: {ex.Message}",
                                "Form Load Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Optional: View Exam History button if needed
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                // Open the StudentPerformance form
                StudentPerformance performanceForm = new StudentPerformance(studentId, studentName);
                performanceForm.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Could not open Student Performance.\n\nError: {ex.Message}",
                                "System Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void StudentDashboard_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
