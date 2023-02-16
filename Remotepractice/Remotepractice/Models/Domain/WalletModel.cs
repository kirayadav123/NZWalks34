using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Remotepractice.Models.Domain
{
    public class WalletModel
    {
        [Key]
        public int WalletId { get; set; }

        [Required]
        public int CurrentBalance { get; set; }


        [ForeignKey("UserModel")]
        public int UserModel_UserId { get; set; }

        public UserModel UserModel { get; set; }

        public CartModel CartModel { get; set; }
    }
}
