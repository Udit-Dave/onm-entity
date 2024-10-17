using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities
{
    public class EncounterStaff
    {
        [Key]
        public Guid EncounterStaffId { get; set; }

        [Required]
        [ForeignKey("Staff")]
        public Guid StaffId { get; set; }

        [Required]
        [ForeignKey("Encounter")]
        public Guid EncounterId { get; set; }

        [Required]
        public DateTime DateCreated { get; set; } = DateTime.Now;

        [Required]
        public DateTime DateLastModified { get; set; } = DateTime.Now;

        // Relationships
        public Staff Staff { get; set; }
        public Encounter Encounter { get; set; }
    }
}
