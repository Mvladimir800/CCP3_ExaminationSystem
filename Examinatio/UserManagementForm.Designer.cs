namespace ExaminationSystem
{
    partial class UserManagementForm
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
            dataGridView1 = new DataGridView();
            button1 = new Button();
            button2 = new Button();
            button8 = new Button();
            button7 = new Button();
            button6 = new Button();
            button3 = new Button();
            panelTop = new Panel();
            panelData = new Panel();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panelTop.SuspendLayout();
            panelData.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Margin = new Padding(3, 4, 3, 4);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 24;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(776, 433);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // button1
            // 
            button1.Location = new Point(12, 15);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(100, 44);
            button1.TabIndex = 1;
            button1.Text = "Students";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(118, 15);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(100, 44);
            button2.TabIndex = 2;
            button2.Text = "Faculty";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button8
            // 
            button8.Location = new Point(12, 66);
            button8.Margin = new Padding(3, 4, 3, 4);
            button8.Name = "button8";
            button8.Size = new Size(100, 44);
            button8.TabIndex = 3;
            button8.Text = "Add User";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // button7
            // 
            button7.Location = new Point(118, 66);
            button7.Margin = new Padding(3, 4, 3, 4);
            button7.Name = "button7";
            button7.Size = new Size(100, 44);
            button7.TabIndex = 4;
            button7.Text = "Edit User";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // button6
            // 
            button6.Location = new Point(224, 66);
            button6.Margin = new Padding(3, 4, 3, 4);
            button6.Name = "button6";
            button6.Size = new Size(100, 44);
            button6.TabIndex = 5;
            button6.Text = "Delete User";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button3
            // 
            button3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button3.Location = new Point(664, 66);
            button3.Margin = new Padding(3, 4, 3, 4);
            button3.Name = "button3";
            button3.Size = new Size(100, 44);
            button3.TabIndex = 6;
            button3.Text = "Close";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // panelTop
            // 
            panelTop.Controls.Add(button1);
            panelTop.Controls.Add(button3);
            panelTop.Controls.Add(button2);
            panelTop.Controls.Add(button6);
            panelTop.Controls.Add(button8);
            panelTop.Controls.Add(button7);
            panelTop.Dock = DockStyle.Top;
            panelTop.Location = new Point(12, 15);
            panelTop.Margin = new Padding(3, 4, 3, 4);
            panelTop.Name = "panelTop";
            panelTop.Size = new Size(776, 125);
            panelTop.TabIndex = 7;
            panelTop.Paint += panelTop_Paint;
            // 
            // panelData
            // 
            panelData.Controls.Add(dataGridView1);
            panelData.Dock = DockStyle.Fill;
            panelData.Location = new Point(12, 140);
            panelData.Margin = new Padding(3, 4, 3, 4);
            panelData.Name = "panelData";
            panelData.Size = new Size(776, 433);
            panelData.TabIndex = 8;
            // 
            // UserManagementForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 588);
            Controls.Add(panelData);
            Controls.Add(panelTop);
            Margin = new Padding(3, 4, 3, 4);
            MinimumSize = new Size(818, 635);
            Name = "UserManagementForm";
            Padding = new Padding(12, 15, 12, 15);
            Text = "User Management";
            Load += UserManagementForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panelTop.ResumeLayout(false);
            panelData.ResumeLayout(false);
            ResumeLayout(false);

        }


        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Panel panelData;
    }
}