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
    public partial class Form2 : Form
    {
        
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            txtName.Text = "";
            txtAddress.Text = "";
            txtAccNumber.Text = "";
            txtBalance.Text = "";
            txtOverdraft.Text = "";
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSaveForm2_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            string address = txtAddress.Text;
            int accountNumber = int.Parse(txtAccNumber.Text);
            double balance = double.Parse(txtBalance.Text);
            double overdraft = double.Parse(txtOverdraft.Text);

            //newAccountData must be both public and static to be able to use it like this
            //Form1 is not an instance of the class, it IS the class
            Form3.NewAccountData(name, address, accountNumber, balance, overdraft);
            Form1.NewAccountData(name, address, accountNumber, balance, overdraft);//Form1 is the class, this is method within the class - has to be public and static
            this.Close();
        }
    }
}
