using System.ComponentModel.DataAnnotations;
using ZingCRM_Demo.Utilities;

namespace ZingCRM_Demo.Models.DTO
{
    public class UserUpdateDTO
    {
        [Required]
        [Display(Name = "first name")]
        public string FirstName { get; set; }

        [Required]
        [Display(Name = "last name")]
        public string LastName { get; set; }

        [Required]
        [EmailAddress]
        [Display(Name = "Email")]
        public string Email { get; set; }
        [Required]
        public string Role { get; set; } = SD.Role_ClientService;

        [Display(Name = "Phone Number")]
        public string PhoneNumber { get; set; }
    }

}

