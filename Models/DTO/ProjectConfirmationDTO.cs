using static ZingCRM_Demo.Models.Validation.CustomValidation;
using System.ComponentModel.DataAnnotations;
using ZingCRM_Demo.Utilities;

namespace ZingCRM_Demo.Models.DTO
{
    public class ProjectConfirmationDTO
    {
        public string Status { get; set; } = SD.Status_Pending;
        public string PONumber { get; set; } = string.Empty;

        [Required]
        [Display(Name = "Due Date")]
        [NotInThePast(ErrorMessage = "Due Date cannot be in the past.")]
        public DateOnly DueDate { get; set; } = DateOnly.FromDateTime(DateTime.Now);

        [Required]
        [Display(Name = "Invoice Date")]
        [NotInThePast(ErrorMessage = "Invoice Date cannot be in the past.")]
        public DateOnly InvoiceDate { get; set; } = DateOnly.FromDateTime(DateTime.Now);

        public string Phase { get; set; }
    }
}
