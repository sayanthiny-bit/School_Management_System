using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace School_Management_System
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DialogResult check = MessageBox.Show("Are you sure you want to logout?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (check == DialogResult.Yes)
            {
                Loginform lForm = new Loginform();
                lForm.Show();
                this.Hide();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            dashbordForm2.Visible = false;
            addStudentFrom2.Visible = false;
            addTeacherForm2.Visible = true;
        }

        //private void button1_Click(object sender, EventArgs e)
        //{
            DashbordForm dForm = new DashbordForm();

        private void button1_Click(object sender, EventArgs e)
        {
            dashbordForm2.Visible = true;
            addStudentFrom2.Visible = false;
            addTeacherForm2.Visible = false;

        }

        private void addStudentBtn_Click(object sender, EventArgs e)
        {
            dashbordForm2.Visible = false;
            addStudentFrom2.Visible = true;
            addTeacherForm2.Visible = false;

        }
        // dForm.displayEnrolledStudentToday();
        //dForm.displayTotalGS();
        // dForm.displayTotalTT();
        //dForm.displayTotalES();

        //DashbordForm.Visible = true;
        //DashbordForm.Update();
        //addStudentForm1.Visible = false;
        //addTeachersForm1.Visible = false;
        //}
    }
}
