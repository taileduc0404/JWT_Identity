using System.ComponentModel.DataAnnotations;

namespace Api.DTOs.Account
{
    public class RegisterDto
    {
        [Required]
        [StringLength(15, MinimumLength = 2, ErrorMessage = "FirstName must be at least {2}, and maximum {1} characters.")]
        public string FirstName { get; set; }
        [Required]
        [StringLength(15, MinimumLength = 2, ErrorMessage = "LastName must be at least {2}, and maximum {1} characters.")]
        public string LastName { get; set; }
        [Required]
        [EmailAddress]
        [RegularExpression("^[\\w-\\.]+@([\\w-]+\\.)+[\\w-]{2,4}$", ErrorMessage = "Invalid email address.")]
        public string Email { get; set; }
        [Required]
        [StringLength(6, MinimumLength = 1, ErrorMessage = "Password must be at least {2}, and maximum {1} characters.")]
        public string Password { get; set; }
    }
}
