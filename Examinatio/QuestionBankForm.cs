using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ExaminationSystem
{
    public partial class QuestionBankForm : Form
    {
        private string selectedCategory = "Mathematics";

        // 1. RE-ADDED: Field to store the role passed from the parent form.
        private readonly string userRole;

        // 2. RE-ADDED: Constructor that requires the user role string.
        public QuestionBankForm(string role)
        {
            InitializeComponent();
            this.userRole = role; // Store the role
        }

        // Keep the default constructor (without the role argument) only if 
        // you ensure it's never called or if you truly implement CurrentSession
        /*
        public QuestionBankForm() 
        {
            InitializeComponent();
            // If using the default constructor, the role will be empty/null unless 
            // set by a static session manager.
            this.userRole = "Unknown"; 
        }
        */

        private void QuestionBankForm_Load(object sender, EventArgs e)
        {
            if (cmbCategory.Items.Count == 0)
            {
                cmbCategory.Items.AddRange(new string[] { "Mathematics", "English", "Science", "History" });
            }
            cmbCategory.SelectedIndex = 0;
            LoadQuestions();

            // 3. FIXED: Use the local 'userRole' field for conditional hiding.
            if (this.userRole == "Faculty")
            {
                if (btnAdd != null)
                {
                    btnAdd.Visible = false;
                }
                if (btnEdit != null)
                {
                    btnEdit.Visible = false;
                }
                if (btnDelete != null)
                {
                    btnDelete.Visible = false;
                }
            }
        }

        private void cmbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedCategory = cmbCategory.SelectedItem.ToString();
            LoadQuestions();
        }

        private void LoadQuestions()
        {
            using (var conn = Database.GetConnection())
            {
                try
                {
                    conn.Open();
                    string query = "SELECT id, question_text, choice_a, choice_b, choice_c, choice_d, correct_answer, points FROM questions WHERE category=@category";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@category", selectedCategory);

                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    dgvQuestions.DataSource = dt;

                    if (dgvQuestions.Columns.Contains("id"))
                    {
                        dgvQuestions.Columns["id"].Visible = false;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading questions: " + ex.Message);
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            QuestionEditorForm editor = new QuestionEditorForm(selectedCategory);
            editor.ShowDialog();
            LoadQuestions();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvQuestions.SelectedRows.Count > 0)
            {
                int questionId = Convert.ToInt32(dgvQuestions.SelectedRows[0].Cells["id"].Value);
                QuestionEditorForm editor = new QuestionEditorForm(selectedCategory, questionId);
                editor.ShowDialog();
                LoadQuestions();
            }
            else
            {
                MessageBox.Show("Please select a question to edit.");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvQuestions.SelectedRows.Count > 0)
            {
                int questionId = Convert.ToInt32(dgvQuestions.SelectedRows[0].Cells["id"].Value);

                DialogResult confirm = MessageBox.Show("Are you sure you want to delete this question?", "Confirm Delete", MessageBoxButtons.YesNo);
                if (confirm == DialogResult.Yes)
                {
                    using (var conn = Database.GetConnection())
                    {
                        try
                        {
                            conn.Open();
                            string query = "DELETE FROM questions WHERE id=@id";
                            MySqlCommand cmd = new MySqlCommand(query, conn);
                            cmd.Parameters.AddWithValue("@id", questionId);
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Question deleted successfully.");
                            LoadQuestions();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error deleting question: " + ex.Message);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a question to delete.");
            }
        }

        private void dgvQuestions_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}