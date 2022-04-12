namespace Student_Management_System
{
    partial class frm_Update_Student_Detail
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
            this.lbl_RNo = new System.Windows.Forms.Label();
            this.lbl_Name = new System.Windows.Forms.Label();
            this.lbl_DOB = new System.Windows.Forms.Label();
            this.lbl_Course = new System.Windows.Forms.Label();
            this.lbl_City = new System.Windows.Forms.Label();
            this.dtp_DOB = new System.Windows.Forms.DateTimePicker();
            this.tb_RNo = new System.Windows.Forms.TextBox();
            this.tb_Name = new System.Windows.Forms.TextBox();
            this.btn_Search = new System.Windows.Forms.Button();
            this.cmb_Course = new System.Windows.Forms.ComboBox();
            this.cmb_City = new System.Windows.Forms.ComboBox();
            this.btn_Update = new System.Windows.Forms.Button();
            this.btn_Refresh = new System.Windows.Forms.Button();
            this.btn_Back = new System.Windows.Forms.Button();
            this.btn_Log_Out = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_Header
            // 
            this.lbl_Header.AutoSize = true;
            this.lbl_Header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbl_Header.Font = new System.Drawing.Font("Candara", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Header.ForeColor = System.Drawing.Color.MediumSpringGreen;
            this.lbl_Header.Location = new System.Drawing.Point(164, 41);
            this.lbl_Header.Name = "lbl_Header";
            this.lbl_Header.Size = new System.Drawing.Size(352, 42);
            this.lbl_Header.TabIndex = 0;
            this.lbl_Header.Text = "Update Student Detail";
            // 
            // lbl_RNo
            // 
            this.lbl_RNo.AutoSize = true;
            this.lbl_RNo.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.lbl_RNo.Font = new System.Drawing.Font("Calisto MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_RNo.ForeColor = System.Drawing.Color.OrangeRed;
            this.lbl_RNo.Location = new System.Drawing.Point(64, 134);
            this.lbl_RNo.Name = "lbl_RNo";
            this.lbl_RNo.Size = new System.Drawing.Size(80, 22);
            this.lbl_RNo.TabIndex = 0;
            this.lbl_RNo.Text = "Roll No";
            // 
            // lbl_Name
            // 
            this.lbl_Name.AutoSize = true;
            this.lbl_Name.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.lbl_Name.Font = new System.Drawing.Font("Calisto MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Name.ForeColor = System.Drawing.Color.OrangeRed;
            this.lbl_Name.Location = new System.Drawing.Point(64, 182);
            this.lbl_Name.Name = "lbl_Name";
            this.lbl_Name.Size = new System.Drawing.Size(62, 22);
            this.lbl_Name.TabIndex = 0;
            this.lbl_Name.Text = "Name";
            // 
            // lbl_DOB
            // 
            this.lbl_DOB.AutoSize = true;
            this.lbl_DOB.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.lbl_DOB.Font = new System.Drawing.Font("Calisto MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_DOB.ForeColor = System.Drawing.Color.OrangeRed;
            this.lbl_DOB.Location = new System.Drawing.Point(64, 233);
            this.lbl_DOB.Name = "lbl_DOB";
            this.lbl_DOB.Size = new System.Drawing.Size(131, 22);
            this.lbl_DOB.TabIndex = 0;
            this.lbl_DOB.Text = "Date Of Birth";
            // 
            // lbl_Course
            // 
            this.lbl_Course.AutoSize = true;
            this.lbl_Course.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.lbl_Course.Font = new System.Drawing.Font("Calisto MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Course.ForeColor = System.Drawing.Color.OrangeRed;
            this.lbl_Course.Location = new System.Drawing.Point(64, 285);
            this.lbl_Course.Name = "lbl_Course";
            this.lbl_Course.Size = new System.Drawing.Size(72, 22);
            this.lbl_Course.TabIndex = 0;
            this.lbl_Course.Text = "Course";
            // 
            // lbl_City
            // 
            this.lbl_City.AutoSize = true;
            this.lbl_City.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.lbl_City.Font = new System.Drawing.Font("Calisto MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_City.ForeColor = System.Drawing.Color.OrangeRed;
            this.lbl_City.Location = new System.Drawing.Point(64, 337);
            this.lbl_City.Name = "lbl_City";
            this.lbl_City.Size = new System.Drawing.Size(47, 22);
            this.lbl_City.TabIndex = 0;
            this.lbl_City.Text = "City";
            // 
            // dtp_DOB
            // 
            this.dtp_DOB.Font = new System.Drawing.Font("Calisto MT", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_DOB.Location = new System.Drawing.Point(305, 234);
            this.dtp_DOB.Name = "dtp_DOB";
            this.dtp_DOB.Size = new System.Drawing.Size(200, 23);
            this.dtp_DOB.TabIndex = 4;
            // 
            // tb_RNo
            // 
            this.tb_RNo.Font = new System.Drawing.Font("Calisto MT", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_RNo.Location = new System.Drawing.Point(305, 134);
            this.tb_RNo.Name = "tb_RNo";
            this.tb_RNo.Size = new System.Drawing.Size(200, 23);
            this.tb_RNo.TabIndex = 1;
            // 
            // tb_Name
            // 
            this.tb_Name.Font = new System.Drawing.Font("Calisto MT", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Name.Location = new System.Drawing.Point(305, 183);
            this.tb_Name.Name = "tb_Name";
            this.tb_Name.Size = new System.Drawing.Size(200, 23);
            this.tb_Name.TabIndex = 3;
            // 
            // btn_Search
            // 
            this.btn_Search.BackColor = System.Drawing.Color.Black;
            this.btn_Search.Font = new System.Drawing.Font("Calisto MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Search.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_Search.Location = new System.Drawing.Point(562, 126);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(95, 38);
            this.btn_Search.TabIndex = 2;
            this.btn_Search.Text = "Search";
            this.btn_Search.UseVisualStyleBackColor = false;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // cmb_Course
            // 
            this.cmb_Course.Font = new System.Drawing.Font("Calisto MT", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Course.FormattingEnabled = true;
            this.cmb_Course.Items.AddRange(new object[] {
            "BSC",
            "BCA",
            "BCS",
            "BBA",
            "BA",
            "MA",
            "MSC",
            "MCA",
            "MBA"});
            this.cmb_Course.Location = new System.Drawing.Point(305, 285);
            this.cmb_Course.Name = "cmb_Course";
            this.cmb_Course.Size = new System.Drawing.Size(200, 25);
            this.cmb_Course.TabIndex = 5;
            // 
            // cmb_City
            // 
            this.cmb_City.Font = new System.Drawing.Font("Calisto MT", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_City.FormattingEnabled = true;
            this.cmb_City.Items.AddRange(new object[] {
            "Sangli",
            "Karad",
            "Satara",
            "Pune",
            "Mumbai",
            "Aurangabad",
            "Nashik",
            "Solapur",
            "Kolhapur"});
            this.cmb_City.Location = new System.Drawing.Point(305, 337);
            this.cmb_City.Name = "cmb_City";
            this.cmb_City.Size = new System.Drawing.Size(200, 25);
            this.cmb_City.TabIndex = 6;
            // 
            // btn_Update
            // 
            this.btn_Update.BackColor = System.Drawing.Color.Black;
            this.btn_Update.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Update.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_Update.Location = new System.Drawing.Point(68, 406);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(111, 43);
            this.btn_Update.TabIndex = 7;
            this.btn_Update.Text = "Update";
            this.btn_Update.UseVisualStyleBackColor = false;
            this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click);
            // 
            // btn_Refresh
            // 
            this.btn_Refresh.BackColor = System.Drawing.Color.Black;
            this.btn_Refresh.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Refresh.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_Refresh.Location = new System.Drawing.Point(288, 406);
            this.btn_Refresh.Name = "btn_Refresh";
            this.btn_Refresh.Size = new System.Drawing.Size(105, 43);
            this.btn_Refresh.TabIndex = 8;
            this.btn_Refresh.Text = "Refresh";
            this.btn_Refresh.UseVisualStyleBackColor = false;
            this.btn_Refresh.Click += new System.EventHandler(this.btn_Refresh_Click);
            // 
            // btn_Back
            // 
            this.btn_Back.BackColor = System.Drawing.Color.Black;
            this.btn_Back.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Back.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_Back.Location = new System.Drawing.Point(505, 406);
            this.btn_Back.Name = "btn_Back";
            this.btn_Back.Size = new System.Drawing.Size(117, 43);
            this.btn_Back.TabIndex = 9;
            this.btn_Back.Text = "Back";
            this.btn_Back.UseVisualStyleBackColor = false;
            this.btn_Back.Click += new System.EventHandler(this.btn_Back_Click);
            // 
            // btn_Log_Out
            // 
            this.btn_Log_Out.BackColor = System.Drawing.Color.Black;
            this.btn_Log_Out.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Log_Out.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_Log_Out.Location = new System.Drawing.Point(628, 13);
            this.btn_Log_Out.Name = "btn_Log_Out";
            this.btn_Log_Out.Size = new System.Drawing.Size(75, 32);
            this.btn_Log_Out.TabIndex = 10;
            this.btn_Log_Out.Text = "Log Out";
            this.btn_Log_Out.UseVisualStyleBackColor = false;
            this.btn_Log_Out.Click += new System.EventHandler(this.btn_Log_Out_Click);
            // 
            // frm_Update_Student_Detail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(716, 470);
            this.Controls.Add(this.btn_Log_Out);
            this.Controls.Add(this.btn_Back);
            this.Controls.Add(this.btn_Refresh);
            this.Controls.Add(this.btn_Update);
            this.Controls.Add(this.cmb_City);
            this.Controls.Add(this.cmb_Course);
            this.Controls.Add(this.btn_Search);
            this.Controls.Add(this.tb_Name);
            this.Controls.Add(this.tb_RNo);
            this.Controls.Add(this.dtp_DOB);
            this.Controls.Add(this.lbl_City);
            this.Controls.Add(this.lbl_Course);
            this.Controls.Add(this.lbl_DOB);
            this.Controls.Add(this.lbl_Name);
            this.Controls.Add(this.lbl_RNo);
            this.Controls.Add(this.lbl_Header);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_Update_Student_Detail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Update Student Detail";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Header;
        private System.Windows.Forms.Label lbl_RNo;
        private System.Windows.Forms.Label lbl_Name;
        private System.Windows.Forms.Label lbl_DOB;
        private System.Windows.Forms.Label lbl_Course;
        private System.Windows.Forms.Label lbl_City;
        private System.Windows.Forms.DateTimePicker dtp_DOB;
        private System.Windows.Forms.TextBox tb_RNo;
        private System.Windows.Forms.TextBox tb_Name;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.ComboBox cmb_Course;
        private System.Windows.Forms.ComboBox cmb_City;
        private System.Windows.Forms.Button btn_Update;
        private System.Windows.Forms.Button btn_Refresh;
        private System.Windows.Forms.Button btn_Back;
        private System.Windows.Forms.Button btn_Log_Out;
    }
}