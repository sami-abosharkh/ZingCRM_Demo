using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ZingCRM_Demo.Models
{
    public class ProjectM
    {
        [Key]
        public int Id { get; set; }
        [ForeignKey("User")]
        public string UserId { get; set; }
        [Required]
        [ForeignKey("OperationUser")]
        [Display(Name = "Operation Manager")]
        public string OperationUserId { get; set; }
        [Required]
        public int ProjectNumber { get; set; }
        [Required, MaxLength(50)]
        public string Name { get; set; }
        [Required, MaxLength(50)]
        public string Client { get; set; }
        public string PONumber { get; set; }
        public DateTime Date { get; set; }
        [Required]
        public ICollection<ItemM> Items { get; set; }  // One Project has many Items
        public ICollection<PaymentRequestM> PaymentRequests { get; set; }  // One Project has many Payment Requests
        public DateTime DueDate { get; set; }
        public DateTime InvoiceDate { get; set; }
        public int Version { get; set; }
        public string Status { get; set; }
        public string Phase { get; set; }
        [NotMapped]
        public double TotalCost { get; set; }
        [NotMapped]
        public double TotalPrice { get; set; }
        [NotMapped]
        public bool CanEdit { get; set; } = false;
        [NotMapped]
        public bool CanProgress { get; set; } = false;

        //-- Models
        public ApplicationUser User { get; set; }
        public ApplicationUser OperationUser { get; set; }

    }
}