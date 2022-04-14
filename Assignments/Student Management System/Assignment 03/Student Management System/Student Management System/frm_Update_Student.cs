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
    public partial class frm_Update_Student : Form
    {
        public frm_Update_Student()
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
            tb_Mob_No.Clear();
            tb_Name.Clear();
            cmb_Course.Text = "";
            cmb_City.Text = "";

            tb_ID.Focus();
        }


        private void btn_Search_Click(object sender, EventArgs e)
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
                    tb_Mob_No.Text = (Obj["Mob_No"].ToString());
                    cmb_Course.Text = Obj.GetString(Obj.GetOrdinal("Course"));
                    cmb_City.Text = Obj.GetString(Obj.GetOrdinal("City"));
                }
                else
                {
                    MessageBox.Show("No Such Record Found","Not Found",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                    tb_ID.Clear();
                    tb_ID.Focus();
                }

                Con_Close();
            }
        }



        private void btn_Update_Click(object sender, EventArgs e)
        {
            if (tb_ID.Text != "" && tb_Mob_No.Text != "" && tb_Name.Text != "" && cmb_Course.Text != "" && cmb_City.Text != "")
            {
                Con_Open();

                SqlCommand Cmd = new SqlCommand();

                Cmd.Connection = Con;

                Cmd.CommandText = "Update Student_Details set Name = @Name , Mob_No = @Mob_No , Course = @Course , City = @City where ID =  " + tb_ID.Text + " ";

                Cmd.Parameters.Add("Name", SqlDbType.VarChar).Value = tb_Name.Text;
                Cmd.Parameters.Add("Mob_No", SqlDbType.Decimal).Value = tb_Mob_No.Text;
                Cmd.Parameters.Add("Course", SqlDbType.NVarChar).Value = cmb_Course.Text;
                Cmd.Parameters.Add("City", SqlDbType.NVarChar).Value = cmb_City.Text;

                Cmd.ExecuteNonQuery();

                MessageBox.Show("Information Updated Successfully", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Con_Close();

                Clear_Controls();

            }
            else
            {
                MessageBox.Show("Incomplete Information","Incomplete",MessageBoxButtons.OK,MessageBoxIcon.Question);
                Clear_Controls();
            }
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            Clear_Controls();
        }
    }
}
