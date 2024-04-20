using System.ComponentModel.DataAnnotations;

namespace SaralCashFlowAPI.Models
{
    public class CashDetail
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public User User { get; set; }

        [Required]
        public DateTime CreatedOn { get; set; }

        [Required]
        public StatusType Status { get; set; }

        public List<SubCashDetails> SubCashDetails { get; set; }

        public List<Message> Messages { get; set; }
    }
}
