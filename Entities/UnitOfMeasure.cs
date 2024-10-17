using System;
using System.ComponentModel.DataAnnotations;

namespace Entities
{
    public class UnitOfMeasure
    {
        [Key]
        public Guid UnitOfMeasureId { get; set; }

        [Required]
        [MaxLength(4)]
        public string Unit { get; set; }

        [Required]
        public DateTime DateCreated { get; set; } = DateTime.Now;

        [Required]
        public DateTime DateLastModified { get; set; } = DateTime.Now;
    }
}
