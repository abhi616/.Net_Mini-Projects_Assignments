namespace Student_Management_System
{
    partial class frm_Login
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
            this.pnl_Login = new System.Windows.Forms.Panel();
            this.btn_Sign_In = new System.Windows.Forms.Button();
            this.tb_Paasword = new System.Windows.Forms.TextBox();
            this.tb_Username = new System.Windows.Forms.TextBox();
            this.lbl_Password = new System.Windows.Forms.Label();
            this.lbl_Username = new System.Windows.Forms.Label();
            this.lbl_Header = new System.Windows.Forms.Label();
            this.pnl_Login.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_Login
            // 
            this.pnl_Login.Controls.Add(this.btn_Sign_In);
            this.pnl_Login.Controls.Add(this.tb_Paasword);
            this.pnl_Login.Controls.Add(this.tb_Username);
            this.pnl_Login.Controls.Add(this.lbl_Password);
            this.pnl_Login.Controls.Add(this.lbl_Username);
            this.pnl_Login.Controls.Add(this.lbl_Header);
            this.pnl_Login.Location = new System.Drawing.Point(1, 0);
            this.pnl_Login.Name = "pnl_Login";
            this.pnl_Login.Size = new System.Drawing.Size(802, 710);
            this.pnl_Login.TabIndex = 0;
            // 
            // btn_Sign_In
            // 
            this.btn_Sign_In.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn_Sign_In.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Sign_In.Font = new System.Drawing.Font("Gadugi", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Sign_In.ForeColor = System.Drawing.Color.White;
            this.btn_Sign_In.Location = new System.Drawing.Point(307, 522);
            this.btn_Sign_In.Name = "btn_Sign_In";
            this.btn_Sign_In.Size = new System.Drawing.Size(128, 58);
            this.btn_Sign_In.TabIndex = 3;
            this.btn_Sign_In.Text = "Sign in";
            this.btn_Sign_In.UseVisualStyleBackColor = false;
            this.btn_Sign_In.Click += new System.EventHandler(this.btn_Sign_In_Click);
            // 
            // tb_Paasword
            // 
            this.tb_Paasword.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Paasword.Location = new System.Drawing.Point(388, 395);
            this.tb_Paasword.MaxLength = 10;
            this.tb_Paasword.Name = "tb_Paasword";
            this.tb_Paasword.PasswordChar = '#';
            this.tb_Paasword.Size = new System.Drawing.Size(286, 30);
            this.tb_Paasword.TabIndex = 2;
            // 
            // tb_Username
            // 
            this.tb_Username.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Username.Location = new System.Drawing.Point(388, 298);
            this.tb_Username.MaxLength = 15;
            this.tb_Username.Name = "tb_Username";
            this.tb_Username.Size = new System.Drawing.Size(286, 30);
            this.tb_Username.TabIndex = 1;
            // 
            // lbl_Password
            // 
            this.lbl_Password.AutoSize = true;
            this.lbl_Password.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.lbl_Password.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Password.ForeColor = System.Drawing.Color.Crimson;
            this.lbl_Password.Location = new System.Drawing.Point(117, 395);
            this.lbl_Password.Name = "lbl_Password";
            this.lbl_Password.Size = new System.Drawing.Size(114, 36);
            this.lbl_Password.TabIndex = 0;
            this.lbl_Password.Text = "Password";
            // 
            // lbl_Username
            // 
            this.lbl_Username.AutoSize = true;
            this.lbl_Username.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.lbl_Username.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Username.ForeColor = System.Drawing.Color.Crimson;
            this.lbl_Username.Location = new System.Drawing.Point(114, 298);
            this.lbl_Username.Name = "lbl_Username";
            this.lbl_Username.Size = new System.Drawing.Size(119, 36);
            this.lbl_Username.TabIndex = 0;
            this.lbl_Username.Text = "Username";
            // 
            // lbl_Header
            // 
            this.lbl_Header.AutoSize = true;
            this.lbl_Header.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_Header.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_Header.Font = new System.Drawing.Font("Lucida Bright", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Header.ForeColor = System.Drawing.Color.DarkOrange;
            this.lbl_Header.Location = new System.Drawing.Point(288, 94);
            this.lbl_Header.Name = "lbl_Header";
            this.lbl_Header.Size = new System.Drawing.Size(167, 59);
            this.lbl_Header.TabIndex = 0;
            this.lbl_Header.Text = "Login";
            // 
            // frm_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = global::Student_Management_System.Properties.Resources.Student_Mgt;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(802, 708);
            this.Controls.Add(this.pnl_Login);
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.frm_Login_Load);
            this.pnl_Login.ResumeLayout(false);
            this.pnl_Login.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_Login;
        private System.Windows.Forms.Button btn_Sign_In;
        private System.Windows.Forms.TextBox tb_Paasword;
        private System.Windows.Forms.TextBox tb_Username;
        private System.Windows.Forms.Label lbl_Password;
        private System.Windows.Forms.Label lbl_Username;
        private System.Windows.Forms.Label lbl_Header;

    }
}

