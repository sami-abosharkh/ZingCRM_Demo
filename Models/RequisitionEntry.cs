using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ZingCRM_Demo.Models
{
    public class RequisitionEntry
    {
        public int Id { get; set; }
        
        [Range(1, int.MaxValue, ErrorMessage = "Requested Quantity must be greater than zero.")]
        public double Quantity { get; set; }
        
        [Range(1, int.MaxValue, ErrorMessage = "Requested Percentage must be greater than zero.")]
        public double Percentage { get; set; }

        [ForeignKey("QuotedItem")]
        public int QuotedItemId { get; set; }
        public virtual QuotationItem QuotedItem { get; set; }
    }
}