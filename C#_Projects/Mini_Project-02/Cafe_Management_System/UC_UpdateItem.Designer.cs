
namespace Cafe_Management_System
{
    partial class UC_UpdateItem
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
            this.tb_ItemNm = new System.Windows.Forms.TextBox();
            this.tb_Item_Name = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_Category = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgv_UpdateItem = new System.Windows.Forms.DataGridView();
            this.tb_Category = new System.Windows.Forms.TextBox();
            this.tb_ItemPrice = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Print = new System.Windows.Forms.Button();
            this.uC_PlaceOrder1 = new Cafe_Management_System.UC_PlaceOrder();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_UpdateItem)).BeginInit();
            this.SuspendLayout();
            // 
            // tb_ItemNm
            // 
            this.tb_ItemNm.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_ItemNm.Location = new System.Drawing.Point(159, 697);
            this.tb_ItemNm.Name = "tb_ItemNm";
            this.tb_ItemNm.Size = new System.Drawing.Size(309, 35);
            this.tb_ItemNm.TabIndex = 16;
            // 
            // tb_Item_Name
            // 
            this.tb_Item_Name.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Item_Name.Location = new System.Drawing.Point(646, 162);
            this.tb_Item_Name.Name = "tb_Item_Name";
            this.tb_Item_Name.Size = new System.Drawing.Size(290, 35);
            this.tb_Item_Name.TabIndex = 15;
            this.tb_Item_Name.TextChanged += new System.EventHandler(this.tb_Item_Name_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(153, 657);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(146, 35);
            this.label4.TabIndex = 12;
            this.label4.Text = "Item Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(650, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(146, 35);
            this.label3.TabIndex = 11;
            this.label3.Text = "Item Name";
            // 
            // lbl_Category
            // 
            this.lbl_Category.AutoSize = true;
            this.lbl_Category.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Category.Location = new System.Drawing.Point(153, 547);
            this.lbl_Category.Name = "lbl_Category";
            this.lbl_Category.Size = new System.Drawing.Size(118, 35);
            this.lbl_Category.TabIndex = 10;
            this.lbl_Category.Text = "Category";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(225)))));
            this.label2.Location = new System.Drawing.Point(152, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(205, 42);
            this.label2.TabIndex = 18;
            this.label2.Text = "Update Item";
            // 
            // dgv_UpdateItem
            // 
            this.dgv_UpdateItem.AllowUserToAddRows = false;
            this.dgv_UpdateItem.AllowUserToDeleteRows = false;
            this.dgv_UpdateItem.AllowUserToResizeColumns = false;
            this.dgv_UpdateItem.AllowUserToResizeRows = false;
            this.dgv_UpdateItem.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_UpdateItem.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgv_UpdateItem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_UpdateItem.Location = new System.Drawing.Point(150, 242);
            this.dgv_UpdateItem.Name = "dgv_UpdateItem";
            this.dgv_UpdateItem.ReadOnly = true;
            this.dgv_UpdateItem.RowHeadersVisible = false;
            this.dgv_UpdateItem.RowHeadersWidth = 51;
            this.dgv_UpdateItem.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgv_UpdateItem.RowTemplate.Height = 24;
            this.dgv_UpdateItem.Size = new System.Drawing.Size(786, 277);
            this.dgv_UpdateItem.TabIndex = 19;
            this.dgv_UpdateItem.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_UpdateItem_CellClick);
            // 
            // tb_Category
            // 
            this.tb_Category.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Category.Location = new System.Drawing.Point(159, 596);
            this.tb_Category.Name = "tb_Category";
            this.tb_Category.Size = new System.Drawing.Size(309, 35);
            this.tb_Category.TabIndex = 20;
            // 
            // tb_ItemPrice
            // 
            this.tb_ItemPrice.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_ItemPrice.Location = new System.Drawing.Point(621, 596);
            this.tb_ItemPrice.Name = "tb_ItemPrice";
            this.tb_ItemPrice.Size = new System.Drawing.Size(309, 35);
            this.tb_ItemPrice.TabIndex = 22;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(615, 547);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 35);
            this.label1.TabIndex = 21;
            this.label1.Text = "Price";
            // 
            // btn_Print
            // 
            this.btn_Print.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(221)))));
            this.btn_Print.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Print.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Print.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Print.ForeColor = System.Drawing.Color.White;
            this.btn_Print.Location = new System.Drawing.Point(705, 678);
            this.btn_Print.Name = "btn_Print";
            this.btn_Print.Size = new System.Drawing.Size(209, 54);
            this.btn_Print.TabIndex = 28;
            this.btn_Print.Text = "Update Item";
            this.btn_Print.UseVisualStyleBackColor = false;
            this.btn_Print.Click += new System.EventHandler(this.btn_Print_Click);
            // 
            // uC_PlaceOrder1
            // 
            this.uC_PlaceOrder1.Location = new System.Drawing.Point(333, 104);
            this.uC_PlaceOrder1.Name = "uC_PlaceOrder1";
            this.uC_PlaceOrder1.Size = new System.Drawing.Size(8, 8);
            this.uC_PlaceOrder1.TabIndex = 17;
            // 
            // UC_UpdateItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btn_Print);
            this.Controls.Add(this.tb_ItemPrice);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_Category);
            this.Controls.Add(this.dgv_UpdateItem);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.uC_PlaceOrder1);
            this.Controls.Add(this.tb_ItemNm);
            this.Controls.Add(this.tb_Item_Name);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbl_Category);
            this.Name = "UC_UpdateItem";
            this.Size = new System.Drawing.Size(1107, 840);
            this.Load += new System.EventHandler(this.UC_UpdateItem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_UpdateItem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_ItemNm;
        private System.Windows.Forms.TextBox tb_Item_Name;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_Category;
        private UC_PlaceOrder uC_PlaceOrder1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgv_UpdateItem;
        private System.Windows.Forms.TextBox tb_Category;
        private System.Windows.Forms.TextBox tb_ItemPrice;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Print;
    }
}
