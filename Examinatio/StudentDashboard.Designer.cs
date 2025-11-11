using System.Drawing;
using System.Windows.Forms;

namespace ExaminationSystem
{
    partial class StudentDashboard
    {
        private System.ComponentModel.IContainer components = null;

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
            btnLogout = new Button();
            label1 = new Label();
            button1 = new Button();
            label2 = new Label();
            label3 = new Label();
            button3 = new Button();
            SuspendLayout();
            // 
            // btnLogout
            // 
            btnLogout.Location = new Point(39, 450);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(118, 34);
            btnLogout.TabIndex = 0;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(325, 64);
            label1.Name = "label1";
            label1.Size = new Size(327, 46);
            label1.TabIndex = 7;
            label1.Text = "Student Dashboard";
            // 
            // button1
            // 
            button1.Location = new Point(244, 250);
            button1.Name = "button1";
            button1.Size = new Size(175, 34);
            button1.TabIndex = 8;
            button1.Text = "Take Exam";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(408, 119);
            label2.Name = "label2";
            label2.Size = new Size(74, 20);
            label2.TabIndex = 10;
            label2.Text = "Welcome,";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(488, 119);
            label3.Name = "label3";
            label3.Size = new Size(95, 20);
            label3.TabIndex = 11;
            label3.Text = "[Name Here]";
            // 
            // button3
            // 
            button3.Location = new Point(548, 250);
            button3.Name = "button3";
            button3.Size = new Size(175, 34);
            button3.TabIndex = 12;
            button3.Text = "View Score ";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // StudentDashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(948, 512);
            Controls.Add(button3);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(btnLogout);
            Name = "StudentDashboard";
            Text = "Student Dashboard";
            FormClosed += StudentDashboard_FormClosed;
            Load += StudentDashboard_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        private Button btnLogout;
        private Label label1;
        private Button button1;
        private Label label2;
        private Label label3;
        private Button button3;
    }
}
