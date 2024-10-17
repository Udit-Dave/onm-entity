using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities
{
    public class InventoryProduct
    {
        [Key]
        public Guid ProductId { get; set; }

        [Required]
        [MaxLength(255)]
        public string ProductName { get; set; }

        [ForeignKey("ProductType")]
        public Guid ProductTypeId { get; set; }

        [ForeignKey("Manufacturer")]
        public Guid ManufacturerId { get; set; }

        [MaxLength(50)]
        public string CatalogNumber { get; set; }

        [MaxLength(50)]
        public string CleanCatalogNumber { get; set; }

        [MaxLength(255)]
        public string Description { get; set; }

        public bool Latex { get; set; } = false;
        public bool Implant { get; set; } = false;
        public bool Stock { get; set; } = false;
        public bool Discontinued { get; set; } = false;

        [Required]
        public DateTime DateCreated { get; set; } = DateTime.Now;

        [Required]
        public DateTime DateLastModified { get; set; } = DateTime.Now;

        // Relationships
        public InventoryProductType ProductType { get; set; }
        public Manufacturer Manufacturer { get; set; }
    }
}
