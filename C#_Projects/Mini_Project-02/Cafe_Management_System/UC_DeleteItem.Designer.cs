
namespace Cafe_Management_System
{
    partial class UC_DeleteItem
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgv_DeleteItem = new System.Windows.Forms.DataGridView();
            this.lbl_Head = new System.Windows.Forms.Label();
            this.tb_Item_Name = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_Del = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DeleteItem)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_DeleteItem
            // 
            this.dgv_DeleteItem.AllowUserToAddRows = false;
            this.dgv_DeleteItem.AllowUserToDeleteRows = false;
            this.dgv_DeleteItem.AllowUserToResizeColumns = false;
            this.dgv_DeleteItem.AllowUserToResizeRows = false;
            this.dgv_DeleteItem.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_DeleteItem.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgv_DeleteItem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_DeleteItem.Location = new System.Drawing.Point(69, 302);
            this.dgv_DeleteItem.Name = "dgv_DeleteItem";
            this.dgv_DeleteItem.ReadOnly = true;
            this.dgv_DeleteItem.RowHeadersVisible = false;
            this.dgv_DeleteItem.RowHeadersWidth = 51;
            this.dgv_DeleteItem.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgv_DeleteItem.RowTemplate.Height = 24;
            this.dgv_DeleteItem.Size = new System.Drawing.Size(958, 391);
            this.dgv_DeleteItem.TabIndex = 24;
            this.dgv_DeleteItem.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_DeleteItem_CellClick);
            // 
            // lbl_Head
            // 
            this.lbl_Head.AutoSize = true;
            this.lbl_Head.Font = new System.Drawing.Font("Comic Sans MS", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Head.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(225)))));
            this.lbl_Head.Location = new System.Drawing.Point(126, 34);
            this.lbl_Head.Name = "lbl_Head";
            this.lbl_Head.Size = new System.Drawing.Size(196, 42);
            this.lbl_Head.TabIndex = 23;
            this.lbl_Head.Text = "Delete Item";
            // 
            // tb_Item_Name
            // 
            this.tb_Item_Name.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Item_Name.Location = new System.Drawing.Point(377, 221);
            this.tb_Item_Name.Name = "tb_Item_Name";
            this.tb_Item_Name.Size = new System.Drawing.Size(395, 35);
            this.tb_Item_Name.TabIndex = 21;
            this.tb_Item_Name.TextChanged += new System.EventHandler(this.tb_Item_Name_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(371, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(146, 35);
            this.label3.TabIndex = 20;
            this.label3.Text = "Item Name";
            // 
            // lbl_Del
            // 
            this.lbl_Del.AutoSize = true;
            this.lbl_Del.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_Del.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Del.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(225)))));
            this.lbl_Del.Location = new System.Drawing.Point(646, 705);
            this.lbl_Del.Name = "lbl_Del";
            this.lbl_Del.Size = new System.Drawing.Size(69, 34);
            this.lbl_Del.TabIndex = 25;
            this.lbl_Del.Text = "label";
            this.lbl_Del.Click += new System.EventHandler(this.lbl_Del_Click);
            // 
            // UC_DeleteItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lbl_Del);
            this.Controls.Add(this.dgv_DeleteItem);
            this.Controls.Add(this.lbl_Head);
            this.Controls.Add(this.tb_Item_Name);
            this.Controls.Add(this.label3);
            this.Name = "UC_DeleteItem";
            this.Size = new System.Drawing.Size(1107, 840);
            this.Load += new System.EventHandler(this.UC_DeleteItem_Load);
            this.Enter += new System.EventHandler(this.UC_DeleteItem_Enter);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DeleteItem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_DeleteItem;
        private System.Windows.Forms.Label lbl_Head;
        private System.Windows.Forms.TextBox tb_Item_Name;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_Del;
    }
}
