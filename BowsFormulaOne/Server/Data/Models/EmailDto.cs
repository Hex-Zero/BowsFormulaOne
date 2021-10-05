using System;

namespace BowsFormulaOneAPI.Data.Models
{
    public class EmailDto
    {
        public int Id { get; set; }
        public int UserDtoId { get; set; }
        public string EmailAddress { get; set; }
        public DateTime ModifiedDate { get; set; } = DateTime.Now;
        public bool IsDeleted { get; set; } = false;
    }
}
