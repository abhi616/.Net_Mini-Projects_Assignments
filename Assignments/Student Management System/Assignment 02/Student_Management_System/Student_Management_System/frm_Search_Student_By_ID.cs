using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Student_Management_System
{
    public partial class frm_Search_Student_By_ID : Form
    {
        public frm_Search_Student_By_ID()
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
            tb_ID.Clear();
            tb_Name.Clear();
            tb_MobNo.Clear();
            cmb_Course.Text = "";
            cmb_City.Text = "";

            tb_ID.Focus();
        }

        private void btn_View_Student_By_Course_Click(object sender, EventArgs e)
        {
            frm_View_Student_By_Course Obj = new frm_View_Student_By_Course();
            Obj.Show();
            this.Hide();
        }

        private void btn_View_All_Details_Click(object sender, EventArgs e)
        {
            frm_View_All_Details Obj = new frm_View_All_Details();
            Obj.Show();
            this.Hide();
        }

        private void btn_Log_Out_Click(object sender, EventArgs e)
        {
            frm_login Obj = new frm_login();
            Obj.Show();
            this.Hide();
        }

        private void btn_Serach_Click(object sender, EventArgs e)
        {
            if (tb_ID.Text != "")
            {
                Con_Open();

                SqlCommand Cmd = new SqlCommand();

                Cmd.Connection = Con;

                Cmd.CommandText = "Select * from Student_Details where ID = " + tb_ID.Text + " ";

                var Obj = Cmd.ExecuteReader();

                if (Obj.Read())
                {
                    tb_Name.Text = Obj.GetString(Obj.GetOrdinal("Name"));
                    tb_MobNo.Text = (Obj["Mob_No"].ToString());
                    cmb_Course.Text = Obj.GetString(Obj.GetOrdinal("Course"));
                    cmb_City.Text = Obj.GetString(Obj.GetOrdinal("City"));
                }

                else
                {
                    MessageBox.Show("No Such Record Found","ERROR",MessageBoxButtons.OK,MessageBoxIcon.Error);

                    Clear_Controls();
                }

                Con_Close();
             }
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            Clear_Controls();
        }
    }
}
