namespace ExaminationSystem
{
    partial class ReportingForm
    {
        
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
            cbCategory = new ComboBox();
            btnSortHigh = new Button();
            btnSortLow = new Button();
            dgvExamResults = new DataGridView();
            btnRefresh = new Button();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvExamResults).BeginInit();
            SuspendLayout();
            // 
            // cbCategory
            // 
            cbCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            cbCategory.FormattingEnabled = true;
            cbCategory.Location = new Point(100, 19);
            cbCategory.Margin = new Padding(3, 4, 3, 4);
            cbCategory.Name = "cbCategory";
            cbCategory.Size = new Size(150, 28);
            cbCategory.TabIndex = 0;
            cbCategory.SelectedIndexChanged += cbCategory_SelectedIndexChanged;
            // 
            // btnSortHigh
            // 
            btnSortHigh.Location = new Point(260, 15);
            btnSortHigh.Margin = new Padding(3, 4, 3, 4);
            btnSortHigh.Name = "btnSortHigh";
            btnSortHigh.Size = new Size(120, 38);
            btnSortHigh.TabIndex = 1;
            btnSortHigh.Text = "Sort High Score";
            btnSortHigh.UseVisualStyleBackColor = true;
            btnSortHigh.Click += btnSortHigh_Click;
            // 
            // btnSortLow
            // 
            btnSortLow.Location = new Point(386, 15);
            btnSortLow.Margin = new Padding(3, 4, 3, 4);
            btnSortLow.Name = "btnSortLow";
            btnSortLow.Size = new Size(120, 38);
            btnSortLow.TabIndex = 2;
            btnSortLow.Text = "Sort Low Score";
            btnSortLow.UseVisualStyleBackColor = true;
            btnSortLow.Click += btnSortLow_Click;
            // 
            // dgvExamResults
            // 
            dgvExamResults.AllowUserToAddRows = false;
            dgvExamResults.AllowUserToDeleteRows = false;
            dgvExamResults.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvExamResults.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvExamResults.Location = new Point(12, 68);
            dgvExamResults.Margin = new Padding(3, 4, 3, 4);
            dgvExamResults.Name = "dgvExamResults";
            dgvExamResults.ReadOnly = true;
            dgvExamResults.RowHeadersWidth = 51;
            dgvExamResults.RowTemplate.Height = 24;
            dgvExamResults.Size = new Size(776, 480);
            dgvExamResults.TabIndex = 3;
            dgvExamResults.CellContentClick += dgvExamResults_CellContentClick;
            // 
            // btnRefresh
            // 
            btnRefresh.Location = new Point(512, 15);
            btnRefresh.Margin = new Padding(3, 4, 3, 4);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(100, 38);
            btnRefresh.TabIndex = 4;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 22);
            label1.Name = "label1";
            label1.Size = new Size(72, 20);
            label1.TabIndex = 5;
            label1.Text = "Category:";
            // 
            // ReportingForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 562);
            Controls.Add(label1);
            Controls.Add(btnRefresh);
            Controls.Add(dgvExamResults);
            Controls.Add(btnSortLow);
            Controls.Add(btnSortHigh);
            Controls.Add(cbCategory);
            Margin = new Padding(3, 4, 3, 4);
            Name = "ReportingForm";
            Text = "Exam Reporting";
            Load += ReportingForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvExamResults).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        private System.Windows.Forms.ComboBox cbCategory;
        private System.Windows.Forms.Button btnSortHigh;
        private System.Windows.Forms.Button btnSortLow;
        private System.Windows.Forms.DataGridView dgvExamResults;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Label label1;
    }
}