using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YABA
{
    public partial class Form3 : Form
    {
        const int MAX_CUST = 100;
        public static Account[] Bank = new Account[MAX_CUST];

        public string editField; //string used to pull in the account index number from the text box on form1

        public static void NewAccountData(string n, string ad, int an, double b, double o) //Grabs all the details from Form2
        {
            int counter = 0;
            for (int i = 0; i < MAX_CUST; i++)
            {
                if (Bank[i].name == null)
                {
                    counter = i;
                    break;
                }
            }
            Bank[counter].state = AccountState.New;
            Bank[counter].name = n;
            Bank[counter].address = ad;
            Bank[counter].accountNumber = an;
            Bank[counter].balance = b;
            Bank[counter].overdraft = o;
        }


        public enum AccountState
        {
            Active, Closed, Frozen, New, UnderAudit
        }

        public struct Account
        {
            public AccountState state;
            public string name;
            public string address;
            public int accountNumber;
            public double balance;
            public double overdraft;
        }
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            int index; //sets index as an int variable to use within the Bank array to pull up different accounts in the edit window
            bool inRangeAndParseable = int.TryParse(editField, out index) && index < Bank.Length; //index becomes the value of editField; uses tryparse to make sure it's an integer value
            if (inRangeAndParseable) {
                txtName.Text = Bank[index].name;
                txtAddress.Text = Bank[index].address;
                txtAccNumber.Text = "" + Bank[index].accountNumber;
                txtBalance.Text = "" + Bank[index].balance;
                txtOverdraft.Text = "" + Bank[index].overdraft;
            }
            else
            {
                // error handling goes here
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSaveForm2_Click(object sender, EventArgs e) //save button for editing account data
        {
            int index; //first bit saves the data you edited into the array, based on the index number for the account
            bool inRangeAndParseable = int.TryParse(editField, out index) && index < Bank.Length;
            if (inRangeAndParseable)
            {
                Bank[index].name = txtName.Text;
                Bank[index].address = txtAddress.Text;
                Bank[index].accountNumber = int.Parse(txtAccNumber.Text);
                Bank[index].balance = double.Parse(txtBalance.Text);
                Bank[index].overdraft = double.Parse(txtOverdraft.Text);
            }

            //second bit sends the data back into form 1
            string name = txtName.Text;
            string address = txtAddress.Text;
            int accountNumber = int.Parse(txtAccNumber.Text);
            double balance = double.Parse(txtBalance.Text);
            double overdraft = double.Parse(txtOverdraft.Text);

            Form1.EditedAccountData(name, address, accountNumber, balance, overdraft); //sends data into the method in Form1
            this.Close();
        }
    }
}
