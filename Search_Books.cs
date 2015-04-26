using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace LMS_DB_Project
{
    public partial class Search_Books : Form
    {
        public Search_Books()
        {
            InitializeComponent();
        }

        private void Search_Books_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            this.Dispose();
            Form1 f1 = new Form1();
            f1.ShowDialog();
        }

        private void search_books_btn_Click(object sender, EventArgs e)
        {
            bool executeQuery = true;

            try
            {
            MySqlConnection con = new MySqlConnection("datasource=localhost;port=1234;username=root;password=1234");
            
            
           // String query = "SELECT b.*,ba.Author_name,bc.Branch_id,bc.No_of_copies FROM librarydatabasemanagementsystem.book AS b, librarydatabasemanagementsystem.book_authors AS ba, librarydatabasemanagementsystem.book_copies AS bc ";
            MySqlDataAdapter SDA = new MySqlDataAdapter();
            String book_Id_searchBook = bookId_tb.Text.ToString();
            String title_SearchBook = bookTitle_tb.Text.ToString();
            String book_author_searchBook = authorName_tb.Text.ToString();
            String Query = null;

            if(book_Id_searchBook.Equals("") )

            {
                if(!title_SearchBook.Equals("") && !book_author_searchBook.Equals(""))
                {
                    Query = "use librarydatabasemanagementsystem; select temp.Book_id, temp.Branch_id, No_of_copies as total_available, count(book_loans.Book_id) as available_copies from librarydatabasemanagementsystem.book_loans right outer join (select book.Book_id, Branch_id, No_of_copies, Author_name from librarydatabasemanagementsystem.book_copies natural join book left outer join librarydatabasemanagementsystem.book_authors on book.book_id=book_authors.book_id where title like '%" + title_SearchBook + "%' and author_name like '%" + book_author_searchBook + "%') as temp on book_loans.Book_id and Book_loans.branch_id = temp.branch_id group by temp.Book_id, temp.Branch_id, No_of_copies";
                }
                else { executeQuery = false; MessageBox.Show("Please enter atleast two combinations to search", "Invalid entries", MessageBoxButtons.OK, MessageBoxIcon.Information); }
               // String Query1 ="select temp.book_id, temp.branch_id,no_of_copies as total,no_of_copies-count(book_loans.book_id) as available from book_loans right join (select book.book_id,branch_id,no_of_copies,author_name from book_copies natural join book left join book_authors on book.book_id=book_authors.book_id where title like '%" + title1 + "%' and author_name like '%" + authorname + "%') as temp on book_loans.book_id=temp.book_id and book_loans.branch_id=temp.branch_id group by temp.book_id,temp.branch_id,no_of_copies";			 
            }
           else if(title_SearchBook.Equals("") )
            {
               if(!book_Id_searchBook.Equals("") && !book_author_searchBook.Equals(""))
               {
                   Query = "use librarydatabasemanagementsystem; select temp.book_id, temp.branch_id,no_of_copies as total,no_of_copies, count(book_loans.book_id) as available from librarydatabasemanagementsystem.book_loans right outer join (select book.book_id,branch_id,no_of_copies,author_name from librarydatabasemanagementsystem.book_copies natural join book left outer join librarydatabasemanagementsystem.book_authors on book.book_id=book_authors.book_id where book.book_id like '%" + book_Id_searchBook + "%' and author_name like '%" + book_author_searchBook + "%') as temp on book_loans.book_id=temp.book_id and book_loans.branch_id=temp.branch_id group by temp.book_id,temp.branch_id,no_of_copies";

               }
               else { executeQuery = false; MessageBox.Show("Please enter atleast two combinations to search", "Invalid entries", MessageBoxButtons.OK, MessageBoxIcon.Information); }

            }

            else if(book_author_searchBook.Equals(""))
            {

                if(!title_SearchBook.Equals("") && !book_Id_searchBook.Equals(""))
                {
                    Query = "use librarydatabasemanagementsystem; select temp.book_id, temp.branch_id,no_of_copies as total,no_of_copies, count(book_loans.book_id) as available from librarydatabasemanagementsystem.book_loans right join (select book.book_id,branch_id,no_of_copies,author_name from librarydatabasemanagementsystem.book_copies natural join book left join librarydatabasemanagementsystem.book_authors on book.book_id=book_authors.book_id where book.book_id like '%" + book_Id_searchBook + "%' and title like '%" + title_SearchBook + "%') as temp on book_loans.book_id=temp.book_id and book_loans.branch_id=temp.branch_id group by temp.book_id,temp.branch_id,no_of_copies";

                }

                else { executeQuery = false; MessageBox.Show("Please enter atleast two combinations to search", "Invalid entries", MessageBoxButtons.OK, MessageBoxIcon.Information); }
            }
            else if(!book_Id_searchBook.Equals("") && !book_author_searchBook.Equals("") && !title_SearchBook.Equals(""))
            {

                Query = "use librarydatabasemanagementsystem; select temp.book_id, temp.branch_id,no_of_copies as total,no_of_copies, count(book_loans.book_id) as available from book_loans right join (select book.book_id,branch_id,no_of_copies,author_name from book_copies natural join book left join book_authors on book.book_id=book_authors.book_id where book.book_id like '%" + book_Id_searchBook + "%' and author_name like '%" + book_author_searchBook + "%' and title like '%" + title_SearchBook + "%') as temp on book_loans.book_id=temp.book_id and book_loans.branch_id=temp.branch_id group by temp.book_id,temp.branch_id,no_of_copies";

            }

            else { executeQuery = false; MessageBox.Show("Please enter atleast two combinations to search", "Invalid entries", MessageBoxButtons.OK, MessageBoxIcon.Information); }

            
            if(executeQuery)
            {
            DataTable dTable = new DataTable();
            DataSet ds = new DataSet();
            con.Open();
           // dTable.data
            MySqlCommand commandDatabase = new MySqlCommand(Query, con);
           // con.Open();
            SDA.SelectCommand = commandDatabase;

            SDA.Fill(dTable);
            BindingSource bSource = new BindingSource();
            bSource.DataSource = dTable;
            searchBooksGridView.DataSource = bSource;
           // dTable.Columns.Add(new DataColumn("Title"),);

            SDA.Update(dTable);

           // int No_Of_Cols = new DataView(dTable, "Book_id = 'Y'", "Book_id", DataViewRowState.CurrentRows).Table.Columns.Count;

            //MessageBox.Show(No_Of_Cols.ToString());

           // DataView dv = new DataView(dTable);
           // dv.RowFilter = ;
           //searchBooksGridView.DataSource = dv;





           // MySqlDataReader sda;
          //  con.Open();
           // sda = commandDatabase.ExecuteReader();
            //ds = sda.getda
            }
            }
            catch (Exception ex)
            { MessageBox.Show("You Got an Exception {0} :" +ex.ToString(), "exception"); }

        }

        private void authorName_tb_TextChanged(object sender, EventArgs e)
        {
            if(authorName_tb.Text.Equals(""))
            {

                SearchByAuthor_GB.Enabled = true;
            }
            else
            {

                SearchByAuthor_GB.Enabled = false;

            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if(textBox1.Text.Equals(""))
            {

                authorName_tb.Enabled = true;

            }
            else
            {

                authorName_tb.Enabled = false;
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (textBox2.Text.Equals(""))
            {

                authorName_tb.Enabled = true;

            }
            else
            {
                authorName_tb.Enabled = false;
            }
        }
        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            if (textBox3.Text.Equals(""))
            {
                authorName_tb.Enabled = true;
            }
            else
            {
                authorName_tb.Enabled = false;
            }
        }
    }
}
