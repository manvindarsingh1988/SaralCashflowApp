using System.ComponentModel.DataAnnotations;

namespace SaralCashFlowAPI.Models
{
    public class SubCashDetails
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public Customer Customer { get; set; }

        [Required]
        public StatusType Status { get; set; }

        [Required]
        public User Collector { get; set; }

        [Required]
        public AmountType AmountType { get; set; }

        [Required]
        public DateTime UpdatedOn { get; set; }

        public List<Message> Messages { get; set; }

        public List<SubCashDetails> RecoveredCashList { get; set; }
    }
}
