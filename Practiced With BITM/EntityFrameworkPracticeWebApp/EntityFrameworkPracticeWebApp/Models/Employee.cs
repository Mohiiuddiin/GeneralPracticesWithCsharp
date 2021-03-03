using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EntityFrameworkPracticeWebApp.Models
{
    public class Employee
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Please Input Your Name")]
        [StringLength(50)]
        [Column(TypeName = "VARCHAR")]
        public string Name { get; set; }
        [Required]
        [EmailAddress]
        [StringLength(50)]
        [Column(TypeName = "VARCHAR")]
        public string Email { get; set; }
        [StringLength(10)]
        [Column(TypeName = "VARCHAR")]
        public string Gender { get; set; }
        [Required]
        [ForeignKey("Department")]
        public int DepartmentId { get; set; }
        public Department Department { get; set; }
    }
}