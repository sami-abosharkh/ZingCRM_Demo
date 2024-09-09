using System.ComponentModel.DataAnnotations;

namespace ZingCRM_Demo.Models.DTO
{
    public class ClientDTO
    {
        [Required, StringLength(255)]
        public string Name { get; set; }

        [Required, EmailAddress, StringLength(255)]
        public string Email { get; set; }

        [StringLength(255)]
        public string Position { get; set; }

        [StringLength(255)]
        [Display(Name = "Phone Number")]
        public string PhoneNumber { get; set; }
    }
}
