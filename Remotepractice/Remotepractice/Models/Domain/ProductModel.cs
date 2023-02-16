using System.ComponentModel.DataAnnotations;

namespace Remotepractice.Models.Domain
{
    public class ProductModel
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
