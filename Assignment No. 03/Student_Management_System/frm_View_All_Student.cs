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
    public partial class frm_View_All_Student : Form
    {
        public frm_View_All_Student()
        {
            InitializeComponent();
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            frm_MDI_Student_Management_System Obj = new frm_MDI_Student_Management_System();

            Obj.Show();
            this.Hide();
        }

        private void frm_View_All_Student_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'student_Management_System_DBDataSet2.Student_Details' table. You can move, or remove it, as needed.
            this.student_DetailsTableAdapter2.Fill(this.student_Management_System_DBDataSet2.Student_Details);
            // TODO: This line of code loads data into the 'student_Management_System_DBDataSet1.Student_Details' table. You can move, or remove it, as needed.
            this.student_DetailsTableAdapter1.Fill(this.student_Management_System_DBDataSet1.Student_Details);
            // TODO: This line of code loads data into the 'student_Management_System_DBDataSet.Student_Details' table. You can move, or remove it, as needed.
            this.student_DetailsTableAdapter.Fill(this.student_Management_System_DBDataSet.Student_Details);

        }

        private void btn_Log_Out_Click(object sender, EventArgs e)
        {
            frm_Login Obj = new frm_Login();

            Obj.Show();
            this.Hide();
        }
    }
}
