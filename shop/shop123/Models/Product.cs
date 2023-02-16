using System.ComponentModel.DataAnnotations;

namespace shop123.Models
{
    public class Product
    {
        [Key]
        public int ProductId { get; set; }

        [Required]
        public string ProductName { get; set; }

        [Required]
        public string Image { get; set; }

        [Required]
        public float Price { get; set; }

        public CategoryModel CategoryModel { get; set; }
    }
}
