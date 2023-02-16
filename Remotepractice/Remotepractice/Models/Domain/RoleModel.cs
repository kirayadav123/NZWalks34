using System.ComponentModel.DataAnnotations;

namespace Remotepractice.Models.Domain
{
    public class RoleModel
    {
        [Key]
        public int UserTypeId { get; set; }

        [Required]
        public string UserTypeName { get; set; }
    }
}
