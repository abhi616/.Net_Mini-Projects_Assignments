using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cafe_Management_System
{
    public partial class UC_DeleteItem : UserControl
    {
        Function fn = new Function();
        String query;
        public UC_DeleteItem()
        {
            InitializeComponent();
        }

        private void UC_DeleteItem_Load(object sender, EventArgs e)
        {
            load_Data();
            lbl_Del.Text = "How to DELETE?";
        }

        public void load_Data()
        {
            query = "select * from Items";
            DataSet ds = fn.getData(query);
            dgv_DeleteItem.DataSource = ds.Tables[0];
        }

        private void tb_Item_Name_TextChanged(object sender, EventArgs e)
        {
            query = "select * from items where name like '"+tb_Item_Name.Text+"%'";
            DataSet ds = fn.getData(query);
            dgv_DeleteItem.DataSource = ds.Tables[0];
        }

        private void dgv_DeleteItem_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(MessageBox.Show("Delete Item?","Important Message",MessageBoxButtons.OKCancel,MessageBoxIcon.Question)==DialogResult.OK)
            {
                int id = int.Parse(dgv_DeleteItem.Rows[e.RowIndex].Cells[0].Value.ToString());
                query = "delete from items where Iid = "+id+"";
                fn.setData(query);
                load_Data();
            }
        }

        private void lbl_Del_Click(object sender, EventArgs e)
        {
            lbl_Del.ForeColor = Color.Red;
            lbl_Del.Text = "*Click on Row to Delete the Item.";
        }

        private void UC_DeleteItem_Enter(object sender, EventArgs e)
        {
            load_Data();
        }
    }
}
