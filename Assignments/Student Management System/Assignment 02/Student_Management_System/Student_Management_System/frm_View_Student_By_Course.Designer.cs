namespace Student_Management_System
{
    partial class frm_View_Student_By_Course
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
            this.components = new System.ComponentModel.Container();
            this.lbl_View_Student_By_Course = new System.Windows.Forms.Label();
            this.lbl_Course = new System.Windows.Forms.Label();
            this.btn_Refresh = new System.Windows.Forms.Button();
            this.cmb_Course = new System.Windows.Forms.ComboBox();
            this.dgv_View_Student_By_Course = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mobNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.courseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentDetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.student_Management_System_DBDataSet1 = new Student_Management_System.Student_Management_System_DBDataSet1();
            this.student_DetailsTableAdapter = new Student_Management_System.Student_Management_System_DBDataSet1TableAdapters.Student_DetailsTableAdapter();
            this.btn_log_Out = new System.Windows.Forms.Button();
            this.btn_Add_New_Student = new System.Windows.Forms.Button();
            this.btn_Search_Student_By_ID = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_View_Student_By_Course)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentDetailsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.student_Management_System_DBDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_View_Student_By_Course
            // 
            this.lbl_View_Student_By_Course.AutoSize = true;
            this.lbl_View_Student_By_Course.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lbl_View_Student_By_Course.Font = new System.Drawing.Font("Calisto MT", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_View_Student_By_Course.ForeColor = System.Drawing.Color.Red;
            this.lbl_View_Student_By_Course.Location = new System.Drawing.Point(236, 30);
            this.lbl_View_Student_By_Course.Name = "lbl_View_Student_By_Course";
            this.lbl_View_Student_By_Course.Size = new System.Drawing.Size(683, 67);
            this.lbl_View_Student_By_Course.TabIndex = 0;
            this.lbl_View_Student_By_Course.Text = "View Student By Course";
            // 
            // lbl_Course
            // 
            this.lbl_Course.AutoSize = true;
            this.lbl_Course.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lbl_Course.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Course.ForeColor = System.Drawing.Color.SpringGreen;
            this.lbl_Course.Location = new System.Drawing.Point(216, 157);
            this.lbl_Course.Name = "lbl_Course";
            this.lbl_Course.Size = new System.Drawing.Size(85, 31);
            this.lbl_Course.TabIndex = 0;
            this.lbl_Course.Text = "Course";
            // 
            // btn_Refresh
            // 
            this.btn_Refresh.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn_Refresh.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Refresh.ForeColor = System.Drawing.Color.Aqua;
            this.btn_Refresh.Location = new System.Drawing.Point(690, 144);
            this.btn_Refresh.Name = "btn_Refresh";
            this.btn_Refresh.Size = new System.Drawing.Size(131, 50);
            this.btn_Refresh.TabIndex = 2;
            this.btn_Refresh.Text = "Refresh";
            this.btn_Refresh.UseVisualStyleBackColor = false;
            this.btn_Refresh.Click += new System.EventHandler(this.btn_Refresh_Click);
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
            this.cmb_Course.Location = new System.Drawing.Point(375, 156);
            this.cmb_Course.Name = "cmb_Course";
            this.cmb_Course.Size = new System.Drawing.Size(230, 32);
            this.cmb_Course.TabIndex = 1;
            this.cmb_Course.SelectedIndexChanged += new System.EventHandler(this.cmb_Course_SelectedIndexChanged);
            // 
            // dgv_View_Student_By_Course
            // 
            this.dgv_View_Student_By_Course.AllowUserToAddRows = false;
            this.dgv_View_Student_By_Course.AllowUserToDeleteRows = false;
            this.dgv_View_Student_By_Course.AutoGenerateColumns = false;
            this.dgv_View_Student_By_Course.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_View_Student_By_Course.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_View_Student_By_Course.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.mobNoDataGridViewTextBoxColumn,
            this.courseDataGridViewTextBoxColumn,
            this.cityDataGridViewTextBoxColumn});
            this.dgv_View_Student_By_Course.DataSource = this.studentDetailsBindingSource;
            this.dgv_View_Student_By_Course.Location = new System.Drawing.Point(92, 241);
            this.dgv_View_Student_By_Course.Name = "dgv_View_Student_By_Course";
            this.dgv_View_Student_By_Course.ReadOnly = true;
            this.dgv_View_Student_By_Course.RowTemplate.Height = 24;
            this.dgv_View_Student_By_Course.Size = new System.Drawing.Size(938, 365);
            this.dgv_View_Student_By_Course.TabIndex = 3;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // mobNoDataGridViewTextBoxColumn
            // 
            this.mobNoDataGridViewTextBoxColumn.DataPropertyName = "Mob_No";
            this.mobNoDataGridViewTextBoxColumn.HeaderText = "Mob_No";
            this.mobNoDataGridViewTextBoxColumn.Name = "mobNoDataGridViewTextBoxColumn";
            this.mobNoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // courseDataGridViewTextBoxColumn
            // 
            this.courseDataGridViewTextBoxColumn.DataPropertyName = "Course";
            this.courseDataGridViewTextBoxColumn.HeaderText = "Course";
            this.courseDataGridViewTextBoxColumn.Name = "courseDataGridViewTextBoxColumn";
            this.courseDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cityDataGridViewTextBoxColumn
            // 
            this.cityDataGridViewTextBoxColumn.DataPropertyName = "City";
            this.cityDataGridViewTextBoxColumn.HeaderText = "City";
            this.cityDataGridViewTextBoxColumn.Name = "cityDataGridViewTextBoxColumn";
            this.cityDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // studentDetailsBindingSource
            // 
            this.studentDetailsBindingSource.DataMember = "Student_Details";
            this.studentDetailsBindingSource.DataSource = this.student_Management_System_DBDataSet1;
            // 
            // student_Management_System_DBDataSet1
            // 
            this.student_Management_System_DBDataSet1.DataSetName = "Student_Management_System_DBDataSet1";
            this.student_Management_System_DBDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // student_DetailsTableAdapter
            // 
            this.student_DetailsTableAdapter.ClearBeforeFill = true;
            // 
            // btn_log_Out
            // 
            this.btn_log_Out.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_log_Out.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_log_Out.Location = new System.Drawing.Point(1091, 12);
            this.btn_log_Out.Name = "btn_log_Out";
            this.btn_log_Out.Size = new System.Drawing.Size(97, 40);
            this.btn_log_Out.TabIndex = 5;
            this.btn_log_Out.Text = "Log Out";
            this.btn_log_Out.UseVisualStyleBackColor = true;
            this.btn_log_Out.Click += new System.EventHandler(this.btn_log_Out_Click);
            // 
            // btn_Add_New_Student
            // 
            this.btn_Add_New_Student.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn_Add_New_Student.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Add_New_Student.ForeColor = System.Drawing.Color.Aqua;
            this.btn_Add_New_Student.Location = new System.Drawing.Point(148, 652);
            this.btn_Add_New_Student.Name = "btn_Add_New_Student";
            this.btn_Add_New_Student.Size = new System.Drawing.Size(278, 55);
            this.btn_Add_New_Student.TabIndex = 3;
            this.btn_Add_New_Student.Text = "Add New Student";
            this.btn_Add_New_Student.UseVisualStyleBackColor = false;
            this.btn_Add_New_Student.Click += new System.EventHandler(this.btn_Add_New_Student_Click);
            // 
            // btn_Search_Student_By_ID
            // 
            this.btn_Search_Student_By_ID.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn_Search_Student_By_ID.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Search_Student_By_ID.ForeColor = System.Drawing.Color.Aqua;
            this.btn_Search_Student_By_ID.Location = new System.Drawing.Point(590, 653);
            this.btn_Search_Student_By_ID.Name = "btn_Search_Student_By_ID";
            this.btn_Search_Student_By_ID.Size = new System.Drawing.Size(335, 52);
            this.btn_Search_Student_By_ID.TabIndex = 4;
            this.btn_Search_Student_By_ID.Text = "Search Student By ID";
            this.btn_Search_Student_By_ID.UseVisualStyleBackColor = false;
            this.btn_Search_Student_By_ID.Click += new System.EventHandler(this.btn_Search_Student_By_ID_Click);
            // 
            // frm_View_Student_By_Course
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1215, 751);
            this.Controls.Add(this.btn_Search_Student_By_ID);
            this.Controls.Add(this.btn_Add_New_Student);
            this.Controls.Add(this.btn_log_Out);
            this.Controls.Add(this.dgv_View_Student_By_Course);
            this.Controls.Add(this.cmb_Course);
            this.Controls.Add(this.btn_Refresh);
            this.Controls.Add(this.lbl_Course);
            this.Controls.Add(this.lbl_View_Student_By_Course);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_View_Student_By_Course";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "View Student By Course";
            this.Load += new System.EventHandler(this.frm_View_Student_By_Course_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_View_Student_By_Course)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentDetailsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.student_Management_System_DBDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_View_Student_By_Course;
        private System.Windows.Forms.Label lbl_Course;
        private System.Windows.Forms.Button btn_Refresh;
        private System.Windows.Forms.ComboBox cmb_Course;
        private System.Windows.Forms.DataGridView dgv_View_Student_By_Course;
        private Student_Management_System_DBDataSet1 student_Management_System_DBDataSet1;
        private System.Windows.Forms.BindingSource studentDetailsBindingSource;
        private Student_Management_System_DBDataSet1TableAdapters.Student_DetailsTableAdapter student_DetailsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mobNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn courseDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cityDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btn_log_Out;
        private System.Windows.Forms.Button btn_Add_New_Student;
        private System.Windows.Forms.Button btn_Search_Student_By_ID;

    }
}