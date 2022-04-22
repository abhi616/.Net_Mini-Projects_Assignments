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
    public partial class UC_Welcome : UserControl
    {
        public UC_Welcome()
        {
            InitializeComponent();
        }

        int num = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if(num==0)
            {
                lbl_CafeName.Location = new Point(72, 500);
                lbl_CafeName.ForeColor = Color.Orange;
                num++;
            }
            else if(num==1)
            {
                lbl_CafeName.Location = new Point(200, 500);
                lbl_CafeName.ForeColor = Color.Red;
                num++;
            }
            else if(num==2)
            {
                lbl_CafeName.Location = new Point(372, 500);
                lbl_CafeName.ForeColor = Color.Blue;
                num = 0;
            }
        }

        private void UC_Welcome_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}
