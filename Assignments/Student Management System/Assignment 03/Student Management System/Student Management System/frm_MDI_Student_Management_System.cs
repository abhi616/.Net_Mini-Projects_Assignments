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

        private void addNewStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Add_New_Student Obj = new frm_Add_New_Student();

            Obj.MdiParent = this;
            Obj.WindowState = FormWindowState.Maximized;
            Obj.Show();
        }

        private void searchStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Search_Student Obj = new frm_Search_Student();

            Obj.MdiParent = this;
            Obj.WindowState = FormWindowState.Maximized;
            Obj.Show();
        }

        private void updateStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Update_Student Obj = new frm_Update_Student();

            Obj.MdiParent = this;
            Obj.WindowState = FormWindowState.Maximized;
            Obj.Show();
        }

        private void viewAllDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_View_All_Details Obj = new frm_View_All_Details();

            Obj.MdiParent = this;
            Obj.WindowState = FormWindowState.Maximized;
            Obj.Show();
        }

        private void viewStudentByCourseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_View_Student_By_Course Obj = new frm_View_Student_By_Course();

            Obj.MdiParent = this;
            Obj.WindowState = FormWindowState.Maximized;
            Obj.Show();
        }

        private void btn_Log_Out_Click(object sender, EventArgs e)
        {
            frm_login L = new frm_login();

            L.Show();
            this.Hide();
        }

        private void frm_MDI_Student_Management_System_Load(object sender, EventArgs e)
        {
            lbl_Head.Text = lbl_Head.Text + " , " + Global_Vars.User;
            lbl_Head.Visible = true;                                                                                                                                                                                                                                                                                                                                                                                                            
        }


    }
}
