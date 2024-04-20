using System.ComponentModel.DataAnnotations;

namespace SaralCashFlowAPI.Models
{
    public class Customer
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; } = string.Empty;

        [StringLength(50)]
        public string Mobile { get; set; } = string.Empty;

        [StringLength(200)]
        public string Address { get; set; } = string.Empty;

        [StringLength(50)]
        public string Email { get; set; } = string.Empty;
    }
}
