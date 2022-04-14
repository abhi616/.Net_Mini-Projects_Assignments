namespace Student_Management_System
{
    partial class frm_Add_New_Student
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
            this.lbl_Header = new System.Windows.Forms.Label();
            this.lbl_ID = new System.Windows.Forms.Label();
            this.lbl_Name = new System.Windows.Forms.Label();
            this.lbl_MobNo = new System.Windows.Forms.Label();
            this.lbl_Course = new System.Windows.Forms.Label();
            this.lbl_City = new System.Windows.Forms.Label();
            this.tb_ID = new System.Windows.Forms.TextBox();
            this.tb_Name = new System.Windows.Forms.TextBox();
            this.tb_MobNo = new System.Windows.Forms.TextBox();
            this.cmb_Course = new System.Windows.Forms.ComboBox();
            this.cmb_City = new System.Windows.Forms.ComboBox();
            this.btn_Save = new System.Windows.Forms.Button();
            this.btn_Refresh = new System.Windows.Forms.Button();
            this.btn_View_All_Details = new System.Windows.Forms.Button();
            this.btn_log_Out = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_Header
            // 
            this.lbl_Header.AutoSize = true;
            this.lbl_Header.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lbl_Header.Font = new System.Drawing.Font("Calisto MT", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Header.ForeColor = System.Drawing.Color.Red;
            this.lbl_Header.Location = new System.Drawing.Point(297, 54);
            this.lbl_Header.Name = "lbl_Header";
            this.lbl_Header.Size = new System.Drawing.Size(501, 67);
            this.lbl_Header.TabIndex = 0;
            this.lbl_Header.Text = "Add New Student";
            // 
            // lbl_ID
            // 
            this.lbl_ID.AutoSize = true;
            this.lbl_ID.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_ID.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ID.ForeColor = System.Drawing.Color.DarkBlue;
            this.lbl_ID.Location = new System.Drawing.Point(116, 190);
            this.lbl_ID.Name = "lbl_ID";
            this.lbl_ID.Size = new System.Drawing.Size(125, 31);
            this.lbl_ID.TabIndex = 0;
            this.lbl_ID.Text = "Student ID";
            // 
            // lbl_Name
            // 
            this.lbl_Name.AutoSize = true;
            this.lbl_Name.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_Name.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Name.ForeColor = System.Drawing.Color.DarkBlue;
            this.lbl_Name.Location = new System.Drawing.Point(116, 266);
            this.lbl_Name.Name = "lbl_Name";
            this.lbl_Name.Size = new System.Drawing.Size(163, 31);
            this.lbl_Name.TabIndex = 0;
            this.lbl_Name.Text = "Student Name";
            // 
            // lbl_MobNo
            // 
            this.lbl_MobNo.AutoSize = true;
            this.lbl_MobNo.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_MobNo.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_MobNo.ForeColor = System.Drawing.Color.DarkBlue;
            this.lbl_MobNo.Location = new System.Drawing.Point(116, 349);
            this.lbl_MobNo.Name = "lbl_MobNo";
            this.lbl_MobNo.Size = new System.Drawing.Size(129, 31);
            this.lbl_MobNo.TabIndex = 0;
            this.lbl_MobNo.Text = "Mobile No.";
            // 
            // lbl_Course
            // 
            this.lbl_Course.AutoSize = true;
            this.lbl_Course.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_Course.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Course.ForeColor = System.Drawing.Color.DarkBlue;
            this.lbl_Course.Location = new System.Drawing.Point(119, 428);
            this.lbl_Course.Name = "lbl_Course";
            this.lbl_Course.Size = new System.Drawing.Size(85, 31);
            this.lbl_Course.TabIndex = 0;
            this.lbl_Course.Text = "Course";
            // 
            // lbl_City
            // 
            this.lbl_City.AutoSize = true;
            this.lbl_City.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_City.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_City.ForeColor = System.Drawing.Color.DarkBlue;
            this.lbl_City.Location = new System.Drawing.Point(122, 511);
            this.lbl_City.Name = "lbl_City";
            this.lbl_City.Size = new System.Drawing.Size(54, 31);
            this.lbl_City.TabIndex = 0;
            this.lbl_City.Text = "City";
            // 
            // tb_ID
            // 
            this.tb_ID.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_ID.Location = new System.Drawing.Point(444, 190);
            this.tb_ID.MaxLength = 4;
            this.tb_ID.Name = "tb_ID";
            this.tb_ID.Size = new System.Drawing.Size(392, 32);
            this.tb_ID.TabIndex = 1;
            this.tb_ID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_ID_KeyPress);
            // 
            // tb_Name
            // 
            this.tb_Name.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Name.Location = new System.Drawing.Point(444, 266);
            this.tb_Name.MaxLength = 50;
            this.tb_Name.Name = "tb_Name";
            this.tb_Name.Size = new System.Drawing.Size(392, 32);
            this.tb_Name.TabIndex = 2;
            this.tb_Name.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_Name_KeyPress);
            // 
            // tb_MobNo
            // 
            this.tb_MobNo.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_MobNo.Location = new System.Drawing.Point(444, 339);
            this.tb_MobNo.MaxLength = 10;
            this.tb_MobNo.Name = "tb_MobNo";
            this.tb_MobNo.Size = new System.Drawing.Size(392, 32);
            this.tb_MobNo.TabIndex = 3;
            this.tb_MobNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_MobNo_KeyPress);
            // 
            // cmb_Course
            // 
            this.cmb_Course.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Course.FormattingEnabled = true;
            this.cmb_Course.Items.AddRange(new object[] {
            "BCA",
            "BCS",
            "BBA",
            "BA",
            "BCOM",
            "MCA",
            "MA",
            "MCS",
            "MCOM",
            "MBA"});
            this.cmb_Course.Location = new System.Drawing.Point(444, 428);
            this.cmb_Course.MaxLength = 10;
            this.cmb_Course.Name = "cmb_Course";
            this.cmb_Course.Size = new System.Drawing.Size(392, 32);
            this.cmb_Course.TabIndex = 4;
            // 
            // cmb_City
            // 
            this.cmb_City.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_City.FormattingEnabled = true;
            this.cmb_City.Items.AddRange(new object[] {
            "Sangli",
            "Satara",
            "Pune",
            "Mumbai",
            "Kolhapur",
            "Solapur",
            "Nagpur",
            "Nashik",
            "Delhi"});
            this.cmb_City.Location = new System.Drawing.Point(444, 511);
            this.cmb_City.Name = "cmb_City";
            this.cmb_City.Size = new System.Drawing.Size(392, 32);
            this.cmb_City.TabIndex = 5;
            // 
            // btn_Save
            // 
            this.btn_Save.BackColor = System.Drawing.Color.DimGray;
            this.btn_Save.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Save.ForeColor = System.Drawing.Color.Aqua;
            this.btn_Save.Location = new System.Drawing.Point(389, 613);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(127, 54);
            this.btn_Save.TabIndex = 6;
            this.btn_Save.Text = "Save";
            this.btn_Save.UseVisualStyleBackColor = false;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // btn_Refresh
            // 
            this.btn_Refresh.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn_Refresh.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Refresh.ForeColor = System.Drawing.Color.Aqua;
            this.btn_Refresh.Location = new System.Drawing.Point(37, 613);
            this.btn_Refresh.Name = "btn_Refresh";
            this.btn_Refresh.Size = new System.Drawing.Size(141, 54);
            this.btn_Refresh.TabIndex = 7;
            this.btn_Refresh.Text = "Refresh";
            this.btn_Refresh.UseVisualStyleBackColor = false;
            this.btn_Refresh.Click += new System.EventHandler(this.btn_Refresh_Click);
            // 
            // btn_View_All_Details
            // 
            this.btn_View_All_Details.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn_View_All_Details.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_View_All_Details.ForeColor = System.Drawing.Color.Aqua;
            this.btn_View_All_Details.Location = new System.Drawing.Point(708, 613);
            this.btn_View_All_Details.Name = "btn_View_All_Details";
            this.btn_View_All_Details.Size = new System.Drawing.Size(248, 54);
            this.btn_View_All_Details.TabIndex = 8;
            this.btn_View_All_Details.Text = "View All Details";
            this.btn_View_All_Details.UseVisualStyleBackColor = false;
            this.btn_View_All_Details.Click += new System.EventHandler(this.btn_View_All_Details_Click);
            // 
            // btn_log_Out
            // 
            this.btn_log_Out.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_log_Out.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_log_Out.Location = new System.Drawing.Point(993, 12);
            this.btn_log_Out.Name = "btn_log_Out";
            this.btn_log_Out.Size = new System.Drawing.Size(97, 40);
            this.btn_log_Out.TabIndex = 9;
            this.btn_log_Out.Text = "Log Out";
            this.btn_log_Out.UseVisualStyleBackColor = true;
            this.btn_log_Out.Click += new System.EventHandler(this.btn_log_Out_Click);
            // 
            // frm_Add_New_Student
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1102, 731);
            this.Controls.Add(this.btn_log_Out);
            this.Controls.Add(this.btn_View_All_Details);
            this.Controls.Add(this.btn_Refresh);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.cmb_City);
            this.Controls.Add(this.cmb_Course);
            this.Controls.Add(this.tb_MobNo);
            this.Controls.Add(this.tb_Name);
            this.Controls.Add(this.tb_ID);
            this.Controls.Add(this.lbl_City);
            this.Controls.Add(this.lbl_Course);
            this.Controls.Add(this.lbl_MobNo);
            this.Controls.Add(this.lbl_Name);
            this.Controls.Add(this.lbl_ID);
            this.Controls.Add(this.lbl_Header);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_Add_New_Student";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add New Student";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Header;
        private System.Windows.Forms.Label lbl_ID;
        private System.Windows.Forms.Label lbl_Name;
        private System.Windows.Forms.Label lbl_MobNo;
        private System.Windows.Forms.Label lbl_Course;
        private System.Windows.Forms.Label lbl_City;
        private System.Windows.Forms.TextBox tb_ID;
        private System.Windows.Forms.TextBox tb_Name;
        private System.Windows.Forms.TextBox tb_MobNo;
        private System.Windows.Forms.ComboBox cmb_Course;
        private System.Windows.Forms.ComboBox cmb_City;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.Button btn_Refresh;
        private System.Windows.Forms.Button btn_View_All_Details;
        private System.Windows.Forms.Button btn_log_Out;
    }
}