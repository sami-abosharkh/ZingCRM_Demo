using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ZingCRM_Demo.Models.DTO
{
    public class ItemUpsertDTO
    {
        public int Id { get; set; }

        [Required, MaxLength(255)]
        public string Name { get; set; }
        [Required, MaxLength(255)]
        public string Category { get; set; }
        public string Description { get; set; }
        [Required]
        [Range(1, int.MaxValue, ErrorMessage = "Quantity must be greater than zero.")]
        public int Quantity { get; set; }
        public int ProjectId { get; set; }
    }
}
