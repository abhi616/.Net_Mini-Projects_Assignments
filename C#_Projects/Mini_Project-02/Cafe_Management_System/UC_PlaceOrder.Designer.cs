
namespace Cafe_Management_System
{
    partial class UC_PlaceOrder
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
            this.label1 = new System.Windows.Forms.Label();
            this.cmb_Category = new System.Windows.Forms.ComboBox();
            this.tb_Search = new System.Windows.Forms.TextBox();
            this.lb_Items = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tb_ItemName = new System.Windows.Forms.TextBox();
            this.tb_Price = new System.Windows.Forms.TextBox();
            this.tb_Total = new System.Windows.Forms.TextBox();
            this.btn_Add_Item = new System.Windows.Forms.Button();
            this.tb_UpDown = new System.Windows.Forms.NumericUpDown();
            this.dgv_Order = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_Print = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tb_UpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Order)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Category";
            // 
            // cmb_Category
            // 
            this.cmb_Category.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Category.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmb_Category.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Category.FormattingEnabled = true;
            this.cmb_Category.IntegralHeight = false;
            this.cmb_Category.ItemHeight = 32;
            this.cmb_Category.Items.AddRange(new object[] {
            "Cake",
            "Soft Drink",
            "South Indian",
            "Thali",
            "Indian"});
            this.cmb_Category.Location = new System.Drawing.Point(23, 143);
            this.cmb_Category.Name = "cmb_Category";
            this.cmb_Category.Size = new System.Drawing.Size(252, 40);
            this.cmb_Category.TabIndex = 8;
            this.cmb_Category.SelectedIndexChanged += new System.EventHandler(this.cmb_Category_SelectedIndexChanged);
            // 
            // tb_Search
            // 
            this.tb_Search.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Search.Location = new System.Drawing.Point(23, 229);
            this.tb_Search.Name = "tb_Search";
            this.tb_Search.Size = new System.Drawing.Size(252, 40);
            this.tb_Search.TabIndex = 9;
            this.tb_Search.TextChanged += new System.EventHandler(this.tb_Item_Name_TextChanged);
            // 
            // lb_Items
            // 
            this.lb_Items.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Items.FormattingEnabled = true;
            this.lb_Items.ItemHeight = 25;
            this.lb_Items.Location = new System.Drawing.Point(23, 348);
            this.lb_Items.Name = "lb_Items";
            this.lb_Items.Size = new System.Drawing.Size(252, 429);
            this.lb_Items.TabIndex = 10;
            this.lb_Items.SelectedIndexChanged += new System.EventHandler(this.lb_Items_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(225)))));
            this.label2.Location = new System.Drawing.Point(16, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(191, 42);
            this.label2.TabIndex = 11;
            this.label2.Text = "Place Order";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(392, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 29);
            this.label3.TabIndex = 12;
            this.label3.Text = "Item Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(697, 154);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 29);
            this.label4.TabIndex = 13;
            this.label4.Text = "Total";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Comic Sans MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(697, 44);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 29);
            this.label5.TabIndex = 14;
            this.label5.Text = "Price";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Comic Sans MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(392, 159);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 29);
            this.label6.TabIndex = 15;
            this.label6.Text = "Quantity";
            // 
            // tb_ItemName
            // 
            this.tb_ItemName.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_ItemName.Location = new System.Drawing.Point(397, 96);
            this.tb_ItemName.Name = "tb_ItemName";
            this.tb_ItemName.Size = new System.Drawing.Size(249, 33);
            this.tb_ItemName.TabIndex = 18;
            // 
            // tb_Price
            // 
            this.tb_Price.Enabled = false;
            this.tb_Price.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Price.Location = new System.Drawing.Point(702, 96);
            this.tb_Price.Name = "tb_Price";
            this.tb_Price.Size = new System.Drawing.Size(249, 33);
            this.tb_Price.TabIndex = 19;
            // 
            // tb_Total
            // 
            this.tb_Total.Enabled = false;
            this.tb_Total.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Total.Location = new System.Drawing.Point(702, 207);
            this.tb_Total.Name = "tb_Total";
            this.tb_Total.Size = new System.Drawing.Size(249, 33);
            this.tb_Total.TabIndex = 20;
            // 
            // btn_Add_Item
            // 
            this.btn_Add_Item.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(221)))));
            this.btn_Add_Item.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Add_Item.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Add_Item.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Add_Item.ForeColor = System.Drawing.Color.White;
            this.btn_Add_Item.Location = new System.Drawing.Point(811, 269);
            this.btn_Add_Item.Name = "btn_Add_Item";
            this.btn_Add_Item.Size = new System.Drawing.Size(181, 54);
            this.btn_Add_Item.TabIndex = 22;
            this.btn_Add_Item.Text = "Add To Cart";
            this.btn_Add_Item.UseVisualStyleBackColor = false;
            // 
            // tb_UpDown
            // 
            this.tb_UpDown.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_UpDown.Location = new System.Drawing.Point(397, 207);
            this.tb_UpDown.Name = "tb_UpDown";
            this.tb_UpDown.Size = new System.Drawing.Size(249, 33);
            this.tb_UpDown.TabIndex = 23;
            this.tb_UpDown.ValueChanged += new System.EventHandler(this.tb_UpDown_ValueChanged);
            // 
            // dgv_Order
            // 
            this.dgv_Order.AllowUserToAddRows = false;
            this.dgv_Order.AllowUserToDeleteRows = false;
            this.dgv_Order.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgv_Order.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.dgv_Order.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Order.Location = new System.Drawing.Point(337, 381);
            this.dgv_Order.Name = "dgv_Order";
            this.dgv_Order.ReadOnly = true;
            this.dgv_Order.RowHeadersWidth = 51;
            this.dgv_Order.RowTemplate.Height = 24;
            this.dgv_Order.Size = new System.Drawing.Size(716, 281);
            this.dgv_Order.TabIndex = 24;
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(337, 20);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(716, 337);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(221)))));
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(334, 723);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(181, 54);
            this.button1.TabIndex = 26;
            this.button1.Text = "Remove";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // btn_Print
            // 
            this.btn_Print.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(221)))));
            this.btn_Print.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Print.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Print.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Print.ForeColor = System.Drawing.Color.White;
            this.btn_Print.Location = new System.Drawing.Point(872, 723);
            this.btn_Print.Name = "btn_Print";
            this.btn_Print.Size = new System.Drawing.Size(181, 54);
            this.btn_Print.TabIndex = 27;
            this.btn_Print.Text = "Print";
            this.btn_Print.UseVisualStyleBackColor = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Comic Sans MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(620, 678);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(129, 29);
            this.label7.TabIndex = 28;
            this.label7.Text = "Grand Total";
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label8.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(602, 723);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(181, 54);
            this.label8.TabIndex = 29;
            this.label8.Text = "Rs 00";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UC_PlaceOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btn_Print);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgv_Order);
            this.Controls.Add(this.tb_UpDown);
            this.Controls.Add(this.btn_Add_Item);
            this.Controls.Add(this.tb_Total);
            this.Controls.Add(this.tb_Price);
            this.Controls.Add(this.tb_ItemName);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lb_Items);
            this.Controls.Add(this.tb_Search);
            this.Controls.Add(this.cmb_Category);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Name = "UC_PlaceOrder";
            this.Size = new System.Drawing.Size(1107, 840);
            ((System.ComponentModel.ISupportInitialize)(this.tb_UpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Order)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmb_Category;
        private System.Windows.Forms.TextBox tb_Search;
        private System.Windows.Forms.ListBox lb_Items;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tb_ItemName;
        private System.Windows.Forms.TextBox tb_Price;
        private System.Windows.Forms.TextBox tb_Total;
        private System.Windows.Forms.Button btn_Add_Item;
        private System.Windows.Forms.NumericUpDown tb_UpDown;
        private System.Windows.Forms.DataGridView dgv_Order;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_Print;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}
