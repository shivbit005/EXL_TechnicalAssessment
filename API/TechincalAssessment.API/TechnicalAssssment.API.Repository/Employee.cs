using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TechnicalAssssment.API.Repository
{
    public class Employee
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int EmployeeID { get; set; }

        [Required]
        [MaxLength(30)]
        public string FirstName { get; set; }

        [Required]
        [MaxLength(30)]
        public string LastName { get; set; }

        [Range(20,60)]
        public int Age { get; set; }

        public string JobTitle { get; set; }

        [Required]
        public System.DateTime EmploymentStartDate { get; set; }

        public System.DateTime? EmploymentEndDate { get; set; }
    }
}
