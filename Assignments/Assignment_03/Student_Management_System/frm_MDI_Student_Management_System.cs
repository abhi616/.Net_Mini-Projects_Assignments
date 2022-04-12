using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Student_Management_System
{
    public partial class frm_MDI_Student_Management_System : Form
    {
        private int childFormNumber = 0;

        public frm_MDI_Student_Management_System()
        {
            InitializeComponent();
        }

        private void MDI_Student_Management_System_Load(object sender, EventArgs e)
        {
            lbl_Head.Text = "Welcome" + " , " +Global_Vars.Uname;
            lbl_Head.Visible = true;
        }

        private void addNewStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Add_New_Student Obj = new frm_Add_New_Student();

            Obj.Show();
            this.Hide();
        }

        private void searchStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Search_Student Obj = new frm_Search_Student();

            Obj.Show();
            this.Hide();
        }

        private void viewAllStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_View_All_Student Obj = new frm_View_All_Student();

            Obj.Show();
            this.Hide();
        }

        private void updateStudentDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Update_Student_Detail Obj = new frm_Update_Student_Detail();

            Obj.Show();
            this.Hide();
        }

        private void btn_Log_Out_Click(object sender, EventArgs e)
        {
            frm_Login Obj = new frm_Login();

            Obj.Show();
            this.Hide();

        }

        private void viewStudentByCourseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_View_Student_By_Course Obj = new frm_View_Student_By_Course();

            Obj.Show();
            this.Hide();

        }

    }

}
      