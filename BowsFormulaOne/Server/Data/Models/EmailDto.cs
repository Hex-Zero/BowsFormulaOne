using System;
using System.ComponentModel.DataAnnotations;

namespace BowsFormulaOneAPI.Data.Models
{
    public class EmailDto
    {
        public int Id { get; set; }
        public int UserDtoId { get; set; }
        [Required]
        public string EmailAddress { get; set; }
        public DateTime ModifiedDate { get; set; } = DateTime.Now;
        public bool IsDeleted { get; set; } = false;
    }
}
