using System;
using System.ComponentModel.DataAnnotations;

namespace Entities
{
    public class Facility
    {
        [Key]
        public Guid FacilityId { get; set; }

        [Required]
        [MaxLength(255)]
        public string FacilityName { get; set; }

        [Required]
        public DateTime DateCreated { get; set; } = DateTime.Now;

        [Required]
        public DateTime DateLastModified { get; set; } = DateTime.Now;
    }
}
