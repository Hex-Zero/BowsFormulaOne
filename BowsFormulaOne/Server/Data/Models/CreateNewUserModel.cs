using System.ComponentModel.DataAnnotations;

namespace BowsFormulaOneAPI.Data.Models
{
    public class CreateNewUserModel
    {
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        public string EmployeeNumber { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string PhoneNumber { get; set; }
        public int PinCode { get; set; }
        public string CardNumber { get; set; }
    }
}
