using System.ComponentModel.DataAnnotations;

namespace shop123.Models
{
    public class User
    {

        [Key]
        public int UserId { get; set; }

        [Required]
        public string FullName { get; set; }

        [Required]
        public string MobileNumber { get; set; }

        [Required]
      public string Address { get; set; }
        [Required]
        public string Gender { get; set; }

        [Required]
        public string Email { get; set; }

        [Required]
        public string Password { get; set; }

       
    }
}

