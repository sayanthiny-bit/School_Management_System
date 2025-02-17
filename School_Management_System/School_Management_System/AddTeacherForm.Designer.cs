namespace School_Management_System
{
    partial class AddTeacherForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel2 = new System.Windows.Forms.Panel();
            this.teacher_deleteBtn = new System.Windows.Forms.Button();
            this.teacher_clearBtn = new System.Windows.Forms.Button();
            this.teacher_updateBtn = new System.Windows.Forms.Button();
            this.teacher_addBtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.teacher_address = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.teacher_gender = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.teacher_name = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.teacher_id = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.teacher_gridData = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.teacher_status = new System.Windows.Forms.ComboBox();
            this.teacher_image = new System.Windows.Forms.PictureBox();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.teacher_gridData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teacher_image)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.teacher_status);
            this.panel2.Controls.Add(this.teacher_deleteBtn);
            this.panel2.Controls.Add(this.teacher_clearBtn);
            this.panel2.Controls.Add(this.teacher_updateBtn);
            this.panel2.Controls.Add(this.teacher_addBtn);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.teacher_address);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.teacher_gender);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.teacher_name);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.teacher_id);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(12, 439);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1008, 354);
            this.panel2.TabIndex = 5;
            // 
            // teacher_deleteBtn
            // 
            this.teacher_deleteBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(47)))), ((int)(((byte)(122)))));
            this.teacher_deleteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.teacher_deleteBtn.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teacher_deleteBtn.ForeColor = System.Drawing.Color.White;
            this.teacher_deleteBtn.Location = new System.Drawing.Point(609, 278);
            this.teacher_deleteBtn.Name = "teacher_deleteBtn";
            this.teacher_deleteBtn.Size = new System.Drawing.Size(98, 53);
            this.teacher_deleteBtn.TabIndex = 17;
            this.teacher_deleteBtn.Text = "Delete";
            this.teacher_deleteBtn.UseVisualStyleBackColor = false;
            this.teacher_deleteBtn.Click += new System.EventHandler(this.teacher_deleteBtn_Click);
            // 
            // teacher_clearBtn
            // 
            this.teacher_clearBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(47)))), ((int)(((byte)(122)))));
            this.teacher_clearBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.teacher_clearBtn.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teacher_clearBtn.ForeColor = System.Drawing.Color.White;
            this.teacher_clearBtn.Location = new System.Drawing.Point(450, 278);
            this.teacher_clearBtn.Name = "teacher_clearBtn";
            this.teacher_clearBtn.Size = new System.Drawing.Size(98, 53);
            this.teacher_clearBtn.TabIndex = 16;
            this.teacher_clearBtn.Text = "Clear";
            this.teacher_clearBtn.UseVisualStyleBackColor = false;
            this.teacher_clearBtn.Click += new System.EventHandler(this.teacher_clearBtn_Click);
            // 
            // teacher_updateBtn
            // 
            this.teacher_updateBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(47)))), ((int)(((byte)(122)))));
            this.teacher_updateBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.teacher_updateBtn.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teacher_updateBtn.ForeColor = System.Drawing.Color.White;
            this.teacher_updateBtn.Location = new System.Drawing.Point(299, 278);
            this.teacher_updateBtn.Name = "teacher_updateBtn";
            this.teacher_updateBtn.Size = new System.Drawing.Size(98, 53);
            this.teacher_updateBtn.TabIndex = 15;
            this.teacher_updateBtn.Text = "Update";
            this.teacher_updateBtn.UseVisualStyleBackColor = false;
            this.teacher_updateBtn.Click += new System.EventHandler(this.teacher_updateBtn_Click);
            // 
            // teacher_addBtn
            // 
            this.teacher_addBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(47)))), ((int)(((byte)(122)))));
            this.teacher_addBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.teacher_addBtn.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teacher_addBtn.ForeColor = System.Drawing.Color.White;
            this.teacher_addBtn.Location = new System.Drawing.Point(146, 278);
            this.teacher_addBtn.Name = "teacher_addBtn";
            this.teacher_addBtn.Size = new System.Drawing.Size(98, 53);
            this.teacher_addBtn.TabIndex = 14;
            this.teacher_addBtn.Text = "Add";
            this.teacher_addBtn.UseVisualStyleBackColor = false;
            this.teacher_addBtn.Click += new System.EventHandler(this.teacher_addBtn_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(47)))), ((int)(((byte)(122)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(854, 166);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 38);
            this.button1.TabIndex = 13;
            this.button1.Text = "Import";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.LightGray;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.teacher_image);
            this.panel3.Location = new System.Drawing.Point(854, 75);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(80, 85);
            this.panel3.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(594, 37);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 16);
            this.label7.TabIndex = 10;
            this.label7.Text = "Status";
            // 
            // teacher_address
            // 
            this.teacher_address.Location = new System.Drawing.Point(397, 34);
            this.teacher_address.Multiline = true;
            this.teacher_address.Name = "teacher_address";
            this.teacher_address.Size = new System.Drawing.Size(151, 75);
            this.teacher_address.TabIndex = 8;
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
            // teacher_gender
            // 
            this.teacher_gender.FormattingEnabled = true;
            this.teacher_gender.Items.AddRange(new object[] {
            "Male",
            "Female",
            "other"});
            this.teacher_gender.Location = new System.Drawing.Point(92, 166);
            this.teacher_gender.Name = "teacher_gender";
            this.teacher_gender.Size = new System.Drawing.Size(121, 24);
            this.teacher_gender.TabIndex = 5;
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
            // teacher_name
            // 
            this.teacher_name.Location = new System.Drawing.Point(92, 103);
            this.teacher_name.Multiline = true;
            this.teacher_name.Name = "teacher_name";
            this.teacher_name.Size = new System.Drawing.Size(181, 34);
            this.teacher_name.TabIndex = 3;
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
            // teacher_id
            // 
            this.teacher_id.Location = new System.Drawing.Point(92, 31);
            this.teacher_id.Multiline = true;
            this.teacher_id.Name = "teacher_id";
            this.teacher_id.Size = new System.Drawing.Size(135, 34);
            this.teacher_id.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Teacher ID:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.teacher_gridData);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1008, 404);
            this.panel1.TabIndex = 4;
            // 
            // teacher_gridData
            // 
            this.teacher_gridData.AllowUserToAddRows = false;
            this.teacher_gridData.AllowUserToDeleteRows = false;
            this.teacher_gridData.AllowUserToResizeRows = false;
            this.teacher_gridData.BackgroundColor = System.Drawing.Color.LightGray;
            this.teacher_gridData.CausesValidation = false;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(47)))), ((int)(((byte)(122)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.teacher_gridData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.teacher_gridData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.teacher_gridData.EnableHeadersVisualStyles = false;
            this.teacher_gridData.Location = new System.Drawing.Point(17, 25);
            this.teacher_gridData.Name = "teacher_gridData";
            this.teacher_gridData.ReadOnly = true;
            this.teacher_gridData.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.teacher_gridData.RowHeadersVisible = false;
            this.teacher_gridData.RowHeadersWidth = 51;
            this.teacher_gridData.RowTemplate.Height = 24;
            this.teacher_gridData.Size = new System.Drawing.Size(973, 358);
            this.teacher_gridData.TabIndex = 1;
            this.teacher_gridData.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.teacher_gridData_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Teacher\'s Data";
            // 
            // teacher_status
            // 
            this.teacher_status.FormattingEnabled = true;
            this.teacher_status.Items.AddRange(new object[] {
            "Active",
            "Inactive"});
            this.teacher_status.Location = new System.Drawing.Point(644, 34);
            this.teacher_status.Name = "teacher_status";
            this.teacher_status.Size = new System.Drawing.Size(151, 24);
            this.teacher_status.TabIndex = 18;
            // 
            // teacher_image
            // 
            this.teacher_image.Location = new System.Drawing.Point(-1, -1);
            this.teacher_image.Name = "teacher_image";
            this.teacher_image.Size = new System.Drawing.Size(80, 85);
            this.teacher_image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.teacher_image.TabIndex = 0;
            this.teacher_image.TabStop = false;
            // 
            // AddTeacherForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "AddTeacherForm";
            this.Size = new System.Drawing.Size(1032, 805);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.teacher_gridData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teacher_image)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button teacher_deleteBtn;
        private System.Windows.Forms.Button teacher_clearBtn;
        private System.Windows.Forms.Button teacher_updateBtn;
        private System.Windows.Forms.Button teacher_addBtn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox teacher_address;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox teacher_gender;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox teacher_name;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox teacher_id;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView teacher_gridData;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox teacher_status;
        private System.Windows.Forms.PictureBox teacher_image;
    }
}
