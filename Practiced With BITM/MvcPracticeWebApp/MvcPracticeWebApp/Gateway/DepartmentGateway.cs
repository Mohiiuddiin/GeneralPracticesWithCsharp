using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MvcPracticeWebApp.Models;

namespace MvcPracticeWebApp.Gateway
{
    public class DepartmentGateway
    {
        public List<Department> GetAllDepartments()
        {
            return new List<Department>()
            {
                new Department(){ Id = 1, Name = "HR"},
                new Department(){ Id = 2 , Name = "Marketing"}
            };
        }
    }
}