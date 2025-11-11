using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ExaminationSystem
{
    public partial class StudentScores : Form
    {
        private int studentId;
        private string studentName;
        private string subject;
        private string connectionString = "server=localhost;user=jmbalang;password=dt117;database=examdb;";

        public StudentScores(int id, string name, string subject)
        {
            InitializeComponent();
            studentId = id;
            studentName = name;
            this.subject = subject;

            label2.Text = $"Finished your exam? Review your score, {studentName}!";

            // Hide ComboBox and label1 since subject is already known
            comboBox1.Visible = false;
            label1.Visible = false;

            LoadLatestScore(subject);
        }

        private void LoadLatestScore(string subject)
        {
            // FIX APPLIED HERE: Changed 'date_taken' to 'exam_date'
            string query = @"SELECT score, percentage, status
                             FROM exam_results
                             WHERE student_id = @id AND exam_category = @subject
                             ORDER BY exam_date DESC 
                             LIMIT 1";

            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", studentId);
                        cmd.Parameters.AddWithValue("@subject", subject);

                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                int score = Convert.ToInt32(reader["score"]);
                                decimal percentage = Convert.ToDecimal(reader["percentage"]);
                                string status = reader["status"].ToString();

                                label4.Text = $"{score} / 10 | {percentage:F2}% ({status})";
                                label5.Text = GetEncouragementText(percentage, status);
                            }
                            else
                            {
                                label4.Text = "[No Data]";
                                label5.Text = "[No Recent Exam]";
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading score: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private string GetEncouragementText(decimal percentage, string status)
        {
            if (status == "Passed")
            {
                if (percentage >= 90) return "Excellent work! Keep it up!";
                if (percentage >= 75) return "Good job! You can do even better!";
            }
            else
            {
                if (percentage >= 50) return "Almost there! Review and try again.";
                return "Don't give up! Study and improve!";
            }
            return "Keep practicing!";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void StudentScores_Load(object sender, EventArgs e)
        {

        }
    }
}