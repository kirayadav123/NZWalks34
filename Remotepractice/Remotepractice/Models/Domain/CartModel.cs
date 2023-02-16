using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Remotepractice.Models.Domain
{
    public class CartModel
    {
        [Key]
        public int CartId { get; set; }

        [Required]
        public int Quantity { get; set; }

        [Required]
        public float TotalAmount { get; set; }
        public int price { get; set; }
        public string productname { get; set; }
        
        public int UserId { get; set; }

        public UserModel UserModel { get; set; }


        [ForeignKey("ProductModel")]
        public int ProductModel_ProductId { get; set; }

        public ProductModel ProductModel { get; set; }
    }
}
