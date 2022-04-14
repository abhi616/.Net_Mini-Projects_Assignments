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
    public partial class frm_Add_New_Student : Form
    {
        public frm_Add_New_Student()
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
           // tb_ID.Text = Convert.ToString(Auto_Increment());
            tb_ID.Clear();
            tb_Name.Clear();
            tb_Mob_No.Clear();
            cmb_City.Text = "";
            cmb_Course.Text = "";

            tb_ID.Focus();
        }

        /*
        int Auto_Increment()
        {
            Con_Open();

            int Cnt = -1;

            SqlCommand Cmd = new SqlCommand();

            Cmd.Connection = Con;
            Cmd.CommandText = "Select Count(*) from Student_Details";

            Cnt = Convert.ToInt32(Cmd.ExecuteScalar());

            Cmd.Dispose();

            if (Cnt > 100)
            {
                Cmd.Connection = Con;
                Cmd.CommandText = "Slect Max(ID)From Student_Details";

                Cnt = Convert.ToInt32(Cmd.ExecuteScalar());
            }

            else
            {
                Cnt = 101;
            }

            Con_Close();

            return Cnt;
        }
        */

        private void btn_Save_Click(object sender, EventArgs e)
        {
            if (tb_ID.Text != "" && tb_Name.Text != "" && tb_Mob_No.TextLength == 10 && cmb_Course.Text != "" && cmb_City.Text != "")
            {
                Con_Open();

                SqlCommand Cmd = new SqlCommand();

                Cmd.Connection = Con;

                Cmd.CommandText = "Insert Into Student_Details(ID,Name,Mob_No,Course,City)values(@S_ID,@S_Name,@S_Mob,@S_Course,@S_City)";

                Cmd.Parameters.Add("S_ID", SqlDbType.Int).Value = tb_ID.Text;
                Cmd.Parameters.Add("S_Name", SqlDbType.VarChar).Value = tb_Name.Text;
                Cmd.Parameters.Add("S_Mob", SqlDbType.Decimal).Value = tb_Mob_No.Text;
                Cmd.Parameters.Add("S_Course", SqlDbType.NVarChar).Value = cmb_Course.Text;
                Cmd.Parameters.Add("S_City", SqlDbType.NVarChar).Value = cmb_City.Text;

                Cmd.ExecuteNonQuery();

                MessageBox.Show("Student Details Saved Successfully", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Con_Close();
                Clear_Controls();            

            }
            else
            {
                MessageBox.Show("Incomplete Information.Fill Up The Information.","Incomplete",MessageBoxButtons.OK,MessageBoxIcon.Warning);

                Clear_Controls();
            }

        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            Clear_Controls();
        }

        private void tb_Name_KeyPress(object sender, KeyPressEventArgs e)
        {
            if((!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar)) && (!char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        private void tb_ID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void tb_Mob_No_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }

        }

      
    }
}
