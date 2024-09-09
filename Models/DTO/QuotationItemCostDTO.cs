using System.ComponentModel.DataAnnotations;

namespace ZingCRM_Demo.Models.DTO
{
    public class QuotationItemCostDTO
    {
        public int Id { get; set; }
        public Item Item { get; set; }
        public string Description { get; set; }
        public int Quantity { get; set; }
        [Required]
        [Range(1, int.MaxValue, ErrorMessage = "Cost must be greater than zero.")]
        public decimal? Cost { get; set; }
        public decimal? TotalCost { get; set; }
    }
}
