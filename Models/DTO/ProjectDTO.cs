using System.ComponentModel.DataAnnotations;
using ZingCRM_Demo.Utilities;
using static ZingCRM_Demo.Models.Validation.CustomValidation;

namespace ZingCRM_Demo.Models.DTO
{
    public class ProjectDTO
    {
        public int Number { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        [Required]
        [Display(Name = "Client")]
        public string ClientId { get; set; }
        public Client Client { get; set; }

        [Required]
        [Display(Name = "Operation Manager")]
        public string OperationUserId { get; set; }
        public ApplicationUser OperationUser { get; set; }

        public DateTime Date { get; set; } = DateTime.Now;

        [Required]
        [Display(Name = "Due Date")]
        [NotInThePast(ErrorMessage = "Due Date cannot be in the past.")]
        public DateOnly DueDate { get; set; } = DateOnly.FromDateTime(DateTime.Now);

        [Required]
        [Display(Name = "Invoice Date")]
        [NotInThePast(ErrorMessage = "Invoice Date cannot be in the past.")]
        public DateOnly InvoiceDate { get; set; } = DateOnly.FromDateTime(DateTime.Now);
    }
}
