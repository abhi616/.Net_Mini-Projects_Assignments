namespace Student_Management_System
{
    partial class frm_login
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
            this.label1 = new System.Windows.Forms.Label();
            this.tb_Username = new System.Windows.Forms.TextBox();
            this.tb_Password = new System.Windows.Forms.TextBox();
            this.btn_Sign_In = new System.Windows.Forms.Button();
            this.pb_Password = new System.Windows.Forms.PictureBox();
            this.pb_Username = new System.Windows.Forms.PictureBox();
            this.pb_Header = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Password)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Username)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Header)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.label1.Location = new System.Drawing.Point(243, 165);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Login Page";
            // 
            // tb_Username
            // 
            this.tb_Username.Font = new System.Drawing.Font("Californian FB", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Username.Location = new System.Drawing.Point(222, 256);
            this.tb_Username.MaxLength = 20;
            this.tb_Username.Name = "tb_Username";
            this.tb_Username.Size = new System.Drawing.Size(236, 34);
            this.tb_Username.TabIndex = 1;
            // 
            // tb_Password
            // 
            this.tb_Password.Font = new System.Drawing.Font("Californian FB", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Password.Location = new System.Drawing.Point(222, 385);
            this.tb_Password.MaxLength = 8;
            this.tb_Password.Name = "tb_Password";
            this.tb_Password.PasswordChar = '*';
            this.tb_Password.Size = new System.Drawing.Size(236, 34);
            this.tb_Password.TabIndex = 2;
            // 
            // btn_Sign_In
            // 
            this.btn_Sign_In.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Sign_In.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Sign_In.Font = new System.Drawing.Font("Bahnschrift", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Sign_In.ForeColor = System.Drawing.Color.RoyalBlue;
            this.btn_Sign_In.Location = new System.Drawing.Point(264, 525);
            this.btn_Sign_In.Name = "btn_Sign_In";
            this.btn_Sign_In.Size = new System.Drawing.Size(108, 46);
            this.btn_Sign_In.TabIndex = 3;
            this.btn_Sign_In.Text = "Sign in";
            this.btn_Sign_In.UseVisualStyleBackColor = false;
            this.btn_Sign_In.Click += new System.EventHandler(this.btn_Sign_In_Click);
            // 
            // pb_Password
            // 
            this.pb_Password.Image = global::Student_Management_System.Properties.Resources.Password_icon;
            this.pb_Password.Location = new System.Drawing.Point(111, 374);
            this.pb_Password.Name = "pb_Password";
            this.pb_Password.Size = new System.Drawing.Size(44, 45);
            this.pb_Password.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_Password.TabIndex = 2;
            this.pb_Password.TabStop = false;
            // 
            // pb_Username
            // 
            this.pb_Username.Image = global::Student_Management_System.Properties.Resources.User;
            this.pb_Username.Location = new System.Drawing.Point(111, 256);
            this.pb_Username.Name = "pb_Username";
            this.pb_Username.Size = new System.Drawing.Size(44, 47);
            this.pb_Username.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_Username.TabIndex = 1;
            this.pb_Username.TabStop = false;
            // 
            // pb_Header
            // 
            this.pb_Header.Image = global::Student_Management_System.Properties.Resources._21078913;
            this.pb_Header.Location = new System.Drawing.Point(275, 50);
            this.pb_Header.Name = "pb_Header";
            this.pb_Header.Size = new System.Drawing.Size(91, 94);
            this.pb_Header.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_Header.TabIndex = 0;
            this.pb_Header.TabStop = false;
            // 
            // frm_login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(670, 631);
            this.Controls.Add(this.btn_Sign_In);
            this.Controls.Add(this.tb_Password);
            this.Controls.Add(this.pb_Password);
            this.Controls.Add(this.tb_Username);
            this.Controls.Add(this.pb_Username);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pb_Header);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login Form";
            ((System.ComponentModel.ISupportInitialize)(this.pb_Password)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Username)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Header)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pb_Header;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pb_Username;
        private System.Windows.Forms.TextBox tb_Username;
        private System.Windows.Forms.PictureBox pb_Password;
        private System.Windows.Forms.TextBox tb_Password;
        private System.Windows.Forms.Button btn_Sign_In;
    }
}

