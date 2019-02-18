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
    public partial class Form1 : Form
    {
        public static Form3 f3 = new Form3();
        public Form2 f2 = new Form2();

        
        const int MAX_CUST = 100;
        static Account[] Bank = new Account[MAX_CUST]; //I had to add static to this to make the Bank array appear in the NewAccountData method below

        //Bank[0]... save account info into bank array

        public static void NewAccountData(string n, string ad, int an, double b, double o) //Grabs all the details from Form2
        {
            int counter = 0; //start counting at zero
            for (int i = 0; i < MAX_CUST; i++) //loop through all indexes of array to find next available index
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

        public static void EditedAccountData(string n, string ad, int an, double b, double o)
        {
            int index = int.Parse(f3.editField);
            
            Bank[index].name = n;
            Bank[index].address = ad;
            Bank[index].accountNumber = an;
            Bank[index].balance = b;
            Bank[index].overdraft = o;
        }


        enum AccountState
        {
            Active, Closed, Frozen, New, UnderAudit
        }

        struct Account
        {
            public AccountState state;
            public string name;
            public string address;
            public int accountNumber;
            public double balance;
            public double overdraft;
        }

        public Form1()
        {
            InitializeComponent();
        }

        public void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            for (int i = 0; i < MAX_CUST; i++)
            {
                if (Bank[i].accountNumber != 0)
                {
                    listBox1.Items.Add(i + " " + Bank[i].state + " " + Bank[i].name + " " + Bank[i].address + " " + Bank[i].accountNumber + " " + Bank[i].balance + " " + Bank[i].overdraft);
                }    
            }         
        }

        private void btnAddNewAccount_Click(object sender, EventArgs e)
        {
            f2.ShowDialog();
        }

        private void btnEditAccount_Click(object sender, EventArgs e)
        {
            int placeholder;
            if (int.TryParse(this.txtEditAccount.Text, out placeholder)) //this only allows form 3 to open when the value in txtEditAccount is an integer
            {
                if(placeholder < Form3.Bank.Length)
                {
                    f3.ShowDialog();
                }         
            }         
            else
            {
                // error handling here - probably use diablogue box
            }         
        }


        private void txtEditAccount_TextChanged(object sender, EventArgs e)
        {
            f3.editField = txtEditAccount.Text; //Uses the string editField from Form 3 for the input value of the text box
        }
    }
}
