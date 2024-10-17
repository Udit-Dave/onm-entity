using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities
{
    public class InventoryProductVariant
    {
        [Key]
        public Guid ProductVariantId { get; set; }

        [Required]
        [ForeignKey("Product")]
        public Guid ProductId { get; set; }

        [Required]
        [MaxLength(50)]
        public string UPN { get; set; }

        [MaxLength(255)]
        public string Description { get; set; }

        [ForeignKey("UnitOfMeasure")]
        public Guid UnitOfMeasureId { get; set; }

        public int QuantityInUOM { get; set; }

        public decimal Price { get; set; }

        [MaxLength(50)]
        public string GLCode { get; set; }

        [Required]
        public bool Inactive { get; set; } = false;

        [Required]
        public DateTime DateCreated { get; set; } = DateTime.Now;

        [Required]
        public DateTime DateLastModified { get; set; } = DateTime.Now;

        // Relationships
        public Product Product { get; set; }
        public UnitOfMeasure UnitOfMeasure { get; set; }
    }
}
