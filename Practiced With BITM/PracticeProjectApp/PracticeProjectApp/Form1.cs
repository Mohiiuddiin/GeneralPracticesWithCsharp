using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PracticeProjectApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void clickMeButton_Click(object sender, EventArgs e)
        {
            string checkedValue = "";

            if (javaCheckBox.Checked)
            {
                checkedValue += "Java,";
            }
            if (cSharpCheckBox.Checked)
            {
                checkedValue += "C#,";
            }
            if (pythonCheckBox.Checked)
            {
                checkedValue += "Python,";
            }

            checkedValue = checkedValue.Substring(0, checkedValue.Length - 1);
            MessageBox.Show(checkedValue+" is checked");
        }

        private void showButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show(comboBox1.Text);
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            string myValue = textBox1.Text;
            textBox1.Clear();
            listBox1.Items.Add(myValue);
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }
    }
}
