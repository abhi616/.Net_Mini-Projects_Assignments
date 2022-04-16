namespace frm_DB_Creation
{
    partial class frm_DB_Creation
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
            this.btn_Create_Db = new System.Windows.Forms.Button();
            this.tb_DB_Name = new System.Windows.Forms.TextBox();
            this.tb_Table_Name = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_Head = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_Create_Db
            // 
            this.btn_Create_Db.Font = new System.Drawing.Font("Microsoft YaHei", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Create_Db.Location = new System.Drawing.Point(349, 408);
            this.btn_Create_Db.Name = "btn_Create_Db";
            this.btn_Create_Db.Size = new System.Drawing.Size(185, 64);
            this.btn_Create_Db.TabIndex = 3;
            this.btn_Create_Db.Text = "Create";
            this.btn_Create_Db.UseVisualStyleBackColor = true;
            this.btn_Create_Db.Click += new System.EventHandler(this.btn_Create_Db_Click);
            // 
            // tb_DB_Name
            // 
            this.tb_DB_Name.Font = new System.Drawing.Font("Microsoft Tai Le", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_DB_Name.Location = new System.Drawing.Point(372, 191);
            this.tb_DB_Name.Name = "tb_DB_Name";
            this.tb_DB_Name.Size = new System.Drawing.Size(279, 37);
            this.tb_DB_Name.TabIndex = 1;
            // 
            // tb_Table_Name
            // 
            this.tb_Table_Name.Font = new System.Drawing.Font("Microsoft Tai Le", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Table_Name.Location = new System.Drawing.Point(372, 300);
            this.tb_Table_Name.Name = "tb_Table_Name";
            this.tb_Table_Name.Size = new System.Drawing.Size(279, 37);
            this.tb_Table_Name.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(122, 199);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Database Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(124, 313);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Table Name";
            // 
            // lbl_Head
            // 
            this.lbl_Head.AutoSize = true;
            this.lbl_Head.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbl_Head.Font = new System.Drawing.Font("Microsoft YaHei UI", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Head.Location = new System.Drawing.Point(208, 70);
            this.lbl_Head.Name = "lbl_Head";
            this.lbl_Head.Size = new System.Drawing.Size(496, 50);
            this.lbl_Head.TabIndex = 5;
            this.lbl_Head.Text = "Create Database && Table";
            // 
            // frm_DB_Creation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(996, 614);
            this.Controls.Add(this.lbl_Head);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_Table_Name);
            this.Controls.Add(this.tb_DB_Name);
            this.Controls.Add(this.btn_Create_Db);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_DB_Creation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Database Creation";
            this.Load += new System.EventHandler(this.frm_DB_Creation_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Create_Db;
        private System.Windows.Forms.TextBox tb_DB_Name;
        private System.Windows.Forms.TextBox tb_Table_Name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_Head;
    }
}

