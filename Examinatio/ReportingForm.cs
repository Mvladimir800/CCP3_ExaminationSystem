using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ExaminationSystem
{
    public partial class ReportingForm : Form
    {
        private bool isFaculty;

        public ReportingForm(bool facultyView = false)
        {
            InitializeComponent();
            isFaculty = facultyView;
        }

        private void ReportingForm_Load(object sender, EventArgs e)
        {
            LoadCategoryComboBox();
            LoadExamResults();
            SetFacultyMode();
        }

        private void SetFacultyMode()
        {
            // Disable sorting and refresh buttons in faculty view
            if (isFaculty)
            {
                btnSortHigh.Enabled = false;
                btnSortLow.Enabled = false;
                btnRefresh.Enabled = false;
                
            }
        }

        private void LoadCategoryComboBox()
        {
            cbCategory.Items.Clear();
            cbCategory.Items.Add("All Categories");
            cbCategory.Items.Add("Mathematics");
            cbCategory.Items.Add("English");
            cbCategory.Items.Add("Science");
            cbCategory.Items.Add("History");
            cbCategory.SelectedIndex = 0;
        }

        private void LoadExamResults(string category = "All Categories", string sort = "")
        {
            try
            {
               
                using (var conn = Database.GetConnection())
                {
                    conn.Open();
                    string query = @"
                        SELECT 
                            student_id, 
                            student_name, 
                            exam_category, 
                            score, 
                            percentage, 
                            status, 
                            exam_date 
                        FROM 
                            exam_results";

                    // Add WHERE clause for filtering
                    if (category != "All Categories")
                    {
                        query += " WHERE exam_category = @category";
                    }

                    // Add ORDER BY clause for sorting
                    if (!string.IsNullOrEmpty(sort))
                    {
                        query += $" ORDER BY {sort}";
                    }

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        if (category != "All Categories")
                        {
                            cmd.Parameters.AddWithValue("@category", category);
                        }

                        MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        dgvExamResults.DataSource = dt;
                    }
                }
            }
            catch (Exception ex)
            {
              
                MessageBox.Show("Error loading data. Check database connection and 'Database.cs': " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            // When the category changes, reload results without a specific sort
            LoadExamResults(cbCategory.SelectedItem.ToString());
        }

        private void btnSortHigh_Click(object sender, EventArgs e)
        {
            // Sort the currently loaded data source directly
            if (dgvExamResults.DataSource is DataTable dt)
            {
                DataView dv = dt.DefaultView;
                dv.Sort = "score DESC";
                dgvExamResults.DataSource = dv.ToTable();
            }
        }

        private void btnSortLow_Click(object sender, EventArgs e)
        {
            // Sort the currently loaded data source directly
            if (dgvExamResults.DataSource is DataTable dt)
            {
                DataView dv = dt.DefaultView;
                dv.Sort = "score ASC";
                dgvExamResults.DataSource = dv.ToTable();
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            // Reloads data from the database for the current category, clearing local sorts
            LoadExamResults(cbCategory.SelectedItem.ToString());
        }

        private void dgvExamResults_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}