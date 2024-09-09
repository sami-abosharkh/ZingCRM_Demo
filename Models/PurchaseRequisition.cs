using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using ZingCRM_Demo.Utilities;

namespace ZingCRM_Demo.Models
{
    public class PurchaseRequisition
    {
        public int Id { get; set; }

        [Range(1, int.MaxValue, ErrorMessage = "Activation Number must be greater than zero.")]
        public int Number { get; set; }

        [StringLength(255)]
        public string Status { get; set; }

        [StringLength(500)]
        public string Description { get; set; }

        [Column(TypeName = "decimal(18, 2)")]
        [Range(1, int.MaxValue, ErrorMessage = "Activation Number must be greater than zero.")]
        public decimal RequestedAmount { get; set; }

        public DateTime Date { get; set; }

        public virtual ICollection<RequisitionEntry> RequisitionEntries { get; set; }  // One to many

        [ForeignKey("Project")]
        public int ProjectId { get; set; }
        public virtual Project Project { get; set; }
    }
}
