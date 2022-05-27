using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Shoppee_Mini_Project
{
    public partial class frm_Product_Report : Form
    {
        public frm_Product_Report()
        {
            InitializeComponent();
        }

        private void frm_Product_Report_Load(object sender, EventArgs e)
        {
            ProductReport crpt = new ProductReport();

            crpt.Load(@"D:\C# Assignments\C# Assignments + Project\C#_Projects\Mini_Project-01\Shoppee_Mini_Project\ProductReport.rpt");

            crystalReportViewer1.ReportSource = crpt;
        }
    }
}
