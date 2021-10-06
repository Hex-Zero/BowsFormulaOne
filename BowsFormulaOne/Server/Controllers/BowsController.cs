using System.Threading.Tasks;
using BowsFormulaOne.Server.Helpers;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using BowsFormulaOneAPI.Data;
using BowsFormulaOneAPI.Data.Models;

namespace BowsFormulaOne.Server.Controllers
{
    // To enable the API key protection uncomment the below line and set the API Key in appsettings.json file
    // [ApiKey]
    [Route("api/[controller]")]
    [ApiController]
    public class BowsController : ControllerBase
    {
        private readonly DataContext _context;
        private readonly IValidators _validators;
        private readonly IKeyGenerator _keyGenerator;

        public BowsController(DataContext context, IValidators validators, IKeyGenerator keyGenerator)
        {
            _context = context;
            _validators = validators;
            _keyGenerator = keyGenerator;
        }

        //GET: api/Bows/43kjfkdsfui343jk
        [HttpGet("{cardNumber}")]
        public async Task<ActionResult<CardDto>> GetCardDto(string cardNumber)
        {

            if (!_validators.IsValidCardNumber(cardNumber))
            {
                return NotFound("Card Number is invalid");
            }

            var cardDto = await _context.CardDto.FirstOrDefaultAsync(c => c.CardNumber.Equals(cardNumber));
            if (cardDto == null)
            {
                return NotFound("No card Found. Please add a new card user.");
            }

            var cardUser = await _context.Users.FirstOrDefaultAsync(u => u.Id.Equals(cardDto.UserDtoId));

            cardDto.CardUser = cardUser;

            return cardDto;
        }

        private async Task<bool> IsUniqueCardNumber(string cardNumber)
        {
            return await _context.CardDto.FirstOrDefaultAsync(c => c.CardNumber == cardNumber) == null;;
        }

        [HttpPost]
        public async Task<ActionResult<CardDto>> PostCardDto(CreateNewUserModel newUser)
        {
            var newId = "";

            if (newUser.CardNumber != null)
            {
                if (await IsUniqueCardNumber(newUser.CardNumber))
                {
                    return NotFound("Card number is not unique");
                }
            }
            else
            {
                var isUniqueId = false;
                while (!isUniqueId)
                {
                    newId = _keyGenerator.GetUniqueKey(16);
                    isUniqueId = await IsUniqueCardNumber(newId);
                }

            }


            return NotFound(newId);

            await _context.SaveChangesAsync();

            return Ok();
        }


    }

}
