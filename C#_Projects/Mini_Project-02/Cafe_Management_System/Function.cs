using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cafe_Management_System
{
    class Function
    {
       protected SqlConnection getConnection()
        {
            SqlConnection Con = new SqlConnection();
            Con.ConnectionString = @"data source = LAPTOP-19V81UR4\SQLEXPRESS2019;database = Cafe_Mgt_DB; integrated security = True";
            return Con;
        }

        public DataSet getData(string Query)
        {
            SqlConnection Con = getConnection();

            SqlCommand Cmd = new SqlCommand(Query,Con);

            SqlDataAdapter Sda = new SqlDataAdapter(Cmd);

            DataSet Ds = new DataSet();
            Sda.Fill(Ds);
            return Ds;
        }

        public void setData(string Query)
        {
            SqlConnection Con = getConnection();

            Con.Open();

            SqlCommand Cmd = new SqlCommand(Query, Con);
            Cmd.ExecuteNonQuery();

            Con.Close(); 
        }
    }
}
