using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace StudentWebApp
{
    public partial class StudentEntryUI : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void saveButton_Click(object sender, EventArgs e)
        {
            Student aStudent = new Student();
            aStudent.RegNo = regNoTextBox.Text;
            aStudent.Name = nameTextBox.Text;
            aStudent.Email = emailTextBox.Text;
            aStudent.Address = addressTextBox.Text;
            aStudent.Department = departmentTextBox.Text;

            string connectionString =
                @"Data Source=.\SQLEXPRESS;Initial Catalog=UniversityDB_21;Integrated Security=True";

            SqlConnection connection = new SqlConnection(connectionString);

            string query = "INSERT INTO Students(RegNo, Name, Email, Address, Department) VALUES(@regNo,@name,@email,@address,@department)";

            SqlCommand command = new SqlCommand(query,connection);
            command.Parameters.AddWithValue("@regNo", aStudent.RegNo);
            command.Parameters.AddWithValue("@name", aStudent.Name);
            command.Parameters.AddWithValue("@email", aStudent.Email);
            command.Parameters.AddWithValue("@address", aStudent.Address);
            command.Parameters.AddWithValue("@department", aStudent.Department);


            connection.Open();
            int rowAffect = command.ExecuteNonQuery();
            if (rowAffect> 0)
            {
                outputLabel.Text = "Save Successful";
            }
            else
            {
                outputLabel.Text = "Save Failed";                
            }
            connection.Close();


        }
    }
}