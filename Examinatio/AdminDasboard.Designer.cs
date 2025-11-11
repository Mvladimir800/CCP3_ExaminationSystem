using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace ExaminationSystem
{
    partial class AdminDashboard
    {
        private IContainer components = null;
        private Label lblWelcome;
        private Button button1; // Grading
        private Button button2; // Reporting
        private Button button3; // Student Management
        private Button button4; // User Management
        private Button button5; // Question Bank
        private Button btnLogout;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            lblWelcome = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            btnLogout = new Button();
            label3 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // lblWelcome
            // 
            lblWelcome.AutoSize = true;
            lblWelcome.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblWelcome.Location = new Point(414, 79);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(172, 28);
            lblWelcome.TabIndex = 0;
            lblWelcome.Text = "Welcome, Admin";
            // 
            // button1
            // 
            button1.Location = new Point(162, 269);
            button1.Name = "button1";
            button1.Size = new Size(263, 29);
            button1.TabIndex = 1;
            button1.Text = "Grading";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(640, 193);
            button2.Name = "button2";
            button2.Size = new Size(263, 29);
            button2.TabIndex = 2;
            button2.Text = "Reporting";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(522, 269);
            button3.Name = "button3";
            button3.Size = new Size(263, 29);
            button3.TabIndex = 3;
            button3.Text = "Student Management";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(58, 193);
            button4.Name = "button4";
            button4.Size = new Size(235, 29);
            button4.TabIndex = 4;
            button4.Text = "User Management";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Location = new Point(341, 193);
            button5.Name = "button5";
            button5.Size = new Size(263, 29);
            button5.TabIndex = 5;
            button5.Text = "Question Bank";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // btnLogout
            // 
            btnLogout.Location = new Point(36, 460);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(110, 31);
            btnLogout.TabIndex = 6;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(491, 117);
            label3.Name = "label3";
            label3.Size = new Size(95, 20);
            label3.TabIndex = 18;
            label3.Text = "[Name Here]";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(411, 117);
            label2.Name = "label2";
            label2.Size = new Size(74, 20);
            label2.TabIndex = 17;
            label2.Text = "Welcome,";
            // 
            // AdminDashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(948, 512);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(lblWelcome);
            Controls.Add(button1);
            Controls.Add(button2);
            Controls.Add(button3);
            Controls.Add(button4);
            Controls.Add(button5);
            Controls.Add(btnLogout);
            Name = "AdminDashboard";
            Text = "Admin Dashboard";
            FormClosed += AdminDashboard_FormClosed;
            Load += AdminDashboard_Load;
            ResumeLayout(false);
            PerformLayout();
        }
        private Label label3;
        private Label label2;
    }
}
