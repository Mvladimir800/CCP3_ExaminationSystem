using System;
using System.Windows.Forms;

namespace ExaminationSystem
{
    public partial class FacultyDashboard : Form
    {
        private int facultyId;
        private string fullname;


        /// <param name="id">The ID of the logged-in faculty member.</param>
        /// <param name="name">The full name of the logged-in faculty member.</param>
        public FacultyDashboard(int id, string name)
        {
            facultyId = id;
            fullname = name;
            InitializeComponent();


            if (label3 != null)
            {
                label3.Text = fullname;
            }
        }

        private void FacultyDashboard_Load(object sender, EventArgs e)
        {

            {

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            MessageBox.Show("Opening Student Management Form...", "Navigation");

            
            var StudentManagementForm = new StudentManagementForm();
            StudentManagementForm.ShowDialog();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            // Close the dashboard to return to the login screen or close the application.
            this.Close();
        }

        // Event handler for button2 (Grading Form)
        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Opening Grading Form...", "Navigation");


            var GradingForm = new GradingForm();
            GradingForm.ShowDialog();
        }

        // Event handler for button3 (Question Bank)
        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Opening Question Bank...", "Navigation");

           
            var QuestionBank = new QuestionBankForm("Faculty");
            QuestionBank.ShowDialog();
        }

        private void FacultyDashboard_FormClosed(object sender, FormClosedEventArgs e)
        {
            
            Application.Exit();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}