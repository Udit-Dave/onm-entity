using System;
using System.ComponentModel.DataAnnotations;

namespace Entities
{
    public class Manufacturer
    {
        [Key]
        public Guid ManufacturerId { get; set; }

        [Required]
        [MaxLength(150)]
        public string ManufacturerName { get; set; }

        [MaxLength(150)]
        public string Address { get; set; }

        [MaxLength(150)]
        public string City { get; set; }

        [MaxLength(50)]
        public string StateRegion { get; set; }

        [MaxLength(16)]
        public string PostalCode { get; set; }

        [MaxLength(50)]
        public string CountryName { get; set; }

        [MaxLength(30)]
        public string MainPhone { get; set; }

        [MaxLength(30)]
        public string MainFax { get; set; }

        [MaxLength(255)]
        public string WebSite { get; set; }

        [MaxLength(30)]
        public string EmailId { get; set; }

        [Required]
        public DateTime DateCreated { get; set; } = DateTime.Now;

        [Required]
        public DateTime DateLastModified { get; set; } = DateTime.Now;
    }
}
