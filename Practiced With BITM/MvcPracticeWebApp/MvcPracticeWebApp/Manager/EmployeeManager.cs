using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MvcPracticeWebApp.Gateway;
using MvcPracticeWebApp.Models;

namespace MvcPracticeWebApp.Manager
{
    public class EmployeeManager
    {
        private EmployeeGateway employeeGateway;

        public EmployeeManager()
        {
            employeeGateway = new EmployeeGateway();
        }
        public string Save(Employee employee)
        {
            int rowAffect = employeeGateway.Save(employee);
            if (rowAffect> 0)
            {
                return "Save Successful";
            }
            else
            {
                return "Save Failed";
            }
        }

        public List<Employee> GetEmployeesByDepartmentId(int departmentId)
        {
            return employeeGateway.GetEmployeesByDepartmentId(departmentId);
        }
    }


}