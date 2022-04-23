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
    public partial class UC_PlaceOrder : UserControl
    {
        Function fn = new Function();
        String query;
        public UC_PlaceOrder()
        {
            InitializeComponent();
        }

        private void cmb_Category_SelectedIndexChanged(object sender, EventArgs e)
        {
            lb_Items.Items.Clear();
            String category = cmb_Category.Text;
            query = "select name from Items where category = '" + category + "'";
            DataSet ds = fn.getData(query);

            for(int i = 0; i < ds.Tables[0].Rows.Count ; i++)
            {
                lb_Items.Items.Add(ds.Tables[0].Rows[i][0].ToString());
            }
        }

        private void tb_Item_Name_TextChanged(object sender, EventArgs e)
        {
            lb_Items.Items.Clear();
            String category = cmb_Category.Text;
            query = "select name from Items where category = '" + category + "' and name like '"+tb_Search.Text+"%'";
            showItemList(query);
        }

        private void showItemList(String query)
        {
            lb_Items.Items.Clear();
            DataSet ds = fn.getData(query);

            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                lb_Items.Items.Add(ds.Tables[0].Rows[i][0].ToString());
            }
        }

        private void lb_Items_SelectedIndexChanged(object sender, EventArgs e)
        {
            tb_UpDown.ResetText();
            tb_Total.Clear();

            String txt = lb_Items.GetItemText(lb_Items.SelectedItem);
            tb_ItemName.Text = txt;
            query = "select price from Items where name = '" + txt + "'";
            DataSet ds = fn.getData(query);

            tb_Price.Text = ds.Tables[0].Rows[0][0].ToString();
        
        }

        private void tb_UpDown_ValueChanged(object sender, EventArgs e)
        {
            Int64 quan = Int64.Parse(tb_UpDown.Value.ToString());
            Int64 price = Int64.Parse(tb_Price.Text);
            tb_Total.Text = (quan * price).ToString();
        }
    }
}
