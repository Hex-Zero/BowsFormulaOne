using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.SqlTypes;

namespace BowsFormulaOneAPI.Data.Models
{
    public class CardDto
    {
        public int Id { get; set; }
        public int UserDtoId { get; set; }
        [Required]
        public string CardNumber { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.Now;
        public DateTime ModifiedDate { get; set; } = DateTime.Now;
        [Required]
        public string PinCode { get; set; }
        public sbyte PinAttempts { get; set; } = 0;
        public DateTime CardLockedTill { get; set; } = DateTime.Now;
        [Column(TypeName="money")]
        public Decimal Balance { get; set; } = 0;
    }
}
