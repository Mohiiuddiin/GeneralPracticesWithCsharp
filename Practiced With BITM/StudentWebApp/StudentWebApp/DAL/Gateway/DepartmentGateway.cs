using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using StudentWebApp.DAL.Models;
using StudentWebApp.DAL.Models.ViewModels;

namespace StudentWebApp.DAL.Gateway
{
    public class DepartmentGateway : BaseGateway
    {
        public List<Department> GetAllDepartments()
        {
            string query = "SELECT * FROM Departments";
            command = new SqlCommand(query, connection);
            connection.Open();
            reader = command.ExecuteReader();

            List<Department> departmentList = new List<Department>();

            while (reader.Read())
            {
                Department department = new Department();
                department.Id = Convert.ToInt32(reader["Id"]);
                department.Name = reader["Name"].ToString();
                department.Code = reader["Code"].ToString();                
                departmentList.Add(department);
            }
            connection.Close();

            return departmentList;
        }

    }
}