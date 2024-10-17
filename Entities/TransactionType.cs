using System;
using System.ComponentModel.DataAnnotations;

namespace Entities
{
    public class TransactionType
    {
        [Key]
        public Guid TransactionTypeId { get; set; }

        [Required]
        [MaxLength(50)]
        public string TransactionTypeName { get; set; }

        public bool Inactive { get; set; } = false;

        [Required]
        public DateTime DateCreated { get; set; } = DateTime.Now;

        [Required]
        public DateTime DateLastModified { get; set; } = DateTime.Now;
    }
}
