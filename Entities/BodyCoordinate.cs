using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities
{
    public class BodyCoordinate
    {
        [Key]
        public Guid BodyCoordinateId { get; set; }

        [Required]
        [ForeignKey("Site")]
        public Guid SiteId { get; set; }

        [Required]
        [ForeignKey("Side")]
        public Guid SideId { get; set; }

        [Required]
        [MaxLength(10)]
        public string Gender { get; set; }

        [Required]
        public decimal XCoordinate { get; set; }

        [Required]
        public decimal YCoordinate { get; set; }

        public bool Inactive { get; set; } = false;

        [Required]
        public DateTime DateCreated { get; set; } = DateTime.Now;

        [Required]
        public DateTime DateLastModified { get; set; } = DateTime.Now;

        // Relationships
        public Site Site { get; set; }
        public Side Side { get; set; }
    }
}
