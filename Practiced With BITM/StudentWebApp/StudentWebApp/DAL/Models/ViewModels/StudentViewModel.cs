using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StudentWebApp.DAL.Models.ViewModels
{
    public class StudentViewModel
    {
        public int Id { get; set; }
        public string RegNo { get; set; }
        public string StudentName { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public int DepartmentId { get; set; }
        public string DepartmentName { get; set; }
        public string Code { get; set; }
        
    }
}