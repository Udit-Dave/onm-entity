using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities
{
    public class InventoryQuantity
    {
        [Key]
        public Guid InventoryQuantityId { get; set; }

        [Required]
        [ForeignKey("ProductVariant")]
        public Guid ProductVariantId { get; set; }

        [ForeignKey("Location")]
        public Guid LocationId { get; set; }

        public int Quantity { get; set; }

        [MaxLength(50)]
        public string LotNumber { get; set; }

        [MaxLength(45)]
        public string SerialNumber { get; set; }

        public DateTime? ExpirationDate { get; set; }

        public decimal ReceivedPrice { get; set; }

        public bool Consigned { get; set; }
        public bool Loaned { get; set; }

        [Required]
        public DateTime DateCreated { get; set; } = DateTime.Now;

        [Required]
        public DateTime DateLastModified { get; set; } = DateTime.Now;

        // Relationships
        public ProductVariant ProductVariant { get; set; }
        public InventoryLocation Location { get; set; }
    }
}
