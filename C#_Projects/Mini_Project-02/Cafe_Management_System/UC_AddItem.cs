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
    public partial class UC_AddItem : UserControl
    {
        Function Fn = new Function();
        String query;

        public UC_AddItem()
        {
            InitializeComponent();
        }

        private void btn_Add_Item_Click(object sender, EventArgs e)
        {
            if(tb_Item_Name.Text!=""&&tb_Price.Text!=""&&cmb_Category.Text!="")
            {
                query = "Insert Into Items(name,Category,price)values('" + tb_Item_Name.Text + "','" + cmb_Category.Text + "','" + tb_Price.Text + "')";
                Fn.setData(query);

                MessageBox.Show("Items Added Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                clrData();
            }
            else
            {
                MessageBox.Show("Fill All The Fields", "Incomplete", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
        }

        public void clrData()
        {
            tb_Item_Name.Clear();
            tb_Price.Clear();
            cmb_Category.SelectedIndex = -1;
        }

        private void UC_AddItem_Leave(object sender, EventArgs e)
        {
            clrData();
        }
    }
}
