using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ExaminationSystem
{
    public partial class GradingForm : Form
    {
        public GradingForm()
        {
            InitializeComponent();
        }

        private void GradingForm_Load(object sender, EventArgs e)
        {
            LoadStudentScores();

            // Set DGV properties to prevent manual editing of scores/grades
            dataGridViewGrades.AllowUserToAddRows = false;
            dataGridViewGrades.ReadOnly = true;
        }

        /// <summary>
        /// Helper function to safely get integer scores, returning 0 if the value is null or non-numeric.
        /// </summary>
        private int GetScore(object scoreValue)
        {
            if (scoreValue == null || scoreValue == DBNull.Value || !int.TryParse(scoreValue.ToString(), out int score))
            {
                return 0;
            }
            return score;
        }

        private void LoadStudentScores()
        {
            using (var conn = Database.GetConnection()) // Assuming 'Database' class handles connections
            {
                try
                {
                    conn.Open();

                    // QUERY: Selects student info and the LATEST score for each subject from exam_results.
                    string query = @"
                        SELECT 
                            u.id AS ID, 
                            u.fullname AS StudentName,
                            
                            -- Get the latest Math score
                            (SELECT er.score 
                             FROM exam_results er 
                             WHERE er.student_id = u.id AND er.exam_category = 'mathematics' 
                             ORDER BY er.exam_date DESC LIMIT 1) AS MathematicsScore,
                            
                            -- Get the latest English score
                            (SELECT er.score 
                             FROM exam_results er 
                             WHERE er.student_id = u.id AND er.exam_category = 'english' 
                             ORDER BY er.exam_date DESC LIMIT 1) AS EnglishScore,
                             
                            -- Get the latest Science score
                            (SELECT er.score 
                             FROM exam_results er 
                             WHERE er.student_id = u.id AND er.exam_category = 'science' 
                             ORDER BY er.exam_date DESC LIMIT 1) AS ScienceScore,
                             
                            -- Get the latest History score
                            (SELECT er.score 
                             FROM exam_results er 
                             WHERE er.student_id = u.id AND er.exam_category = 'history' 
                             ORDER BY er.exam_date DESC LIMIT 1) AS HistoryScore
                             
                        FROM users u
                        WHERE u.role = 'Student';";

                    MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    // --- STEP 1: Add calculated columns for display ---
                    dt.Columns.Add("Maths Score", typeof(int));
                    dt.Columns.Add("Maths %", typeof(decimal));
                    dt.Columns.Add("English Score", typeof(int));
                    dt.Columns.Add("English %", typeof(decimal));
                    dt.Columns.Add("Science Score", typeof(int));
                    dt.Columns.Add("Science %", typeof(decimal));
                    dt.Columns.Add("History Score", typeof(int));
                    dt.Columns.Add("History %", typeof(decimal));

                    dt.Columns.Add("Overall Total Score", typeof(int));
                    dt.Columns.Add("Overall Percentage", typeof(decimal));

                    // Final Grade (0-100 whole number) based on rounded percentage
                    dt.Columns.Add("Final Grade", typeof(int));

                   
                    foreach (DataRow row in dt.Rows)
                    {
                        // Safely retrieve scores, treating DBNull or non-numeric values as 0
                        int maths = GetScore(row["MathematicsScore"]);
                        int english = GetScore(row["EnglishScore"]);
                        int science = GetScore(row["ScienceScore"]);
                        int history = GetScore(row["HistoryScore"]);

                        // Map Raw Scores (for display)
                        row["Maths Score"] = maths;
                        row["English Score"] = english;
                        row["Science Score"] = science;
                        row["History Score"] = history;

                        // Calculate Subject Percentages (Max Score per subject assumed to be 100)
                        row["Maths %"] = (maths > 0) ? ((decimal)maths / 100M) * 100M : 0M;
                        row["English %"] = (english > 0) ? ((decimal)english / 100M) * 100M : 0M;
                        row["Science %"] = (science > 0) ? ((decimal)science / 100M) * 100M : 0M;
                        row["History %"] = (history > 0) ? ((decimal)history / 100M) * 100M : 0M;

                        // Calculate Overall Total and Percentage (Max Total = 4 subjects * 100 = 400)
                        int totalScore = maths + english + science + history;
                        decimal overallPercentage = (totalScore > 0) ? ((decimal)totalScore / 400M) * 100M : 0M;

                        row["Overall Total Score"] = totalScore;
                        row["Overall Percentage"] = overallPercentage;

                        // Assign the rounded integer percentage as the Final Grade (0-100)
                        row["Final Grade"] = (int)Math.Round(overallPercentage);
                    }

                    dataGridViewGrades.DataSource = dt;

                     
                    if (dataGridViewGrades.Columns.Contains("MathematicsScore")) dataGridViewGrades.Columns["MathematicsScore"].Visible = false;
                    if (dataGridViewGrades.Columns.Contains("EnglishScore")) dataGridViewGrades.Columns["EnglishScore"].Visible = false;
                    if (dataGridViewGrades.Columns.Contains("ScienceScore")) dataGridViewGrades.Columns["ScienceScore"].Visible = false;
                    if (dataGridViewGrades.Columns.Contains("HistoryScore")) dataGridViewGrades.Columns["HistoryScore"].Visible = false;

                    // Format percentage columns to two decimal places
                    foreach (DataGridViewColumn col in dataGridViewGrades.Columns)
                    {
                        if (col.HeaderText.EndsWith("%"))
                        {
                            col.DefaultCellStyle.Format = "N2";
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading student scores: " + ex.Message);
                }
            }
        }

       

        private void dataGridViewGrades_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
    }
}