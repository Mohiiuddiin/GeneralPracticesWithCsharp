﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PersonalInformationApp
{
    public partial class Form1 : Form
    {

       string firstName, lastName, fatherName, motherName, address;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            firstName = firstNameTextBox.Text;
            lastName= lastNameTextBox.Text;
            fatherName = fatherNameTextBox.Text;
            motherName= motherNameTextBox.Text;
            address= addressTextBox.Text;

            firstNameTextBox.Clear();
            lastNameTextBox.Clear();
            fatherNameTextBox.Clear();
            motherNameTextBox.Clear();
            addressTextBox.Clear();

        }

        private void showAllButton_Click(object sender, EventArgs e)
        {
            firstNameTextBox.Text = firstName;
            lastNameTextBox.Text = lastName;
            fatherNameTextBox.Text = fatherName;
            motherNameTextBox.Text = motherName;
            addressTextBox.Text = address;

           



        }

        private void nameButton_Click(object sender, EventArgs e)
        {
            firstNameTextBox.Text = firstName;
            lastNameTextBox.Text = lastName;

            fatherNameTextBox.Clear();
            motherNameTextBox.Clear();
            addressTextBox.Clear();

        }

        private void parentsNameButton_Click(object sender, EventArgs e)
        {
            fatherNameTextBox.Text = fatherName;
            motherNameTextBox.Text = motherName;


            firstNameTextBox.Clear();
            lastNameTextBox.Clear();
            
            addressTextBox.Clear();

           
        }

        private void addressButton_Click(object sender, EventArgs e)
        {
            addressTextBox.Text = address;

            firstNameTextBox.Clear();
            lastNameTextBox.Clear();
            fatherNameTextBox.Clear();
            motherNameTextBox.Clear();
        }
    }
}
