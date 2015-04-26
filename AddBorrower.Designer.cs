namespace LMS_DB_Project
{
    partial class AddBorrower
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.saveBtnAddBorrower_btn = new System.Windows.Forms.Button();
            this.fname_tb = new System.Windows.Forms.TextBox();
            this.Lname_tb = new System.Windows.Forms.TextBox();
            this.address_tb = new System.Windows.Forms.TextBox();
            this.city_tb = new System.Windows.Forms.TextBox();
            this.state_tb = new System.Windows.Forms.TextBox();
            this.pNum_tb = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(29, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "First Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(29, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Last Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(29, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Address";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(29, 155);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "City";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(29, 191);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "State";
            // 
            // saveBtnAddBorrower_btn
            // 
            this.saveBtnAddBorrower_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveBtnAddBorrower_btn.Location = new System.Drawing.Point(64, 263);
            this.saveBtnAddBorrower_btn.Name = "saveBtnAddBorrower_btn";
            this.saveBtnAddBorrower_btn.Size = new System.Drawing.Size(75, 23);
            this.saveBtnAddBorrower_btn.TabIndex = 5;
            this.saveBtnAddBorrower_btn.Text = "Save";
            this.saveBtnAddBorrower_btn.UseVisualStyleBackColor = true;
            this.saveBtnAddBorrower_btn.Click += new System.EventHandler(this.saveBtnAddBorrower_btn_Click);
            // 
            // fname_tb
            // 
            this.fname_tb.Location = new System.Drawing.Point(154, 42);
            this.fname_tb.Name = "fname_tb";
            this.fname_tb.Size = new System.Drawing.Size(100, 20);
            this.fname_tb.TabIndex = 6;
            // 
            // Lname_tb
            // 
            this.Lname_tb.Location = new System.Drawing.Point(154, 80);
            this.Lname_tb.Name = "Lname_tb";
            this.Lname_tb.Size = new System.Drawing.Size(100, 20);
            this.Lname_tb.TabIndex = 7;
            // 
            // address_tb
            // 
            this.address_tb.Location = new System.Drawing.Point(154, 115);
            this.address_tb.Name = "address_tb";
            this.address_tb.Size = new System.Drawing.Size(100, 20);
            this.address_tb.TabIndex = 8;
            // 
            // city_tb
            // 
            this.city_tb.Location = new System.Drawing.Point(154, 151);
            this.city_tb.Name = "city_tb";
            this.city_tb.Size = new System.Drawing.Size(100, 20);
            this.city_tb.TabIndex = 9;
            // 
            // state_tb
            // 
            this.state_tb.Location = new System.Drawing.Point(154, 187);
            this.state_tb.MaxLength = 2;
            this.state_tb.Name = "state_tb";
            this.state_tb.Size = new System.Drawing.Size(100, 20);
            this.state_tb.TabIndex = 10;
            this.state_tb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.state_tb_KeyPress);
            // 
            // pNum_tb
            // 
            this.pNum_tb.Location = new System.Drawing.Point(154, 219);
            this.pNum_tb.MaxLength = 10;
            this.pNum_tb.Name = "pNum_tb";
            this.pNum_tb.Size = new System.Drawing.Size(100, 20);
            this.pNum_tb.TabIndex = 11;
            this.pNum_tb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.pNum_tb_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(29, 223);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 16);
            this.label6.TabIndex = 12;
            this.label6.Text = "Phone";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(177, 263);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(77, 23);
            this.button1.TabIndex = 13;
            this.button1.Text = "Menu";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // AddBorrower
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(299, 312);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.pNum_tb);
            this.Controls.Add(this.state_tb);
            this.Controls.Add(this.city_tb);
            this.Controls.Add(this.address_tb);
            this.Controls.Add(this.Lname_tb);
            this.Controls.Add(this.fname_tb);
            this.Controls.Add(this.saveBtnAddBorrower_btn);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "AddBorrower";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddBorrower";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AddBorrower_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button saveBtnAddBorrower_btn;
        private System.Windows.Forms.TextBox fname_tb;
        private System.Windows.Forms.TextBox Lname_tb;
        private System.Windows.Forms.TextBox address_tb;
        private System.Windows.Forms.TextBox city_tb;
        private System.Windows.Forms.TextBox state_tb;
        private System.Windows.Forms.TextBox pNum_tb;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
    }
}