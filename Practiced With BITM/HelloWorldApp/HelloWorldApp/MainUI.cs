using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HelloWorldApp
{
    public partial class MainUI : Form
    {
        public MainUI()
        {
            InitializeComponent();
        }

        private void showButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Helloi World","Error!",
                            MessageBoxButtons.OKCancel,
                            MessageBoxIcon.Error,
                            MessageBoxDefaultButton.Button2);
        }
      
    }
}
