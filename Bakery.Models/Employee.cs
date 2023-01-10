using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Bakery.Models
{
    public class Employee
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name  { get; set; }
        [Column(TypeName = "smallmoney")]
        public int Salary { get; set; }
        public string JobTitle { get; set; }
        public DateTime HireDate { get; set; }

    }
}
