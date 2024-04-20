using System.ComponentModel.DataAnnotations;

namespace SaralCashFlowAPI.Models
{
    public class Message
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public User User { get; set; }

        [Required]
        public DateTime CreatedAt { get; set; }

        public CashDetail? CashDetail { get; set; }

        public SubCashDetails? SubCashDetails { get; set; }

        public string Summary { get; set; }
    }
}
