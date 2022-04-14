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
    public partial class frm_Login : Form
    {
        public frm_Login()
        {
            InitializeComponent();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=Student_Mgt_System_DB;Integrated Security=True");

        private void frm_Login_Load(object sender, EventArgs e)
        {
            pnl_Login.BackColor = Color.FromArgb(100, 0, 0, 0);
        }

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


        private void btn_Sign_In_Click(object sender, EventArgs e)
        {
            if (tb_Username.Text != "" && tb_Paasword.Text != "")
            {
                Con_Open();

                SqlCommand Cmd = new SqlCommand();

                Cmd.Connection = Con;

                Cmd.CommandText = "select * from Login where Username = @user And Password = @Pass";

                Cmd.Parameters.Add("User", SqlDbType.NVarChar).Value = tb_Username.Text;
                Cmd.Parameters.Add("Pass", SqlDbType.NVarChar).Value = tb_Paasword.Text;

                String Ret = Convert.ToString(Cmd.ExecuteScalar());

                if (Ret == tb_Username.Text)
                {
                    Global_Vars.Uname = tb_Username.Text;

                    MessageBox.Show("You Are Logged In Successfully.", "Login", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    frm_MDI_Student_Management_System MSMS = new frm_MDI_Student_Management_System();
                    MSMS.Show();
                    this.Hide();
                }

                else
                {
                    MessageBox.Show("Incorrect Username Or Password", "Incorrect", MessageBoxButtons.OK, MessageBoxIcon.Question);

                    tb_Username.Clear();
                    tb_Paasword.Clear();
                    tb_Username.Focus();
                }

            }
            else
            {
                MessageBox.Show("Please Enter Username And Password.","Incomplete",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                tb_Username.Clear();
                tb_Paasword.Clear();
                tb_Username.Focus();
            }
        }
    }
}
