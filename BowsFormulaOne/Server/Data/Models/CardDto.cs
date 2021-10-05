using System;
using System.Diagnostics.CodeAnalysis;

namespace BowsFormulaOneAPI.Data.Models
{
    public class CardDto
    {
        public int Id { get; set; }
        public int UserDtoId { get; set; }
        public string CardNumber { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.Now;
        public DateTime ModifiedDate { get; set; } = DateTime.Now;
        [NotNull]
        public int PinCode { get; set; }
        public sbyte PinAttempts { get; set; } = 0;
        public DateTime CardLockedTill { get; set; } = DateTime.Now;
    }
}
