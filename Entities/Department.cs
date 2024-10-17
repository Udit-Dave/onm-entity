using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities
{
    public class Department
    {
        [Key]
        public Guid DepartmentId { get; set; }

        [Required]
        [MaxLength(255)]
        public string DepartmentName { get; set; }

        [Required]
        [ForeignKey("Hospital")]
        public Guid HospitalId { get; set; }

        [Required]
        public DateTime DateCreated { get; set; } = DateTime.Now;

        [Required]
        public DateTime DateLastModified { get; set; } = DateTime.Now;

        // Relationships
        public Hospital Hospital { get; set; }
    }
}
