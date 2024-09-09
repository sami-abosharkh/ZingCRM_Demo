using System.ComponentModel.DataAnnotations.Schema;

namespace ZingCRM_Demo.Models
{
    public class PaymentRequestM
    {
        public int Id { get; set; }
        [ForeignKey("Project")]
        public int ProjectId { get; set; }
        public int PRNumber { get; set; }
        public double Amount { get; set; }
        public string Status { get; set; }
        
        //-- Models
        public ProjectM Project { get; set; }

    }
}
