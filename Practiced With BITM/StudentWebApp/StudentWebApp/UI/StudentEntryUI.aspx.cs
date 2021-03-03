using System;
using System.Data.SqlClient;
using StudentWebApp.BLL;
using StudentWebApp.DAL.Models;
using StudentWebApp.Utility;

namespace StudentWebApp.UI
{
    public partial class StudentEntryUI : System.Web.UI.Page
    {
        private StudentManager studentManager = new StudentManager();
        private DepartmentManager departmentManager = new DepartmentManager();
        protected void Page_Load(object sender, EventArgs e)
        {
            departmentDropdownList.DataSource = departmentManager.GetAllDepartments();
            departmentDropdownList.DataTextField = "Name";
            departmentDropdownList.DataValueField = "Id";
            departmentDropdownList.DataBind();
        }

        protected void saveButton_Click(object sender, EventArgs e)
        {
            Student aStudent = new Student();
            aStudent.RegNo = regNoTextBox.Text;
            aStudent.Name = nameTextBox.Text;
            aStudent.Email = emailTextBox.Text;
            aStudent.Address = addressTextBox.Text;
            aStudent.DepartmentId = Convert.ToInt32(departmentDropdownList.SelectedValue);


            string message = studentManager.Save(aStudent);
            outputLabel.Text = message;

            //studentListGridView.DataSource = studentManager.GetAllDepartments();
            //studentListGridView.DataBind();


            //if (message == ConstMessage.SaveSuccessful)
            //{

            //}
            //else
            //{

            //}
        }
    }
}