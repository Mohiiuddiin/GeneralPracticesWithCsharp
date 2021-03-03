using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using StudentWebApp.BLL;
using StudentWebApp.DAL.Models;

namespace StudentWebApp.UI
{
    public partial class StudetnUpdateUI : System.Web.UI.Page
    {
        StudentManager studentManager = new StudentManager();
        DepartmentManager departmentManager = new DepartmentManager();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                int id = Convert.ToInt32(Request.QueryString["Id"]);
                Student student = studentManager.GetStudentById(id);
                departmentDropdownList.DataSource  = departmentManager.GetAllDepartments();
                departmentDropdownList.DataTextField = "Name";
                departmentDropdownList.DataValueField = "Id";
                departmentDropdownList.DataBind();

                if (student != null)
                {
                    idHiddenField.Value = student.Id.ToString();
                    regNoTextBox.Text = student.RegNo;
                    nameTextBox.Text = student.Name;
                    emailTextBox.Text = student.Email;
                    addressTextBox.Text = student.Address;
                    departmentDropdownList.SelectedValue = student.DepartmentId.ToString();
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
            aStudent.DepartmentId = Convert.ToInt32(departmentDropdownList.SelectedValue);

            studentManager.UpdateById(aStudent);

            Response.Redirect("StudentDetailsUI.aspx");


        }
    }
}