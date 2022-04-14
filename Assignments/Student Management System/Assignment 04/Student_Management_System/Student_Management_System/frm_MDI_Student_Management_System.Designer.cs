namespace Student_Management_System
{
    partial class frm_MDI_Student_Management_System
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
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.studentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewStudentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateStudentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchStudentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewAllStudentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchStudentByCourseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.codeBlockToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.notePadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.AutoSize = false;
            this.menuStrip1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.studentToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.toolsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1924, 47);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // studentToolStripMenuItem
            // 
            this.studentToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewStudentToolStripMenuItem,
            this.updateStudentToolStripMenuItem,
            this.searchStudentToolStripMenuItem});
            this.studentToolStripMenuItem.Name = "studentToolStripMenuItem";
            this.studentToolStripMenuItem.Size = new System.Drawing.Size(96, 43);
            this.studentToolStripMenuItem.Text = "Student";
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewAllStudentToolStripMenuItem,
            this.searchStudentByCourseToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(66, 43);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.codeBlockToolStripMenuItem,
            this.notePadToolStripMenuItem});
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(74, 43);
            this.toolsToolStripMenuItem.Text = "Tools";
            // 
            // addNewStudentToolStripMenuItem
            // 
            this.addNewStudentToolStripMenuItem.Name = "addNewStudentToolStripMenuItem";
            this.addNewStudentToolStripMenuItem.Size = new System.Drawing.Size(243, 28);
            this.addNewStudentToolStripMenuItem.Text = "Add New Student";
            this.addNewStudentToolStripMenuItem.Click += new System.EventHandler(this.addNewStudentToolStripMenuItem_Click);
            // 
            // updateStudentToolStripMenuItem
            // 
            this.updateStudentToolStripMenuItem.Name = "updateStudentToolStripMenuItem";
            this.updateStudentToolStripMenuItem.Size = new System.Drawing.Size(243, 28);
            this.updateStudentToolStripMenuItem.Text = "Update Student";
            this.updateStudentToolStripMenuItem.Click += new System.EventHandler(this.updateStudentToolStripMenuItem_Click);
            // 
            // searchStudentToolStripMenuItem
            // 
            this.searchStudentToolStripMenuItem.Name = "searchStudentToolStripMenuItem";
            this.searchStudentToolStripMenuItem.Size = new System.Drawing.Size(243, 28);
            this.searchStudentToolStripMenuItem.Text = "Search Student";
            this.searchStudentToolStripMenuItem.Click += new System.EventHandler(this.searchStudentToolStripMenuItem_Click);
            // 
            // viewAllStudentToolStripMenuItem
            // 
            this.viewAllStudentToolStripMenuItem.Name = "viewAllStudentToolStripMenuItem";
            this.viewAllStudentToolStripMenuItem.Size = new System.Drawing.Size(331, 28);
            this.viewAllStudentToolStripMenuItem.Text = "View All Student";
            this.viewAllStudentToolStripMenuItem.Click += new System.EventHandler(this.viewAllStudentToolStripMenuItem_Click);
            // 
            // searchStudentByCourseToolStripMenuItem
            // 
            this.searchStudentByCourseToolStripMenuItem.Name = "searchStudentByCourseToolStripMenuItem";
            this.searchStudentByCourseToolStripMenuItem.Size = new System.Drawing.Size(331, 28);
            this.searchStudentByCourseToolStripMenuItem.Text = "Search Student By Course";
            this.searchStudentByCourseToolStripMenuItem.Click += new System.EventHandler(this.searchStudentByCourseToolStripMenuItem_Click);
            // 
            // codeBlockToolStripMenuItem
            // 
            this.codeBlockToolStripMenuItem.Name = "codeBlockToolStripMenuItem";
            this.codeBlockToolStripMenuItem.Size = new System.Drawing.Size(184, 28);
            this.codeBlockToolStripMenuItem.Text = "CodeBlock";
            this.codeBlockToolStripMenuItem.Click += new System.EventHandler(this.codeBlockToolStripMenuItem_Click);
            // 
            // notePadToolStripMenuItem
            // 
            this.notePadToolStripMenuItem.Name = "notePadToolStripMenuItem";
            this.notePadToolStripMenuItem.Size = new System.Drawing.Size(184, 28);
            this.notePadToolStripMenuItem.Text = "NotePad++";
            this.notePadToolStripMenuItem.Click += new System.EventHandler(this.notePadToolStripMenuItem_Click);
            // 
            // frm_MDI_Student_Management_System
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 1055);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frm_MDI_Student_Management_System";
            this.Text = "Student Management System";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }
        #endregion

        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem studentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNewStudentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateStudentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchStudentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewAllStudentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchStudentByCourseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem codeBlockToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem notePadToolStripMenuItem;
    }
}



