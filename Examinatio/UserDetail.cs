using MySql.Data.MySqlClient;
using Org.BouncyCastle.Asn1.Cmp;
using System;
using System.Data;
using System.Windows.Forms;

namespace ExaminationSystem
{
   
    public partial class UserDetailForm : Form
    {
        private bool isEditMode = false;
        private int editUserId;

        // Constructor for add mode (initializes with a default role)
        public UserDetailForm(string role)
        {
            InitializeComponent();
            InitializeControls(role, "Active");
            this.Text = "Add New User";
            txtIdNumber.ReadOnly = false; // ID should be editable for a new user
        }

        // Constructor for EDIT mode
        public UserDetailForm(int userId, string fullname, string username, string email, string role, string status)
        {
            InitializeComponent();
            isEditMode = true;
            editUserId = userId;

            // Populate controls with existing data
            txtIdNumber.Text = userId.ToString();
            txtFullname.Text = fullname;
            txtUsername.Text = username;
            txtEmail.Text = email;

            // Initialize ComboBoxes and select existing values
            InitializeControls(role, status);

            txtIdNumber.ReadOnly = true; 
            txtPassword.Text = "";

            this.Text = "Edit User";
        }

        // Helper method to initialize ComboBoxes (used by both constructors)
        private void InitializeControls(string defaultRole, string defaultStatus)
        {
            // Clear existing items just in case (though InitializeComponent usually handles this)
            cmbRole.Items.Clear();
            cmbStatus.Items.Clear();

            cmbRole.Items.AddRange(new string[] { "Student", "Faculty", "Admin" });
            cmbRole.SelectedItem = defaultRole;

            cmbStatus.Items.AddRange(new string[] { "Active", "Inactive" });
            cmbStatus.SelectedItem = defaultStatus;
        }

        private void UserDetailForm_Load(object sender, EventArgs e)
        {

        }


        private void btnSave_Click(object sender, EventArgs e)
        {
            // Validation Checks 
            string idNumber = txtIdNumber.Text.Trim();
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text;
            string fullname = txtFullname.Text.Trim();
            string email = txtEmail.Text.Trim();
            string role = cmbRole.SelectedItem?.ToString();
            string status = cmbStatus.SelectedItem?.ToString();

            // Basic checks for required fields
            if (string.IsNullOrEmpty(fullname) || string.IsNullOrEmpty(username) || string.IsNullOrEmpty(email) || string.IsNullOrEmpty(role) || string.IsNullOrEmpty(status))
            {
                MessageBox.Show("Please fill in all required fields.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // ID Number check for ADD mode
            if (!isEditMode && string.IsNullOrEmpty(idNumber))
            {
                MessageBox.Show("ID Number is required for new users.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Password check for ADD mode
            if (!isEditMode && string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Password is required for new users.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

          
            // Database Operation 
            try
            {
               
                using (var conn = Database.GetConnection())
                {
                    conn.Open();
                    MySqlCommand cmd;
                    string query;

                    if (isEditMode)
                    {
                        // UPDATE query
                        query = @"UPDATE users SET
                                fullname=@fullname,
                                username=@username,
                                email=@email,
                                role=@role,
                                status=@status";

                        // Only update password if a new one is provided
                        if (!string.IsNullOrEmpty(password))
                        {
                            // In a real application, you should hash the password here (e.g., using BCrypt)
                            query += ", password=@password";
                        }
                        query += " WHERE id=@id";

                        cmd = new MySqlCommand(query, conn);
                        cmd.Parameters.AddWithValue("@id", editUserId);

                        if (!string.IsNullOrEmpty(password))
                        {
                            cmd.Parameters.AddWithValue("@password", password);
                        }
                    }
                    else // ADD mode
                    {
                        // INSERT query
                        query = @"INSERT INTO users
                                (id, fullname, username, password, email, role, status)
                                VALUES (@id, @fullname, @username, @password, @email, @role, @status)";

                        cmd = new MySqlCommand(query, conn);
                        cmd.Parameters.AddWithValue("@id", idNumber);
                        // In a real application, you should hash the password here
                        cmd.Parameters.AddWithValue("@password", password);
                    }

                    // Common parameters
                    cmd.Parameters.AddWithValue("@fullname", fullname);
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@email", email);
                    cmd.Parameters.AddWithValue("@role", role);
                    cmd.Parameters.AddWithValue("@status", status);

                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show(isEditMode ? "User updated successfully." : "User added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.DialogResult = DialogResult.OK; // Signal to the calling form that data was successfully saved
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("No changes were made or user was not found.", "Operation Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (MySqlException sqlEx)
            {
                // Handle specific MySQL errors, like duplicate entry for ID or Username
                if (sqlEx.Number == 1062) 
                {
                    MessageBox.Show($"The entered ID Number or Username already exists. Please use a unique value.\nDetails: {sqlEx.Message}", "Database Conflict", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show($"A database error occurred: {sqlEx.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An unexpected error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

    
}