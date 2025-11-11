using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ExaminationSystem
{
    public partial class ExamForm : Form
    {
        private List<Question> questions = new List<Question>();
        private int currentIndex = 0;
        private Dictionary<int, string> answers = new Dictionary<int, string>();
        private int totalScore = 0;
        private string selectedCategory;
        private string connectionString = "server=localhost;user=jmbalang;password=dt117;database=examdb;";

        private int studentId;
        private string studentName;

        public ExamForm() 
        {
            InitializeComponent();
        }

        public ExamForm(int studentId, string studentName, string subject)
        {
            InitializeComponent();

            this.studentId = studentId;
            this.studentName = studentName;
            this.selectedCategory = subject;

            this.Text = $"Take Exam: {studentName} ({subject})";

            ResetExamState();
            LoadQuestions(subject);
            if (questions.Count > 0)
                DisplayQuestion();
            else
                MessageBox.Show($"No questions available for '{subject}'. Please check the database.",
                                "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ResetExamState()
        {
            questions.Clear();
            answers.Clear();
            currentIndex = 0;
            totalScore = 0;

            lblQuestionNumber.Text = "Question 0/0";
            lblQuestion.Text = "Please select a subject to begin.";
            rbA.Text = rbB.Text = rbC.Text = rbD.Text = "";
            rbA.Checked = rbB.Checked = rbC.Checked = rbD.Checked = false;
            btnPrev.Enabled = btnNext.Enabled = btnSubmit.Enabled = false;
        }

        private void DisplayQuestion()
        {
            if (questions.Count == 0) return;

            var q = questions[currentIndex];
            lblQuestionNumber.Text = $"Question {currentIndex + 1}/{questions.Count}";
            lblQuestion.Text = q.Text;
            rbA.Text = q.ChoiceA;
            rbB.Text = q.ChoiceB;
            rbC.Text = q.ChoiceC;
            rbD.Text = q.ChoiceD;

            rbA.Checked = rbB.Checked = rbC.Checked = rbD.Checked = false;

            if (answers.ContainsKey(q.Id))
            {
                switch (answers[q.Id])
                {
                    case "A": rbA.Checked = true; break;
                    case "B": rbB.Checked = true; break;
                    case "C": rbC.Checked = true; break;
                    case "D": rbD.Checked = true; break;
                }
            }

            btnPrev.Enabled = currentIndex > 0;
            btnNext.Enabled = currentIndex < questions.Count - 1;
            btnSubmit.Enabled = questions.Count > 0;
        }

        private void rbChoice_CheckedChanged(object sender, EventArgs e)
        {
            if (sender is RadioButton rb && rb.Checked)
                SaveAnswer();
        }

        private void SaveAnswer()
        {
            string selected = null;
            if (rbA.Checked) selected = "A";
            else if (rbB.Checked) selected = "B";
            else if (rbC.Checked) selected = "C";
            else if (rbD.Checked) selected = "D";

            if (selected != null)
                answers[questions[currentIndex].Id] = selected;
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            SaveAnswer();
            if (currentIndex < questions.Count - 1)
            {
                currentIndex++;
                DisplayQuestion();
            }
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            SaveAnswer();
            if (currentIndex > 0)
            {
                currentIndex--;
                DisplayQuestion();
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (questions.Count == 0) return;

            SaveAnswer(); // Save last answer

            totalScore = 0;
            decimal totalPoints = 0m;

            foreach (var q in questions)
            {
                totalPoints += q.Points;
                if (answers.ContainsKey(q.Id) && answers[q.Id] == q.CorrectAnswer)
                    totalScore += (int)q.Points;
            }

            decimal percentage = (totalPoints > 0) ? ((decimal)totalScore / totalPoints) * 100 : 0m;
            string status = (percentage >= 75) ? "Passed" : "Failed";

            SaveResultsToDatabase(totalScore, percentage, status, questions.Count);

           

            // Open StudentScores form immediately after saving
            try
            {
                // Redirect the student to their most recent score view
                StudentScores scoreForm = new StudentScores(studentId, studentName, selectedCategory);
                scoreForm.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to open Student Score form.\n\n" + ex.Message,
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            this.Close(); // Close exam form
        }

        private void LoadQuestions(string category)
        {
            questions.Clear();
            string query = @"SELECT id, question_text, choice_a, choice_b, choice_c, choice_d, correct_answer, points
                             FROM questions 
                             WHERE category = @cat 
                             ORDER BY RAND() 
                             LIMIT 10";

            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@cat", category);
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                questions.Add(new Question
                                {
                                    Id = reader.GetInt32("id"),
                                    Text = reader.GetString("question_text"),
                                    ChoiceA = reader.GetString("choice_a"),
                                    ChoiceB = reader.GetString("choice_b"),
                                    ChoiceC = reader.GetString("choice_c"),
                                    ChoiceD = reader.GetString("choice_d"),
                                    CorrectAnswer = reader.GetString("correct_answer"),
                                    Points = reader.GetDecimal("points")
                                });
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading questions: " + ex.Message,
                                "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                BeginInvoke(new MethodInvoker(Close));
            }
        }

        private void SaveResultsToDatabase(int score, decimal percentage, string status, int totalQuestions)
        {
            string query = @"
                INSERT INTO exam_results 
                (student_id, student_name, exam_category, score, percentage, status)
                VALUES (@id, @name, @category, @score, @perc, @status)";

            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", studentId);
                        cmd.Parameters.AddWithValue("@name", studentName);
                        cmd.Parameters.AddWithValue("@category", selectedCategory);
                        cmd.Parameters.AddWithValue("@score", score);
                        cmd.Parameters.AddWithValue("@perc", percentage);
                        cmd.Parameters.AddWithValue("@status", status);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to save exam results: " + ex.Message,
                                "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ExamForm_Load(object sender, EventArgs e)
        {

        }
    }
}