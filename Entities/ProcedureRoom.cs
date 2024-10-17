using System;
using System.ComponentModel.DataAnnotations;

namespace Entities
{
    public class ProcedureRoom
    {
        [Key]
        public Guid ProcedureRoomId { get; set; }

        [Required]
        [MaxLength(50)]
        public string RoomName { get; set; }

        [Required]
        [ForeignKey("Department")]
        public Guid DepartmentId { get; set; }

        [Required]
        public DateTime DateCreated { get; set; } = DateTime.Now;

        [Required]
        public DateTime DateLastModified { get; set; } = DateTime.Now;

        // Relationships
        public Department Department { get; set; }
    }
}
