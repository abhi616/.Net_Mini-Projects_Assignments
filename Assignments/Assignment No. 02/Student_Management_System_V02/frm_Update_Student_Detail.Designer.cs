namespace Student_Management_System_V02
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
            this.tb_Rno = new System.Windows.Forms.TextBox();
            this.tb_Name = new System.Windows.Forms.TextBox();
            this.dtp_DOB = new System.Windows.Forms.DateTimePicker();
            this.cmb_Course = new System.Windows.Forms.ComboBox();
            this.cmb_City = new System.Windows.Forms.ComboBox();
            this.byn_Log_Out = new System.Windows.Forms.Button();
            this.btn_Search = new System.Windows.Forms.Button();
            this.btn_Update = new System.Windows.Forms.Button();
            this.btn_Add_New_Student = new System.Windows.Forms.Button();
            this.btn_View_All_Students = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_Header
            // 
            this.lbl_Header.AutoSize = true;
            this.lbl_Header.BackColor = System.Drawing.Color.MintCream;
            this.lbl_Header.Font = new System.Drawing.Font("Constantia", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Header.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.lbl_Header.Location = new System.Drawing.Point(155, 36);
            this.lbl_Header.Name = "lbl_Header";
            this.lbl_Header.Size = new System.Drawing.Size(387, 42);
            this.lbl_Header.TabIndex = 0;
            this.lbl_Header.Text = "Update Student Detail";
            // 
            // lbl_RNo
            // 
            this.lbl_RNo.AutoSize = true;
            this.lbl_RNo.BackColor = System.Drawing.Color.Azure;
            this.lbl_RNo.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_RNo.Location = new System.Drawing.Point(50, 131);
            this.lbl_RNo.Name = "lbl_RNo";
            this.lbl_RNo.Size = new System.Drawing.Size(78, 21);
            this.lbl_RNo.TabIndex = 0;
            this.lbl_RNo.Text = "Roll No";
            // 
            // lbl_Name
            // 
            this.lbl_Name.AutoSize = true;
            this.lbl_Name.BackColor = System.Drawing.Color.Azure;
            this.lbl_Name.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Name.Location = new System.Drawing.Point(50, 185);
            this.lbl_Name.Name = "lbl_Name";
            this.lbl_Name.Size = new System.Drawing.Size(58, 21);
            this.lbl_Name.TabIndex = 0;
            this.lbl_Name.Text = "Name";
            // 
            // lbl_DOB
            // 
            this.lbl_DOB.AutoSize = true;
            this.lbl_DOB.BackColor = System.Drawing.Color.Azure;
            this.lbl_DOB.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_DOB.Location = new System.Drawing.Point(50, 239);
            this.lbl_DOB.Name = "lbl_DOB";
            this.lbl_DOB.Size = new System.Drawing.Size(133, 21);
            this.lbl_DOB.TabIndex = 3;
            this.lbl_DOB.Text = "Date Of Birth";
            // 
            // lbl_Course
            // 
            this.lbl_Course.AutoSize = true;
            this.lbl_Course.BackColor = System.Drawing.Color.Azure;
            this.lbl_Course.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Course.Location = new System.Drawing.Point(50, 294);
            this.lbl_Course.Name = "lbl_Course";
            this.lbl_Course.Size = new System.Drawing.Size(67, 21);
            this.lbl_Course.TabIndex = 0;
            this.lbl_Course.Text = "Course";
            // 
            // lbl_City
            // 
            this.lbl_City.AutoSize = true;
            this.lbl_City.BackColor = System.Drawing.Color.Azure;
            this.lbl_City.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_City.Location = new System.Drawing.Point(50, 352);
            this.lbl_City.Name = "lbl_City";
            this.lbl_City.Size = new System.Drawing.Size(45, 21);
            this.lbl_City.TabIndex = 5;
            this.lbl_City.Text = "City";
            // 
            // tb_Rno
            // 
            this.tb_Rno.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Rno.Location = new System.Drawing.Point(308, 122);
            this.tb_Rno.Name = "tb_Rno";
            this.tb_Rno.Size = new System.Drawing.Size(223, 21);
            this.tb_Rno.TabIndex = 1;
            // 
            // tb_Name
            // 
            this.tb_Name.Enabled = false;
            this.tb_Name.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Name.Location = new System.Drawing.Point(308, 185);
            this.tb_Name.Name = "tb_Name";
            this.tb_Name.Size = new System.Drawing.Size(223, 21);
            this.tb_Name.TabIndex = 3;
            // 
            // dtp_DOB
            // 
            this.dtp_DOB.Enabled = false;
            this.dtp_DOB.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_DOB.Location = new System.Drawing.Point(308, 239);
            this.dtp_DOB.Name = "dtp_DOB";
            this.dtp_DOB.Size = new System.Drawing.Size(223, 21);
            this.dtp_DOB.TabIndex = 4;
            // 
            // cmb_Course
            // 
            this.cmb_Course.Enabled = false;
            this.cmb_Course.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.cmb_Course.Location = new System.Drawing.Point(308, 293);
            this.cmb_Course.Name = "cmb_Course";
            this.cmb_Course.Size = new System.Drawing.Size(223, 23);
            this.cmb_Course.TabIndex = 5;
            // 
            // cmb_City
            // 
            this.cmb_City.Enabled = false;
            this.cmb_City.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_City.FormattingEnabled = true;
            this.cmb_City.Items.AddRange(new object[] {
            "Sangli",
            "Karad",
            "Satara",
            "Pune",
            "Kolhapur",
            "Solapur",
            "Aurangabad",
            "Mumbai"});
            this.cmb_City.Location = new System.Drawing.Point(308, 355);
            this.cmb_City.Name = "cmb_City";
            this.cmb_City.Size = new System.Drawing.Size(223, 23);
            this.cmb_City.TabIndex = 6;
            // 
            // byn_Log_Out
            // 
            this.byn_Log_Out.BackColor = System.Drawing.Color.Black;
            this.byn_Log_Out.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.byn_Log_Out.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.byn_Log_Out.Location = new System.Drawing.Point(630, 12);
            this.byn_Log_Out.Name = "byn_Log_Out";
            this.byn_Log_Out.Size = new System.Drawing.Size(99, 34);
            this.byn_Log_Out.TabIndex = 9;
            this.byn_Log_Out.Text = "Log Out";
            this.byn_Log_Out.UseVisualStyleBackColor = false;
            this.byn_Log_Out.Click += new System.EventHandler(this.byn_Log_Out_Click);
            // 
            // btn_Search
            // 
            this.btn_Search.BackColor = System.Drawing.Color.Black;
            this.btn_Search.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Search.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_Search.Location = new System.Drawing.Point(572, 116);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(97, 33);
            this.btn_Search.TabIndex = 2;
            this.btn_Search.Text = "Search";
            this.btn_Search.UseVisualStyleBackColor = false;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // btn_Update
            // 
            this.btn_Update.BackColor = System.Drawing.Color.Black;
            this.btn_Update.Font = new System.Drawing.Font("Constantia", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Update.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_Update.Location = new System.Drawing.Point(76, 428);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(107, 34);
            this.btn_Update.TabIndex = 7;
            this.btn_Update.Text = "Update";
            this.btn_Update.UseVisualStyleBackColor = false;
            this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click);
            // 
            // btn_Add_New_Student
            // 
            this.btn_Add_New_Student.BackColor = System.Drawing.Color.Black;
            this.btn_Add_New_Student.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Add_New_Student.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_Add_New_Student.Location = new System.Drawing.Point(495, 428);
            this.btn_Add_New_Student.Name = "btn_Add_New_Student";
            this.btn_Add_New_Student.Size = new System.Drawing.Size(204, 34);
            this.btn_Add_New_Student.TabIndex = 8;
            this.btn_Add_New_Student.Text = "Add New Student";
            this.btn_Add_New_Student.UseVisualStyleBackColor = false;
            this.btn_Add_New_Student.Click += new System.EventHandler(this.btn_Add_New_Student_Click);
            // 
            // btn_View_All_Students
            // 
            this.btn_View_All_Students.BackColor = System.Drawing.Color.Black;
            this.btn_View_All_Students.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_View_All_Students.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_View_All_Students.Location = new System.Drawing.Point(246, 428);
            this.btn_View_All_Students.Name = "btn_View_All_Students";
            this.btn_View_All_Students.Size = new System.Drawing.Size(208, 34);
            this.btn_View_All_Students.TabIndex = 8;
            this.btn_View_All_Students.Text = "View All Students";
            this.btn_View_All_Students.UseVisualStyleBackColor = false;
            this.btn_View_All_Students.Click += new System.EventHandler(this.btn_View_All_Students_Click);
            // 
            // frm_Update_Student_Detail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateGray;
            this.ClientSize = new System.Drawing.Size(741, 488);
            this.Controls.Add(this.btn_View_All_Students);
            this.Controls.Add(this.btn_Add_New_Student);
            this.Controls.Add(this.btn_Update);
            this.Controls.Add(this.btn_Search);
            this.Controls.Add(this.byn_Log_Out);
            this.Controls.Add(this.cmb_City);
            this.Controls.Add(this.cmb_Course);
            this.Controls.Add(this.dtp_DOB);
            this.Controls.Add(this.tb_Name);
            this.Controls.Add(this.tb_Rno);
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
        private System.Windows.Forms.TextBox tb_Rno;
        private System.Windows.Forms.TextBox tb_Name;
        private System.Windows.Forms.DateTimePicker dtp_DOB;
        private System.Windows.Forms.ComboBox cmb_Course;
        private System.Windows.Forms.ComboBox cmb_City;
        private System.Windows.Forms.Button byn_Log_Out;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.Button btn_Update;
        private System.Windows.Forms.Button btn_Add_New_Student;
        private System.Windows.Forms.Button btn_View_All_Students;
    }
}