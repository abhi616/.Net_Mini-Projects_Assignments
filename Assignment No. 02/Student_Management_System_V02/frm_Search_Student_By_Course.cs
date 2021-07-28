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
    public partial class frm_Search_Student_By_Course : Form
    {
        public frm_Search_Student_By_Course()
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

        void Bind_Grid(String Query)
        {

            Con_Open();

            dgv_Search_Student_By_Course.DataSource = "";

            SqlDataAdapter SDA = new SqlDataAdapter(Query , Con);

            DataTable Dt = new DataTable();

            SDA.Fill(Dt);

            dgv_Search_Student_By_Course.DataSource = Dt;

            Con_Close();


        }

        private void btn_Add_New_Student_Click(object sender, EventArgs e)
        {
            frm_Add_New_Student Obj = new frm_Add_New_Student();

            Obj.Show();
            this.Hide();
        }

        private void btn_Log_Out_Click(object sender, EventArgs e)
        {
            frm_login Obj = new frm_login();

            Obj.Show();
            this.Hide();
        }


        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            cmb_Course.Text = "";
            Bind_Grid("Select * From Student_Details");
        }

        private void cmb_Course_SelectedIndexChanged(object sender, EventArgs e)
        {
            Bind_Grid("Select * from Student_Details where Course = '" + cmb_Course.Text + "' ");
        }

        private void frm_Search_Student_By_Course_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'student_Management_System_DBDataSet1.Student_Details' table. You can move, or remove it, as needed.
            this.student_DetailsTableAdapter.Fill(this.student_Management_System_DBDataSet1.Student_Details);

        }

        private void btn_Search_Student_Click(object sender, EventArgs e)
        {
            frm_Search_Student Obj = new frm_Search_Student();

            Obj.Show();
            this.Show();
        }

       
    }
}
