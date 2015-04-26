namespace LMS_DB_Project
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.searchbook_rb = new System.Windows.Forms.RadioButton();
            this.action_btn = new System.Windows.Forms.Button();
            this.bookloan_rb = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.addBorrower_rb = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutMeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.helpToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutMeToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutUsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox2.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // searchbook_rb
            // 
            this.searchbook_rb.AutoSize = true;
            this.searchbook_rb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchbook_rb.Location = new System.Drawing.Point(18, 41);
            this.searchbook_rb.Name = "searchbook_rb";
            this.searchbook_rb.Size = new System.Drawing.Size(150, 20);
            this.searchbook_rb.TabIndex = 5;
            this.searchbook_rb.TabStop = true;
            this.searchbook_rb.Text = "Search/ Issue Books";
            this.searchbook_rb.UseVisualStyleBackColor = true;
            // 
            // action_btn
            // 
            this.action_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.action_btn.Location = new System.Drawing.Point(562, 31);
            this.action_btn.Name = "action_btn";
            this.action_btn.Size = new System.Drawing.Size(82, 30);
            this.action_btn.TabIndex = 7;
            this.action_btn.Text = "Submit";
            this.action_btn.UseVisualStyleBackColor = true;
            this.action_btn.Click += new System.EventHandler(this.action_btn_Click);
            // 
            // bookloan_rb
            // 
            this.bookloan_rb.AutoSize = true;
            this.bookloan_rb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookloan_rb.Location = new System.Drawing.Point(221, 41);
            this.bookloan_rb.Name = "bookloan_rb";
            this.bookloan_rb.Size = new System.Drawing.Size(98, 20);
            this.bookloan_rb.TabIndex = 9;
            this.bookloan_rb.TabStop = true;
            this.bookloan_rb.Text = "Book Loans";
            this.bookloan_rb.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.addBorrower_rb);
            this.groupBox2.Controls.Add(this.action_btn);
            this.groupBox2.Controls.Add(this.searchbook_rb);
            this.groupBox2.Controls.Add(this.bookloan_rb);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 253);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(664, 76);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Actions";
            // 
            // addBorrower_rb
            // 
            this.addBorrower_rb.AutoSize = true;
            this.addBorrower_rb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addBorrower_rb.Location = new System.Drawing.Point(366, 41);
            this.addBorrower_rb.Name = "addBorrower_rb";
            this.addBorrower_rb.Size = new System.Drawing.Size(108, 20);
            this.addBorrower_rb.TabIndex = 12;
            this.addBorrower_rb.TabStop = true;
            this.addBorrower_rb.Text = "Add Borrower";
            this.addBorrower_rb.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.BackgroundImage = global::LMS_DB_Project.Properties.Resources.Library7;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel1.Location = new System.Drawing.Point(12, 31);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(673, 216);
            this.panel1.TabIndex = 13;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helpToolStripMenuItem,
            this.aboutMeToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(128, 48);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // aboutMeToolStripMenuItem
            // 
            this.aboutMeToolStripMenuItem.Name = "aboutMeToolStripMenuItem";
            this.aboutMeToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.aboutMeToolStripMenuItem.Text = "&About Me";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helpToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(691, 24);
            this.menuStrip1.TabIndex = 15;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // helpToolStripMenuItem1
            // 
            this.helpToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutMeToolStripMenuItem1,
            this.aboutUsToolStripMenuItem});
            this.helpToolStripMenuItem1.Name = "helpToolStripMenuItem1";
            this.helpToolStripMenuItem1.Size = new System.Drawing.Size(95, 20);
            this.helpToolStripMenuItem1.Text = "Click To Know";
            // 
            // aboutMeToolStripMenuItem1
            // 
            this.aboutMeToolStripMenuItem1.Name = "aboutMeToolStripMenuItem1";
            this.aboutMeToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.aboutMeToolStripMenuItem1.Text = "Help";
            this.aboutMeToolStripMenuItem1.Click += new System.EventHandler(this.aboutMeToolStripMenuItem1_Click);
            // 
            // aboutUsToolStripMenuItem
            // 
            this.aboutUsToolStripMenuItem.Name = "aboutUsToolStripMenuItem";
            this.aboutUsToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.aboutUsToolStripMenuItem.Text = "About Us";
            this.aboutUsToolStripMenuItem.Click += new System.EventHandler(this.aboutUsToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(691, 341);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Library Database Management System";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton searchbook_rb;
        private System.Windows.Forms.Button action_btn;
        private System.Windows.Forms.RadioButton bookloan_rb;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton addBorrower_rb;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutMeToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem aboutMeToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem aboutUsToolStripMenuItem;

    }
}

