using System.ComponentModel.DataAnnotations;

namespace Shoppingcart.Models.Domain
{
    public class RoleModel
    {
        [Key]
        public int UserTypeId { get; set; }

        [Required]
        public string UserTypeName { get; set; }
    }
}
