using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Student_Management_System_V02
{
    public partial class frm_View_All_Students : Form
    {
        public frm_View_All_Students()
        {
            InitializeComponent();
        }

        private void frm_View_All_Students_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'student_Management_System_DBDataSet.Student_Details' table. You can move, or remove it, as needed.
            this.student_DetailsTableAdapter.Fill(this.student_Management_System_DBDataSet.Student_Details);

        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            frm_Add_New_Student Obj = new frm_Add_New_Student();

            Obj.Show();
            this.Hide();
        }

        private void btn_Log_Out_Click(object sender, EventArgs e)
        {
            frm_login Obj = new frm_login();

            Obj.Show();
            this.Hide();
        }

        private void btn_Search_Student_Click(object sender, EventArgs e)
        {
            frm_Search_Student Obj = new frm_Search_Student();

            Obj.Show();
            this.Hide();
        }

       
    }
}
