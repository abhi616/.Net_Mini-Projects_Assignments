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
    public partial class frm_Add_New_Student : Form
    {
        public frm_Add_New_Student()
        {
            InitializeComponent();
        }

        private void btn_Log_Out_Click(object sender, EventArgs e)
        {
            frm_login Obj = new frm_login();

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

        void Clear_Controls()
        {
            tb_Roll_No.Clear();
            tb_Name.Clear();
            dtp_DOB.Text = "";
            cmb_Course.Text = "";
            cmb_City.Text = "";

            tb_Roll_No.Focus();
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {

            if (tb_Roll_No.Text != "" && tb_Name.Text != "" && dtp_DOB.Text != "" && cmb_City.Text != "" && cmb_Course.Text != "")
            {
                Con_Open();

                SqlCommand Cmd = new SqlCommand();

                Cmd.Connection = Con;

                Cmd.CommandText = "Insert Into Student_Details(Roll_No,Name,DOB,Course,City) Values (@S_RNO,@S_Name,@S_DOB,@S_Course,@S_City)";

                Cmd.Parameters.Add("S_RNo",SqlDbType.Int).Value = tb_Roll_No.Text;
                Cmd.Parameters.Add("S_Name",SqlDbType.VarChar).Value = tb_Name.Text;
                Cmd.Parameters.Add("S_DOB",SqlDbType.Date).Value = dtp_DOB.Text;
                Cmd.Parameters.Add("S_Course",SqlDbType.NVarChar).Value = cmb_Course.Text;
                Cmd.Parameters.Add("S_City",SqlDbType.VarChar).Value = cmb_City.Text;

                Cmd.ExecuteNonQuery();

                MessageBox.Show("Record Saved Successfully","Success",MessageBoxButtons.OK,MessageBoxIcon.Information);

                Clear_Controls();

            }

            else
            {
                MessageBox.Show("Fill The Information","Incomplete",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }

            Con_Close();
        }

        private void btn_View_All_Student_Click(object sender, EventArgs e)
        {
            frm_View_All_Students Obj = new frm_View_All_Students();

            Obj.Show();
            this.Hide();
        }

        
    }
}
