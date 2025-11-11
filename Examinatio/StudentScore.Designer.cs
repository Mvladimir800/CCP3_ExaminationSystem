using System.Drawing;
using System.Windows.Forms;

namespace ExaminationSystem
{
    partial class StudentScores
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            button3 = new Button();
            comboBox1 = new ComboBox();
            label2 = new Label();
            label1 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            SuspendLayout();
            // 
            // button3
            // 
            button3.Location = new Point(12, 186);
            button3.Name = "button3";
            button3.Size = new Size(94, 29);
            button3.TabIndex = 7;
            button3.Text = "Return";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // comboBox1
            // 
            comboBox1.Location = new Point(39, 109);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(159, 28);
            comboBox1.TabIndex = 8;
            comboBox1.Visible = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(39, 27);
            label2.Name = "label2";
            label2.Size = new Size(383, 20);
            label2.TabIndex = 9;
            label2.Text = "Finished with your exams? Have a re-view at your scores!";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(39, 86);
            label1.Name = "label1";
            label1.Size = new Size(126, 20);
            label1.TabIndex = 10;
            label1.Text = "Choose a Subject:";
            label1.Visible = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(251, 72);
            label3.Name = "label3";
            label3.Size = new Size(147, 20);
            label3.TabIndex = 11;
            label3.Text = "Your score, out of 10:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 19.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(251, 92);
            label4.Name = "label4";
            label4.Size = new Size(171, 45);
            label4.TabIndex = 12;
            label4.Text = "[Number]";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(251, 159);
            label5.Name = "label5";
            label5.Size = new Size(154, 20);
            label5.TabIndex = 13;
            label5.Text = "[Encouragement Text]";
            // 
            // StudentScores
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(464, 225);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(comboBox1);
            Controls.Add(button3);
            Name = "StudentScores";
            Text = "Rhodes Canvas - Scores";
            Load += StudentScores_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button3;
        private ComboBox comboBox1;
        private Label label2;
        private Label label1;
        private Label label3;
        private Label label4;
        private Label label5;
    }
}
