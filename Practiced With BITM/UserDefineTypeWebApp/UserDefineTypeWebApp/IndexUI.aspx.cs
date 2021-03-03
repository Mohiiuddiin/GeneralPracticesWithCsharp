using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace UserDefineTypeWebApp
{
    public partial class IndexUI : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void saveButton_Click(object sender, EventArgs e)
        {
            //string fName = firstNameTextBox.Text;

            Person aPerson = new Person();
            aPerson.firstName = firstNameTextBox.Text;
            aPerson.middleName = middleNameTextBox.Text;
           aPerson.lastName = lastNameTextBox.Text;
            firstNameTextBox.Text = String.Empty;
            middleNameTextBox.Text = String.Empty;
            lastNameTextBox.Text = String.Empty;
            ViewState["personVS"] = aPerson;
        }

        protected void showButton_Click(object sender, EventArgs e)
        {
            Person newPerson = (Person)ViewState["personVS"];
            //string fullName = newPerson.firstName + " " + newPerson.middleName + " " + newPerson.lastName;
            string fullName = newPerson.GetFullName();
            fullNameListBox.Items.Add(fullName);
        }
    }
}