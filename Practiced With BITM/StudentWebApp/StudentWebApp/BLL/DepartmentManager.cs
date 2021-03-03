using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using StudentWebApp.DAL.Gateway;
using StudentWebApp.DAL.Models;

namespace StudentWebApp.BLL
{
    public class DepartmentManager
    {
        DepartmentGateway departmentGateway = new DepartmentGateway();
        public List<Department> GetAllDepartments()
        {
            return departmentGateway.GetAllDepartments();
        }
    }
}