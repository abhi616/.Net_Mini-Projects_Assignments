﻿namespace OLA_CAB_Management_Syatem
{
    partial class frm_MDI_OlaCab
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.customerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addPassengerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bikeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.carToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewPassengerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bikeToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.carToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.vehicalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addVehicalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewVehicalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.driverToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addDriverToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateDriverToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewDriverToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.areaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addAreaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateAreaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewAreaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.userManagementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changePasswordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.AutoSize = false;
            this.menuStrip1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.customerToolStripMenuItem,
            this.vehicalToolStripMenuItem,
            this.driverToolStripMenuItem,
            this.areaToolStripMenuItem,
            this.userManagementToolStripMenuItem,
            this.reportToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1924, 55);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // customerToolStripMenuItem
            // 
            this.customerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addPassengerToolStripMenuItem,
            this.viewPassengerToolStripMenuItem});
            this.customerToolStripMenuItem.Name = "customerToolStripMenuItem";
            this.customerToolStripMenuItem.Size = new System.Drawing.Size(140, 51);
            this.customerToolStripMenuItem.Text = "Passenger";
            // 
            // addPassengerToolStripMenuItem
            // 
            this.addPassengerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bikeToolStripMenuItem,
            this.carToolStripMenuItem});
            this.addPassengerToolStripMenuItem.Name = "addPassengerToolStripMenuItem";
            this.addPassengerToolStripMenuItem.Size = new System.Drawing.Size(262, 30);
            this.addPassengerToolStripMenuItem.Text = "Add Passenger";
            // 
            // bikeToolStripMenuItem
            // 
            this.bikeToolStripMenuItem.Name = "bikeToolStripMenuItem";
            this.bikeToolStripMenuItem.Size = new System.Drawing.Size(132, 30);
            this.bikeToolStripMenuItem.Text = "Bike";
            this.bikeToolStripMenuItem.Click += new System.EventHandler(this.bikeToolStripMenuItem_Click);
            // 
            // carToolStripMenuItem
            // 
            this.carToolStripMenuItem.Name = "carToolStripMenuItem";
            this.carToolStripMenuItem.Size = new System.Drawing.Size(152, 30);
            this.carToolStripMenuItem.Text = "Car";
            this.carToolStripMenuItem.Click += new System.EventHandler(this.carToolStripMenuItem_Click);
            // 
            // viewPassengerToolStripMenuItem
            // 
            this.viewPassengerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bikeToolStripMenuItem1,
            this.carToolStripMenuItem1});
            this.viewPassengerToolStripMenuItem.Name = "viewPassengerToolStripMenuItem";
            this.viewPassengerToolStripMenuItem.Size = new System.Drawing.Size(262, 30);
            this.viewPassengerToolStripMenuItem.Text = "View Passenger";
            // 
            // bikeToolStripMenuItem1
            // 
            this.bikeToolStripMenuItem1.Name = "bikeToolStripMenuItem1";
            this.bikeToolStripMenuItem1.Size = new System.Drawing.Size(152, 30);
            this.bikeToolStripMenuItem1.Text = "Bike";
            this.bikeToolStripMenuItem1.Click += new System.EventHandler(this.bikeToolStripMenuItem1_Click);
            // 
            // carToolStripMenuItem1
            // 
            this.carToolStripMenuItem1.Name = "carToolStripMenuItem1";
            this.carToolStripMenuItem1.Size = new System.Drawing.Size(152, 30);
            this.carToolStripMenuItem1.Text = "Car";
            this.carToolStripMenuItem1.Click += new System.EventHandler(this.carToolStripMenuItem1_Click);
            // 
            // vehicalToolStripMenuItem
            // 
            this.vehicalToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addVehicalToolStripMenuItem,
            this.viewVehicalToolStripMenuItem});
            this.vehicalToolStripMenuItem.Name = "vehicalToolStripMenuItem";
            this.vehicalToolStripMenuItem.Size = new System.Drawing.Size(105, 51);
            this.vehicalToolStripMenuItem.Text = "Vehical";
            // 
            // addVehicalToolStripMenuItem
            // 
            this.addVehicalToolStripMenuItem.Name = "addVehicalToolStripMenuItem";
            this.addVehicalToolStripMenuItem.Size = new System.Drawing.Size(227, 30);
            this.addVehicalToolStripMenuItem.Text = "Add Vehical";
            this.addVehicalToolStripMenuItem.Click += new System.EventHandler(this.addVehicalToolStripMenuItem_Click);
            // 
            // viewVehicalToolStripMenuItem
            // 
            this.viewVehicalToolStripMenuItem.Name = "viewVehicalToolStripMenuItem";
            this.viewVehicalToolStripMenuItem.Size = new System.Drawing.Size(227, 30);
            this.viewVehicalToolStripMenuItem.Text = "View Vehical";
            this.viewVehicalToolStripMenuItem.Click += new System.EventHandler(this.viewVehicalToolStripMenuItem_Click);
            // 
            // driverToolStripMenuItem
            // 
            this.driverToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addDriverToolStripMenuItem,
            this.updateDriverToolStripMenuItem,
            this.viewDriverToolStripMenuItem});
            this.driverToolStripMenuItem.Name = "driverToolStripMenuItem";
            this.driverToolStripMenuItem.Size = new System.Drawing.Size(94, 51);
            this.driverToolStripMenuItem.Text = "Driver";
            // 
            // addDriverToolStripMenuItem
            // 
            this.addDriverToolStripMenuItem.Name = "addDriverToolStripMenuItem";
            this.addDriverToolStripMenuItem.Size = new System.Drawing.Size(240, 30);
            this.addDriverToolStripMenuItem.Text = "Add Driver";
            this.addDriverToolStripMenuItem.Click += new System.EventHandler(this.addDriverToolStripMenuItem_Click);
            // 
            // updateDriverToolStripMenuItem
            // 
            this.updateDriverToolStripMenuItem.Name = "updateDriverToolStripMenuItem";
            this.updateDriverToolStripMenuItem.Size = new System.Drawing.Size(240, 30);
            this.updateDriverToolStripMenuItem.Text = "Update Driver";
            this.updateDriverToolStripMenuItem.Click += new System.EventHandler(this.updateDriverToolStripMenuItem_Click);
            // 
            // viewDriverToolStripMenuItem
            // 
            this.viewDriverToolStripMenuItem.Name = "viewDriverToolStripMenuItem";
            this.viewDriverToolStripMenuItem.Size = new System.Drawing.Size(240, 30);
            this.viewDriverToolStripMenuItem.Text = "View Driver";
            this.viewDriverToolStripMenuItem.Click += new System.EventHandler(this.viewDriverToolStripMenuItem_Click);
            // 
            // areaToolStripMenuItem
            // 
            this.areaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addAreaToolStripMenuItem,
            this.updateAreaToolStripMenuItem,
            this.viewAreaToolStripMenuItem});
            this.areaToolStripMenuItem.Name = "areaToolStripMenuItem";
            this.areaToolStripMenuItem.Size = new System.Drawing.Size(76, 51);
            this.areaToolStripMenuItem.Text = "Area";
            // 
            // addAreaToolStripMenuItem
            // 
            this.addAreaToolStripMenuItem.Name = "addAreaToolStripMenuItem";
            this.addAreaToolStripMenuItem.Size = new System.Drawing.Size(222, 30);
            this.addAreaToolStripMenuItem.Text = "Add Area";
            this.addAreaToolStripMenuItem.Click += new System.EventHandler(this.addAreaToolStripMenuItem_Click);
            // 
            // updateAreaToolStripMenuItem
            // 
            this.updateAreaToolStripMenuItem.Name = "updateAreaToolStripMenuItem";
            this.updateAreaToolStripMenuItem.Size = new System.Drawing.Size(222, 30);
            this.updateAreaToolStripMenuItem.Text = "Update Area";
            this.updateAreaToolStripMenuItem.Click += new System.EventHandler(this.updateAreaToolStripMenuItem_Click);
            // 
            // viewAreaToolStripMenuItem
            // 
            this.viewAreaToolStripMenuItem.Name = "viewAreaToolStripMenuItem";
            this.viewAreaToolStripMenuItem.Size = new System.Drawing.Size(222, 30);
            this.viewAreaToolStripMenuItem.Text = "View Area";
            this.viewAreaToolStripMenuItem.Click += new System.EventHandler(this.viewAreaToolStripMenuItem_Click);
            // 
            // userManagementToolStripMenuItem
            // 
            this.userManagementToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addUserToolStripMenuItem,
            this.changePasswordToolStripMenuItem,
            this.deleteUserToolStripMenuItem});
            this.userManagementToolStripMenuItem.Name = "userManagementToolStripMenuItem";
            this.userManagementToolStripMenuItem.Size = new System.Drawing.Size(225, 51);
            this.userManagementToolStripMenuItem.Text = "User Management";
            // 
            // addUserToolStripMenuItem
            // 
            this.addUserToolStripMenuItem.Name = "addUserToolStripMenuItem";
            this.addUserToolStripMenuItem.Size = new System.Drawing.Size(283, 30);
            this.addUserToolStripMenuItem.Text = "Add User";
            this.addUserToolStripMenuItem.Click += new System.EventHandler(this.addUserToolStripMenuItem_Click);
            // 
            // changePasswordToolStripMenuItem
            // 
            this.changePasswordToolStripMenuItem.Name = "changePasswordToolStripMenuItem";
            this.changePasswordToolStripMenuItem.Size = new System.Drawing.Size(283, 30);
            this.changePasswordToolStripMenuItem.Text = "Change Password";
            this.changePasswordToolStripMenuItem.Click += new System.EventHandler(this.changePasswordToolStripMenuItem_Click);
            // 
            // deleteUserToolStripMenuItem
            // 
            this.deleteUserToolStripMenuItem.Name = "deleteUserToolStripMenuItem";
            this.deleteUserToolStripMenuItem.Size = new System.Drawing.Size(283, 30);
            this.deleteUserToolStripMenuItem.Text = "Delete User";
            this.deleteUserToolStripMenuItem.Click += new System.EventHandler(this.deleteUserToolStripMenuItem_Click);
            // 
            // reportToolStripMenuItem
            // 
            this.reportToolStripMenuItem.Name = "reportToolStripMenuItem";
            this.reportToolStripMenuItem.Size = new System.Drawing.Size(100, 51);
            this.reportToolStripMenuItem.Text = "Report";
            // 
            // frm_MDI_OlaCab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1924, 1055);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_MDI_OlaCab";
            this.Text = "Ola Cab Management System";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem customerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vehicalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem driverToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem areaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem userManagementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addPassengerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewPassengerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addVehicalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewVehicalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addDriverToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateDriverToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewDriverToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addAreaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateAreaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewAreaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addUserToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changePasswordToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteUserToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bikeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem carToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bikeToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem carToolStripMenuItem1;
    }
}