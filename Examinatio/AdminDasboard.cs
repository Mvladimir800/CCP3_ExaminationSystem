using System;
using System.Windows.Forms;

namespace ExaminationSystem
{
    public partial class AdminDashboard : Form
    {
        private int userId;
        private string fullname;

        public AdminDashboard(int id, string name)
        {
            InitializeComponent();
            userId = id;
            fullname = name;


            label3.Text = fullname;
        }

        private void AdminDashboard_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Opening Grading Form...", "Navigation");
            var GradingForm = new GradingForm();
            GradingForm.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Opening Reporting Form...", "Navigation");
            var ReportingForm = new ReportingForm();
            ReportingForm.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Opening Student Management Form...", "Navigation");
            var StudentManagementForm = new StudentManagementForm();
            StudentManagementForm.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Opening User Management Form...", "Navigation");
            var UserManagementForm = new UserManagementForm();
            UserManagementForm.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Opening Question Bank Form...", "Navigation");

            
            var QuestionBankForm = new QuestionBankForm("Admin");
            QuestionBankForm.ShowDialog();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AdminDashboard_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}