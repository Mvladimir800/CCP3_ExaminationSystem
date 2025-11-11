namespace ExaminationSystem
{
    partial class RandomQuestionForm
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            cmbCategory = new ComboBox();
            numQuestionCount = new NumericUpDown();
            btnGenerate = new Button();
            btnClear = new Button();
            btnClose = new Button();
            dgvRandomQuestions = new DataGridView();
            lblCategory = new Label();
            lblCount = new Label();
            lblLimit = new Label();
            ((System.ComponentModel.ISupportInitialize)numQuestionCount).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvRandomQuestions).BeginInit();
            SuspendLayout();
            // 
            // cmbCategory
            // 
            cmbCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCategory.FormattingEnabled = true;
            cmbCategory.Location = new Point(140, 25);
            cmbCategory.Margin = new Padding(3, 4, 3, 4);
            cmbCategory.Name = "cmbCategory";
            cmbCategory.Size = new Size(180, 28);
            cmbCategory.TabIndex = 0;
            // 
            // numQuestionCount
            // 
            numQuestionCount.Location = new Point(490, 25);
            numQuestionCount.Margin = new Padding(3, 4, 3, 4);
            numQuestionCount.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numQuestionCount.Name = "numQuestionCount";
            numQuestionCount.Size = new Size(60, 27);
            numQuestionCount.TabIndex = 1;
            numQuestionCount.Value = new decimal(new int[] { 5, 0, 0, 0 });
            // 
            // btnGenerate
            // 
            btnGenerate.Location = new Point(570, 21);
            btnGenerate.Margin = new Padding(3, 4, 3, 4);
            btnGenerate.Name = "btnGenerate";
            btnGenerate.Size = new Size(95, 36);
            btnGenerate.TabIndex = 2;
            btnGenerate.Text = "&Generate";
            btnGenerate.UseVisualStyleBackColor = true;
            btnGenerate.Click += btnGenerate_Click;
            // 
            // btnClear
            // 
            btnClear.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnClear.Location = new Point(600, 581);
            btnClear.Margin = new Padding(3, 4, 3, 4);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(85, 36);
            btnClear.TabIndex = 3;
            btnClear.Text = "C&lear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnClose
            // 
            btnClose.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnClose.Location = new Point(691, 581);
            btnClose.Margin = new Padding(3, 4, 3, 4);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(85, 36);
            btnClose.TabIndex = 4;
            btnClose.Text = "&Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // dgvRandomQuestions
            // 
            dgvRandomQuestions.AllowUserToAddRows = false;
            dgvRandomQuestions.AllowUserToDeleteRows = false;
            dgvRandomQuestions.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvRandomQuestions.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvRandomQuestions.BackgroundColor = SystemColors.ControlLightLight;
            dgvRandomQuestions.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvRandomQuestions.DefaultCellStyle = dataGridViewCellStyle1;
            dgvRandomQuestions.Location = new Point(20, 75);
            dgvRandomQuestions.Margin = new Padding(3, 4, 3, 4);
            dgvRandomQuestions.Name = "dgvRandomQuestions";
            dgvRandomQuestions.ReadOnly = true;
            dgvRandomQuestions.RowHeadersWidth = 51;
            dgvRandomQuestions.RowTemplate.Height = 24;
            dgvRandomQuestions.Size = new Size(756, 488);
            dgvRandomQuestions.TabIndex = 5;
            dgvRandomQuestions.CellContentClick += dgvRandomQuestions_CellContentClick;
            // 
            // lblCategory
            // 
            lblCategory.AutoSize = true;
            lblCategory.Location = new Point(20, 29);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(116, 20);
            lblCategory.TabIndex = 6;
            lblCategory.Text = "Select Category:";
            // 
            // lblCount
            // 
            lblCount.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblCount.AutoSize = true;
            lblCount.Location = new Point(20, 589);
            lblCount.Name = "lblCount";
            lblCount.Size = new Size(171, 20);
            lblCount.TabIndex = 7;
            lblCount.Text = "No questions generated.";
            // 
            // lblLimit
            // 
            lblLimit.AutoSize = true;
            lblLimit.Location = new Point(340, 29);
            lblLimit.Name = "lblLimit";
            lblLimit.Size = new Size(153, 20);
            lblLimit.TabIndex = 8;
            lblLimit.Text = "Number of Questions:";
            // 
            // RandomQuestionForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(796, 625);
            Controls.Add(lblLimit);
            Controls.Add(lblCount);
            Controls.Add(lblCategory);
            Controls.Add(dgvRandomQuestions);
            Controls.Add(btnClose);
            Controls.Add(btnClear);
            Controls.Add(btnGenerate);
            Controls.Add(numQuestionCount);
            Controls.Add(cmbCategory);
            Margin = new Padding(3, 4, 3, 4);
            MinimumSize = new Size(700, 613);
            Name = "RandomQuestionForm";
            Text = "Random Question Generator";
            Load += RandomQuestionForm_Load;
            ((System.ComponentModel.ISupportInitialize)numQuestionCount).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvRandomQuestions).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        private System.Windows.Forms.ComboBox cmbCategory;
        private System.Windows.Forms.NumericUpDown numQuestionCount;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.DataGridView dgvRandomQuestions;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.Label lblCount;
        private System.Windows.Forms.Label lblLimit;
    }
}