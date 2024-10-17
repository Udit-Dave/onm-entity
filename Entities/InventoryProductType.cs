using System;
using System.ComponentModel.DataAnnotations;

namespace Entities
{
    public class InventoryProductType
    {
        [Key]
        public Guid ProductTypeId { get; set; }

        [Required]
        [MaxLength(100)]
        public string ProductTypeName { get; set; }

        public bool Implant { get; set; } = false;

        [Required]
        public DateTime DateCreated { get; set; } = DateTime.Now;

        [Required]
        public DateTime DateLastModified { get; set; } = DateTime.Now;
    }
}
