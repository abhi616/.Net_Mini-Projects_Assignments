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
    public partial class frm_Update_Student_Detail : Form
    {
        public frm_Update_Student_Detail()
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
            tb_Rno.Clear();
            tb_Name.Clear();
            dtp_DOB.Text = "";
            cmb_Course.Text = "";
            cmb_City.Text = "";        
            tb_Rno.Enabled = true;
            tb_Rno.Focus();
            tb_Name.Enabled = false;
            dtp_DOB.Enabled = false;
            cmb_Course.Enabled = false;
            cmb_City.Enabled = false;
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

        private void btn_Search_Click(object sender, EventArgs e)
        {
            if (tb_Rno.Text != "")
            {
                Con_Open();

                SqlCommand Cmd = new SqlCommand();

                Cmd.Connection = Con;

                Cmd.CommandText = "Select * From Student_Details Where Roll_No = " + tb_Rno.Text + " ";

                var Obj = Cmd.ExecuteReader();

                if (Obj.Read())
                {
                    tb_Rno.Enabled = false;
                    tb_Name.Enabled = true;
                    dtp_DOB.Enabled = true;
                    cmb_Course.Enabled = true;
                    cmb_City.Enabled = true;
                    tb_Name.Text = Obj.GetString(Obj.GetOrdinal("Name"));
                    dtp_DOB.Text = (Obj["DOB"].ToString());
                    cmb_Course.Text = Obj.GetString(Obj.GetOrdinal("Course"));
                    cmb_City.Text = Obj.GetString(Obj.GetOrdinal("City"));

                }

                else
                {             
                    MessageBox.Show("No Such Record Found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    tb_Rno.Clear();
                    tb_Rno.Enabled = true;
                    tb_Rno.Focus();
                }

                Con_Close();

            }
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {

            if (tb_Rno.Text != "" && tb_Name.Text != "" && dtp_DOB.Text != "" && cmb_Course.Text != "" && cmb_City.Text != "")
            {
                Con_Open();

                SqlCommand Cmd = new SqlCommand();

                Cmd.Connection = Con;

                Cmd.CommandText = "Update Student_Details Set Name = @S_Name, DOB = @S_DOB , Course = @S_Course , City = @S_City Where Roll_No = " + tb_Rno.Text + " ";

                Cmd.Parameters.Add("S_Name", SqlDbType.VarChar).Value = tb_Name.Text;
                Cmd.Parameters.Add("S_DOB", SqlDbType.Date).Value = dtp_DOB.Text;
                Cmd.Parameters.Add("S_Course", SqlDbType.NVarChar).Value = cmb_Course.Text;
                Cmd.Parameters.Add("S_City", SqlDbType.VarChar).Value = cmb_City.Text;

                Cmd.ExecuteNonQuery();

                MessageBox.Show("Record Updated Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Clear_Controls();             

            }

            else
            {
                MessageBox.Show("Incomplete Information", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tb_Rno.Clear();
                tb_Rno.Focus();
            }

            Con_Close();
        }

        private void btn_View_All_Students_Click(object sender, EventArgs e)
        {
            frm_View_All_Students Obj = new frm_View_All_Students();

            Obj.Show();
            this.Hide();
        }

        
    }
}
