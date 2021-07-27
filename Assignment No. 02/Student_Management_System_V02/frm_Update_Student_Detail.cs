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
    public partial class frm_Update_Student_Detail : Form
    {
        public frm_Update_Student_Detail()
        {
            InitializeComponent();
        }

        private void btn_Add_New_Student_Click(object sender, EventArgs e)
        {
            frm_Add_New_Student Obj = new frm_Add_New_Student();

            Obj.Show();
            this.Hide();
        }

        private void byn_Log_Out_Click(object sender, EventArgs e)
        {
            frm_login Obj = new frm_login();

            Obj.Show();
            this.Hide();
        }

        
    }
}
