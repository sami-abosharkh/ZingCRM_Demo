using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ZingCRM_Demo.Models
{
    public class Client
    {
        public string Id { get; set; } = Guid.NewGuid().ToString();

        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        [Required]
        [EmailAddress, StringLength(255)]
        public string Email { get; set; }

        [StringLength(255)]
        public string Position { get; set; }

        [StringLength(255)]
        [Display(Name = "Phone Number")]
        public string PhoneNumber { get; set; }

        public DateOnly Date { get; set; } = DateOnly.FromDateTime(DateTime.Now);

        public virtual ICollection<Project> Projects { get; set; } // One to many

        [NotMapped]
        public int ProjectsTotal { get; set; }
    }
}
