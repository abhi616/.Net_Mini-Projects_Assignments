using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace frm_DB_Creation
{
    public partial class frm_DB_Creation : Form
    {
        public frm_DB_Creation()
        {
            InitializeComponent();
        }


        void Clear()
        {
            tb_DB_Name.Clear();
            tb_Table_Name.Clear();
            tb_DB_Name.Focus();
        }
     
        private void btn_Create_Db_Click(object sender, EventArgs e)
        {
            if (tb_DB_Name.Text != ""&&tb_Table_Name.Text!="")
            {
                try
                {
                    string SqlCon = @"Data Source= .\SQLEXPRESS;Initial Catalog=;Integrated Security=True";
                    string CmdTxt = "Create Database "+ tb_DB_Name.Text +"";

                    SqlConnection Con = new SqlConnection(SqlCon);
                    Con.Open();
                    SqlCommand Cmd = new SqlCommand(CmdTxt,Con);                  
                    Cmd.ExecuteNonQuery();

                    MessageBox.Show(tb_DB_Name.Text + " Database Created Successfully","Database Created",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    Cmd.Dispose();

                    string Db = tb_DB_Name.Text;
                    Con.ChangeDatabase(Db);

                    Cmd.Connection = Con;
                    Cmd.CommandText = "Create table " + tb_Table_Name.Text + "(ID int primary key,Name varchar(30))";
                    Cmd.ExecuteNonQuery();

                    MessageBox.Show(tb_Table_Name.Text + " Table Created Successfully", "Table Created", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Clear();
                    Con.Close();
                }
                catch(Exception ex)
                {
                    throw;
                }
            }
            else
            {
                 MessageBox.Show("Enter Database Name & Table Name","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);  
            }
            
        }

        private void frm_DB_Creation_Load(object sender, EventArgs e)
        {
            Clear();
        }

       
    }
}
