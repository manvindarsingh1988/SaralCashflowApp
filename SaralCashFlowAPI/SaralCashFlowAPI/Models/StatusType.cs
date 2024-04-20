using System.ComponentModel.DataAnnotations;

namespace SaralCashFlowAPI.Models
{
    public class StatusType
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; } = string.Empty;

        [Required]
        [StringLength(50)]
        public string DisplayName { get; set; } = string.Empty;
    }
}
