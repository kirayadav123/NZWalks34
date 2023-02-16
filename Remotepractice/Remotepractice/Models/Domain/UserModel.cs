using System.ComponentModel.DataAnnotations;

namespace Remotepractice.Models.Domain
{
    public class UserModel
    {
        [Key]
        public int UserId { get; set; }
        public string? FullName { get; set; }
        public String? Email { get; set; }
        public string? Password { get; set; }
        public string MobileNumber { get; set; }
        public WalletModel WalletId { get; set; }
        public CartModel CartId { get; set; }
        public virtual RoleModel RoleModel { get; set; }
    }
}
