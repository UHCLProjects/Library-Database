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
    public partial class AddBorrower : Form
    {
        public AddBorrower()
        {
            InitializeComponent();
        }

        bool flag_for_Save = false;

        private void AddBorrower_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            this.Dispose();
            Form1 f1 = new Form1();
            f1.ShowDialog();
        }

        void addBorrower()
        {

            String myConnection = "datasource=localhost;port=3306;username=root;password=1234";
            String Query = "INSERT INTO `librarydatabasemanagementsystem`.`borrower` (`fname`, `lname`, `address`, `city`, `state`, `phone`) VALUES ('" + this.fname_tb.Text + "','" + this.Lname_tb.Text + "','" + this.address_tb.Text + "','" + this.city_tb.Text + "','" + this.state_tb.Text + "','" + this.pNum_tb.Text + "');";
            //   String Query = "INSERT INTO librarydatabaseManagementsystem.Borrower(card_no,fname,lname,address,city,state,phone) VALUES ('90043','" + this.fname_tb.Text + "','" + this.Lname_tb.Text + "','" + this.address_tb.Text + "','" + this.city_tb.Text + "','" + this.state_tb.Text + "','" + this.pNum_tb.Text + "');";
            MySqlConnection myCon = new MySqlConnection(myConnection);
            MySqlCommand commandDatabase = new MySqlCommand(Query, myCon);
            MySqlDataReader myReader;
           // commandDatabase.Parameters.AddWithValue("fname", fname_tb.Text.ToString());

            

            try
            {

                myCon.Open();
                myReader = commandDatabase.ExecuteReader();
                MessageBox.Show("Saved");
                while (myReader.Read())
                {



                }

            }

            catch (MySqlException)

            { MessageBox.Show("The Borrower Information is already in the database","Duplicate Entry",MessageBoxButtons.OK,MessageBoxIcon.Warning);

            flag_for_Save = false;
            
            }

        }
        private void saveBtnAddBorrower_btn_Click(object sender, EventArgs e)
        {
            flag_for_Save = true;

            if (!(fname_tb.Text.Equals("")) && !(Lname_tb.Text.Equals("")) && !(address_tb.Text.Equals("")) && !(city_tb.Text.Equals("")) && !(state_tb.Text.Equals("")) && !(pNum_tb.Text.Equals("")))
            {

                addBorrower();
            }

            else
            {

                MessageBox.Show("Please fill all the details.!", "Fill ou the form", MessageBoxButtons.OK,MessageBoxIcon.Error);




            }
           
           

         //   String myConnection = "datasource=localhost;port=3306;username=root;password=1234";
         //   String Query = "INSERT INTO `librarydatabasemanagementsystem`.`borrower` (`card_no`, `fname`, `lname`, `address`, `city`, `state`, `phone`) VALUES ( '90043','" + this.fname_tb.Text + "','" + this.Lname_tb.Text + "','" + this.address_tb.Text + "','" + this.city_tb.Text + "','" + this.state_tb.Text + "','" + this.pNum_tb.Text + "');";
         ////   String Query = "INSERT INTO librarydatabaseManagementsystem.Borrower(card_no,fname,lname,address,city,state,phone) VALUES ('90043','" + this.fname_tb.Text + "','" + this.Lname_tb.Text + "','" + this.address_tb.Text + "','" + this.city_tb.Text + "','" + this.state_tb.Text + "','" + this.pNum_tb.Text + "');";
         //   MySqlConnection myCon = new MySqlConnection(myConnection);
         //   MySqlCommand commandDatabase = new MySqlCommand(Query,myCon);
         //   MySqlDataReader myReader;
         //   try
         //   {

         //       myCon.Open();
         //       myReader = commandDatabase.ExecuteReader();
         //       MessageBox.Show("Saved");
         //       while (myReader.Read())
         //       {



         //       }

         //   }

         //   catch (Exception ex)

         //   { MessageBox.Show(ex.ToString()); }


            //  MySqlDataAdapter myDataAdapter = new MySqlDataAdapter();
           // MySqlCommand SelectCommand = new MySqlCommand("SELECT * from sample_library.logindetails where username = '" + this..Text + "' and password = '" + this.password_txt.Text + "';", myCon);
            // MySqlCommandBuilder cb = new MySqlCommandBuilder(myDataAdapter);
            //MySqlDataReader myReader;
            //myCon.Open();
            //myReader = SelectCommand.ExecuteReader();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (flag_for_Save)
            {
                this.Hide();
                this.Dispose();
                Form1 f1 = new Form1();
                f1.ShowDialog();
            }
            else
            {
                DialogResult myDialogResult;

                myDialogResult = MessageBox.Show("Would you like to save the data?", "caution",MessageBoxButtons.YesNo);

                if(myDialogResult == DialogResult.Yes)
                {


                    addBorrower();
                }
                else
                {

                    this.Hide();
                    this.Dispose();
                    Form1 f1 = new Form1();
                    f1.ShowDialog();

                }

            }
        }

        private void pNum_tb_KeyPress(object sender, KeyPressEventArgs e)
        {

            char ch = e.KeyChar;
            if(!char.IsDigit(e.KeyChar) && ch != 8 && ch != 46)
            {

                e.Handled = true;
            }
        }

        private void state_tb_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if(!char.IsLetter(ch))
            {

                e.Handled = true;

            }

        }
    }
}
