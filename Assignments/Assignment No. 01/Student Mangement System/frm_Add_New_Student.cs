using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Student_Mangement_System
{
    public partial class frm_Add_New_Student : Form
    {
        public frm_Add_New_Student()
        {
            InitializeComponent();
        }

        private void btn_Log_Out_Click(object sender, EventArgs e)
        {
            frm_Login Obj = new frm_Login();

            Obj.Show();
            this.Hide();
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


        private void btn_View_All_Student_Click(object sender, EventArgs e)
        {
            frm_View_All_Students Obj = new frm_View_All_Students();

            Obj.Show();

            this.Hide();
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            Con_Open();
            if (tb_Roll_No.Text != "" && tb_Name.Text != "" && dtp_DOB.Text != "" && cmb_Course.Text != "" && cmb_City.Text != "")
            {
                

                SqlCommand Cmd = new SqlCommand();
                Cmd.Connection = Con;
                Cmd.CommandText = "Insert Into Student_Details(Roll_No,Name,DOB,Course,City) Values (@R_No,@S_Name,@S_DOB,@S_Course,@S_City)";
                Cmd.Parameters.Add("R_No", SqlDbType.Int).Value = tb_Roll_No.Text;
                Cmd.Parameters.Add("S_Name", SqlDbType.VarChar).Value = tb_Name.Text;
                Cmd.Parameters.Add("S_DOB", SqlDbType.Date).Value = dtp_DOB.Text;
                Cmd.Parameters.Add("S_Course", SqlDbType.NVarChar).Value = cmb_Course.Text;
                Cmd.Parameters.Add("S_City", SqlDbType.VarChar).Value = cmb_City.Text;

                Cmd.ExecuteNonQuery();

                MessageBox.Show("Record Saved Successfully...!","Success",MessageBoxButtons.OK);

            }

            else
            {
                MessageBox.Show("Incomplete Info","Warning",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }

            tb_Roll_No.Clear();
            tb_Name.Clear();
            dtp_DOB.Text = "";
            cmb_Course.Text = "";
            cmb_City.Text = "";

            Con_Close();
        }   
    }
}
