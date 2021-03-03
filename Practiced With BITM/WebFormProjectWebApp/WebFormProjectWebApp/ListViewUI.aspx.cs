using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebFormProjectWebApp
{
    public partial class ListViewUI : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void saveButton_Click(object sender, EventArgs e)
        {
            if (ViewState["nameListVS"] ==null)
            {
                string name = nameTextBox.Text;
                nameTextBox.Text = String.Empty;
                List<string> nameList = new List<string>();
                nameList.Add(name);
                ViewState["nameListVS"] = nameList;
            }
            else
            {
                string name = nameTextBox.Text;
                nameTextBox.Text = String.Empty;
                List<string> yourList = (List<string>)ViewState["nameListVS"];
                yourList.Add(name);
                ViewState["nameListVS"] = yourList;
            }                    
        }

        protected void showButton_Click(object sender, EventArgs e)
        {
            List<string> myList =(List<string>)ViewState["nameListVS"];

            foreach (string name in myList)
            {
                nameListBox.Items.Add(name);
            }
        }
    }
}