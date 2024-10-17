using System;
using System.ComponentModel.DataAnnotations;

namespace Entities
{
    public class Site
    {
        [Key]
        public Guid SiteId { get; set; }

        [Required]
        [MaxLength(50)]
        public string SiteName { get; set; }

        public bool Inactive { get; set; } = false;

        [Required]
        public DateTime DateCreated { get; set; } = DateTime.Now;

        [Required]
        public DateTime DateLastModified { get; set; } = DateTime.Now;
    }
}
