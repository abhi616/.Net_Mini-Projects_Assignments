using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Student_Management_System_V02
{
    public partial class frm_Search_Student : Form
    {
        public frm_Search_Student()
        {
            InitializeComponent();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=Student_Management_System_DB;Integrated Security=True");
            

        void Con_Open()
        {
            if (Con.State == ConnectionState.Closed)
            {
                Con.Open();
            }
        }

        void Con_Close()
        {
            if (Con.State == ConnectionState.Open)
            {
                Con.Close();
            }
        }


        void Clear_Controls()
        {
            tb_Roll_No.Clear();
            tb_Name.Clear();
            dtp_DOB.Text = "";
            cmb_Course.Text = "";
            cmb_City.Text = "";

            tb_Roll_No.Focus();
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            if (tb_Roll_No.Text != "")
            {
                Con_Open();

                SqlCommand Cmd = new SqlCommand();

                Cmd.Connection = Con;

                Cmd.CommandText = "Select * from Student_Details where Roll_No = " + tb_Roll_No.Text + "";

                var Obj = Cmd.ExecuteReader();

                if (Obj.Read())
                {
                    tb_Name.Text = Obj.GetString(Obj.GetOrdinal("Name"));
                    dtp_DOB.Text = (Obj["DOB"].ToString());
                    cmb_Course.Text = Obj.GetString(Obj.GetOrdinal("Course"));
                    cmb_City.Text = Obj.GetString(Obj.GetOrdinal("City"));

                }

                else
                {
                    MessageBox.Show("No Such Record Found", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    Clear_Controls();
                }

                Con_Close();
            }

        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            Clear_Controls();
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

        private void btn_Search_Student_By_Course_Click(object sender, EventArgs e)
        {
            frm_Search_Student_By_Course Obj = new frm_Search_Student_By_Course();

            Obj.Show();
            this.Hide();
        }
    }
}
