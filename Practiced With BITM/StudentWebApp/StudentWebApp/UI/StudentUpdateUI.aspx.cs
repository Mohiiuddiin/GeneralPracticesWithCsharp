using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using StudentWebApp.BLL;
using StudentWebApp.DAL.Gateway;
using StudentWebApp.DAL.Model;

namespace StudentWebApp.UI
{
    public partial class StudentUpdateUI : System.Web.UI.Page
    {
        StudentManager studentManager = new StudentManager();
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!IsPostBack)
            {
                int id = Convert.ToInt32(Request.QueryString["Id"]);
                Response.Write(id);

                Student student = studentManager.GetStudentById(id);

                if (student != null)
                {
                    idHiddenField.Value = student.Id.ToString();
                    regNoTextBox.Text = student.RegNo;
                    nameTextBox.Text = student.Name;
                    emailTextBox.Text = student.Email;
                    addressTextBox.Text = student.Address;
                    departmentTextBox.Text = student.Department;
                }
            }
            
           
        }

        protected void updateButton_Click(object sender, EventArgs e)
        {
            Student aStudent = new Student();
            aStudent.Id = Convert.ToInt32(idHiddenField.Value);
            aStudent.RegNo = regNoTextBox.Text;
            aStudent.Name = nameTextBox.Text;
            aStudent.Email = emailTextBox.Text;
            aStudent.Address = addressTextBox.Text;
            aStudent.Department = departmentTextBox.Text;

            studentManager.UpdateById(aStudent);
            Response.Redirect("StudentDetailsUI.aspx");
        }
    }
}