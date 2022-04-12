namespace Student_Management_System_V02
{
    partial class frm_Search_Student_By_Course
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
            this.lbl_Header = new System.Windows.Forms.Label();
            this.lbl_Course = new System.Windows.Forms.Label();
            this.cmb_Course = new System.Windows.Forms.ComboBox();
            this.btn_Log_Out = new System.Windows.Forms.Button();
            this.btn_Add_New_Student = new System.Windows.Forms.Button();
            this.btn_Refresh = new System.Windows.Forms.Button();
            this.dgv_Search_Student_By_Course = new System.Windows.Forms.DataGridView();
            this.student_Management_System_DBDataSet1 = new Student_Management_System_V02.Student_Management_System_DBDataSet1();
            this.studentDetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.student_DetailsTableAdapter = new Student_Management_System_V02.Student_Management_System_DBDataSet1TableAdapters.Student_DetailsTableAdapter();
            this.rollNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.courseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_Search_Student = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Search_Student_By_Course)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.student_Management_System_DBDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentDetailsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_Header
            // 
            this.lbl_Header.AutoSize = true;
            this.lbl_Header.BackColor = System.Drawing.Color.MintCream;
            this.lbl_Header.Font = new System.Drawing.Font("Constantia", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Header.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.lbl_Header.Location = new System.Drawing.Point(184, 42);
            this.lbl_Header.Name = "lbl_Header";
            this.lbl_Header.Size = new System.Drawing.Size(401, 39);
            this.lbl_Header.TabIndex = 0;
            this.lbl_Header.Text = "Search Student By Course";
            // 
            // lbl_Course
            // 
            this.lbl_Course.AutoSize = true;
            this.lbl_Course.BackColor = System.Drawing.Color.LavenderBlush;
            this.lbl_Course.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Course.ForeColor = System.Drawing.Color.Indigo;
            this.lbl_Course.Location = new System.Drawing.Point(163, 124);
            this.lbl_Course.Name = "lbl_Course";
            this.lbl_Course.Size = new System.Drawing.Size(82, 25);
            this.lbl_Course.TabIndex = 0;
            this.lbl_Course.Text = "Course";
            // 
            // cmb_Course
            // 
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
            this.cmb_Course.Location = new System.Drawing.Point(278, 126);
            this.cmb_Course.Name = "cmb_Course";
            this.cmb_Course.Size = new System.Drawing.Size(222, 23);
            this.cmb_Course.TabIndex = 1;
            this.cmb_Course.SelectedIndexChanged += new System.EventHandler(this.cmb_Course_SelectedIndexChanged);
            // 
            // btn_Log_Out
            // 
            this.btn_Log_Out.BackColor = System.Drawing.Color.Black;
            this.btn_Log_Out.Font = new System.Drawing.Font("Constantia", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Log_Out.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_Log_Out.Location = new System.Drawing.Point(679, 12);
            this.btn_Log_Out.Name = "btn_Log_Out";
            this.btn_Log_Out.Size = new System.Drawing.Size(86, 32);
            this.btn_Log_Out.TabIndex = 5;
            this.btn_Log_Out.Text = "Log Out";
            this.btn_Log_Out.UseVisualStyleBackColor = false;
            this.btn_Log_Out.Click += new System.EventHandler(this.btn_Log_Out_Click);
            // 
            // btn_Add_New_Student
            // 
            this.btn_Add_New_Student.BackColor = System.Drawing.Color.Black;
            this.btn_Add_New_Student.Font = new System.Drawing.Font("Constantia", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Add_New_Student.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_Add_New_Student.Location = new System.Drawing.Point(446, 409);
            this.btn_Add_New_Student.Name = "btn_Add_New_Student";
            this.btn_Add_New_Student.Size = new System.Drawing.Size(210, 39);
            this.btn_Add_New_Student.TabIndex = 4;
            this.btn_Add_New_Student.Text = "Add New Student";
            this.btn_Add_New_Student.UseVisualStyleBackColor = false;
            this.btn_Add_New_Student.Click += new System.EventHandler(this.btn_Add_New_Student_Click);
            // 
            // btn_Refresh
            // 
            this.btn_Refresh.BackColor = System.Drawing.Color.Black;
            this.btn_Refresh.Font = new System.Drawing.Font("Constantia", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Refresh.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_Refresh.Location = new System.Drawing.Point(556, 115);
            this.btn_Refresh.Name = "btn_Refresh";
            this.btn_Refresh.Size = new System.Drawing.Size(117, 39);
            this.btn_Refresh.TabIndex = 2;
            this.btn_Refresh.Text = "Refresh";
            this.btn_Refresh.UseVisualStyleBackColor = false;
            this.btn_Refresh.Click += new System.EventHandler(this.btn_Refresh_Click);
            // 
            // dgv_Search_Student_By_Course
            // 
            this.dgv_Search_Student_By_Course.AllowUserToAddRows = false;
            this.dgv_Search_Student_By_Course.AllowUserToDeleteRows = false;
            this.dgv_Search_Student_By_Course.AutoGenerateColumns = false;
            this.dgv_Search_Student_By_Course.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Search_Student_By_Course.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Search_Student_By_Course.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.rollNoDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.courseDataGridViewTextBoxColumn,
            this.cityDataGridViewTextBoxColumn});
            this.dgv_Search_Student_By_Course.DataSource = this.studentDetailsBindingSource;
            this.dgv_Search_Student_By_Course.Location = new System.Drawing.Point(0, 186);
            this.dgv_Search_Student_By_Course.Name = "dgv_Search_Student_By_Course";
            this.dgv_Search_Student_By_Course.ReadOnly = true;
            this.dgv_Search_Student_By_Course.Size = new System.Drawing.Size(781, 183);
            this.dgv_Search_Student_By_Course.TabIndex = 10;
            // 
            // student_Management_System_DBDataSet1
            // 
            this.student_Management_System_DBDataSet1.DataSetName = "Student_Management_System_DBDataSet1";
            this.student_Management_System_DBDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // studentDetailsBindingSource
            // 
            this.studentDetailsBindingSource.DataMember = "Student_Details";
            this.studentDetailsBindingSource.DataSource = this.student_Management_System_DBDataSet1;
            // 
            // student_DetailsTableAdapter
            // 
            this.student_DetailsTableAdapter.ClearBeforeFill = true;
            // 
            // rollNoDataGridViewTextBoxColumn
            // 
            this.rollNoDataGridViewTextBoxColumn.DataPropertyName = "Roll_No";
            this.rollNoDataGridViewTextBoxColumn.HeaderText = "Roll_No";
            this.rollNoDataGridViewTextBoxColumn.Name = "rollNoDataGridViewTextBoxColumn";
            this.rollNoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
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
            // btn_Search_Student
            // 
            this.btn_Search_Student.BackColor = System.Drawing.Color.Black;
            this.btn_Search_Student.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Search_Student.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_Search_Student.Location = new System.Drawing.Point(78, 409);
            this.btn_Search_Student.Name = "btn_Search_Student";
            this.btn_Search_Student.Size = new System.Drawing.Size(182, 39);
            this.btn_Search_Student.TabIndex = 3;
            this.btn_Search_Student.Text = "Search Student";
            this.btn_Search_Student.UseVisualStyleBackColor = false;
            this.btn_Search_Student.Click += new System.EventHandler(this.btn_Search_Student_Click);
            // 
            // frm_Search_Student_By_Course
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateGray;
            this.ClientSize = new System.Drawing.Size(777, 481);
            this.Controls.Add(this.btn_Search_Student);
            this.Controls.Add(this.dgv_Search_Student_By_Course);
            this.Controls.Add(this.btn_Refresh);
            this.Controls.Add(this.btn_Add_New_Student);
            this.Controls.Add(this.btn_Log_Out);
            this.Controls.Add(this.cmb_Course);
            this.Controls.Add(this.lbl_Course);
            this.Controls.Add(this.lbl_Header);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_Search_Student_By_Course";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_Search_Student_By_Course";
            this.Load += new System.EventHandler(this.frm_Search_Student_By_Course_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Search_Student_By_Course)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.student_Management_System_DBDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentDetailsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Header;
        private System.Windows.Forms.Label lbl_Course;
        private System.Windows.Forms.ComboBox cmb_Course;
        private System.Windows.Forms.Button btn_Log_Out;
        private System.Windows.Forms.Button btn_Add_New_Student;
        private System.Windows.Forms.Button btn_Refresh;
        private System.Windows.Forms.DataGridView dgv_Search_Student_By_Course;
        private Student_Management_System_DBDataSet1 student_Management_System_DBDataSet1;
        private System.Windows.Forms.BindingSource studentDetailsBindingSource;
        private Student_Management_System_DBDataSet1TableAdapters.Student_DetailsTableAdapter student_DetailsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn rollNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn courseDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cityDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btn_Search_Student;
    }
}