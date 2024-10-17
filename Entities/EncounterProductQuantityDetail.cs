using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities
{
    public class EncounterProductQuantityDetail
    {
        [Key]
        public Guid EncounterProductQuantityDetailId { get; set; }

        [Required]
        [ForeignKey("EncounterProduct")]
        public Guid EncounterProductId { get; set; }

        [Required]
        [ForeignKey("ProductVariant")]
        public Guid ProductVariantId { get; set; }

        [Required]
        [ForeignKey("InventoryQuantity")]
        public Guid InventoryQuantityId { get; set; }

        public int Quantity { get; set; }

        [Required]
        public DateTime DateCreated { get; set; } = DateTime.Now;

        [Required]
        public DateTime DateLastModified { get; set; } = DateTime.Now;

        // Relationships
        public EncounterProduct EncounterProduct { get; set; }
        public ProductVariant ProductVariant { get; set; }
        public InventoryQuantity InventoryQuantity { get; set; }
    }
}
