using System.ComponentModel.DataAnnotations;

namespace shop123.Models
{
    public class Wallet
    {

        [Key]
        public int WalletId { get; set; }

        [Required]
        public int CurrentBalance { get; set; }

        public User UserModel { get; set; }

        public Cart CartModel { get; set; }
    }
}
