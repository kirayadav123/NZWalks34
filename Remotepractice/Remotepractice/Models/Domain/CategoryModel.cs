using System.ComponentModel.DataAnnotations;

namespace Remotepractice.Models.Domain
{
    public class CategoryModel
    {
        [Key]
        public int CategoryId { get; set; }

        [Required]
        public string CategoryName { get; set; }
    }
}
