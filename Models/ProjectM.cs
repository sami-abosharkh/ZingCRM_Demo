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
public int ProjectNumber { get; set; }
[Required, MaxLength(50)]
public string Name { get; set; }
[Required, MaxLength(50)]
public string Client { get; set; }
public DateTime Date { get; set; }
[Required]
public ICollection<ItemM> Items { get; set; }  // One Project has many Items
public DateTime DueDate { get; set; }
public DateTime InvoiceDate { get; set; }
public int Version { get; set; }
public string Status { get; set; }
public string Phase { get; set; }

//-- 
public ApplicationUser User { get; set; }
}
}