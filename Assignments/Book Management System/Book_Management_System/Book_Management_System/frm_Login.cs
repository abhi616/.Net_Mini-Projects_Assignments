using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace Book_Management_System
{
    public partial class frm_login : Form
    {
        public frm_login()
        {
            InitializeComponent();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=Book_Management_System_DB;Integrated Security=True");

        void Con_Open()
        {
             if(Con.State == ConnectionState.Closed)
             {
                 Con.Open();
             }
        }

        void Con_Close()
        {
             if(Con.State == ConnectionState.Open)
             {
                 Con.Close();
             }
        }

        private void btn_Sign_in_Click(object sender, EventArgs e)
        {
            if (tb_Username.Text != "" && tb_Password.Text != "")
            {
                Con_Open();

                SqlCommand Cmd = new SqlCommand();

                Cmd.Connection = Con;

                Cmd.CommandText = "Select * from Login where Username = @User And Password = @Pass";

                Cmd.Parameters.Add("User", SqlDbType.VarChar).Value = tb_Username.Text;
                Cmd.Parameters.Add("Pass", SqlDbType.VarChar).Value = tb_Password.Text;

                string Ret = Convert.ToString(Cmd.ExecuteScalar());

                if (Ret == tb_Username.Text && tb_Password.Text != "")
                {
                    Global_Vars.User = tb_Username.Text;

                    // if(tb_Username.Text=="")

                    MessageBox.Show("You are logged in successfully !!!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    frm_MDI_Book_Management_System MDIObj = new frm_MDI_Book_Management_System();
                    MDIObj.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Incorrect Username Or Password", "Incorrect", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
              
            }
            else
            {
                 MessageBox.Show("Please Enter Username & Password", "Incomplete", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                 tb_Username.Focus();
            }

        }

       
    }
}
