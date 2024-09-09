using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations.Schema;

namespace ZingCRM_Demo.Models
{
    // Add profile data for application users by adding properties to the ApplicationUser class
    public class ApplicationUser : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime TimeCreated { get; set; }
        public DateTime? LastLogin { get; set; }

        [InverseProperty("User")]
        public virtual ICollection<Project> Projects { get; set; }  // One to many

        [NotMapped]
        public List<string> Roles { get; set; }
    }
}