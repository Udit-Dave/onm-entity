using System;
using System.ComponentModel.DataAnnotations;

namespace Entities
{
    public class InventoryLocation
    {
        [Key]
        public Guid LocationId { get; set; }

        [Required]
        [MaxLength(255)]
        public string LocationName { get; set; }

        [Required]
        public DateTime DateCreated { get; set; } = DateTime.Now;

        [Required]
        public DateTime DateLastModified { get; set; } = DateTime.Now;
    }
}
