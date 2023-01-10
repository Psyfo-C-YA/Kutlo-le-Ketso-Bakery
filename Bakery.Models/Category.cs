using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Bakery.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [DisplayName("Category Name")]
        public string Name { get; set; }
        [DisplayName("Display Order")]
        [Range(1, 100, ErrorMessage = "Value for {0} must be between {1} and {2}.")]
        public int DisplayOrder { get; set; }
        [DisplayName("Date Time")]
        public DateTime CreatedDateTime { get; set; } = DateTime.Now;
    }
}
