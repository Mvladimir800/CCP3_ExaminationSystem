using System.Drawing;
using System.Windows.Forms;

namespace ExaminationSystem
{
    partial class FacultyDashboard
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
            label3 = new Label();
            label2 = new Label();
            button2 = new Button();
            button1 = new Button();
            label1 = new Label();
            button3 = new Button();
            SuspendLayout();
            // 
            // btnLogout
            // 
            btnLogout.Location = new Point(35, 448);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(118, 34);
            btnLogout.TabIndex = 0;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(487, 159);
            label3.Name = "label3";
            label3.Size = new Size(95, 20);
            label3.TabIndex = 16;
            label3.Text = "[Name Here]";
            label3.Click += label3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(407, 159);
            label2.Name = "label2";
            label2.Size = new Size(74, 20);
            label2.TabIndex = 15;
            label2.Text = "Welcome,";
            // 
            // button2
            // 
            button2.Location = new Point(663, 252);
            button2.Name = "button2";
            button2.Size = new Size(207, 34);
            button2.TabIndex = 14;
            button2.Text = "Grading Form";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(93, 252);
            button1.Name = "button1";
            button1.Size = new Size(175, 34);
            button1.TabIndex = 13;
            button1.Text = "Student Management";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(338, 113);
            label1.Name = "label1";
            label1.Size = new Size(315, 46);
            label1.TabIndex = 12;
            label1.Text = "Faculty Dashboard";
            // 
            // button3
            // 
            button3.Location = new Point(375, 252);
            button3.Name = "button3";
            button3.Size = new Size(207, 34);
            button3.TabIndex = 17;
            button3.Text = "Question Bank";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // FacultyDashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(948, 512);
            Controls.Add(button3);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(btnLogout);
            Name = "FacultyDashboard";
            Text = "Faculty Dashboard";
            Load += FacultyDashboard_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        private Button btnLogout;
        private Label label3;
        private Label label2;
        private Button button2;
        private Button button1;
        private Label label1;
        private Button button3;
    }
}
