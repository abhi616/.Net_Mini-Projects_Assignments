using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace OLA_CAB_Management_Syatem
{
    public partial class frm_Login : Form
    {
        public frm_Login()
        {
            InitializeComponent();
        }

        private void btn_SingIn_Click(object sender, EventArgs e)
        {
            frm_MDI_OlaCab mo = new frm_MDI_OlaCab();

            mo.Show();

            this.Hide();
        }
    }
}
