using System;
using System.Collections.Generic;

namespace BowsFormulaOneAPI.Data.Models
{
    public class UserDto
    {
        public int Id { get; set; }
        public string FirstName { get; set; } = "";
        public string LastName { get; set; } = "";
        public string EmployeeNumber { get; set; } = "";
        public DateTime CreatedDate { get; set; } = DateTime.Now;
        public DateTime ModifiedDate { get; set; } = DateTime.Now;
        public bool IsDeleted { get; set; } = false;
        public virtual ICollection<PhoneNumberDto> PhoneNumbers { get; set; }
        public virtual ICollection<EmailDto> Emails { get; set; }
        public virtual ICollection<CardDto> Cards { get; set; }
    }
}
