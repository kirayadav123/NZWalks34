using System.ComponentModel.DataAnnotations;

namespace shop123.Models
{
    public class Order
    {
        [Key]
        public int OrderId { get; set; }

        [Required]
        public DateTime OrderDate { get; set; }

        [Required]
        public float AmountPaid { get; set; }

        [Required]
        public string ModeOfPayment { get; set; }

        [Required]
        public string OrderStatus { get; set; }

        public Cart Cart { get; set; }

    }
}
