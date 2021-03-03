using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NumberEntryApp
{
    public partial class Form1 : Form
    {
        List<int> numberList = new List<int>();
        public Form1()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        {            
            numberList.Add(Convert.ToInt32(numberTextBox.Text));
            numberTextBox.Clear();
        }

        private void showAllButton_Click(object sender, EventArgs e)
        {
            foreach (int number in numberList)
            {
                numberListBox.Items.Add(number);
            }
        }
    }
}
