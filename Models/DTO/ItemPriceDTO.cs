using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ZingCRM_Demo.Models.DTO
{
    public class ItemPriceDTO
    {
        public int Id { get; set; }
        public Item Item { get; set; }
        public string Description { get; set; }
        public int Quantity { get; set; }
        public decimal Cost { get; set; }

        [Required]
        [Range(1, int.MaxValue, ErrorMessage = "Price must be greater than zero.")]
        public decimal? Price { get; set; }

        public decimal? Margin { get; set; }
        public decimal? TotalMargin { get; set; }
        public decimal? MarginPercent { get; set; }

    }
}
