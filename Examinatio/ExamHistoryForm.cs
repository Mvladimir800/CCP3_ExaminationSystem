using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace ExaminationSystem
{
    public partial class ExamHistoryForm : Form
    {
        private readonly int studentId;
        private readonly string studentName;
        private readonly Form previousForm; // Can be null if using the 2-arg constructor
        private const string connString = "server=localhost;user=jmbalang;password=dt117;database=examdb;";

        /// <summary>
        /// Constructor used for Faculty flow (with a reference to the previous form for navigation).
        /// </summary>
        public ExamHistoryForm(int studentId, string studentName, Form previousForm)
        {
            InitializeComponent();
            this.studentId = studentId;
            this.studentName = studentName;
            this.previousForm = previousForm;
            this.Text = $"Exam History for {studentName} (ID: {studentId})";
        }

        /// <summary>
        /// Constructor used for Student flow (if they open their history directly, taking only 2 arguments).
        /// This resolves the CS1729 error for any part of your code calling it with 2 arguments.
        /// </summary>
        public ExamHistoryForm(int studentId, string studentName) : this(studentId, studentName, null)
        {
            
        }


        private void ExamHistoryForm_Load(object sender, EventArgs e)
        {
            LoadExamHistory();
        }

        private void LoadExamHistory()
        {
            string query = @"
                SELECT 
                    result_id AS ResultID,
                    student_name AS StudentName,
                    exam_category AS Subject,
                    score AS Score,
                    percentage AS Percentage,
                    status AS Status,
                    exam_date AS DateTaken  -- FIX: Corrected column name from 'date_taken' to 'exam_date'
                FROM 
                    exam_results
                WHERE 
                    student_id = @studentId
                ORDER BY 
                    exam_date DESC;         -- FIX: Corrected column name from 'date_taken' to 'exam_date'
                ";

            try
            {
                using (MySqlConnection conn = new MySqlConnection(connString))
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                {
                    cmd.Parameters.AddWithValue("@studentId", studentId);

                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    dgvExamHistory.DataSource = dt;

                    if (dt.Rows.Count == 0)
                    {
                        MessageBox.Show("No exam history found for this student.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    dgvExamHistory.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    dgvExamHistory.ReadOnly = true;
                    dgvExamHistory.AllowUserToAddRows = false;
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show($"Database error: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading exam history: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            // If previousForm is set, show it. Otherwise, just close.
            if (previousForm != null)
            {
                previousForm.Show();
            }
            this.Close();
        }

        private void dgvExamHistory_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
          
        }
    }
}