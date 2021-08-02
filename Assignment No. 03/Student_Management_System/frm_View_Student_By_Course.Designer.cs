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
            this.lbl_Header = new System.Windows.Forms.Label();
            this.lbl_Course = new System.Windows.Forms.Label();
            this.cmb_Course = new System.Windows.Forms.ComboBox();
            this.btn_Refresh = new System.Windows.Forms.Button();
            this.dgv_View_Student_By_Course = new System.Windows.Forms.DataGridView();
            this.rollNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dOBDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.courseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentDetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.student_Management_System_DBDataSet3 = new Student_Management_System.Student_Management_System_DBDataSet3();
            this.btn_Back = new System.Windows.Forms.Button();
            this.btn_Log_Out = new System.Windows.Forms.Button();
            this.student_DetailsTableAdapter = new Student_Management_System.Student_Management_System_DBDataSet3TableAdapters.Student_DetailsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_View_Student_By_Course)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentDetailsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.student_Management_System_DBDataSet3)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_Header
            // 
            this.lbl_Header.AutoSize = true;
            this.lbl_Header.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lbl_Header.Font = new System.Drawing.Font("Candara", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Header.ForeColor = System.Drawing.Color.MediumSpringGreen;
            this.lbl_Header.Location = new System.Drawing.Point(171, 46);
            this.lbl_Header.Name = "lbl_Header";
            this.lbl_Header.Size = new System.Drawing.Size(378, 42);
            this.lbl_Header.TabIndex = 0;
            this.lbl_Header.Text = "View Student By Course";
            // 
            // lbl_Course
            // 
            this.lbl_Course.AutoSize = true;
            this.lbl_Course.BackColor = System.Drawing.Color.DarkGray;
            this.lbl_Course.Font = new System.Drawing.Font("Calisto MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Course.ForeColor = System.Drawing.Color.DarkRed;
            this.lbl_Course.Location = new System.Drawing.Point(127, 136);
            this.lbl_Course.Name = "lbl_Course";
            this.lbl_Course.Size = new System.Drawing.Size(72, 22);
            this.lbl_Course.TabIndex = 0;
            this.lbl_Course.Text = "Course";
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
            this.cmb_Course.Location = new System.Drawing.Point(252, 136);
            this.cmb_Course.Name = "cmb_Course";
            this.cmb_Course.Size = new System.Drawing.Size(185, 25);
            this.cmb_Course.TabIndex = 0;
            this.cmb_Course.SelectedIndexChanged += new System.EventHandler(this.cmb_Course_SelectedIndexChanged);
            // 
            // btn_Refresh
            // 
            this.btn_Refresh.BackColor = System.Drawing.Color.Black;
            this.btn_Refresh.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Refresh.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_Refresh.Location = new System.Drawing.Point(485, 130);
            this.btn_Refresh.Name = "btn_Refresh";
            this.btn_Refresh.Size = new System.Drawing.Size(101, 31);
            this.btn_Refresh.TabIndex = 1;
            this.btn_Refresh.Text = "Refresh";
            this.btn_Refresh.UseVisualStyleBackColor = false;
            this.btn_Refresh.Click += new System.EventHandler(this.btn_Refresh_Click);
            // 
            // dgv_View_Student_By_Course
            // 
            this.dgv_View_Student_By_Course.AllowUserToAddRows = false;
            this.dgv_View_Student_By_Course.AllowUserToDeleteRows = false;
            this.dgv_View_Student_By_Course.AutoGenerateColumns = false;
            this.dgv_View_Student_By_Course.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_View_Student_By_Course.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_View_Student_By_Course.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.rollNoDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.dOBDataGridViewTextBoxColumn,
            this.courseDataGridViewTextBoxColumn,
            this.cityDataGridViewTextBoxColumn});
            this.dgv_View_Student_By_Course.DataSource = this.studentDetailsBindingSource;
            this.dgv_View_Student_By_Course.Location = new System.Drawing.Point(-3, 191);
            this.dgv_View_Student_By_Course.Name = "dgv_View_Student_By_Course";
            this.dgv_View_Student_By_Course.ReadOnly = true;
            this.dgv_View_Student_By_Course.Size = new System.Drawing.Size(746, 199);
            this.dgv_View_Student_By_Course.TabIndex = 0;
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
            // dOBDataGridViewTextBoxColumn
            // 
            this.dOBDataGridViewTextBoxColumn.DataPropertyName = "DOB";
            this.dOBDataGridViewTextBoxColumn.HeaderText = "DOB";
            this.dOBDataGridViewTextBoxColumn.Name = "dOBDataGridViewTextBoxColumn";
            this.dOBDataGridViewTextBoxColumn.ReadOnly = true;
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
            this.studentDetailsBindingSource.DataSource = this.student_Management_System_DBDataSet3;
            // 
            // student_Management_System_DBDataSet3
            // 
            this.student_Management_System_DBDataSet3.DataSetName = "Student_Management_System_DBDataSet3";
            this.student_Management_System_DBDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btn_Back
            // 
            this.btn_Back.BackColor = System.Drawing.Color.Black;
            this.btn_Back.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Back.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_Back.Location = new System.Drawing.Point(297, 422);
            this.btn_Back.Name = "btn_Back";
            this.btn_Back.Size = new System.Drawing.Size(90, 36);
            this.btn_Back.TabIndex = 2;
            this.btn_Back.Text = "Back";
            this.btn_Back.UseVisualStyleBackColor = false;
            this.btn_Back.Click += new System.EventHandler(this.btn_Back_Click);
            // 
            // btn_Log_Out
            // 
            this.btn_Log_Out.BackColor = System.Drawing.Color.Black;
            this.btn_Log_Out.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Log_Out.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_Log_Out.Location = new System.Drawing.Point(653, 0);
            this.btn_Log_Out.Name = "btn_Log_Out";
            this.btn_Log_Out.Size = new System.Drawing.Size(80, 34);
            this.btn_Log_Out.TabIndex = 3;
            this.btn_Log_Out.Text = "Log Out";
            this.btn_Log_Out.UseVisualStyleBackColor = false;
            this.btn_Log_Out.Click += new System.EventHandler(this.btn_Log_Out_Click);
            // 
            // student_DetailsTableAdapter
            // 
            this.student_DetailsTableAdapter.ClearBeforeFill = true;
            // 
            // frm_View_Student_By_Course
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(745, 474);
            this.Controls.Add(this.btn_Log_Out);
            this.Controls.Add(this.btn_Back);
            this.Controls.Add(this.dgv_View_Student_By_Course);
            this.Controls.Add(this.btn_Refresh);
            this.Controls.Add(this.cmb_Course);
            this.Controls.Add(this.lbl_Course);
            this.Controls.Add(this.lbl_Header);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_View_Student_By_Course";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "View Student By Course";
            this.Load += new System.EventHandler(this.frm_View_Student_By_Course_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_View_Student_By_Course)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentDetailsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.student_Management_System_DBDataSet3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Header;
        private System.Windows.Forms.Label lbl_Course;
        private System.Windows.Forms.ComboBox cmb_Course;
        private System.Windows.Forms.Button btn_Refresh;
        private System.Windows.Forms.DataGridView dgv_View_Student_By_Course;
        private System.Windows.Forms.Button btn_Back;
        private System.Windows.Forms.Button btn_Log_Out;
        private Student_Management_System_DBDataSet3 student_Management_System_DBDataSet3;
        private System.Windows.Forms.BindingSource studentDetailsBindingSource;
        private Student_Management_System_DBDataSet3TableAdapters.Student_DetailsTableAdapter student_DetailsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn rollNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dOBDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn courseDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cityDataGridViewTextBoxColumn;
    }
}