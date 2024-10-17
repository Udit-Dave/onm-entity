using System;
using System.ComponentModel.DataAnnotations;

namespace Entities
{
    public class Designation
    {
        [Key]
        public Guid DesignationId { get; set; }

        [Required]
        [MaxLength(50)]
        public string DesignationName { get; set; }

        public bool Inactive { get; set; } = false;

        [Required]
        public DateTime DateCreated { get; set; } = DateTime.Now;

        [Required]
        public DateTime DateLastModified { get; set; } = DateTime.Now;
    }
}
