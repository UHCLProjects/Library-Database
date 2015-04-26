using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace LMS_DB_Project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            contextMenuStrip1.Visible = true;
            contextMenuStrip1.Enabled = true;
            searchbook_rb.Checked = true;

        }

        private void action_btn_Click(object sender, EventArgs e)
        {
            
            if (searchbook_rb.Checked)
            {
                this.Hide();
                Search_Books sb = new Search_Books();
                sb.ShowDialog();
       
            }
            
            else if(bookloan_rb.Checked)
            {
                this.Hide();
                Book_Loans bL = new Book_Loans();
                bL.ShowDialog();

            }
            
            else if(addBorrower_rb.Checked)
            {
                this.Hide();
                AddBorrower addBorrower = new AddBorrower();
                addBorrower.ShowDialog();


            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void aboutMeToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void aboutUsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutUsForm abtus = new AboutUsForm();
            abtus.ShowDialog();
        }

       
            
        

       
    }
}
