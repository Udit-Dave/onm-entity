using System;
using System.ComponentModel.DataAnnotations;

namespace Entities
{
    public class ProductBillingCode
    {
        [Key]
        public Guid ProductBillingCodeId { get; set; }

        [Required]
        [MaxLength(50)]
        public string BillingCode { get; set; }

        [Required]
        public DateTime DateCreated { get; set; } = DateTime.Now;

        [Required]
        public DateTime DateLastModified { get; set; } = DateTime.Now;
    }
}
