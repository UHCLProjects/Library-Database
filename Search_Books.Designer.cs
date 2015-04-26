namespace LMS_DB_Project
{
    partial class Search_Books
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.authorName_tb = new System.Windows.Forms.TextBox();
            this.bookTitle_tb = new System.Windows.Forms.TextBox();
            this.bookId_tb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.search_books_btn = new System.Windows.Forms.Button();
            this.searchBooksGridView = new System.Windows.Forms.DataGridView();
            this.SearchByAuthor_GB = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchBooksGridView)).BeginInit();
            this.SearchByAuthor_GB.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.SearchByAuthor_GB);
            this.groupBox1.Controls.Add(this.searchBooksGridView);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.authorName_tb);
            this.groupBox1.Controls.Add(this.bookTitle_tb);
            this.groupBox1.Controls.Add(this.bookId_tb);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.search_books_btn);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(674, 342);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search For Books";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(19, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Author";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(19, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Book Title";
            // 
            // authorName_tb
            // 
            this.authorName_tb.Location = new System.Drawing.Point(103, 123);
            this.authorName_tb.Name = "authorName_tb";
            this.authorName_tb.Size = new System.Drawing.Size(100, 22);
            this.authorName_tb.TabIndex = 4;
            this.authorName_tb.TextChanged += new System.EventHandler(this.authorName_tb_TextChanged);
            // 
            // bookTitle_tb
            // 
            this.bookTitle_tb.Location = new System.Drawing.Point(103, 64);
            this.bookTitle_tb.Name = "bookTitle_tb";
            this.bookTitle_tb.Size = new System.Drawing.Size(100, 22);
            this.bookTitle_tb.TabIndex = 3;
            // 
            // bookId_tb
            // 
            this.bookId_tb.Location = new System.Drawing.Point(103, 23);
            this.bookId_tb.Name = "bookId_tb";
            this.bookId_tb.Size = new System.Drawing.Size(100, 22);
            this.bookId_tb.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Book ID";
            // 
            // search_books_btn
            // 
            this.search_books_btn.Location = new System.Drawing.Point(55, 298);
            this.search_books_btn.Name = "search_books_btn";
            this.search_books_btn.Size = new System.Drawing.Size(120, 33);
            this.search_books_btn.TabIndex = 0;
            this.search_books_btn.Text = "Search Books";
            this.search_books_btn.UseVisualStyleBackColor = true;
            this.search_books_btn.Click += new System.EventHandler(this.search_books_btn_Click);
            // 
            // searchBooksGridView
            // 
            this.searchBooksGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.searchBooksGridView.Location = new System.Drawing.Point(209, 11);
            this.searchBooksGridView.Name = "searchBooksGridView";
            this.searchBooksGridView.Size = new System.Drawing.Size(457, 320);
            this.searchBooksGridView.TabIndex = 1;
            // 
            // SearchByAuthor_GB
            // 
            this.SearchByAuthor_GB.Controls.Add(this.label6);
            this.SearchByAuthor_GB.Controls.Add(this.label5);
            this.SearchByAuthor_GB.Controls.Add(this.label4);
            this.SearchByAuthor_GB.Controls.Add(this.textBox3);
            this.SearchByAuthor_GB.Controls.Add(this.textBox2);
            this.SearchByAuthor_GB.Controls.Add(this.textBox1);
            this.SearchByAuthor_GB.Location = new System.Drawing.Point(9, 151);
            this.SearchByAuthor_GB.Name = "SearchByAuthor_GB";
            this.SearchByAuthor_GB.Size = new System.Drawing.Size(194, 127);
            this.SearchByAuthor_GB.TabIndex = 7;
            this.SearchByAuthor_GB.TabStop = false;
            this.SearchByAuthor_GB.Text = "Author Name";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(94, 21);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(94, 61);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 22);
            this.textBox2.TabIndex = 1;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(94, 89);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 22);
            this.textBox3.TabIndex = 2;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "First";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 61);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Middle";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 95);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "Last";
            // 
            // Search_Books
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(689, 349);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Search_Books";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Search_Books";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Search_Books_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchBooksGridView)).EndInit();
            this.SearchByAuthor_GB.ResumeLayout(false);
            this.SearchByAuthor_GB.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button search_books_btn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox authorName_tb;
        private System.Windows.Forms.TextBox bookTitle_tb;
        private System.Windows.Forms.TextBox bookId_tb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView searchBooksGridView;
        private System.Windows.Forms.GroupBox SearchByAuthor_GB;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
    }
}