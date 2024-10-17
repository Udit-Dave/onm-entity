using System;
using System.ComponentModel.DataAnnotations;

namespace Entities
{
    public class Side
    {
        [Key]
        public Guid SideId { get; set; }

        [Required]
        [MaxLength(50)]
        public string SideName { get; set; }

        public bool Inactive { get; set; } = false;

        [Required]
        public DateTime DateCreated { get; set; } = DateTime.Now;

        [Required]
        public DateTime DateLastModified { get; set; } = DateTime.Now;
    }
}
