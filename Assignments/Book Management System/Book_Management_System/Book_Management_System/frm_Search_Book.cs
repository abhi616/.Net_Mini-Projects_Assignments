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
    public partial class frm_Search_Book : Form
    {
        public frm_Search_Book()
        {
            InitializeComponent();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=Book_Management_System_DB;Integrated Security=True");

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
            tb_Book_Name.Clear();
            tb_Author.Clear();
            dtp_Publish_Date.Text = "";
            cmb_Category.Text = "";
            tb_ID.Focus();
        }


        private void btn_Search_Click(object sender, EventArgs e)
        {
            if (tb_ID.Text != "")
            {
                lbl_Required.Visible = false;
                Con_Open();

                SqlCommand Cmd = new SqlCommand();

                Cmd.Connection = Con;
                Cmd.CommandText = "Select * from Book_Detail where B_ID = " + tb_ID.Text + "";

                SqlDataReader Dr = Cmd.ExecuteReader();

                if (Dr.Read())
                {
                    tb_Book_Name.Text = Dr.GetString(Dr.GetOrdinal("B_Name"));
                    tb_Author.Text = Dr.GetString(Dr.GetOrdinal("B_Author"));
                    dtp_Publish_Date.Text = (Dr["B_PublishDate"].ToString());
                    cmb_Category.Text = Dr.GetString(Dr.GetOrdinal("B_Category"));
                }
                else
                {
                    MessageBox.Show("Not Such Book Found", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    tb_ID.Clear();
                    tb_ID.Focus();
                }

                Con_Close();

            }
            else
            {
                lbl_Required.Visible = true;
            }
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            Clear_Controls();
        }

       

    }
}
