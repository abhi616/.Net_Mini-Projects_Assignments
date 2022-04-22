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
    public partial class UC_UpdateItem : UserControl
    {
        Function fn = new Function();
        String query;
        public UC_UpdateItem()
        {
            InitializeComponent();
        }

        private void UC_UpdateItem_Load(object sender, EventArgs e)
        {
            Load_Data();
        }

        public void Load_Data()
        {
            query = "Select * from items";
            DataSet Ds = fn.getData(query);
            dgv_UpdateItem.DataSource = Ds.Tables[0];
        }

        public void Clr_Data()
        {
            tb_Category.Clear();
            tb_ItemNm.Clear();
            tb_ItemPrice.Clear();
        }

        private void tb_Item_Name_TextChanged(object sender, EventArgs e)
        {
            query = "select * from items where name like '"+tb_Item_Name.Text+"%'";
            DataSet Ds = fn.getData(query);
            dgv_UpdateItem.DataSource = Ds.Tables[0];
        }

        int id;
        private void dgv_UpdateItem_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            id = int.Parse(dgv_UpdateItem.Rows[e.RowIndex].Cells[0].Value.ToString());
            String Category = dgv_UpdateItem.Rows[e.RowIndex].Cells[2].Value.ToString();
            String name = dgv_UpdateItem.Rows[e.RowIndex].Cells[1].Value.ToString();
            int price = int.Parse(dgv_UpdateItem.Rows[e.RowIndex].Cells[3].Value.ToString());

            tb_Category.Text = Category;
            tb_ItemNm.Text = name;
            tb_ItemPrice.Text = price.ToString();
        }

        private void btn_Print_Click(object sender, EventArgs e)
        {
            if(tb_Category.Text!="" && tb_ItemNm.Text!="" && tb_ItemPrice.Text!="")
            {
                query = "update items set name = '" + tb_ItemNm.Text + "',Category = '" + tb_Category.Text + "',price = " + tb_ItemPrice.Text + " where Iid = " + id + "";
                fn.setData(query);
                Load_Data();
                MessageBox.Show("Items Updated Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Clr_Data();
            }
            else
            {
                MessageBox.Show("Something Wents Wrong", "Wrong", MessageBoxButtons.OK, MessageBoxIcon.Question);
            }
        }
    }
}
