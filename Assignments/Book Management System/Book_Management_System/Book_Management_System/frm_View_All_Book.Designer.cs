namespace Book_Management_System
{
    partial class frm_View_All_Book
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
            this.dgv_View_All_Book = new System.Windows.Forms.DataGridView();
            this.book_Management_System_DBDataSet = new Book_Management_System.Book_Management_System_DBDataSet();
            this.bookDetailBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.book_DetailTableAdapter = new Book_Management_System.Book_Management_System_DBDataSetTableAdapters.Book_DetailTableAdapter();
            this.bIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bAuthorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bCategoryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bPublishDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_View_All_Book)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.book_Management_System_DBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookDetailBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_Header
            // 
            this.lbl_Header.AutoSize = true;
            this.lbl_Header.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_Header.Font = new System.Drawing.Font("Century Schoolbook", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Header.ForeColor = System.Drawing.Color.DarkMagenta;
            this.lbl_Header.Location = new System.Drawing.Point(734, 70);
            this.lbl_Header.Name = "lbl_Header";
            this.lbl_Header.Size = new System.Drawing.Size(468, 71);
            this.lbl_Header.TabIndex = 0;
            this.lbl_Header.Text = "View All Book";
            // 
            // dgv_View_All_Book
            // 
            this.dgv_View_All_Book.AllowUserToAddRows = false;
            this.dgv_View_All_Book.AllowUserToDeleteRows = false;
            this.dgv_View_All_Book.AutoGenerateColumns = false;
            this.dgv_View_All_Book.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_View_All_Book.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_View_All_Book.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.bIDDataGridViewTextBoxColumn,
            this.bNameDataGridViewTextBoxColumn,
            this.bAuthorDataGridViewTextBoxColumn,
            this.bCategoryDataGridViewTextBoxColumn,
            this.bPublishDateDataGridViewTextBoxColumn});
            this.dgv_View_All_Book.DataSource = this.bookDetailBindingSource;
            this.dgv_View_All_Book.Location = new System.Drawing.Point(345, 220);
            this.dgv_View_All_Book.Name = "dgv_View_All_Book";
            this.dgv_View_All_Book.ReadOnly = true;
            this.dgv_View_All_Book.RowTemplate.Height = 24;
            this.dgv_View_All_Book.Size = new System.Drawing.Size(1277, 582);
            this.dgv_View_All_Book.TabIndex = 0;
            // 
            // book_Management_System_DBDataSet
            // 
            this.book_Management_System_DBDataSet.DataSetName = "Book_Management_System_DBDataSet";
            this.book_Management_System_DBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bookDetailBindingSource
            // 
            this.bookDetailBindingSource.DataMember = "Book_Detail";
            this.bookDetailBindingSource.DataSource = this.book_Management_System_DBDataSet;
            // 
            // book_DetailTableAdapter
            // 
            this.book_DetailTableAdapter.ClearBeforeFill = true;
            // 
            // bIDDataGridViewTextBoxColumn
            // 
            this.bIDDataGridViewTextBoxColumn.DataPropertyName = "B_ID";
            this.bIDDataGridViewTextBoxColumn.HeaderText = "Book ID";
            this.bIDDataGridViewTextBoxColumn.Name = "bIDDataGridViewTextBoxColumn";
            this.bIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bNameDataGridViewTextBoxColumn
            // 
            this.bNameDataGridViewTextBoxColumn.DataPropertyName = "B_Name";
            this.bNameDataGridViewTextBoxColumn.HeaderText = "Book Name";
            this.bNameDataGridViewTextBoxColumn.Name = "bNameDataGridViewTextBoxColumn";
            this.bNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bAuthorDataGridViewTextBoxColumn
            // 
            this.bAuthorDataGridViewTextBoxColumn.DataPropertyName = "B_Author";
            this.bAuthorDataGridViewTextBoxColumn.HeaderText = "Book Author";
            this.bAuthorDataGridViewTextBoxColumn.Name = "bAuthorDataGridViewTextBoxColumn";
            this.bAuthorDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bCategoryDataGridViewTextBoxColumn
            // 
            this.bCategoryDataGridViewTextBoxColumn.DataPropertyName = "B_Category";
            this.bCategoryDataGridViewTextBoxColumn.HeaderText = "Book Category";
            this.bCategoryDataGridViewTextBoxColumn.Name = "bCategoryDataGridViewTextBoxColumn";
            this.bCategoryDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bPublishDateDataGridViewTextBoxColumn
            // 
            this.bPublishDateDataGridViewTextBoxColumn.DataPropertyName = "B_PublishDate";
            this.bPublishDateDataGridViewTextBoxColumn.HeaderText = "PublishDate";
            this.bPublishDateDataGridViewTextBoxColumn.Name = "bPublishDateDataGridViewTextBoxColumn";
            this.bPublishDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // frm_View_All_Book
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(1920, 887);
            this.ControlBox = false;
            this.Controls.Add(this.dgv_View_All_Book);
            this.Controls.Add(this.lbl_Header);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_View_All_Book";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "View All Book";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frm_View_All_Book_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_View_All_Book)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.book_Management_System_DBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookDetailBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Header;
        private System.Windows.Forms.DataGridView dgv_View_All_Book;
        private Book_Management_System_DBDataSet book_Management_System_DBDataSet;
        private System.Windows.Forms.BindingSource bookDetailBindingSource;
        private Book_Management_System_DBDataSetTableAdapters.Book_DetailTableAdapter book_DetailTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn bIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bAuthorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bCategoryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bPublishDateDataGridViewTextBoxColumn;
    }
}