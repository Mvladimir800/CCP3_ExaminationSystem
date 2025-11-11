namespace ExaminationSystem
{
    partial class QuestionEditorForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }


        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblCategory = new Label();
            label1 = new Label();
            txtQuestion = new TextBox();
            label2 = new Label();
            txtChoiceA = new TextBox();
            txtChoiceB = new TextBox();
            label3 = new Label();
            txtChoiceC = new TextBox();
            label4 = new Label();
            txtChoiceD = new TextBox();
            label5 = new Label();
            label6 = new Label();
            cmbCorrectAnswer = new ComboBox();
            btnSave = new Button();
            btnCancel = new Button();
            numPoints = new NumericUpDown();
            label7 = new Label();
            ((System.ComponentModel.ISupportInitialize)numPoints).BeginInit();
            SuspendLayout();
            // 
            // lblCategory
            // 
            lblCategory.AutoSize = true;
            lblCategory.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCategory.Location = new Point(12, 10);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(89, 23);
            lblCategory.TabIndex = 0;
            lblCategory.Text = "Category:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 45);
            label1.Name = "label1";
            label1.Size = new Size(102, 20);
            label1.TabIndex = 1;
            label1.Text = "Question Text:";
            // 
            // txtQuestion
            // 
            txtQuestion.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtQuestion.Location = new Point(15, 63);
            txtQuestion.Multiline = true;
            txtQuestion.Name = "txtQuestion";
            txtQuestion.ScrollBars = ScrollBars.Vertical;
            txtQuestion.Size = new Size(641, 70);
            txtQuestion.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 145);
            label2.Name = "label2";
            label2.Size = new Size(71, 20);
            label2.TabIndex = 3;
            label2.Text = "Choice A:";
            // 
            // txtChoiceA
            // 
            txtChoiceA.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtChoiceA.Location = new Point(15, 163);
            txtChoiceA.Name = "txtChoiceA";
            txtChoiceA.Size = new Size(641, 27);
            txtChoiceA.TabIndex = 1;
            // 
            // txtChoiceB
            // 
            txtChoiceB.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtChoiceB.Location = new Point(15, 212);
            txtChoiceB.Name = "txtChoiceB";
            txtChoiceB.Size = new Size(641, 27);
            txtChoiceB.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 194);
            label3.Name = "label3";
            label3.Size = new Size(70, 20);
            label3.TabIndex = 5;
            label3.Text = "Choice B:";
            // 
            // txtChoiceC
            // 
            txtChoiceC.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtChoiceC.Location = new Point(15, 261);
            txtChoiceC.Name = "txtChoiceC";
            txtChoiceC.Size = new Size(641, 27);
            txtChoiceC.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 243);
            label4.Name = "label4";
            label4.Size = new Size(70, 20);
            label4.TabIndex = 7;
            label4.Text = "Choice C:";
            // 
            // txtChoiceD
            // 
            txtChoiceD.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtChoiceD.Location = new Point(15, 310);
            txtChoiceD.Name = "txtChoiceD";
            txtChoiceD.Size = new Size(641, 27);
            txtChoiceD.TabIndex = 4;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 292);
            label5.Name = "label5";
            label5.Size = new Size(72, 20);
            label5.TabIndex = 9;
            label5.Text = "Choice D:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 353);
            label6.Name = "label6";
            label6.Size = new Size(112, 20);
            label6.TabIndex = 11;
            label6.Text = "Correct Answer:";
            // 
            // cmbCorrectAnswer
            // 
            cmbCorrectAnswer.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCorrectAnswer.FormattingEnabled = true;
            cmbCorrectAnswer.Location = new Point(113, 350);
            cmbCorrectAnswer.Name = "cmbCorrectAnswer";
            cmbCorrectAnswer.Size = new Size(57, 28);
            cmbCorrectAnswer.TabIndex = 5;
            // 
            // btnSave
            // 
            btnSave.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnSave.Location = new Point(500, 395);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 27);
            btnSave.TabIndex = 7;
            btnSave.Text = "&Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCancel.Location = new Point(581, 395);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 27);
            btnCancel.TabIndex = 8;
            btnCancel.Text = "&Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // numPoints
            // 
            numPoints.DecimalPlaces = 1;
            numPoints.Location = new Point(243, 350);
            numPoints.Minimum = new decimal(new int[] { 1, 0, 0, 65536 });
            numPoints.Name = "numPoints";
            numPoints.Size = new Size(70, 27);
            numPoints.TabIndex = 6;
            numPoints.Value = new decimal(new int[] { 10, 0, 0, 65536 });
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(197, 353);
            label7.Name = "label7";
            label7.Size = new Size(51, 20);
            label7.TabIndex = 16;
            label7.Text = "Points:";
            // 
            // QuestionEditorForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(668, 434);
            Controls.Add(label7);
            Controls.Add(numPoints);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(cmbCorrectAnswer);
            Controls.Add(label6);
            Controls.Add(txtChoiceD);
            Controls.Add(label5);
            Controls.Add(txtChoiceC);
            Controls.Add(label4);
            Controls.Add(txtChoiceB);
            Controls.Add(label3);
            Controls.Add(txtChoiceA);
            Controls.Add(label2);
            Controls.Add(txtQuestion);
            Controls.Add(label1);
            Controls.Add(lblCategory);
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "QuestionEditorForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Question Editor";
            Load += QuestionEditorForm_Load;
            ((System.ComponentModel.ISupportInitialize)numPoints).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtQuestion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtChoiceA;
        private System.Windows.Forms.TextBox txtChoiceB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtChoiceC;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtChoiceD;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbCorrectAnswer;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.NumericUpDown numPoints;
        private System.Windows.Forms.Label label7;
    }
}