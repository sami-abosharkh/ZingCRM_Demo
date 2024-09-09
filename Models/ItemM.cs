using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ZingCRM_Demo.Models
{
    public class ItemM
    {
        public int Id { get; set; }
        [Required, MaxLength(255)]
        public string Name { get; set; }
        [Required]
        public string Category { get; set; }
        public string Description { get; set; }
        [Required]
        [Range(1, int.MaxValue, ErrorMessage = "Quantity must be greater than zero.")]
        public int Quantity { get; set; }
        public double Cost { get; set; }
        public double Price { get; set; }
        [ForeignKey("Project")] 
        public int ProjectId { get; set; }
        [NotMapped]
        public double TotalCost { get; set; }
        [NotMapped]
        public double TotalPrice { get; set; }
        
        //-- Models
        public ProjectM Project { get; set; }
    }
}