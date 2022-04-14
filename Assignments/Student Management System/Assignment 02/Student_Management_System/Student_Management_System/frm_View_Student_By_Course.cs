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
    public partial class frm_View_Student_By_Course : Form
    {
        public frm_View_Student_By_Course()
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


        void Bind_Grid(string Query)
        {
            Con_Open();

            dgv_View_Student_By_Course.DataSource = "";

            SqlDataAdapter SDA = new SqlDataAdapter(Query, Con);

            DataTable DT = new DataTable();

            SDA.Fill(DT);

            dgv_View_Student_By_Course.DataSource = DT;

            Con_Close();
        
        }



        private void frm_View_Student_By_Course_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'student_Management_System_DBDataSet1.Student_Details' table. You can move, or remove it, as needed.
            this.student_DetailsTableAdapter.Fill(this.student_Management_System_DBDataSet1.Student_Details);

        }

        private void cmb_Course_SelectedIndexChanged(object sender, EventArgs e)
        {
            Bind_Grid("Select * From Student_Details where Course = '" + cmb_Course.Text + "'");
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            cmb_Course.Text = "";
            Bind_Grid("Select * From Student_Details");
        }

        private void btn_Add_New_Student_Click(object sender, EventArgs e)
        {
            frm_Add_New_Student ANS = new frm_Add_New_Student();

            ANS.Show();
            this.Hide();
        }

        private void btn_Search_Student_By_ID_Click(object sender, EventArgs e)
        {
            frm_Search_Student_By_ID Obj = new frm_Search_Student_By_ID();

            Obj.Show();
            this.Hide();
        }

        private void btn_log_Out_Click(object sender, EventArgs e)
        {
            DialogResult Res = MessageBox.Show("Are You Sure ??","Logging Out",MessageBoxButtons.YesNo,MessageBoxIcon.Question);

            if (Res == DialogResult.Yes)
            {
                frm_login Obj = new frm_login();

                Obj.Show();
                this.Hide();
            }
        }


    }
}
