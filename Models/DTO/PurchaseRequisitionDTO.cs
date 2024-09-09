using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using ZingCRM_Demo.Utilities;

namespace ZingCRM_Demo.Models.DTO
{
    public class PurchaseRequisitionDTO
    {
        public int Id { get; set; }

        [Range(1, int.MaxValue, ErrorMessage = "Activation Number must be greater than zero.")]
        public int Number { get; set; }

        [StringLength(255)]
        public string Status { get; set; } = SD.Status_Pending;

        [StringLength(500)]
        public string Description { get; set; } = "Cras rhoncus ante et neque scelerisque, eget tincidunt velit dignissim. Aenean id elit viverra neque dapibus consectetur a sed nulla. Quisque vitae laoreet leo.";

        [Range(1, int.MaxValue, ErrorMessage = "Activation Number must be greater than zero.")]
        public decimal RequestedAmount { get; set; }

        public DateTime Date { get; set; } = DateTime.Now;

        public virtual ICollection<RequisitionEntry> RequisitionEntries { get; set; }  // One to many

        public int ProjectId { get; set; }
    }
}
