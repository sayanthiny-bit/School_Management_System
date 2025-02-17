namespace School_Management_System
{
    partial class AddStudentFrom
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel2 = new System.Windows.Forms.Panel();
            this.student_status = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.student_deleteBtn = new System.Windows.Forms.Button();
            this.student_ClearBtn = new System.Windows.Forms.Button();
            this.student_updateBtn = new System.Windows.Forms.Button();
            this.student_addBtn = new System.Windows.Forms.Button();
            this.student_importBtn = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.student_image = new System.Windows.Forms.PictureBox();
            this.student_section = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.student_grade = new System.Windows.Forms.ComboBox();
            this.student_address = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.student_gender = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.student_name = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.student_id = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.student_studentData = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.student_image)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.student_studentData)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.student_status);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.student_deleteBtn);
            this.panel2.Controls.Add(this.student_ClearBtn);
            this.panel2.Controls.Add(this.student_updateBtn);
            this.panel2.Controls.Add(this.student_addBtn);
            this.panel2.Controls.Add(this.student_importBtn);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.student_section);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.student_grade);
            this.panel2.Controls.Add(this.student_address);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.student_gender);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.student_name);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.student_id);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(12, 439);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1008, 354);
            this.panel2.TabIndex = 3;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // student_status
            // 
            this.student_status.FormattingEnabled = true;
            this.student_status.Items.AddRange(new object[] {
            "Enrolled",
            "Pending",
            "Graduated"});
            this.student_status.Location = new System.Drawing.Point(652, 106);
            this.student_status.Name = "student_status";
            this.student_status.Size = new System.Drawing.Size(151, 24);
            this.student_status.TabIndex = 19;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(594, 106);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 16);
            this.label8.TabIndex = 18;
            this.label8.Text = "Status";
            // 
            // student_deleteBtn
            // 
            this.student_deleteBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(47)))), ((int)(((byte)(122)))));
            this.student_deleteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.student_deleteBtn.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.student_deleteBtn.ForeColor = System.Drawing.Color.White;
            this.student_deleteBtn.Location = new System.Drawing.Point(609, 278);
            this.student_deleteBtn.Name = "student_deleteBtn";
            this.student_deleteBtn.Size = new System.Drawing.Size(98, 53);
            this.student_deleteBtn.TabIndex = 17;
            this.student_deleteBtn.Text = "Delete";
            this.student_deleteBtn.UseVisualStyleBackColor = false;
            this.student_deleteBtn.Click += new System.EventHandler(this.student_deleteBtn_Click);
            // 
            // student_ClearBtn
            // 
            this.student_ClearBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(47)))), ((int)(((byte)(122)))));
            this.student_ClearBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.student_ClearBtn.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.student_ClearBtn.ForeColor = System.Drawing.Color.White;
            this.student_ClearBtn.Location = new System.Drawing.Point(450, 278);
            this.student_ClearBtn.Name = "student_ClearBtn";
            this.student_ClearBtn.Size = new System.Drawing.Size(98, 53);
            this.student_ClearBtn.TabIndex = 16;
            this.student_ClearBtn.Text = "Clear";
            this.student_ClearBtn.UseVisualStyleBackColor = false;
            this.student_ClearBtn.Click += new System.EventHandler(this.student_ClearBtn_Click);
            // 
            // student_updateBtn
            // 
            this.student_updateBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(47)))), ((int)(((byte)(122)))));
            this.student_updateBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.student_updateBtn.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.student_updateBtn.ForeColor = System.Drawing.Color.White;
            this.student_updateBtn.Location = new System.Drawing.Point(299, 278);
            this.student_updateBtn.Name = "student_updateBtn";
            this.student_updateBtn.Size = new System.Drawing.Size(98, 53);
            this.student_updateBtn.TabIndex = 15;
            this.student_updateBtn.Text = "Update";
            this.student_updateBtn.UseVisualStyleBackColor = false;
            this.student_updateBtn.Click += new System.EventHandler(this.student_updateBtn_Click);
            // 
            // student_addBtn
            // 
            this.student_addBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(47)))), ((int)(((byte)(122)))));
            this.student_addBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.student_addBtn.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.student_addBtn.ForeColor = System.Drawing.Color.White;
            this.student_addBtn.Location = new System.Drawing.Point(146, 278);
            this.student_addBtn.Name = "student_addBtn";
            this.student_addBtn.Size = new System.Drawing.Size(98, 53);
            this.student_addBtn.TabIndex = 14;
            this.student_addBtn.Text = "Add";
            this.student_addBtn.UseVisualStyleBackColor = false;
            this.student_addBtn.Click += new System.EventHandler(this.student_addBtn_Click);
            // 
            // student_importBtn
            // 
            this.student_importBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(47)))), ((int)(((byte)(122)))));
            this.student_importBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.student_importBtn.ForeColor = System.Drawing.Color.White;
            this.student_importBtn.Location = new System.Drawing.Point(854, 164);
            this.student_importBtn.Name = "student_importBtn";
            this.student_importBtn.Size = new System.Drawing.Size(75, 38);
            this.student_importBtn.TabIndex = 13;
            this.student_importBtn.Text = "Import";
            this.student_importBtn.UseVisualStyleBackColor = false;
            this.student_importBtn.Click += new System.EventHandler(this.student_importBtn_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.LightGray;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.student_image);
            this.panel3.Location = new System.Drawing.Point(854, 75);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(80, 85);
            this.panel3.TabIndex = 12;
            // 
            // student_image
            // 
            this.student_image.Location = new System.Drawing.Point(-1, -1);
            this.student_image.Name = "student_image";
            this.student_image.Size = new System.Drawing.Size(80, 85);
            this.student_image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.student_image.TabIndex = 0;
            this.student_image.TabStop = false;
            // 
            // student_section
            // 
            this.student_section.FormattingEnabled = true;
            this.student_section.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D",
            "E"});
            this.student_section.Location = new System.Drawing.Point(652, 34);
            this.student_section.Name = "student_section";
            this.student_section.Size = new System.Drawing.Size(151, 24);
            this.student_section.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(594, 37);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 16);
            this.label7.TabIndex = 10;
            this.label7.Text = "Section";
            // 
            // student_grade
            // 
            this.student_grade.FormattingEnabled = true;
            this.student_grade.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "O/L",
            "A/L"});
            this.student_grade.Location = new System.Drawing.Point(397, 140);
            this.student_grade.Name = "student_grade";
            this.student_grade.Size = new System.Drawing.Size(151, 24);
            this.student_grade.TabIndex = 9;
            // 
            // student_address
            // 
            this.student_address.Location = new System.Drawing.Point(397, 34);
            this.student_address.Multiline = true;
            this.student_address.Name = "student_address";
            this.student_address.Size = new System.Drawing.Size(151, 75);
            this.student_address.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(352, 143);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 16);
            this.label6.TabIndex = 7;
            this.label6.Text = "Grade";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(339, 34);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 16);
            this.label5.TabIndex = 6;
            this.label5.Text = "Address";
            // 
            // student_gender
            // 
            this.student_gender.FormattingEnabled = true;
            this.student_gender.Items.AddRange(new object[] {
            "Male",
            "Female",
            "other"});
            this.student_gender.Location = new System.Drawing.Point(92, 166);
            this.student_gender.Name = "student_gender";
            this.student_gender.Size = new System.Drawing.Size(121, 24);
            this.student_gender.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 175);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Gender";
            // 
            // student_name
            // 
            this.student_name.Location = new System.Drawing.Point(92, 103);
            this.student_name.Multiline = true;
            this.student_name.Name = "student_name";
            this.student_name.Size = new System.Drawing.Size(181, 34);
            this.student_name.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Full Name";
            // 
            // student_id
            // 
            this.student_id.Location = new System.Drawing.Point(92, 31);
            this.student_id.Multiline = true;
            this.student_id.Name = "student_id";
            this.student_id.Size = new System.Drawing.Size(135, 34);
            this.student_id.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Student ID:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.student_studentData);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1008, 404);
            this.panel1.TabIndex = 2;
            // 
            // student_studentData
            // 
            this.student_studentData.AllowUserToAddRows = false;
            this.student_studentData.AllowUserToDeleteRows = false;
            this.student_studentData.BackgroundColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(47)))), ((int)(((byte)(122)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.student_studentData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.student_studentData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.student_studentData.EnableHeadersVisualStyles = false;
            this.student_studentData.Location = new System.Drawing.Point(17, 25);
            this.student_studentData.Name = "student_studentData";
            this.student_studentData.ReadOnly = true;
            this.student_studentData.RowHeadersVisible = false;
            this.student_studentData.RowHeadersWidth = 51;
            this.student_studentData.RowTemplate.Height = 24;
            this.student_studentData.Size = new System.Drawing.Size(973, 358);
            this.student_studentData.TabIndex = 1;
            this.student_studentData.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.student_studentData_CellClick);
            this.student_studentData.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.student_GridData_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Student\'s Data";
            // 
            // AddStudentFrom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "AddStudentFrom";
            this.Size = new System.Drawing.Size(1032, 805);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.student_image)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.student_studentData)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button student_deleteBtn;
        private System.Windows.Forms.Button student_ClearBtn;
        private System.Windows.Forms.Button student_updateBtn;
        private System.Windows.Forms.Button student_addBtn;
        private System.Windows.Forms.Button student_importBtn;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ComboBox student_section;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox student_grade;
        private System.Windows.Forms.TextBox student_address;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox student_gender;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox student_name;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox student_id;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView student_studentData;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox student_image;
        private System.Windows.Forms.ComboBox student_status;
        private System.Windows.Forms.Label label8;
    }
}
