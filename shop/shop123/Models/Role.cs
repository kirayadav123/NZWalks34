using System.ComponentModel.DataAnnotations;

namespace shop123.Models
{
    public class Role
    {
        [Key]
        public int UserTypeId { get; set; }

        [Required]
        public string UserTypeName { get; set; }
    }
}
