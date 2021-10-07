using System.Linq;
using System.Threading.Tasks;
using BowsFormulaOne.Server.Helpers;
using BowsFormulaOneAPI.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BowsFormulaOne.Server.Controllers
{
    // To enable the API key protection uncomment the below line and set the API Key in appsettings.json file
    // [ApiKey]
    [Route("api/[controller]")]
    [ApiController]
    public class BalanceController : Controller
    {
        private readonly DataContext _context;
        private readonly IValidators _validators;

        public BalanceController(DataContext context, IValidators validators)
        {
            _context = context;
            _validators = validators;
        }

        //GET: api/Bows/43kjfkdsfui343jk
        [HttpGet("{cardNumber}")]
        public async Task<ActionResult<decimal>> GetCardBalance(string cardNumber)
        {
            if (!_validators.IsValidCardNumber(cardNumber))
            {
                return NotFound("Card Number is invalid");
            }

            var cardDto = await _context.CardDto.FirstOrDefaultAsync(c => c.CardNumber == cardNumber);
            if (cardDto == null)
            {
                return NotFound("Card Not Found");
            }

            return Ok(cardDto.Balance);
        }

        // Both topping up and paying for at the kiosk is handled here
        // To top-up pass in positive value to process transaction pass in negative value
        //GET: api/Bows/43kjfkdsfui343jk
        [HttpPut("{cardNumber}")]
        public async Task<ActionResult<decimal>> CardTransaction(string cardNumber, decimal transactionAmount)
        {
            if (!_validators.IsValidCardNumber(cardNumber))
            {
                return NotFound("Card Number is invalid");
            }

            var cardDto = await _context.CardDto.FirstOrDefaultAsync(c => c.CardNumber == cardNumber);
            if (cardDto == null)
            {
                return NotFound("Card Not Found");
            }

            var resultingBalance = cardDto.Balance;

            resultingBalance = cardDto.Balance + transactionAmount;
            if (resultingBalance < 0)
            {
                return NotFound("insufficient Balance. Please top-up. Your Balance is: " + cardDto.Balance + "£");
            }

            cardDto.Balance = resultingBalance;

            _context.Entry(cardDto).State = EntityState.Modified;
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CardDtoExists(cardDto.Id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return Ok(cardDto.Balance);
        }
        private bool CardDtoExists(int id)
        {
            return _context.CardDto.Any(e => e.Id == id);
        }
    }
}
