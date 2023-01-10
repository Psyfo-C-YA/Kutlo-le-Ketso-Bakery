using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Bakery.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Flavor { get; set; }
        public int Size { get; set; }
        [Column(TypeName = "smallmoney")]
        [Required]
        [Range(1, 10000)]
        public int Price { get; set; }
        [Required]
        [Range(1,50)]
        public int Availability { get; set; }
        [ValidateNever]
        public string? ImageUrl { get; set; }
        [Required]
        public int CategoryId { get; set; }
        [ValidateNever]
        public Category Category { get; set; }



    }
}
