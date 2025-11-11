using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ExaminationSystem
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            txtIdNumber.Focus();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            // Input Validation and Data Trimming
            string idNumber = txtIdNumber.Text.Trim();
            string username = txtUsername.Text.Trim();
            string pwd = txtPassword.Text.Trim();

            if (string.IsNullOrEmpty(idNumber) || string.IsNullOrEmpty(username) || string.IsNullOrEmpty(pwd))
            {
                MessageBox.Show("Please enter ID Number, Username, and Password.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (var conn = Database.GetConnection())
                {
                    
                    conn.Open();

                    // Using parameterized query for security against SQL injection
                    string query = "SELECT id, fullname, role FROM users WHERE id=@idnum AND username=@u AND password=@p";

                    using (var cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@idnum", idNumber);
                        cmd.Parameters.AddWithValue("@u", username);
                        cmd.Parameters.AddWithValue("@p", pwd);

                        using (var reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                // User found and credentials match
                                int id = reader.GetInt32("id");
                                string fullname = reader.IsDBNull(reader.GetOrdinal("fullname")) ? username : reader.GetString("fullname");
                                string role = reader.GetString("role");

                                Form dashboardForm = null;

                                // Dashboard routing based on user role
                                if (role.Equals("Admin", StringComparison.OrdinalIgnoreCase))
                                {
                                    dashboardForm = new AdminDashboard(id, fullname);
                                }
                                else if (role.Equals("Faculty", StringComparison.OrdinalIgnoreCase))
                                {
                                    dashboardForm = new FacultyDashboard(id, fullname);
                                }
                                else if (role.Equals("Student", StringComparison.OrdinalIgnoreCase))
                                {
                                    dashboardForm = new StudentDashboard(id, fullname);
                                }
                                else
                                {
                                    MessageBox.Show("Login successful, but user role is not recognized or configured.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                    return;
                                }

                                if (dashboardForm != null)
                                {
                                    this.Hide();
                                    dashboardForm.Show();
                                }
                            }
                            else
                            {
                                // No matching record found
                                MessageBox.Show("Invalid ID Number, Username, or Password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                } 
            }
            // Catch specific MySQL errors (e.g., bad connection string, server offline)
            catch (MySqlException ex)
            {
                MessageBox.Show($"Database connection failed. Please ensure the MySQL server is running and the connection details in Database.cs are correct.\n\nError: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            // Catch all other unexpected errors
            catch (Exception ex)
            {
                MessageBox.Show("An unexpected error occurred: " + ex.Message, "System Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            // Implementation for the Register button click
            var regForm = new RegisterForm();
            regForm.ShowDialog();
        }

        private void LoginForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Ensures the entire application exits when the main form is closed
            Application.Exit();
        }
    }
}