using System;
using System.ComponentModel.DataAnnotations;

namespace Entities
{
    public class Hospital
    {
        [Key]
        public Guid HospitalId { get; set; }

        [Required]
        [MaxLength(255)]
        public string HospitalName { get; set; }

        [Required]
        public DateTime DateCreated { get; set; } = DateTime.Now;

        [Required]
        public DateTime DateLastModified { get; set; } = DateTime.Now;
    }
}
