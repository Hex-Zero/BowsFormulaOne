using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BowsFormulaOne.Server.Attributes;
using BowsFormulaOne.Server.Helpers;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using BowsFormulaOneAPI.Data;
using BowsFormulaOneAPI.Data.Models;

namespace BowsFormulaOne.Server.Controllers
{
    // This controller can be removed if NOT in use
    // To enable the API key protection uncomment the below line and set the API Key in appsettings.json file
    // [ApiKey]
    [Route("api/[controller]")]
    [ApiController]
    public class CardController : ControllerBase
    {
        private readonly DataContext _context;
        private readonly IValidators _validators;
        private readonly IEncryption _encryption;

        public CardController(DataContext context, IValidators validators, IEncryption encryption)
        {
            _context = context;
            _validators = validators;
            _encryption = encryption;
        }

        // GET: api/Card
        [HttpGet]
        public async Task<ActionResult<IEnumerable<CardDto>>> GetCardDto()
        {
            var cards = await _context.CardDto.ToListAsync();
            foreach (var cardDto in cards)
            {
                if (!_validators.IsValidPinCode(cardDto.PinCode))
                {
                    cardDto.PinCode = _encryption.DecryptString(cardDto.PinCode);
                }
            }

            return cards;
        }

        // GET: api/Card/5
        [HttpGet("{id}")]
        public async Task<ActionResult<CardDto>> GetCardDto(int id)
        {
            var cardDto = await _context.CardDto.FindAsync(id);

            if (cardDto == null)
            {
                return NotFound();
            }

            if (!_validators.IsValidPinCode(cardDto.PinCode))
            {
                cardDto.PinCode = _encryption.DecryptString(cardDto.PinCode);
            }

            return cardDto;
        }


        // PUT: api/Card/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCardDto(int id, CardDto cardDto)
        {
            if (!_validators.IsValidPinCode(cardDto.PinCode))
            {
                return NotFound("The Pin Code is Invalid");
            }

            if (!_validators.IsValidCardNumber(cardDto.CardNumber))
            {
                return NotFound("Card Number is Invalid");
            }


            if (id != cardDto.Id)
            {
                return BadRequest();
            }

            cardDto.PinCode = _encryption.EncryptString(cardDto.PinCode);

            _context.Entry(cardDto).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CardDtoExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        private async Task<bool> IsUniqueCardNumber(string cardNumber)
        {
            return await _context.CardDto.FirstOrDefaultAsync(c => c.CardNumber == cardNumber) == null;;
        }

        // POST: api/Card
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<CardDto>> PostCardDto(CardDto cardDto)
        {
            if (!_validators.IsValidPinCode(cardDto.PinCode))
            {
                return NotFound("The Pin Code is Invalid");
            }

            if (!_validators.IsValidCardNumber(cardDto.CardNumber))
            {
                return NotFound("Card Number Invalid");
            }

            if (!await IsUniqueCardNumber(cardDto.CardNumber))
            {
                return NotFound("Card number is NOT Unique");
            }

            cardDto.PinCode = _encryption.EncryptString(cardDto.PinCode);

            _context.CardDto.Add(cardDto);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetCardDto", new { id = cardDto.Id }, cardDto);
        }

        // DELETE: api/Card/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCardDto(int id)
        {
            var cardDto = await _context.CardDto.FindAsync(id);
            if (cardDto == null)
            {
                return NotFound();
            }

            _context.CardDto.Remove(cardDto);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool CardDtoExists(int id)
        {
            return _context.CardDto.Any(e => e.Id == id);
        }
    }
}
