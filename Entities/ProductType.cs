using System;
using System.ComponentModel.DataAnnotations;

namespace Entities
{
    public class ProductType
    {
        [Key]
        public Guid ProductTypeId { get; set; }

        [Required]
        [MaxLength(100)]
        public string ProductTypeName { get; set; }

        [Required]
        public bool Implant { get; set; } = false;

        [Required]
        public DateTime DateCreated { get; set; } = DateTime.Now;

        [Required]
        public DateTime DateLastModified { get; set; } = DateTime.Now;
    }
}
