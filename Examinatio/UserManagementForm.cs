using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ExaminationSystem
{
    public partial class UserManagementForm : Form
    {
        private MySqlDataAdapter adapter;
        private DataTable dt;
        private string currentRole = "Student";

        public UserManagementForm()
        {
            InitializeComponent();
        }

        private void UserManagementForm_Load(object sender, EventArgs e)
        {
            LoadUsers(currentRole);
        }

        private void LoadUsers(string role)
        {
            try
            {
                // Clear the existing data source before loading new data
                if (dataGridView1.DataSource != null)
                {
                    ((DataTable)dataGridView1.DataSource).Clear();
                }

                using (var conn = Database.GetConnection())
                {
                    conn.Open();
                    // Select users by role, excluding password column
                    string query = "SELECT id, fullname, username, email, role, status FROM users WHERE role=@role ORDER BY fullname";
                    adapter = new MySqlDataAdapter(query, conn);
                    adapter.SelectCommand.Parameters.AddWithValue("@role", role);

                    dt = new DataTable();
                    adapter.Fill(dt);
                    dataGridView1.DataSource = dt;

                    // Hide the ID column
                    if (dataGridView1.Columns.Contains("id"))
                    {
                        dataGridView1.Columns["id"].Visible = false;
                    }

                    this.Text = $"User Management - {role}s";
                }
            }
            catch (Exception ex)
            {
                // Catching the base Exception to handle both SQL and other runtime errors gracefully
                MessageBox.Show("Error loading users: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Button Click to view Student users (button1)
        private void button1_Click(object sender, EventArgs e)
        {
            currentRole = "Student";
            LoadUsers(currentRole);
        }

        // Button Click to view Faculty users (button2)
        private void button2_Click(object sender, EventArgs e)
        {
            currentRole = "Faculty";
            LoadUsers(currentRole);
        }

        // Button Click for Add User (button8)
        private void button8_Click(object sender, EventArgs e)
        {
            // Pass the current role for the new user default
            using (UserDetailForm addForm = new UserDetailForm(currentRole))
            {
                if (addForm.ShowDialog() == DialogResult.OK)
                {
                    LoadUsers(currentRole);
                }
            }
        }

        // Button Click for Edit User (button7)
        private void button7_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Select a user to edit.", "No User Selected", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            try
            {
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];

                // Retrieve data from the selected row
                int id = Convert.ToInt32(selectedRow.Cells["id"].Value);
                string fullname = selectedRow.Cells["fullname"].Value.ToString();
                string username = selectedRow.Cells["username"].Value.ToString();
                string email = selectedRow.Cells["email"].Value.ToString();
                string role = selectedRow.Cells["role"].Value.ToString();
                string status = selectedRow.Cells["status"].Value.ToString();

                

                using (UserDetailForm editForm = new UserDetailForm(id, fullname, username, email, role, status))
                {
                    if (editForm.ShowDialog() == DialogResult.OK)
                    {
                        LoadUsers(currentRole);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error reading selected user data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Button Click for Delete User (button6)
        private void button6_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Select a user to delete.", "No User Selected", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Ensure the ID cell exists and has a value
            if (dataGridView1.SelectedRows[0].Cells["id"] == null || dataGridView1.SelectedRows[0].Cells["id"].Value == null)
            {
                MessageBox.Show("Cannot find the user ID for deletion.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["id"].Value);
            string fullname = dataGridView1.SelectedRows[0].Cells["fullname"].Value.ToString();

            var confirm = MessageBox.Show($"Are you sure you want to delete user: {fullname}?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (confirm == DialogResult.Yes)
            {
                try
                {
                    using (var conn = Database.GetConnection())
                    {
                        conn.Open();
                        string query = "DELETE FROM users WHERE id=@id";
                        MySqlCommand cmd = new MySqlCommand(query, conn);
                        cmd.Parameters.AddWithValue("@id", id);
                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("User deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadUsers(currentRole);
                        }
                        else
                        {
                            MessageBox.Show("User not found or nothing was deleted.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error deleting user: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // Button Click for Close (button3)
        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void panelTop_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}