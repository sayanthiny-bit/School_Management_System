namespace School_Management_System
{
    partial class MainForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.addTeacherBtn = new System.Windows.Forms.Button();
            this.addStudentBtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.addTeacherForm2 = new School_Management_System.AddTeacherForm();
            this.addStudentFrom2 = new School_Management_System.AddStudentFrom();
            this.dashbordForm2 = new School_Management_System.DashbordForm();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1387, 31);
            this.panel1.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label3.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(1352, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(22, 21);
            this.label3.TabIndex = 1;
            this.label3.Text = "X";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(328, 22);
            this.label2.TabIndex = 0;
            this.label2.Text = "School Management System| Main Form";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(47)))), ((int)(((byte)(122)))));
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.button4);
            this.panel2.Controls.Add(this.addTeacherBtn);
            this.panel2.Controls.Add(this.addStudentBtn);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 31);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(355, 805);
            this.panel2.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(65, 761);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 18);
            this.label4.TabIndex = 2;
            this.label4.Text = "Logout";
            // 
            // button4
            // 
            this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Image = global::School_Management_System.Properties.Resources.icons8_logout_rounded_up_filled_35px;
            this.button4.Location = new System.Drawing.Point(12, 750);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(47, 43);
            this.button4.TabIndex = 5;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // addTeacherBtn
            // 
            this.addTeacherBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addTeacherBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addTeacherBtn.ForeColor = System.Drawing.Color.White;
            this.addTeacherBtn.Image = global::School_Management_System.Properties.Resources.icons8_training_35px;
            this.addTeacherBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addTeacherBtn.Location = new System.Drawing.Point(88, 378);
            this.addTeacherBtn.Name = "addTeacherBtn";
            this.addTeacherBtn.Size = new System.Drawing.Size(200, 40);
            this.addTeacherBtn.TabIndex = 4;
            this.addTeacherBtn.Text = "Add Teacher";
            this.addTeacherBtn.UseVisualStyleBackColor = true;
            this.addTeacherBtn.Click += new System.EventHandler(this.button3_Click);
            // 
            // addStudentBtn
            // 
            this.addStudentBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addStudentBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addStudentBtn.ForeColor = System.Drawing.Color.White;
            this.addStudentBtn.Image = global::School_Management_System.Properties.Resources.icons8_student_35px;
            this.addStudentBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addStudentBtn.Location = new System.Drawing.Point(88, 307);
            this.addStudentBtn.Name = "addStudentBtn";
            this.addStudentBtn.Size = new System.Drawing.Size(200, 40);
            this.addStudentBtn.TabIndex = 3;
            this.addStudentBtn.Text = "Add Student";
            this.addStudentBtn.UseVisualStyleBackColor = true;
            this.addStudentBtn.Click += new System.EventHandler(this.addStudentBtn_Click);
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Image = global::School_Management_System.Properties.Resources.icons8_dashboard_35px_1;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(88, 239);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(200, 40);
            this.button1.TabIndex = 2;
            this.button1.Text = "Dasbord";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.SeaShell;
            this.label1.Location = new System.Drawing.Point(102, 145);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Welcome,Admin";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::School_Management_System.Properties.Resources.icon_School;
            this.pictureBox1.Location = new System.Drawing.Point(141, 50);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(80, 80);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dashbordForm2);
            this.panel3.Controls.Add(this.addStudentFrom2);
            this.panel3.Controls.Add(this.addTeacherForm2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(355, 31);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1032, 805);
            this.panel3.TabIndex = 2;
            // 
            // addTeacherForm2
            // 
            this.addTeacherForm2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addTeacherForm2.Location = new System.Drawing.Point(0, 0);
            this.addTeacherForm2.Name = "addTeacherForm2";
            this.addTeacherForm2.Size = new System.Drawing.Size(1032, 805);
            this.addTeacherForm2.TabIndex = 0;
            // 
            // addStudentFrom2
            // 
            this.addStudentFrom2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addStudentFrom2.Location = new System.Drawing.Point(0, 0);
            this.addStudentFrom2.Name = "addStudentFrom2";
            this.addStudentFrom2.Size = new System.Drawing.Size(1032, 805);
            this.addStudentFrom2.TabIndex = 1;
            // 
            // dashbordForm2
            // 
            this.dashbordForm2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dashbordForm2.Location = new System.Drawing.Point(0, 0);
            this.dashbordForm2.Name = "dashbordForm2";
            this.dashbordForm2.Size = new System.Drawing.Size(1032, 805);
            this.dashbordForm2.TabIndex = 2;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1387, 836);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button addTeacherBtn;
        private System.Windows.Forms.Button addStudentBtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel3;
        private AddTeacherForm addTeacherForm1;
        private AddStudentFrom addStudentFrom1;
        private DashbordForm dashbordForm1;
        private AddTeacherForm addTeacherForm2;
        private AddStudentFrom addStudentFrom2;
        private DashbordForm dashbordForm2;
    }
}