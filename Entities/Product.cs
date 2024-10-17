using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities
{
    public class Product
    {
        [Key]
        public Guid ProductId { get; set; }

        [Required]
        [MaxLength(255)]
        public string ProductName { get; set; }

        [Required]
        [ForeignKey("Manufacturer")]
        public Guid ManufacturerId { get; set; }

        [MaxLength(50)]
        public string CatalogNumber { get; set; }

        [Required]
        public bool IsDiscontinued { get; set; }

        [Required]
        public DateTime DateCreated { get; set; } = DateTime.Now;

        [Required]
        public DateTime DateLastModified { get; set; } = DateTime.Now;

        // Relationships
        public Manufacturer Manufacturer { get; set; }
    }
}
