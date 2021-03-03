using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using StudentWebApp.BLL;

namespace StudentWebApp.UI
{
    public partial class StudentDetailsUI : System.Web.UI.Page
    {
        StudentManager studentManager = new StudentManager();
        protected void Page_Load(object sender, EventArgs e)
        {
            studentListGridView.DataSource = studentManager.GetAllStudents();
            studentListGridView.DataBind();
        }

        protected void UpdateLinkButton_Click(object sender, EventArgs e)
        {
            LinkButton linkButton = sender as LinkButton;
            DataControlFieldCell cell =  linkButton.Parent as DataControlFieldCell;
            GridViewRow row = cell.Parent as GridViewRow;
            HiddenField idHiddenField = row.FindControl("idHiddenField") as HiddenField;
            //Response.Write(idHiddenField.Value);
            int id = Convert.ToInt32(idHiddenField.Value);
            Response.Redirect("StudetnUpdateUI.aspx?Id="+id);
        }

        protected void DeleteLinkButton_Click(object sender, EventArgs e)
        {
            LinkButton linkButton = sender as LinkButton;
            DataControlFieldCell cell = linkButton.Parent as DataControlFieldCell;
            GridViewRow row = cell.Parent as GridViewRow;
            HiddenField idHiddenField = row.FindControl("idHiddenField") as HiddenField;
            //Response.Write(idHiddenField.Value);
            int id = Convert.ToInt32(idHiddenField.Value);
            
        }
    }
}