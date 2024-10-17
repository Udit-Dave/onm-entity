using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities
{
    public class Encounter
    {
        [Key]
        public Guid EncounterId { get; set; }

        [Required]
        [ForeignKey("Facility")]
        public Guid FacilityId { get; set; }

        [Required]
        [ForeignKey("Department")]
        public Guid DepartmentId { get; set; }

        [Required]
        [ForeignKey("Patient")]
        public Guid PatientId { get; set; }

        [Required]
        [MaxLength(50)]
        public string StatusId { get; set; }

        [MaxLength(1024)]
        public string Comment { get; set; }

        [Required]
        public DateTime DateStarted { get; set; } = DateTime.Now;

        [Required]
        public DateTime DateCompleted { get; set; }

        [Required]
        public DateTime DateCreated { get; set; } = DateTime.Now;

        [Required]
        public DateTime DateLastModified { get; set; } = DateTime.Now;

        // Relationships
        public Facility Facility { get; set; }
        public Department Department { get; set; }
        public Patient Patient { get; set; }
    }
}
