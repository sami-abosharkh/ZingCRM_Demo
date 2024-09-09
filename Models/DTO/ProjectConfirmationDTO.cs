using System.ComponentModel.DataAnnotations;

namespace ZingCRM_Demo.Models.DTO
{
    public class ProjectConfirmationDTO
    {
        [Required]
        public string Status { get; set; }
        public string PONumber { get; set; }
        public DateTime DueDate { get; set; }
        public DateTime InvoiceDate { get; set; }
    }
}
