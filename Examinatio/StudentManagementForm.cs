using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Data;

namespace ExaminationSystem
{
    public partial class StudentManagementForm : Form
    {
        // Constructor
        public StudentManagementForm()
        {
            InitializeComponent();
        }

        // Form Load Event
        private void StudentManagementForm_Load(object sender, EventArgs e)
        {
            LoadStudentData();
        }

        // Method to load student data into the DataGridView
        private void LoadStudentData()
        {
            // returns a MySqlConnection object.
            try
            {
                // NOTE: Assuming 'Database.GetConnection()' is a static helper method that returns a MySqlConnection object.

                using (var conn = Database.GetConnection())
                {
                    conn.Open();
                    // Selecting ID, Full Name, Username, and Email for students only
                    string query = "SELECT id, fullname, username, email FROM users WHERE role = 'Student'";

                    MySqlDataAdapter da = new MySqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    // Assign the DataTable to the DataGridView
                    dgvStudents.DataSource = dt;

                    // Optional: Auto-size columns to fit the content
                    dgvStudents.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
                }
            }
            catch (Exception ex)
            {
                // Show a detailed error message if connection or query fails
                MessageBox.Show("Error loading student data: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Button Click Event Handler for viewing exam history
        private void btnViewExamHistory_Click(object sender, EventArgs e)
        {
            // Check if any row is selected in the DataGridView
            if (dgvStudents.SelectedRows.Count > 0)
            {
                var selectedRow = dgvStudents.SelectedRows[0];

                // Get Student ID (assuming 'id' column)
                string idString = selectedRow.Cells["id"].Value.ToString();

                // Get Student Name (assuming 'fullname' column)
                string studentName = selectedRow.Cells["fullname"].Value.ToString();

                if (int.TryParse(idString, out int studentId))
                {
                    // FIX START: Replace placeholder message with form redirection
                    try
                    {
                        // 1. Hide the current form
                        this.Hide();

                        // 2. Create the ExamHistoryForm, passing ID, Name, and THIS form as the previousForm reference
                        ExamHistoryForm historyForm = new ExamHistoryForm(studentId, studentName, this);

                        // 3. Show the history form
                        historyForm.Show();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Failed to open Exam History Form.\n\nError: {ex.Message}", "System Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        this.Show(); // Show the management form again if load fails
                    }
                    // FIX END
                }
                else
                {
                    MessageBox.Show("Invalid ID format in the selected row. Cannot retrieve student ID.", "Data Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please select a student to view exam history.", "No Student Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // DataGridView Cell Content Click Event (optional/placeholder)
        private void dgvStudents_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}