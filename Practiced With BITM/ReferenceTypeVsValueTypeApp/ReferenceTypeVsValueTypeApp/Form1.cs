using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReferenceTypeVsValueTypeApp
{
    public partial class Form1 : Form
    {
        List<Person> personList = new List<Person>();
        Person aPerson = new Person();

        public Form1()
        {
            InitializeComponent();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            
            aPerson.firstName = firstNameTextBox.Text;
            aPerson.middleName = middleNameTextBox.Text;
            aPerson.lastName = lastNameTextBox.Text; 
           

            firstNameTextBox.Clear();
            middleNameTextBox.Clear();
            lastNameTextBox.Clear();

            personList.Add(aPerson);            
        }

        private void showButton_Click(object sender, EventArgs e)
        {
            foreach (Person person in personList)
            {
                string fullName = person.GetFullName();
                fullNameListBox.Items.Add(fullName);
            }
        }
    }
}
