using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities
{
    public class EncounterProduct
    {
        [Key]
        public Guid EncounterProductId { get; set; }

        [Required]
        [ForeignKey("Encounter")]
        public Guid EncounterId { get; set; }

        [Required]
        [ForeignKey("Product")]
        public Guid ProductId { get; set; }

        public int Quantity { get; set; }

        [Required]
        public DateTime DateCreated { get; set; } = DateTime.Now;

        [Required]
        public DateTime DateLastModified { get; set; } = DateTime.Now;

        // Relationships
        public Encounter Encounter { get; set; }
        public Product Product { get; set; }
    }
}
