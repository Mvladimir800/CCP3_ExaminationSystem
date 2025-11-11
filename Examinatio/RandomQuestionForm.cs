using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ExaminationSystem
{
    public partial class RandomQuestionForm : Form
    {
        public RandomQuestionForm()
        {
            InitializeComponent();
        }

        private void RandomQuestionForm_Load(object sender, EventArgs e)
        {
            // Initializes the ComboBox and NumericUpDown controls
            if (cmbCategory.Items.Count == 0)
            {
                cmbCategory.Items.AddRange(new string[] { "Mathematics", "English", "Science", "History" });
            }
            cmbCategory.SelectedIndex = 0;
            numQuestionCount.Value = 5;
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            if (cmbCategory.SelectedItem == null)
            {
                MessageBox.Show("Please select a category.", "Selection Missing", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string category = cmbCategory.SelectedItem.ToString();
            int limit = (int)numQuestionCount.Value;

            using (var conn = Database.GetConnection())
            {
                try
                {
                    conn.Open();
                    // Using parameterized query for security
                    string query = @"
                        SELECT id, question_text, choice_a, choice_b, choice_c, choice_d, correct_answer, points 
                        FROM questions 
                        WHERE category=@category 
                        ORDER BY RAND() 
                        LIMIT @limit";

                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@category", category);
                    cmd.Parameters.AddWithValue("@limit", limit);

                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    dgvRandomQuestions.DataSource = dt;
                    dgvRandomQuestions.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);

                    lblCount.Text = $"Generated {dt.Rows.Count} random questions for {category}.";
                }
                catch (MySqlException sqlEx)
                {
                    MessageBox.Show("Database Error: Could not connect or retrieve data. Check your connection string and SQL statement.\n\n" + sqlEx.Message,
                        "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An unexpected error occurred: " + ex.Message,
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            dgvRandomQuestions.DataSource = null; // Clears the data source
            dgvRandomQuestions.Rows.Clear(); // Ensures any leftover rows are cleared
            lblCount.Text = "No questions generated.";
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvRandomQuestions_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}