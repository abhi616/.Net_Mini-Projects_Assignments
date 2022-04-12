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
    public partial class frm_Add_New_Book : Form
    {
        public frm_Add_New_Book()
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


        int Auto_Incr()
        {
            Con_Open();

            int Cnt = 0;

            SqlCommand Cmd = new SqlCommand("Select Count(*) From Book_Detail", Con);

            Cnt = Convert.ToInt32(Cmd.ExecuteScalar());

            Cmd.Dispose();

            if (Cnt > 0)
            {
                Cmd.Connection = Con;
                Cmd.CommandText = "Select Max(B_ID) From Book_Detail";

                Cnt = Convert.ToInt32(Cmd.ExecuteScalar()) + 1;

            }
            else
            {
                Cnt = 1;
            }

            Cmd.Dispose();

            return Cnt;
        }


        void Clear_Contrls()
        {
            tb_BookID.Text = Convert.ToString(Auto_Incr());
            tb_Book_Name.Clear();
            tb_BookAuthor.Clear();
            dtp_Publish_Date.Text = "";
            cmb_Category.Text = "";
            tb_Book_Name.Focus();
        }

        private void frm_Add_New_Book_Load(object sender, EventArgs e)
        {
            tb_BookID.Text = Convert.ToString(Auto_Incr());
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            if (tb_BookID.Text != "" && tb_Book_Name.Text != "" && tb_BookAuthor.Text != "" && cmb_Category.Text != "" && dtp_Publish_Date.Text != "")
            {

                Con_Open();

                SqlCommand Cmd = new SqlCommand();
                Cmd.Connection = Con;

                Cmd.CommandText = "Insert into Book_Detail(B_ID,B_Name,B_Author,B_PublishDate,B_Category) Values(@ID,@Name,@Author,@PublishDate,@Category)";

                Cmd.Parameters.Add("ID", SqlDbType.Int).Value = tb_BookID.Text;
                Cmd.Parameters.Add("Name", SqlDbType.VarChar).Value = tb_Book_Name.Text;
                Cmd.Parameters.Add("Author", SqlDbType.VarChar).Value = tb_BookAuthor.Text;
                Cmd.Parameters.Add("PublishDate", SqlDbType.Date).Value = dtp_Publish_Date.Text;
                Cmd.Parameters.Add("Category", SqlDbType.VarChar).Value = cmb_Category.Text;

                Cmd.ExecuteNonQuery();

                MessageBox.Show("New Book Added Successfully", "Added", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Con_Close();
                Clear_Contrls();
            }
            else
            {
                MessageBox.Show("Plaese Insert Book Deatil", "Can't Add", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
