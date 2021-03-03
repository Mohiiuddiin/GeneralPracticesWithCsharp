using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MvcPracticeWebApp.Models
{
    public class Employee
    {
        
        public int Id { get; set; }

        [Required(ErrorMessage = "Please Please Provide Name")]
        [StringLength(50)]
        [Column(TypeName = "varchar")]
        public string Name { get; set; }
        [Required]
        [EmailAddress]
        [StringLength(50)]
        [Column(TypeName = "varchar")]
        public string Email { get; set; }
        [StringLength(10)]
        [Column(TypeName = "varchar")]
        public string Gender { get; set; }
        [Required]
        [Display(Name = "Department")]
        [StringLength(50)]
        [Column(TypeName = "varchar")]
        public int DepartmentId { get; set; }
    }
}