using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ZingCRM_Demo.Models
{
public class ItemM
{
public int Id { get; set; }
[Required, MaxLength(255)]
public string Name { get; set; }
public int Quantity { get; set; }
public double Cost { get; set; }
public double Price { get; set; }
[ForeignKey("Project")]
public int ProjectId { get; set; }

//--
public ProjectM Project { get; set; }
}
}
