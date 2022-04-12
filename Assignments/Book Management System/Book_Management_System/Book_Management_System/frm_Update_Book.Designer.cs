namespace Book_Management_System
{
    partial class frm_Update_Book
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
            this.lbl_Category = new System.Windows.Forms.Label();
            this.lbl_Publish_Date = new System.Windows.Forms.Label();
            this.lbl_Book_Author = new System.Windows.Forms.Label();
            this.lbl_Book_Name = new System.Windows.Forms.Label();
            this.lbl_ID = new System.Windows.Forms.Label();
            this.cmb_Category = new System.Windows.Forms.ComboBox();
            this.dtp_Publish_Date = new System.Windows.Forms.DateTimePicker();
            this.tb_Author = new System.Windows.Forms.TextBox();
            this.tb_Book_Name = new System.Windows.Forms.TextBox();
            this.tb_ID = new System.Windows.Forms.TextBox();
            this.btn_Refresh = new System.Windows.Forms.Button();
            this.btn_Update = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_Header
            // 
            this.lbl_Header.AutoSize = true;
            this.lbl_Header.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_Header.Font = new System.Drawing.Font("Century Schoolbook", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Header.ForeColor = System.Drawing.Color.DarkMagenta;
            this.lbl_Header.Location = new System.Drawing.Point(767, 87);
            this.lbl_Header.Name = "lbl_Header";
            this.lbl_Header.Size = new System.Drawing.Size(435, 71);
            this.lbl_Header.TabIndex = 0;
            this.lbl_Header.Text = "Update Book";
            // 
            // lbl_Category
            // 
            this.lbl_Category.AutoSize = true;
            this.lbl_Category.BackColor = System.Drawing.Color.FloralWhite;
            this.lbl_Category.Font = new System.Drawing.Font("Cambria", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Category.ForeColor = System.Drawing.Color.Crimson;
            this.lbl_Category.Location = new System.Drawing.Point(616, 598);
            this.lbl_Category.Name = "lbl_Category";
            this.lbl_Category.Size = new System.Drawing.Size(130, 33);
            this.lbl_Category.TabIndex = 0;
            this.lbl_Category.Text = "Category";
            // 
            // lbl_Publish_Date
            // 
            this.lbl_Publish_Date.AutoSize = true;
            this.lbl_Publish_Date.BackColor = System.Drawing.Color.FloralWhite;
            this.lbl_Publish_Date.Font = new System.Drawing.Font("Cambria", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Publish_Date.ForeColor = System.Drawing.Color.Crimson;
            this.lbl_Publish_Date.Location = new System.Drawing.Point(616, 518);
            this.lbl_Publish_Date.Name = "lbl_Publish_Date";
            this.lbl_Publish_Date.Size = new System.Drawing.Size(180, 33);
            this.lbl_Publish_Date.TabIndex = 0;
            this.lbl_Publish_Date.Text = "Publish Date";
            // 
            // lbl_Book_Author
            // 
            this.lbl_Book_Author.AutoSize = true;
            this.lbl_Book_Author.BackColor = System.Drawing.Color.FloralWhite;
            this.lbl_Book_Author.Font = new System.Drawing.Font("Cambria", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Book_Author.ForeColor = System.Drawing.Color.Crimson;
            this.lbl_Book_Author.Location = new System.Drawing.Point(616, 431);
            this.lbl_Book_Author.Name = "lbl_Book_Author";
            this.lbl_Book_Author.Size = new System.Drawing.Size(178, 33);
            this.lbl_Book_Author.TabIndex = 0;
            this.lbl_Book_Author.Text = "Book Author";
            // 
            // lbl_Book_Name
            // 
            this.lbl_Book_Name.AutoSize = true;
            this.lbl_Book_Name.BackColor = System.Drawing.Color.FloralWhite;
            this.lbl_Book_Name.Font = new System.Drawing.Font("Cambria", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Book_Name.ForeColor = System.Drawing.Color.Crimson;
            this.lbl_Book_Name.Location = new System.Drawing.Point(616, 342);
            this.lbl_Book_Name.Name = "lbl_Book_Name";
            this.lbl_Book_Name.Size = new System.Drawing.Size(162, 33);
            this.lbl_Book_Name.TabIndex = 0;
            this.lbl_Book_Name.Text = "Book Name";
            // 
            // lbl_ID
            // 
            this.lbl_ID.AutoSize = true;
            this.lbl_ID.BackColor = System.Drawing.Color.FloralWhite;
            this.lbl_ID.Font = new System.Drawing.Font("Cambria", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ID.ForeColor = System.Drawing.Color.Crimson;
            this.lbl_ID.Location = new System.Drawing.Point(616, 255);
            this.lbl_ID.Name = "lbl_ID";
            this.lbl_ID.Size = new System.Drawing.Size(118, 33);
            this.lbl_ID.TabIndex = 0;
            this.lbl_ID.Text = "Book ID";
            // 
            // cmb_Category
            // 
            this.cmb_Category.Enabled = false;
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
            this.cmb_Category.Location = new System.Drawing.Point(984, 595);
            this.cmb_Category.Name = "cmb_Category";
            this.cmb_Category.Size = new System.Drawing.Size(340, 35);
            this.cmb_Category.TabIndex = 5;
            // 
            // dtp_Publish_Date
            // 
            this.dtp_Publish_Date.Enabled = false;
            this.dtp_Publish_Date.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_Publish_Date.Location = new System.Drawing.Point(984, 515);
            this.dtp_Publish_Date.Name = "dtp_Publish_Date";
            this.dtp_Publish_Date.Size = new System.Drawing.Size(340, 34);
            this.dtp_Publish_Date.TabIndex = 4;
            // 
            // tb_Author
            // 
            this.tb_Author.Enabled = false;
            this.tb_Author.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Author.Location = new System.Drawing.Point(984, 428);
            this.tb_Author.MaxLength = 30;
            this.tb_Author.Name = "tb_Author";
            this.tb_Author.Size = new System.Drawing.Size(340, 34);
            this.tb_Author.TabIndex = 3;
            // 
            // tb_Book_Name
            // 
            this.tb_Book_Name.Enabled = false;
            this.tb_Book_Name.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Book_Name.Location = new System.Drawing.Point(984, 339);
            this.tb_Book_Name.MaxLength = 30;
            this.tb_Book_Name.Name = "tb_Book_Name";
            this.tb_Book_Name.Size = new System.Drawing.Size(340, 34);
            this.tb_Book_Name.TabIndex = 2;
            // 
            // tb_ID
            // 
            this.tb_ID.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_ID.Location = new System.Drawing.Point(984, 252);
            this.tb_ID.Name = "tb_ID";
            this.tb_ID.Size = new System.Drawing.Size(340, 34);
            this.tb_ID.TabIndex = 1;
            // 
            // btn_Refresh
            // 
            this.btn_Refresh.BackColor = System.Drawing.SystemColors.Info;
            this.btn_Refresh.Font = new System.Drawing.Font("Castellar", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Refresh.ForeColor = System.Drawing.Color.Black;
            this.btn_Refresh.Location = new System.Drawing.Point(662, 731);
            this.btn_Refresh.Name = "btn_Refresh";
            this.btn_Refresh.Size = new System.Drawing.Size(144, 46);
            this.btn_Refresh.TabIndex = 6;
            this.btn_Refresh.Text = "Refresh";
            this.btn_Refresh.UseVisualStyleBackColor = false;
            // 
            // btn_Update
            // 
            this.btn_Update.BackColor = System.Drawing.SystemColors.Info;
            this.btn_Update.Font = new System.Drawing.Font("Castellar", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Update.ForeColor = System.Drawing.Color.Black;
            this.btn_Update.Location = new System.Drawing.Point(1017, 731);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(177, 46);
            this.btn_Update.TabIndex = 7;
            this.btn_Update.Text = "Update";
            this.btn_Update.UseVisualStyleBackColor = false;
            // 
            // frm_Update_Book
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(1924, 1055);
            this.ControlBox = false;
            this.Controls.Add(this.btn_Update);
            this.Controls.Add(this.btn_Refresh);
            this.Controls.Add(this.cmb_Category);
            this.Controls.Add(this.dtp_Publish_Date);
            this.Controls.Add(this.tb_Author);
            this.Controls.Add(this.tb_Book_Name);
            this.Controls.Add(this.tb_ID);
            this.Controls.Add(this.lbl_Category);
            this.Controls.Add(this.lbl_Publish_Date);
            this.Controls.Add(this.lbl_Book_Author);
            this.Controls.Add(this.lbl_Book_Name);
            this.Controls.Add(this.lbl_ID);
            this.Controls.Add(this.lbl_Header);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_Update_Book";
            this.Text = "Update Book";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Header;
        private System.Windows.Forms.Label lbl_Category;
        private System.Windows.Forms.Label lbl_Publish_Date;
        private System.Windows.Forms.Label lbl_Book_Author;
        private System.Windows.Forms.Label lbl_Book_Name;
        private System.Windows.Forms.Label lbl_ID;
        private System.Windows.Forms.ComboBox cmb_Category;
        private System.Windows.Forms.DateTimePicker dtp_Publish_Date;
        private System.Windows.Forms.TextBox tb_Author;
        private System.Windows.Forms.TextBox tb_Book_Name;
        private System.Windows.Forms.TextBox tb_ID;
        private System.Windows.Forms.Button btn_Refresh;
        private System.Windows.Forms.Button btn_Update;
    }
}