using System;
using System.ComponentModel.DataAnnotations;

namespace BowsFormulaOneAPI.Data.Models
{
    public class PhoneNumberDto
    {
        public int Id { get; set; }
        public int UserDtoId { get; set; }
        [Required]
        public string PhoneNumber { get; set; }
        public DateTime ModifiedDate { get; set; } = DateTime.Now;
        public bool IsDeleted { get; set; } = false;
    }
}
