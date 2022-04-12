using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Book_Management_System
{
    public partial class frm_MDI_Book_Management_System : Form
    {
        private int childFormNumber = 0;

        public frm_MDI_Book_Management_System()
        {
            InitializeComponent();
        }

        private void addNewBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Add_New_Book ANB = new frm_Add_New_Book();

            ANB.MdiParent = this;
            ANB.WindowState = FormWindowState.Maximized;
            ANB.Show();

        }

        private void viewAllBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_View_All_Book VAB = new frm_View_All_Book();

            VAB.MdiParent = this;
            VAB.WindowState = FormWindowState.Maximized;
            VAB.Show();

        }

        private void searchBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Search_Book SB = new frm_Search_Book();

            SB.MdiParent = this;
            SB.WindowState = FormWindowState.Maximized;
            SB.Show();
        }

        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Update_Book UB = new frm_Update_Book();

            UB.MdiParent = this;
            UB.WindowState = FormWindowState.Maximized;
            UB.Show();
        }

        private void viewByCategoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_View_Book_By_Category VBBC = new frm_View_Book_By_Category();

            VBBC.MdiParent = this;
            VBBC.WindowState = FormWindowState.Maximized;
            VBBC.Show();
        }


    }

}