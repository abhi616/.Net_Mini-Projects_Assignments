﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace OLA_CAB_Management_Syatem
{
    public partial class frm_MDI_OlaCab : Form
    {
        public frm_MDI_OlaCab()
        {
            InitializeComponent();
        }

        private void bikeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Add_Passenger ap = new frm_Add_Passenger();

            ap.MdiParent = this;

            ap.WindowState = FormWindowState.Maximized;

            ap.Show();
        }

        private void addVehicalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Add_Vehicle av = new frm_Add_Vehicle();

            av.MdiParent = this;

            av.WindowState = FormWindowState.Maximized;

            av.Show();
        }

        private void viewVehicalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_View_Vehicle vv = new frm_View_Vehicle();

            vv.MdiParent = this;

            vv.WindowState = FormWindowState.Maximized;

            vv.Show();
        }

        private void updateDriverToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Update_Driver ur = new frm_Update_Driver();

            ur.MdiParent = this;

            ur.WindowState = FormWindowState.Maximized;

            ur.Show();
        }

        private void viewDriverToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_View_Driver vd = new frm_View_Driver();

            vd.MdiParent = this;

            vd.WindowState = FormWindowState.Maximized;

            vd.Show();
        }

        private void addAreaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Add_Area aa = new frm_Add_Area();

            aa.MdiParent = this;

            aa.WindowState = FormWindowState.Maximized;

            aa.Show();
        }

        private void updateAreaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Update_Area ua = new frm_Update_Area();

            ua.MdiParent = this;

            ua.WindowState = FormWindowState.Maximized;

            ua.Show();
        }

        private void viewAreaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_View_Area va = new frm_View_Area();

            va.MdiParent = this;

            va.WindowState = FormWindowState.Maximized;

            va.Show();
        }

        private void addUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Add_User au = new frm_Add_User();

            au.MdiParent = this;

            au.WindowState = FormWindowState.Maximized;

            au.Show();
        }

        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Update_User uu = new frm_Update_User();

            uu.MdiParent = this;

            uu.WindowState = FormWindowState.Maximized;

            uu.Show();
        }

        private void deleteUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Delete_User du = new frm_Delete_User();

            du.MdiParent = this;

            du.WindowState = FormWindowState.Maximized;

            du.Show();
        }

        private void addDriverToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Add_Driver ad = new frm_Add_Driver();

            ad.MdiParent = this;

            ad.WindowState = FormWindowState.Maximized;

            ad.Show();
        }

        private void bikeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frm_View_Bike_Passenger vbp = new frm_View_Bike_Passenger();

            vbp.MdiParent = this;

            vbp.WindowState = FormWindowState.Maximized;

            vbp.Show();
        }

        private void carToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frm_View_Car_Passenger vcp = new frm_View_Car_Passenger();

            vcp.MdiParent = this;

            vcp.WindowState = FormWindowState.Maximized;

            vcp.Show();
        }

        private void carToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Add_Passenger_Car acp = new frm_Add_Passenger_Car();

            acp.MdiParent = this;

            acp.WindowState = FormWindowState.Maximized;

            acp.Show();
        }



    }
}
