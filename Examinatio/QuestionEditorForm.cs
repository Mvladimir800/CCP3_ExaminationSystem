using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Data;

namespace ExaminationSystem
{
    // Make sure the form name matches the designer file.
    public partial class QuestionEditorForm : Form
    {
        private string category;
        // Use nullable int for questionId
        private int? questionId = null;

        // Constructor
        public QuestionEditorForm(string category, int? questionId = null)
        {
            InitializeComponent();
            this.category = category;
            this.questionId = questionId;
        }

        private void QuestionEditorForm_Load(object sender, EventArgs e)
        {
            lblCategory.Text = $"Category: {category}";

            // Ensure the ComboBox has items only once
            if (cmbCorrectAnswer.Items.Count == 0)
            {
                cmbCorrectAnswer.Items.AddRange(new string[] { "A", "B", "C", "D" });
            }
            cmbCorrectAnswer.SelectedIndex = 0;

            if (questionId.HasValue)
            {
                // Load data for editing
                LoadQuestionData();
            }
            else
            {
                // Set default values for new question
                numPoints.Value = 1.0M;
            }
        }

        private void LoadQuestionData()
        {
            
            using (var conn = Database.GetConnection())
            {
                try
                {
                    conn.Open();
                    // Using parameterized query for safety
                    string query = "SELECT question_text, choice_a, choice_b, choice_c, choice_d, correct_answer, points FROM questions WHERE id=@id";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@id", questionId);

                    MySqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        txtQuestion.Text = reader["question_text"].ToString();
                        txtChoiceA.Text = reader["choice_a"].ToString();
                        txtChoiceB.Text = reader["choice_b"].ToString();
                        txtChoiceC.Text = reader["choice_c"].ToString();
                        txtChoiceD.Text = reader["choice_d"].ToString();

                        // Set the correct answer in the ComboBox
                        string correctAnswer = reader["correct_answer"].ToString();
                        if (cmbCorrectAnswer.Items.Contains(correctAnswer))
                        {
                            cmbCorrectAnswer.SelectedItem = correctAnswer;
                        }

                        if (reader["points"] != DBNull.Value)
                        {
                            // Convert to Decimal for the NumericUpDown control
                            numPoints.Value = Convert.ToDecimal(reader["points"]);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading question: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // --- Input Validation ---
            if (string.IsNullOrWhiteSpace(txtQuestion.Text) ||
                string.IsNullOrWhiteSpace(txtChoiceA.Text) ||
                string.IsNullOrWhiteSpace(txtChoiceB.Text) ||
                string.IsNullOrWhiteSpace(txtChoiceC.Text) ||
                string.IsNullOrWhiteSpace(txtChoiceD.Text) ||
                cmbCorrectAnswer.SelectedItem == null)
            {
                MessageBox.Show("Please complete all fields and select a correct answer.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // --- Database Operation ---
            using (var conn = Database.GetConnection())
            {
                try
                {
                    conn.Open();

                    string query;
                    // Check if we are updating (editing) or inserting (new)
                    if (questionId.HasValue)
                    {
                        // Update query
                        query = @"UPDATE questions 
                                SET question_text=@question_text, choice_a=@choice_a, choice_b=@choice_b, 
                                    choice_c=@choice_c, choice_d=@choice_d, correct_answer=@correct_answer, 
                                    points=@points 
                                WHERE id=@id";
                    }
                    else
                    {
                        // Insert query
                        query = @"INSERT INTO questions 
                                (category, question_text, choice_a, choice_b, choice_c, choice_d, correct_answer, points)
                                VALUES (@category, @question_text, @choice_a, @choice_b, @choice_c, @choice_d, @correct_answer, @points)";
                    }

                    MySqlCommand cmd = new MySqlCommand(query, conn);

                    // Add parameters
                    cmd.Parameters.AddWithValue("@category", category);
                    cmd.Parameters.AddWithValue("@question_text", txtQuestion.Text.Trim());
                    cmd.Parameters.AddWithValue("@choice_a", txtChoiceA.Text.Trim());
                    cmd.Parameters.AddWithValue("@choice_b", txtChoiceB.Text.Trim());
                    cmd.Parameters.AddWithValue("@choice_c", txtChoiceC.Text.Trim());
                    cmd.Parameters.AddWithValue("@choice_d", txtChoiceD.Text.Trim());
                    cmd.Parameters.AddWithValue("@correct_answer", cmbCorrectAnswer.Text.Trim());
                    cmd.Parameters.AddWithValue("@points", numPoints.Value);

                    if (questionId.HasValue)
                        cmd.Parameters.AddWithValue("@id", questionId.Value); // Add ID for UPDATE

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Question saved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    // Close the form after successful save
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error saving question: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            // Close the form without saving
            this.Close();
        }
    }
}