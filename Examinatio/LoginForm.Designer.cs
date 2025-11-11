namespace ExaminationSystem
{
    partial class LoginForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblIdNumber;
        private System.Windows.Forms.TextBox txtIdNumber;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label lblPass;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            lblIdNumber = new Label();
            txtIdNumber = new TextBox();
            lblUser = new Label();
            txtUsername = new TextBox();
            lblPass = new Label();
            txtPassword = new TextBox();
            btnLogin = new Button();
            btnRegister = new Button();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lblIdNumber
            // 
            lblIdNumber.AutoSize = true;
            lblIdNumber.Location = new Point(81, 169);
            lblIdNumber.Name = "lblIdNumber";
            lblIdNumber.Size = new Size(82, 20);
            lblIdNumber.TabIndex = 0;
            lblIdNumber.Text = "ID Number";
            // 
            // txtIdNumber
            // 
            txtIdNumber.Location = new Point(184, 162);
            txtIdNumber.Name = "txtIdNumber";
            txtIdNumber.Size = new Size(260, 27);
            txtIdNumber.TabIndex = 1;
            // 
            // lblUser
            // 
            lblUser.AutoSize = true;
            lblUser.Location = new Point(81, 226);
            lblUser.Name = "lblUser";
            lblUser.Size = new Size(75, 20);
            lblUser.TabIndex = 2;
            lblUser.Text = "Username";
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(184, 223);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(260, 27);
            txtUsername.TabIndex = 3;
            // 
            // lblPass
            // 
            lblPass.AutoSize = true;
            lblPass.Location = new Point(81, 282);
            lblPass.Name = "lblPass";
            lblPass.Size = new Size(70, 20);
            lblPass.TabIndex = 4;
            lblPass.Text = "Password";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(184, 279);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(260, 27);
            txtPassword.TabIndex = 5;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(126, 381);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(125, 33);
            btnLogin.TabIndex = 6;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // btnRegister
            // 
            btnRegister.Location = new Point(369, 381);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(125, 33);
            btnRegister.TabIndex = 7;
            btnRegister.Text = "Register (Admin)";
            btnRegister.UseVisualStyleBackColor = true;
            btnRegister.Click += btnRegister_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(243, 31);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(126, 44);
            pictureBox1.TabIndex = 15;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(258, 78);
            label1.Name = "label1";
            label1.Size = new Size(97, 41);
            label1.TabIndex = 14;
            label1.Text = "Login";
            // 
            // LoginForm
            // 
            ClientSize = new Size(591, 493);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Controls.Add(btnRegister);
            Controls.Add(btnLogin);
            Controls.Add(txtPassword);
            Controls.Add(lblPass);
            Controls.Add(txtUsername);
            Controls.Add(lblUser);
            Controls.Add(txtIdNumber);
            Controls.Add(lblIdNumber);
            Name = "LoginForm";
            Text = "Exam System - Login";
            FormClosing += LoginForm_FormClosing;
            Load += LoginForm_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
