using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ExaminationSystem
{
    public partial class StudentPerformance : Form
    {
        private readonly int studentId;
        private readonly string studentName;
        private readonly string connectionString = "server=localhost;user=jmbalang;password=dt117;database=examdb;";

        public StudentPerformance(int id, string name)
        {
            InitializeComponent();
            studentId = id;
            studentName = name;
            lblWelcome.Text = $"Performance Progress: {studentName}";

            // Disable any features that could allow access to other students
            dataGridViewPerformance.AllowUserToAddRows = false;
            dataGridViewPerformance.ReadOnly = true;
        }

        private void StudentPerformance_Load(object sender, EventArgs e)
        {
            LoadPerformanceData();
        }

        private void LoadPerformanceData()
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();

                    // Only show exams for the logged-in student
                    string query = @"
                        SELECT exam_category AS Subject,
                               score AS Score,
                               percentage AS Percentage,
                               status AS Result
                        FROM exam_results
                        WHERE student_id = @id
                        ORDER BY result_id ASC;";

                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn))
                    {
                        adapter.SelectCommand.Parameters.AddWithValue("@id", studentId);

                        DataTable dt = new DataTable();
                        adapter.Fill(dt);

                        dataGridViewPerformance.DataSource = dt;
                    }

                    // Highlight failing scores (<75%)
                    foreach (DataGridViewRow row in dataGridViewPerformance.Rows)
                    {
                        if (row.Cells["Percentage"].Value != null &&
                            decimal.TryParse(row.Cells["Percentage"].Value.ToString(), out decimal perc) &&
                            perc < 75)
                        {
                            row.DefaultCellStyle.BackColor = System.Drawing.Color.LightCoral;
                        }
                        else
                        {
                            row.DefaultCellStyle.BackColor = System.Drawing.Color.White;
                        }
                    }

                    dataGridViewPerformance.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Database connection failed.\n\n" + ex.Message,
                                "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading performance data: " + ex.Message,
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridViewPerformance_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // No action – students cannot access other data
        }
    }
}
