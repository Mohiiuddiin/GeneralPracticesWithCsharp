using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EntryNumberApp
{
    public partial class Form1 : Form
    {
        List<int> number=new List<int>();
        int sum = 0;
        public Form1()
        {
            InitializeComponent();
        }

        public void addButton_Click(object sender, EventArgs e)
        {
            number.Add(Convert.ToInt32(numberTextBox.Text));
            numberTextBox.Clear();
        }

        private void showAllnumberButton_Click(object sender, EventArgs e)
        {
            foreach (int num in number)
            {
                numberListBox.Items.Add(num);
            }
        }

        private void sumOfAllNumberButton_Click(object sender, EventArgs e)
        {
            foreach (int num in number)
            {
                sum = sum + num;

                sumLabel.Text = sum.ToString();
            }
        }
    }
}
