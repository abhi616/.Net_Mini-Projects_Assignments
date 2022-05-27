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
    public partial class frm_Customer_Report : Form
    {
        public frm_Customer_Report()
        {
            InitializeComponent();
        }

        private void frm_Customer_Report_Load(object sender, EventArgs e)
        {
            CustomerReport crpt = new CustomerReport();

            crpt.Load(@"D:\C# Assignments\C# Assignments + Project\C#_Projects\Mini_Project-01\Shoppee_Mini_Project\CustomerReport.rpt");

            crystalReportViewer1.ReportSource = crpt;
        }
    }
}
