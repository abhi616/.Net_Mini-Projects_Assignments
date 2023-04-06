using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Shoppee_Mini_Project
{
    public partial class frm_Customer_Report : Form
    {
        public frm_Customer_Report()
        {
            InitializeComponent();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=Mini_Shoppee_DB;Integrated Security=True");

        private void frm_Customer_Report_Load(object sender, EventArgs e)
        {
            string sqlStr = "Select * from Customer_Details";

            SqlDataAdapter da = new SqlDataAdapter(sqlStr, Con);

            DataSet ds = new DataSet();
            da.Fill(ds, "Customer_Details");

            CustomerReport pr = new CustomerReport();
            pr.SetDataSource(ds);

            crystalReportViewer1.ReportSource = pr;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frm_Customer_Menu cm = new frm_Customer_Menu();
            cm.Show();
            this.Hide();
        }
    }
}
