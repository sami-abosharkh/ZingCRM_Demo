using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static ZingCRM_Demo.Models.Validation.CustomValidation;

namespace ZingCRM_Demo.Models
{
    public class Project
    {
        public int Id { get; set; }

        [Range(1, int.MaxValue, ErrorMessage = "Activation Number must be greater than zero.")]
        public int Number { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        [ForeignKey("User")]
        public string UserId { get; set; }
        public virtual ApplicationUser User { get; set; }

        [Required]
        [ForeignKey("Client")]
        [Display(Name = "Client")]
        public string ClientId { get; set; }
        public virtual Client Client { get; set; }

        [Required]
        [ForeignKey("OperationUser")]
        [Display(Name = "Operation Manager")]
        public string OperationUserId { get; set; }
        public virtual ApplicationUser OperationUser { get; set; }

        public DateTime Date { get; set; } = DateTime.Now;

        [Required]
        [NotInThePast(ErrorMessage = "Due Date cannot be in the past.")]
        [Display(Name = "Due Date")]
        public DateOnly DueDate { get; set; } = default!;

        [Required]
        [NotInThePast(ErrorMessage = "Invoice Date cannot be in the past.")]
        [Display(Name = "Invoice Date")]
        public DateOnly InvoiceDate { get; set; } = default!;

        public virtual ICollection<QuotationItem> QuotationItems { get; set; }  // One Project has many Items
        public virtual ICollection<PurchaseRequisition> PurchaseRequisitions { get; set; }  // One Project has many Payment Requests

        public string PONumber { get; set; }
        public string Status { get; set; }
        public string Phase { get; set; }
        public int Version { get; set; }

        //[NotMapped] public bool CanEdit { get; set; } = false;
        //[NotMapped] public bool CanProgress { get; set; } = false;
    }
}