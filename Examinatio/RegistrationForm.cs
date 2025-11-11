using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ExaminationSystem
{
    public partial class RegisterForm : Form
    {
        
        private const string ADMIN_KEY = "Admin123";

        public RegisterForm()
        {
            InitializeComponent();
        }

        private void RegisterForm_Load(object sender, EventArgs e)
        {
            cmbRole.Items.AddRange(new string[] { "Admin", "Faculty", "Student" });
            cmbRole.SelectedIndex = 2; // Default to Student
            txtIdNumber.Focus();

            // Hide Admin Key field by default
            lblAdminKey.Visible = false;
            txtAdminKey.Visible = false;

            // Show/hide Admin Key field when role changes
            cmbRole.SelectedIndexChanged += (s, ev) =>
            {
                bool isAdmin = cmbRole.SelectedItem.ToString() == "Admin";
                lblAdminKey.Visible = isAdmin;
                txtAdminKey.Visible = isAdmin;
            };
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string idNumber = txtIdNumber.Text.Trim();
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();
            string fullname = txtFullname.Text.Trim();
            string email = txtEmail.Text.Trim();
            string role = cmbRole.SelectedItem?.ToString();

            // Input Validation 
            if (string.IsNullOrEmpty(idNumber) || string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password) ||
                string.IsNullOrEmpty(fullname) || string.IsNullOrEmpty(email) || string.IsNullOrEmpty(role))
            {
                MessageBox.Show("Please fill all fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Admin Key Verification 
            if (role == "Admin")
            {
                if (txtAdminKey.Text.Trim() != ADMIN_KEY)
                {
                    MessageBox.Show("Invalid Admin Key! Only authorized users can register as Admin.", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            // Database Registration 
            try
            {
                using (var conn = Database.GetConnection())
                {
                   
                    conn.Open();

                    string query = "INSERT INTO users (id, username, password, fullname, email, role) VALUES (@id, @u, @p, @f, @e, @r)";

                    using (var cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", idNumber);
                        cmd.Parameters.AddWithValue("@u", username);
                        cmd.Parameters.AddWithValue("@p", password);
                        cmd.Parameters.AddWithValue("@f", fullname);
                        cmd.Parameters.AddWithValue("@e", email);
                        cmd.Parameters.AddWithValue("@r", role);

                        int result = cmd.ExecuteNonQuery();

                        if (result > 0)
                        {
                            MessageBox.Show("User registered successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Failed to register user. No rows affected.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
           
            catch (MySqlException ex)
            {
                string errorMessage;
               
                if (ex.Number == 1062)
                {
                    errorMessage = "Registration failed: A user with this ID Number or Username already exists.";
                }
                else
                {
                    errorMessage = $"Database connection or query failed. Ensure your server is running and data is valid.\n\nDetails: {ex.Message}";
                }
                MessageBox.Show(errorMessage, "Registration Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            // Catch all other errors
            catch (Exception ex)
            {
                MessageBox.Show("An unexpected error occurred: " + ex.Message, "System Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }
    }
}