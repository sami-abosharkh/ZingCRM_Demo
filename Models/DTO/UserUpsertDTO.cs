using System.ComponentModel.DataAnnotations;
using ZingCRM_Demo.Utilities;

namespace ZingCRM_Demo.Models.DTO
{
    public class UserUpsertDTO
    {
        [Required]
        [Display(Name = "first name")]
        public string FirstName { get; set; }

        [Required]
        [Display(Name = "last name")]
        public string LastName { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} and at max {1} characters long.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirm password")]
        [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
        public string ConfirmPassword { get; set; }

        [Required]
        public List<RoleModel> Roles { get; set; }

        [Display(Name = "Phone Number")]
        public string PhoneNumber { get; set; }
    }

    public class RoleModel
    {
        public string Name { get; set; } = string.Empty;
        public bool Selected { get; set; } = false;
    }
}
