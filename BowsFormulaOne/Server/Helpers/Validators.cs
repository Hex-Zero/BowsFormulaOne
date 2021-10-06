using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace BowsFormulaOne.Server.Helpers
{
    public interface IValidators
    {
        public bool IsValidCardNumber(string cardNumber);
        public bool IsValidUkPhoneNumber(string phoneNumber);
    }

    public class Validators : IValidators
    {
        public bool IsValidCardNumber(string cardNumber)
        {
            var regex = new Regex(@"^[a-zA-Z0-9]{16,16}$");
            return regex.IsMatch(cardNumber);
        }

        public bool IsValidUkPhoneNumber(string phoneNumber)
        {
            var regex = new Regex(@"^(((\+44)? ?(\(0\))? ?)|(0))( ?[0-9]{3,4}){3}");
            return regex.IsMatch(phoneNumber);
        }
    }
}
