using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AccountWebApp
{
    public partial class IndexUI : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void createButton_Click(object sender, EventArgs e)
        {
            Account account = new Account();
            account.AccountNumber = accountNumberTextBox.Text;
            account.CustomerName = customerNameTextBox.Text;

            accountNumberTextBox.Enabled = false;
            customerNameTextBox.Enabled = false;
            createButton.Enabled = false;

            ViewState["accountVS"] = account;
        }

        protected void depositButton_Click(object sender, EventArgs e)
        {
            Account account = (Account)ViewState["accountVS"];
            string message = account.Deposit(Convert.ToDouble(amountTextBox.Text));
            ViewState["accountVS"] = account;
            reportLabel.Text = message;
        }

        protected void withdrawButton_Click(object sender, EventArgs e)
        {

            Account account = (Account)ViewState["accountVS"];
            string message = account.Withdraw(Convert.ToDouble(amountTextBox.Text));
            ViewState["accountVS"] = account;
            reportLabel.Text = message;
        }

        protected void reportButton_Click(object sender, EventArgs e)
        {
            Account account = (Account)ViewState["accountVS"];
            string report = account.GetReport();
            reportLabel.Text = report;

        }
    }
}