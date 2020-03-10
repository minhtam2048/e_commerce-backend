using System.ComponentModel.DataAnnotations;

namespace Shop_API.Dtos
{
    public class UserForRegisterDto
    {
        [Required]
        public string Username { get; set; }
        [Required]
        [StringLength(16, MinimumLength = 6, ErrorMessage = "You must specify password between 6 and 16")]
        public string Password { get; set; }
    }
}