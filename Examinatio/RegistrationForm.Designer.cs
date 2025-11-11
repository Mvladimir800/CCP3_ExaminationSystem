namespace ExaminationSystem
{
    partial class RegisterForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblIdNumber;
        private System.Windows.Forms.TextBox txtIdNumber;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblFullname;
        private System.Windows.Forms.TextBox txtFullname;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblRole;
        private System.Windows.Forms.ComboBox cmbRole;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblAdminKey;
        private System.Windows.Forms.TextBox txtAdminKey;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegisterForm));
            lblIdNumber = new Label();
            txtIdNumber = new TextBox();
            lblUsername = new Label();
            txtUsername = new TextBox();
            lblPassword = new Label();
            txtPassword = new TextBox();
            lblFullname = new Label();
            txtFullname = new TextBox();
            lblEmail = new Label();
            txtEmail = new TextBox();
            lblRole = new Label();
            cmbRole = new ComboBox();
            btnRegister = new Button();
            btnCancel = new Button();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            lblAdminKey = new Label();
            txtAdminKey = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lblIdNumber
            // 
            lblIdNumber.AutoSize = true;
            lblIdNumber.Location = new Point(81, 166);
            lblIdNumber.Name = "lblIdNumber";
            lblIdNumber.Size = new Size(85, 20);
            lblIdNumber.TabIndex = 0;
            lblIdNumber.Text = "ID Number:";
            // 
            // txtIdNumber
            // 
            txtIdNumber.Location = new Point(196, 159);
            txtIdNumber.Name = "txtIdNumber";
            txtIdNumber.Size = new Size(235, 27);
            txtIdNumber.TabIndex = 1;
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Location = new Point(81, 217);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(78, 20);
            lblUsername.TabIndex = 2;
            lblUsername.Text = "Username:";
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(196, 210);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(235, 27);
            txtUsername.TabIndex = 3;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Location = new Point(81, 268);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(73, 20);
            lblPassword.TabIndex = 4;
            lblPassword.Text = "Password:";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(196, 261);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(235, 27);
            txtPassword.TabIndex = 5;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // lblFullname
            // 
            lblFullname.AutoSize = true;
            lblFullname.Location = new Point(81, 316);
            lblFullname.Name = "lblFullname";
            lblFullname.Size = new Size(79, 20);
            lblFullname.TabIndex = 6;
            lblFullname.Text = "Full Name:";
            // 
            // txtFullname
            // 
            txtFullname.Location = new Point(196, 309);
            txtFullname.Name = "txtFullname";
            txtFullname.Size = new Size(235, 27);
            txtFullname.TabIndex = 7;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(81, 362);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(49, 20);
            lblEmail.TabIndex = 8;
            lblEmail.Text = "Email:";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(196, 355);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(235, 27);
            txtEmail.TabIndex = 9;
            // 
            // lblRole
            // 
            lblRole.AutoSize = true;
            lblRole.Location = new Point(81, 413);
            lblRole.Name = "lblRole";
            lblRole.Size = new Size(42, 20);
            lblRole.TabIndex = 10;
            lblRole.Text = "Role:";
            // 
            // cmbRole
            // 
            cmbRole.Location = new Point(196, 405);
            cmbRole.Name = "cmbRole";
            cmbRole.Size = new Size(235, 28);
            cmbRole.TabIndex = 11;
            // 
            // btnRegister
            // 
            btnRegister.Location = new Point(91, 520);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(120, 35);
            btnRegister.TabIndex = 14;
            btnRegister.Text = "Register";
            btnRegister.Click += btnRegister_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(350, 520);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(120, 35);
            btnCancel.TabIndex = 15;
            btnCancel.Text = "Cancel";
            btnCancel.Click += btnCancel_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(206, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(126, 44);
            pictureBox1.TabIndex = 16;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(145, 59);
            label1.Name = "label1";
            label1.Size = new Size(272, 41);
            label1.TabIndex = 17;
            label1.Text = "Registration Form";
            label1.Click += label1_Click;
            // 
            // lblAdminKey
            // 
            lblAdminKey.AutoSize = true;
            lblAdminKey.Location = new Point(81, 457);
            lblAdminKey.Name = "lblAdminKey";
            lblAdminKey.Size = new Size(84, 20);
            lblAdminKey.TabIndex = 12;
            lblAdminKey.Text = "Admin Key:";
            // 
            // txtAdminKey
            // 
            txtAdminKey.Location = new Point(196, 450);
            txtAdminKey.Name = "txtAdminKey";
            txtAdminKey.Size = new Size(235, 27);
            txtAdminKey.TabIndex = 13;
            txtAdminKey.UseSystemPasswordChar = true;
            // 
            // RegisterForm
            // 
            BackColor = SystemColors.ButtonFace;
            ClientSize = new Size(544, 597);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Controls.Add(lblIdNumber);
            Controls.Add(txtIdNumber);
            Controls.Add(lblUsername);
            Controls.Add(txtUsername);
            Controls.Add(lblPassword);
            Controls.Add(txtPassword);
            Controls.Add(lblFullname);
            Controls.Add(txtFullname);
            Controls.Add(lblEmail);
            Controls.Add(txtEmail);
            Controls.Add(lblRole);
            Controls.Add(cmbRole);
            Controls.Add(lblAdminKey);
            Controls.Add(txtAdminKey);
            Controls.Add(btnRegister);
            Controls.Add(btnCancel);
            Name = "RegisterForm";
            Text = "Register New User";
            Load += RegisterForm_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
