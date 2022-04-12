namespace Book_Management_System
{
    partial class frm_Add_New_Book
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
            this.lbl_Book_Name = new System.Windows.Forms.Label();
            this.lbl_Book_Author = new System.Windows.Forms.Label();
            this.lbl_Publish_Date = new System.Windows.Forms.Label();
            this.lbl_Category = new System.Windows.Forms.Label();
            this.tb_BookID = new System.Windows.Forms.TextBox();
            this.tb_Book_Name = new System.Windows.Forms.TextBox();
            this.tb_BookAuthor = new System.Windows.Forms.TextBox();
            this.dtp_Publish_Date = new System.Windows.Forms.DateTimePicker();
            this.cmb_Category = new System.Windows.Forms.ComboBox();
            this.btn_Save = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_Header
            // 
            this.lbl_Header.AutoSize = true;
            this.lbl_Header.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_Header.Font = new System.Drawing.Font("Century Schoolbook", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Header.ForeColor = System.Drawing.Color.DarkMagenta;
            this.lbl_Header.Location = new System.Drawing.Point(743, 194);
            this.lbl_Header.Name = "lbl_Header";
            this.lbl_Header.Size = new System.Drawing.Size(543, 71);
            this.lbl_Header.TabIndex = 0;
            this.lbl_Header.Text = "New Book Entry";
            // 
            // lbl_ID
            // 
            this.lbl_ID.AutoSize = true;
            this.lbl_ID.BackColor = System.Drawing.Color.FloralWhite;
            this.lbl_ID.Font = new System.Drawing.Font("Cambria", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ID.ForeColor = System.Drawing.Color.Crimson;
            this.lbl_ID.Location = new System.Drawing.Point(623, 360);
            this.lbl_ID.Name = "lbl_ID";
            this.lbl_ID.Size = new System.Drawing.Size(118, 33);
            this.lbl_ID.TabIndex = 0;
            this.lbl_ID.Text = "Book ID";
            // 
            // lbl_Book_Name
            // 
            this.lbl_Book_Name.AutoSize = true;
            this.lbl_Book_Name.BackColor = System.Drawing.Color.FloralWhite;
            this.lbl_Book_Name.Font = new System.Drawing.Font("Cambria", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Book_Name.ForeColor = System.Drawing.Color.Crimson;
            this.lbl_Book_Name.Location = new System.Drawing.Point(623, 458);
            this.lbl_Book_Name.Name = "lbl_Book_Name";
            this.lbl_Book_Name.Size = new System.Drawing.Size(162, 33);
            this.lbl_Book_Name.TabIndex = 0;
            this.lbl_Book_Name.Text = "Book Name";
            // 
            // lbl_Book_Author
            // 
            this.lbl_Book_Author.AutoSize = true;
            this.lbl_Book_Author.BackColor = System.Drawing.Color.FloralWhite;
            this.lbl_Book_Author.Font = new System.Drawing.Font("Cambria", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Book_Author.ForeColor = System.Drawing.Color.Crimson;
            this.lbl_Book_Author.Location = new System.Drawing.Point(623, 545);
            this.lbl_Book_Author.Name = "lbl_Book_Author";
            this.lbl_Book_Author.Size = new System.Drawing.Size(178, 33);
            this.lbl_Book_Author.TabIndex = 0;
            this.lbl_Book_Author.Text = "Book Author";
            // 
            // lbl_Publish_Date
            // 
            this.lbl_Publish_Date.AutoSize = true;
            this.lbl_Publish_Date.BackColor = System.Drawing.Color.FloralWhite;
            this.lbl_Publish_Date.Font = new System.Drawing.Font("Cambria", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Publish_Date.ForeColor = System.Drawing.Color.Crimson;
            this.lbl_Publish_Date.Location = new System.Drawing.Point(623, 632);
            this.lbl_Publish_Date.Name = "lbl_Publish_Date";
            this.lbl_Publish_Date.Size = new System.Drawing.Size(180, 33);
            this.lbl_Publish_Date.TabIndex = 0;
            this.lbl_Publish_Date.Text = "Publish Date";
            // 
            // lbl_Category
            // 
            this.lbl_Category.AutoSize = true;
            this.lbl_Category.BackColor = System.Drawing.Color.FloralWhite;
            this.lbl_Category.Font = new System.Drawing.Font("Cambria", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Category.ForeColor = System.Drawing.Color.Crimson;
            this.lbl_Category.Location = new System.Drawing.Point(623, 712);
            this.lbl_Category.Name = "lbl_Category";
            this.lbl_Category.Size = new System.Drawing.Size(130, 33);
            this.lbl_Category.TabIndex = 0;
            this.lbl_Category.Text = "Category";
            // 
            // tb_BookID
            // 
            this.tb_BookID.Enabled = false;
            this.tb_BookID.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_BookID.Location = new System.Drawing.Point(1018, 357);
            this.tb_BookID.Name = "tb_BookID";
            this.tb_BookID.Size = new System.Drawing.Size(340, 34);
            this.tb_BookID.TabIndex = 1;
            // 
            // tb_Book_Name
            // 
            this.tb_Book_Name.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Book_Name.Location = new System.Drawing.Point(1018, 446);
            this.tb_Book_Name.MaxLength = 30;
            this.tb_Book_Name.Name = "tb_Book_Name";
            this.tb_Book_Name.Size = new System.Drawing.Size(340, 34);
            this.tb_Book_Name.TabIndex = 2;
            // 
            // tb_BookAuthor
            // 
            this.tb_BookAuthor.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_BookAuthor.Location = new System.Drawing.Point(1018, 542);
            this.tb_BookAuthor.MaxLength = 30;
            this.tb_BookAuthor.Name = "tb_BookAuthor";
            this.tb_BookAuthor.Size = new System.Drawing.Size(340, 34);
            this.tb_BookAuthor.TabIndex = 3;
            // 
            // dtp_Publish_Date
            // 
            this.dtp_Publish_Date.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_Publish_Date.Location = new System.Drawing.Point(1018, 629);
            this.dtp_Publish_Date.Name = "dtp_Publish_Date";
            this.dtp_Publish_Date.Size = new System.Drawing.Size(340, 34);
            this.dtp_Publish_Date.TabIndex = 4;
            // 
            // cmb_Category
            // 
            this.cmb_Category.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Category.FormattingEnabled = true;
            this.cmb_Category.Items.AddRange(new object[] {
            "Action and Adventure",
            "Love Story",
            "Historical",
            "Comedy",
            "Novel",
            "Biographies",
            "Horror",
            "Short Stories"});
            this.cmb_Category.Location = new System.Drawing.Point(1018, 712);
            this.cmb_Category.MaxLength = 30;
            this.cmb_Category.Name = "cmb_Category";
            this.cmb_Category.Size = new System.Drawing.Size(340, 35);
            this.cmb_Category.TabIndex = 5;
            // 
            // btn_Save
            // 
            this.btn_Save.BackColor = System.Drawing.SystemColors.Info;
            this.btn_Save.Font = new System.Drawing.Font("Castellar", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Save.ForeColor = System.Drawing.Color.Black;
            this.btn_Save.Location = new System.Drawing.Point(891, 820);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(128, 46);
            this.btn_Save.TabIndex = 6;
            this.btn_Save.Text = "Save";
            this.btn_Save.UseVisualStyleBackColor = false;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // frm_Add_New_Book
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(1924, 1055);
            this.ControlBox = false;
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.cmb_Category);
            this.Controls.Add(this.dtp_Publish_Date);
            this.Controls.Add(this.tb_BookAuthor);
            this.Controls.Add(this.tb_Book_Name);
            this.Controls.Add(this.tb_BookID);
            this.Controls.Add(this.lbl_Category);
            this.Controls.Add(this.lbl_Publish_Date);
            this.Controls.Add(this.lbl_Book_Author);
            this.Controls.Add(this.lbl_Book_Name);
            this.Controls.Add(this.lbl_ID);
            this.Controls.Add(this.lbl_Header);
            this.Name = "frm_Add_New_Book";
            this.Text = "Add New Book";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frm_Add_New_Book_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Header;
        private System.Windows.Forms.Label lbl_ID;
        private System.Windows.Forms.Label lbl_Book_Name;
        private System.Windows.Forms.Label lbl_Book_Author;
        private System.Windows.Forms.Label lbl_Publish_Date;
        private System.Windows.Forms.Label lbl_Category;
        private System.Windows.Forms.TextBox tb_BookID;
        private System.Windows.Forms.TextBox tb_Book_Name;
        private System.Windows.Forms.TextBox tb_BookAuthor;
        private System.Windows.Forms.DateTimePicker dtp_Publish_Date;
        private System.Windows.Forms.ComboBox cmb_Category;
        private System.Windows.Forms.Button btn_Save;
    }
}