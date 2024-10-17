using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities
{
    public class Procedure
    {
        [Key]
        public Guid ProcedureId { get; set; }

        [Required]
        [MaxLength(50)]
        public string ProcedureName { get; set; }

        [Required]
        [MaxLength(50)]
        public string ProcedureType { get; set; }

        [Required]
        [ForeignKey("ProcedureRoom")]
        public Guid ProcedureRoomId { get; set; }

        [Required]
        public DateTime DateCreated { get; set; } = DateTime.Now;

        [Required]
        public DateTime DateLastModified { get; set; } = DateTime.Now;

        // Relationships
        public ProcedureRoom ProcedureRoom { get; set; }
    }
}
