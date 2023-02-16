using System.ComponentModel.DataAnnotations;

namespace shop123.Models
{
    public class Cart
    {

        [Key]
        public int CartId { get; set; }

        [Required]
        public int Quantity { get; set; }

        [Required]
        public float TotalAmount { get; set; }

        public UserModel UserModel { get; set; }

        public ProductModel ProductModel { get; set; }
    }

}

