using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcPracticeWebApp.Manager;
using MvcPracticeWebApp.Models;

namespace MvcPracticeWebApp.Controllers
{
    public class EmployeeController : Controller
    {
        private DepartmentManager departmentManager;
        private EmployeeManager employeeManager;
        public EmployeeController()
        {
            departmentManager = new DepartmentManager();
            employeeManager = new EmployeeManager();
        }
                   
        [HttpGet]
        public ActionResult Details()
        {
            ViewBag.Department = departmentManager.GetAllDepartmentForDropdown();
            return View();
        }


        public JsonResult GetEmployeeByDepartmentId(int deptId)
        {
            List<Employee> employees = employeeManager.GetEmployeesByDepartmentId(deptId);
            return Json(employees);
        }
    }
}