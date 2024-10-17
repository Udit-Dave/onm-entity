using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities
{
    public class ProductVariant
    {
        [Key]
        public Guid ProductVariantId { get; set; }

        [Required]
        [ForeignKey("Product")]
        public Guid ProductId { get; set; }

        [Required]
        [MaxLength(50)]
        public string UPN { get; set; }

        public int QuantityInUOM { get; set; }

        [MaxLength(50)]
        public string BillingCode { get; set; }

        [MaxLength(25)]
        public string GLCode { get; set; }

        [MaxLength(500)]
        public string AncillaryNotes { get; set; }

        [Required]
        public bool Inactive { get; set; } = false;

        [Required]
        public DateTime DateCreated { get; set; } = DateTime.Now;

        [Required]
        public DateTime DateLastModified { get; set; } = DateTime.Now;

        // Relationships
        public Product Product { get; set; }
    }
}
