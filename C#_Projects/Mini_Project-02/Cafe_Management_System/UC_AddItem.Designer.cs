
namespace Cafe_Management_System
{
    partial class UC_AddItem
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
            this.lbl_Head = new System.Windows.Forms.Label();
            this.lbl_Category = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_Add_Item = new System.Windows.Forms.Button();
            this.cmb_Category = new System.Windows.Forms.ComboBox();
            this.tb_Item_Name = new System.Windows.Forms.TextBox();
            this.tb_Price = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbl_Head
            // 
            this.lbl_Head.AutoSize = true;
            this.lbl_Head.Font = new System.Drawing.Font("Comic Sans MS", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Head.Location = new System.Drawing.Point(388, 79);
            this.lbl_Head.Name = "lbl_Head";
            this.lbl_Head.Size = new System.Drawing.Size(311, 55);
            this.lbl_Head.TabIndex = 0;
            this.lbl_Head.Text = "Add New Item";
            // 
            // lbl_Category
            // 
            this.lbl_Category.AutoSize = true;
            this.lbl_Category.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Category.Location = new System.Drawing.Point(265, 222);
            this.lbl_Category.Name = "lbl_Category";
            this.lbl_Category.Size = new System.Drawing.Size(118, 35);
            this.lbl_Category.TabIndex = 1;
            this.lbl_Category.Text = "Category";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(265, 376);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(146, 35);
            this.label3.TabIndex = 2;
            this.label3.Text = "Item Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(265, 512);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 35);
            this.label4.TabIndex = 3;
            this.label4.Text = "Price";
            // 
            // btn_Add_Item
            // 
            this.btn_Add_Item.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(221)))));
            this.btn_Add_Item.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Add_Item.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Add_Item.ForeColor = System.Drawing.Color.White;
            this.btn_Add_Item.Location = new System.Drawing.Point(454, 681);
            this.btn_Add_Item.Name = "btn_Add_Item";
            this.btn_Add_Item.Size = new System.Drawing.Size(208, 68);
            this.btn_Add_Item.TabIndex = 6;
            this.btn_Add_Item.Text = "Add Item";
            this.btn_Add_Item.UseVisualStyleBackColor = false;
            this.btn_Add_Item.Click += new System.EventHandler(this.btn_Add_Item_Click);
            // 
            // cmb_Category
            // 
            this.cmb_Category.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Category.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmb_Category.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Category.FormattingEnabled = true;
            this.cmb_Category.IntegralHeight = false;
            this.cmb_Category.ItemHeight = 29;
            this.cmb_Category.Items.AddRange(new object[] {
            "Cake",
            "Soft Drink",
            "South Indian",
            "Thali",
            "Indian"});
            this.cmb_Category.Location = new System.Drawing.Point(296, 288);
            this.cmb_Category.Name = "cmb_Category";
            this.cmb_Category.Size = new System.Drawing.Size(546, 37);
            this.cmb_Category.TabIndex = 7;
            // 
            // tb_Item_Name
            // 
            this.tb_Item_Name.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Item_Name.Location = new System.Drawing.Point(296, 429);
            this.tb_Item_Name.Name = "tb_Item_Name";
            this.tb_Item_Name.Size = new System.Drawing.Size(535, 35);
            this.tb_Item_Name.TabIndex = 8;
            // 
            // tb_Price
            // 
            this.tb_Price.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Price.Location = new System.Drawing.Point(296, 565);
            this.tb_Price.Name = "tb_Price";
            this.tb_Price.Size = new System.Drawing.Size(535, 35);
            this.tb_Price.TabIndex = 9;
            // 
            // UC_AddItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tb_Price);
            this.Controls.Add(this.tb_Item_Name);
            this.Controls.Add(this.cmb_Category);
            this.Controls.Add(this.btn_Add_Item);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbl_Category);
            this.Controls.Add(this.lbl_Head);
            this.Name = "UC_AddItem";
            this.Size = new System.Drawing.Size(1107, 840);
            this.Leave += new System.EventHandler(this.UC_AddItem_Leave);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Head;
        private System.Windows.Forms.Label lbl_Category;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_Add_Item;
        private System.Windows.Forms.ComboBox cmb_Category;
        private System.Windows.Forms.TextBox tb_Item_Name;
        private System.Windows.Forms.TextBox tb_Price;
    }
}
