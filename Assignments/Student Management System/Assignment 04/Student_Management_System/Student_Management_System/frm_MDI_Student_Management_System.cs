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
            frm_Add_New_Student ANS = new frm_Add_New_Student();
            ANS.MdiParent = this;
            ANS.WindowState = FormWindowState.Maximized;
            ANS.Show();
            
        }

        private void updateStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Update_Student US = new frm_Update_Student();
            US.MdiParent = this;
            US.WindowState = FormWindowState.Maximized;
            US.Show();
        }

        private void searchStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Search_Student SS = new frm_Search_Student();
            SS.MdiParent = this;
            SS.WindowState = FormWindowState.Maximized;
            SS.Show();
           
        }

        private void viewAllStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_View_All_Student VAS = new frm_View_All_Student();
            VAS.MdiParent = this;
            VAS.WindowState = FormWindowState.Maximized;
            VAS.Show();
        }

        private void searchStudentByCourseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_View_Student_By_Course VSBC = new frm_View_Student_By_Course();
            VSBC.MdiParent = this;
            VSBC.WindowState = FormWindowState.Maximized;
            VSBC.Show();
        }

        private void codeBlockToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("codeblock.exe");
        }

        private void notePadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("notepad++.exe");
        }

        
    }
}
