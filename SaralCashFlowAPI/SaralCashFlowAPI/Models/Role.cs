﻿using System.ComponentModel.DataAnnotations;

namespace SaralCashFlowAPI.Models
{
    public class Role
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; } = string.Empty;
    }
}
