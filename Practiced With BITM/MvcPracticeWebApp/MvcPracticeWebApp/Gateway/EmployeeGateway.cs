using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MvcPracticeWebApp.Models;

namespace MvcPracticeWebApp.Gateway
{
    public class EmployeeGateway
    {
        public int Save(Employee employee)
        {
            return 1;
        }

        public List<Employee> GetEmployeesByDepartmentId(int departmentId)
        {
            List<Employee> employees = new List<Employee>()
            {
                new Employee(){ Id = 1 ,Name = "Ruhul", Email = "ruhul@gmail.com", Gender = "Male", DepartmentId = 1},
                new Employee(){ Id = 2 ,Name = "Kuddus", Email = "Kuddus@gmail.com", Gender = "Male", DepartmentId = 2},
                new Employee(){ Id = 3 ,Name = "Jumman", Email = "Jumman@gmail.com", Gender = "Male", DepartmentId = 1},
                new Employee(){ Id = 4 ,Name = "Ahmed", Email = "Ahmed@gmail.com", Gender = "Male", DepartmentId = 2},
                
            };

            List<Employee> employeeList = employees.FindAll(x => x.DepartmentId == departmentId).ToList();

            return employeeList;
        }

    }
}