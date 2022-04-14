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
    public partial class frm_login : Form
    {
        public frm_login()
        {
            InitializeComponent();
           
        }


        private void btn_login_Click(object sender, EventArgs e)
        {
            if (tb_Username.Text != "" && tb_Password.Text != "")
            {
                if (tb_Username.Text == "A" && tb_Password.Text == "a")
                {
                    DialogResult Res = MessageBox.Show("Login Successfull", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    if (Res == DialogResult.OK)
                    {                     
                            frm_Add_New_Student Obj = new frm_Add_New_Student();
                            Obj.Show();
                            this.Hide();
                    }

                }

                else
                {
                    MessageBox.Show("Incorrect Username Or Password", "Login Fail", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    tb_Username.Clear();
                    tb_Password.Clear();
                    tb_Username.Focus();
                }

            }

            else
            {
                MessageBox.Show("Please Enter Username & Password", "Incomplete", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                tb_Username.Clear();
                tb_Password.Clear();
                tb_Username.Focus();

            }

                 

        }

            
    }
}
