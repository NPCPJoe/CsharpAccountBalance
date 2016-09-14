using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Account_balance
{
    public partial class Form1 : Form
    {
        private static double balance = 0;
        private static int totalDeposits = 0; // used for summary of all deposits
        private static double totalDepositsAmnt = 0; // used for summary of all deposits dollar amount
        private static int totalChecks = 0; // ued for summar of all checks
        private static double totalCheckAmnt = 0; // used for summary of all checks dollar amounts
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            TBTransactionamount.Clear();
            TBNewaccountbalance.Clear();
            RBCheck.Checked = false;
            RBDeposit.Checked = false;
            RBServicecharge.Checked = false;
            
        }

        private void BtnCalculate_Click(object sender, EventArgs e)
        {
            char transaction = ' '; //What transaction we are performing (deposit, check, service charge)
            // find out what radio button is selected.
            if (RBDeposit.Checked)
                transaction = 'd'; //depoist
            else if (RBServicecharge.Checked)
                transaction = 's'; //service charge
            else if (RBCheck.Checked)
                transaction -= 'c'; //check

            switch(transaction)
            {
                case 'd':
                    if (validateTextBox())// validate if user entered valid number into the text box.
                    {
                        double depoist = Convert.ToDouble(TBTransactionamount.Text);
                        depoistTransaction(depoist);
                        displatBalance();
                    }
                    else
                        errormessage();
                    break;
                        case 's':
                    if (validateTextBox())
                    {
                        double serviceCharge = Convert.ToDouble(TBTransactionamount.Text);
                        serviceChargeTransaction(serviceCharge);
                        displatBalance();
                    }
                    else
                        errormessage();
                    break;
                case 'c':
                    if (validateTextBox())
                    {
                        double check = Convert.ToDouble(TBTransactionamount.Text);
                        checkTransaction(check);
                        displatBalance();
                    }
                    else
                        errormessage();
                    break;
                default:
                    MessageBox.Show("select a transaction");
                    break;

            }
        }
        private void checkTransaction(double c)
        {
            if (balance - c >=0)
            {
                balance -= c;
                totalChecks += 1;
                totalCheckAmnt += c;
            }
            else
            {
                balance -= 10;
                totalCheckAmnt += 10;
                MessageBox.Show("Insufficent funds");
            }
        }
        private void serviceChargeTransaction(double s)
        {
            if (balance - s >= 0)
            {
                balance -= s;
            }
            else
                MessageBox.Show("The transaction cannot be completed because the balance would be less than zero");
        }
        private void errormessage()//displays error message if a valid amount has not been entered.
        {
            MessageBox.Show("Invalid entry. Please select a valid amount.");
        }
        private void displatBalance() // display balance in text box
        {
            TBNewaccountbalance.Text = "$" + balance.ToString();
        }
        private void depoistTransaction(double d)//performs depoist and adds to the curent total
        {
            balance += d;
            totalDeposits += 1;
            totalDepositsAmnt += d;
        }
        private bool validateTextBox()//return true if user enters valid number
        {
            double value;
            return double.TryParse(TBTransactionamount.Text, out value);// pulls the amount the users enters. if the value is able to be a double then it is true. 

        }

        private void BtnSummary_Click(object sender, EventArgs e)
        {
            string message = "total number of depoists:" + totalDeposits;
            message += "\n Total amount of depoists: $" + totalDepositsAmnt;
            message += "\n Total amount of checks:" + totalChecks;
            message += "\n Total amount of checks: " + totalCheckAmnt;

            MessageBox.Show(message);


        }
    }
}
