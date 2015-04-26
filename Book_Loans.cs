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
    public partial class Book_Loans : Form
    {
        public Book_Loans()
        {
            InitializeComponent();
           // autoComplete();
           // autoCompleteCardNo();
           
        }

        DataTable dTable ;
        string bookId_gridView = "";
        int cardNo_gridView = 0;
        int branchId_gridView = 0;
        bool selected_row_gridView = false;



        private void Book_Loans_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            this.Dispose();
            Form1 f1 = new Form1();
            f1.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           

            try
            {


                 if((bookId_bookLoans_tb.Text == "") || (branchId_bookLoans_tb.Text=="") || (cardNo_Book_Loans.Text==""))
                { 

            int x = 0;
            String bookId_bookLoans = bookId_bookLoans_tb.Text.ToString();
            int branchId_bookLoans = Convert.ToInt32(branchId_bookLoans_tb.Text);
            int cardNo_BookLoans = Convert.ToInt32( cardNo_BookLoans_tb.Text);

            String bookId_output = null;
            int  CardNo_output;

            int No_of_copies, No_of_book_loans_borrower = 0, No_of_book_loans_branch, OutputBranch_id;

            String myConnection = "datasource=localhost;port=3306;username=root;password=1234";
          //  String Query = "INSERT INTO `librarydatabasemanagementsystem`.`borrower` (`card_no`, `fname`, `lname`, `address`, `city`, `state`, `phone`) VALUES ( '90043','" + this.fname_tb.Text + "','" + this.Lname_tb.Text + "','" + this.address_tb.Text + "','" + this.city_tb.Text + "','" + this.state_tb.Text + "','" + this.pNum_tb.Text + "');";
            //   String Query = "INSERT INTO librarydatabaseManagementsystem.Borrower(card_no,fname,lname,address,city,state,phone) VALUES ('90043','" + this.fname_tb.Text + "','" + this.Lname_tb.Text + "','" + this.address_tb.Text + "','" + this.city_tb.Text + "','" + this.state_tb.Text + "','" + this.pNum_tb.Text + "');";
            MySqlConnection myCon = new MySqlConnection(myConnection);
          //  MySqlConnection mycon1 = new MySqlConnection(myConnection);
           // MySqlCommand commandDatabase = new MySqlCommand(Query, myCon);
            myCon.Open();

           // MySqlDataReader myReader1;
          //  MySqlDataReader myReader2;
          //  MySqlDataReader myReader3;

             
           // myCon.Open();


            String Que1 = "select card_no,count(*) as No_of_book_loans_borrower from librarydatabasemanagementsystem.book_copies natural join librarydatabasemanagementsystem.book_loans group by card_no";

            String Que2 = "select Branch_id,Book_id,count(*) as No_of_book_loans_branch,no_of_copies from librarydatabasemanagementsystem.book_copies natural join librarydatabasemanagementsystem.book_loans group by book_id,branch_id";

           // MySqlCommand mySql1 = new MySqlCommand(Que1, myCon);

            
           // MySqlCommand mySql2 = new MySqlCommand(Que2, myCon);

          //  mySql2.Parameters.Add("@category", SqlDbType.Int);

            

          //  myReader1 = mySql1.ExecuteReader();

           // myReader2 = mySql2.ExecuteReader();
            
            //DataSet d1 = mySql1.ExecuteNonQuery();
            //DataSet d2 = mySql2.ExecuteNonQuery();


                using (MySqlCommand mysql1 = new MySqlCommand(Que1,myCon))
                {
               using (MySqlDataReader myReader1 = mysql1.ExecuteReader())
               {
            while(myReader1.NextResult())
            {
              //  myReader1.Dispose();
                using (MySqlCommand mySql2 = new MySqlCommand(Que2, myCon))
                using (MySqlDataReader myReader2 = mySql2.ExecuteReader())
                {
                    {
                CardNo_output = myReader1.GetInt32(1);
                No_of_book_loans_borrower = myReader2.GetInt32(2);

                if(CardNo_output==cardNo_BookLoans)
                {

                    if(No_of_book_loans_borrower>2)
                    {
                        MessageBox.Show("Only 3 Books are allowed to borrow!","Error", MessageBoxButtons.OK ,MessageBoxIcon.Information);
                        x = x + 1;

                    }
                    else
                    {
                        
                        while(myReader2.NextResult())
                        {

                            OutputBranch_id = myReader2.GetInt32(1);
                            bookId_output = myReader2.GetString(2);
                            No_of_book_loans_branch = myReader2.GetInt32(3);
                            No_of_copies = myReader2.GetInt32(4);

                            if((OutputBranch_id == branchId_bookLoans) && (bookId_output.Equals(bookId_bookLoans)))
                            {
                                if(No_of_book_loans_branch>=No_of_copies)
                                {
                                    MessageBox.Show("No Book Copies are available at the request Library branch", "Not Available", MessageBoxButtons.OK,MessageBoxIcon.Information);
                                    x = x + 1;

                                }
                                else
                                {

                                    string Query3 = "insert into librarydatabasemanagementsystem.BOOK_LOANS values('" + bookId_bookLoans + " '," + branchId_bookLoans + " ,'" + cardNo_BookLoans + " ',CURDATE(),DATE_ADD(CURDATE(),INTERVAL 14 DAY))";
                                    using (MySqlCommand mySql3 = new MySqlCommand(Query3, myCon))
                                    {
                                        using (MySqlDataReader myReader3 = mySql3.ExecuteReader())
                                        {
                                           // MySqlCommand mySql3 = new MySqlCommand(Query3, myCon);
                                           // myReader3 = mySql3.ExecuteReader();
                                            x = Convert.ToInt32(myReader3);
                                            MessageBox.Show("Successful", "Book Check Out");
                                        }
                                    }

                                }




                            }
                        }
                    }
                    }

                        if(x==0)
                        {
                            String Query3 = "insert into librarydatabasemanagementsystem.BOOK_LOANS values('" + bookId_bookLoans + " '," + branchId_bookLoans + " ,'" + cardNo_BookLoans + " ',CURDATE(),DATE_ADD(CURDATE(),INTERVAL 14 DAY))";
                            using (MySqlCommand mySql3 = new MySqlCommand(Query3, myCon))
                            {
                                using (MySqlDataReader myReader3 = mySql3.ExecuteReader())
                                {
                                  //  myReader3 = mySql3.ExecuteReader();
                                    x = Convert.ToInt32(myReader3);
                                    MessageBox.Show("Successful", "Book Check Out");
                                }
                            }

                        }

                    }

                }



            }
                }
            }

            if(x==0)
            {
                String Query3 = "insert into librarydatabasemanagementsystem.BOOK_LOANS values('" + bookId_bookLoans + " '," + branchId_bookLoans + " ,'" + cardNo_BookLoans + " ',CURDATE(),DATE_ADD(CURDATE(),INTERVAL 14 DAY),null)";
                using (MySqlCommand mySql3 = new MySqlCommand(Query3, myCon))
                {
                    using (MySqlDataReader myReader3 = mySql3.ExecuteReader())
                    {
                       // MySqlCommand mySql3 = new MySqlCommand(Query3, myCon);
                       // myReader3 = mySql3.ExecuteReader();
                       // x = Convert.ToInt32(myReader3);
                        MessageBox.Show("Successful", "Book Check Out");
                    }
                }

            }

          //  myCon.Close();
                 }
                 else{ MessageBox.Show("Please Enter all the required Fields..!","Warning", MessageBoxButtons.OK,MessageBoxIcon.Warning); }

            }
           
            catch( Exception ex)
            {

                MessageBox.Show(ex.ToString());

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {



               // dTable.Clear();
                String Book_id = bookID_Book_Loans.Text.ToString();
                String Query =null;
                int branch_id;
                int No_Of_Cols;
//int card_no = 0;
               // DataTable myTable = new DataTable();
               // if (!(cardNo_BookLoans_tb.Text == ""))
                //{
                 int   card_no = Convert.ToInt32(cardNo_Book_Loans.Text);
               // }
                String Borrower_Lname = borrower_Lname.Text.ToString();
                String Borrower_Fname = borrower_Fname.Text.ToString();

              //  if(!(Book_id=="")|| !(card_no == ""))


                if (Book_id.Equals("") && card_no.Equals("") && Borrower_Lname.Equals("") && !(Borrower_Fname.Equals("")))
                {
                    Query = "use librarydatabasemanagementsystem; select card_no,Book_id,fname,lname,Branch_id from Borrower natural join Book_Loans where fname='" + Borrower_Fname + "'";
                }
                else if (Borrower_Fname.Equals("") && Borrower_Lname.Equals("") && Book_id.Equals("") && !(card_no.Equals("")))
                {
                    Query = "use librarydatabasemanagementsystem; select card_no,Book_id,fname,lname,Branch_id from Book_Loans natural join Borrower where card_no='" + card_no + "'";
                }
                else if (!(Borrower_Fname.Equals("")) && !(Borrower_Lname.Equals("")) && card_no.Equals("") && Book_id.Equals(""))
                {
                    Query = "use librarydatabasemanagementsystem; select card_no,Book_id,fname,lname,Branch_id from Book_Loans natural join Borrower where lname='" + Borrower_Lname + "' and fname='" + Borrower_Fname + "'";
                }
                else if (Borrower_Fname.Equals("") && Borrower_Lname.Equals("") && !(card_no.Equals("")) && !(Book_id.Equals("")))
                {
                    Query = "use librarydatabasemanagementsystem; select card_no,Book_id,fname,lname,Branch_id from Book_Loans natural join Borrower where Book_id='" + Book_id + "' and card_no='" + card_no + "'";
                }
                else if (Book_id.Equals("") && card_no.Equals("") && Borrower_Fname.Equals("") && !(Borrower_Lname.Equals("")))
                {
                    Query = "use librarydatabasemanagementsystem; select card_no,Book_id,fname,lname,Branch_id from Borrower natural join Book_Loans where lname='" + Borrower_Lname + "'";
                }
                else if (Borrower_Fname.Equals("") && !(Borrower_Lname.Equals("")) && card_no.Equals("") && !(Book_id.Equals("")))
                {
                    Query = "use librarydatabasemanagementsystem; select card_no,Book_id,fname,lname,Branch_id from Book_Loans natural join Borrower where lname='" + Borrower_Lname + "' and Book_id='" + Book_id + "'";
                }
                else if (!(Borrower_Fname.Equals("")) && Borrower_Lname.Equals("") && !(card_no.Equals("")) && (Book_id.Equals("")))
                {
                    Query = "use librarydatabasemanagementsystem; select card_no,Book_id,fname,lname,Branch_id from Book_Loans natural join Borrower where card_no='" + card_no + "' and fname='" + Borrower_Fname + "'";
                }

                else if (!(Borrower_Fname.Equals("")) && Borrower_Lname.Equals("") && card_no.Equals("") && !(Book_id.Equals("")))
                {
                    Query = "use librarydatabasemanagementsystem; select card_no,Book_id,fname,lname,Branch_id from Book_Loans natural join Borrower where Book_id='" + Book_id + "' and fname='" + Borrower_Fname + "'";
                }
                else if (!(Borrower_Fname.Equals("")) && Borrower_Lname.Equals("") && !(card_no.Equals("")) && !(Book_id.Equals("")))
                {
                    Query = "use librarydatabasemanagementsystem; select card_no,Book_id,fname,lname,Branch_id from Book_Loans natural join Borrower where fname='" + Borrower_Fname + "' and card_no='" + card_no + "' and Book_id='" + Book_id + "'";
                }
                else if (!(Borrower_Fname.Equals("")) && !(Borrower_Lname.Equals("")) && card_no.Equals("") && !(Book_id.Equals("")))
                {
                    Query = "use librarydatabasemanagementsystem; select card_no,Book_id,fname,lname,Branch_id from Book_Loans natural join Borrower where fname='" + Borrower_Fname + "' and lname='" + Borrower_Lname + "' and Book_id='" + Book_id + "'";
                }
                else if (Borrower_Fname.Equals("") && !(Borrower_Lname.Equals("")) && !(card_no.Equals("")) && Book_id.Equals(""))
                {
                    Query = "use librarydatabasemanagementsystem; select card_no,Book_id,fname,lname,Branch_id from Book_Loans natural join Borrower where lname='" + Borrower_Lname + "' and card_no='" + card_no + "'";
                }

                else if (Borrower_Fname.Equals("") && !(Borrower_Lname.Equals("")) && !(card_no.Equals("")) && !(Book_id.Equals("")))
                {
                    Query = "use librarydatabasemanagementsystem; select card_no,Book_id,fname,lname,Branch_id from Book_Loans natural join Borrower where card_no='" + card_no + "' and lname='" + Borrower_Lname + "' and Book_id='" + Book_id + "'";
                }
                else if (Borrower_Fname.Equals("") && Borrower_Lname.Equals("") && card_no.Equals("") && !(Book_id.Equals("")))
                {
                    Query = "use librarydatabasemanagementsystem; select card_no,Book_id,fname,lname,Branch_id from Book_Loans natural join Borrower where Book_id='" + Book_id + "'";
                }
                else
                    MessageBox.Show("All fields are empty!Please enter atleast one field");
                String myConnection1 = "datasource=localhost;port=3306;username=root;password=1234";

               
                MySqlConnection mySql_bookId = new MySqlConnection(myConnection1);
               

                MySqlDataAdapter SDA = new MySqlDataAdapter();

                DataTable dTable = new DataTable();
                DataSet dSet = new DataSet();

                MySqlConnection myCon1 = new MySqlConnection(myConnection1);
                myCon1.Open();
                MySqlCommand commandDatabase1 = new MySqlCommand(Query, myCon1);

               


                SDA.SelectCommand = commandDatabase1;
                SDA.Fill(dTable);
                BindingSource bSource = new BindingSource();
                bSource.DataSource = dTable;
                dataGridView_Book_Loans.DataSource = bSource;
                SDA.Update(dTable);

                //UPDATE book_loans SET Date_in = current_date() WHERE card_no = '9001' AND Branch_id = '2';
/*
                MySqlDataReader myReader;
                myReader = commandDatabase1.ExecuteReader();
               
               
              
                No_Of_Cols = new DataView(dTable).Table.Columns.Count;


               MessageBox.Show(No_Of_Cols.ToString());
                //List lstMyList = new List();
                List<string> mylist = new List<string>();
                foreach (DataColumn column in dTable.Columns)
                {
                    mylist.Add(column.ColumnName);

                }
                while (myReader.NextResult())
                {
                    card_no = myReader.GetInt32(1);
                    Book_id = myReader.GetString(2);
                    Borrower_Fname = myReader.GetString(3);
                    Borrower_Lname = myReader.GetString(4);
                    branch_id = myReader.GetInt32(5);
                    List<String> row = new List<String>();
                    List<String> info = new List<String>();
                    for (int i = 1; i <= No_Of_Cols; i++)
                    {
                        row.Add(myReader.GetString(i));

                    }
                    foreach (string s in row)
                    {
                        info.Add(s);
                    }


                    //DataTable myTable = new DataTable(info,mylist);

                } */


            }

            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());

            }
            

        }

        void autoComplete()
        {
            bookID_Book_Loans.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            bookID_Book_Loans.AutoCompleteSource = AutoCompleteSource.CustomSource;
            AutoCompleteStringCollection bookId_collection = new AutoCompleteStringCollection();

            String myConnection1 = "datasource=localhost;port=3306;username=root;password=1234";

            String Query_bookId_bookLoans_dropDown = "use librarydatabasemanagementsystem; SELECT Book_id FROM librarydatabasemanagementsystem.book_loans";
            MySqlConnection mySql_bookId = new MySqlConnection(myConnection1);
            MySqlCommand myBookIdCmd = new MySqlCommand(Query_bookId_bookLoans_dropDown, mySql_bookId);
            MySqlDataReader myr1;
            mySql_bookId.Open();
            myr1 = myBookIdCmd.ExecuteReader();

            while (myr1.Read())
            {


                String bookId = myr1.GetString("Book_id");

                bookId_collection.Add(bookId);
            }
            mySql_bookId.Close();

            bookID_Book_Loans.AutoCompleteCustomSource = bookId_collection;

           
        }

        private void bookID_Book_Loans_TextChanged(object sender, EventArgs e)
        {
            DataView dV = new DataView(dTable);
            dV.RowFilter = string.Format("Book_id LIKE '%{0}%' ", bookID_Book_Loans.Text);
            dataGridView_Book_Loans.DataSource = dV;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(selected_row_gridView)

            {
            try
            {

                //MySqlCommandBuilder scbldr;
                //MySqlDataAdapter sdA = new MySqlDataAdapter();
                //scbldr = new MySqlCommandBuilder(sdA);
                MySqlConnection con = new MySqlConnection("datasource=localhost;port=3306;username=root;password=1234");
                MySqlDataAdapter SDA = new MySqlDataAdapter();
                String Query_checkin = " use librarydatabasemanagementsystem; UPDATE book_loans SET Date_in = current_date() WHERE card_no = '"+cardNo_gridView+"' AND book_id = '"+bookId_gridView+"'";

                DataTable dTable = new DataTable();
                DataSet ds = new DataSet();
                con.Open();
                // dTable.data
                MySqlCommand commandDatabase = new MySqlCommand(Query_checkin, con);
                // con.Open();
                SDA.SelectCommand = commandDatabase;

                SDA.Fill(dTable);
                BindingSource bSource = new BindingSource();
                bSource.DataSource = dTable;
                dataGridView_Book_Loans.DataSource = bSource;
                // dTable.Columns.Add(new DataColumn("Title"),);

                SDA.Update(dTable);

                MessageBox.Show("Checked in !");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"Error",MessageBoxButtons.OK,MessageBoxIcon.Error);


            }
        }
            else { MessageBox.Show("Please select a row to checkin.. ", "Select Row", MessageBoxButtons.OK, MessageBoxIcon.Information); }
        }

        private void dataGridView_Book_Loans_SelectionChanged(object sender, EventArgs e)
        {

            selected_row_gridView = true;
            foreach(DataGridViewRow row in dataGridView_Book_Loans.SelectedRows)
            {
                try {
                 bookId_gridView = row.Cells[1].Value.ToString();
                  cardNo_gridView = Convert.ToInt32( row.Cells[0].Value);
                branchId_gridView = Convert.ToInt32( row.Cells[4].Value);
                     }
                 catch(Exception ex)
                 {
                    // MessageBox.Show("Given Card ID not there", MessageBoxButtons.OK); }
                     MessageBox.Show(ex.Message);
                     MessageBox.Show("Given ID not there");
                 }


            }
        }

     

    }
}
