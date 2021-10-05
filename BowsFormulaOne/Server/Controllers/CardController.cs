using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using BowsFormulaOneAPI.Data;
using BowsFormulaOneAPI.Data.Models;

namespace BowsFormulaOne.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CardController : ControllerBase
    {
        private readonly DataContext _context;

        public CardController(DataContext context)
        {
            _context = context;
        }

        // GET: api/Card
        [HttpGet]
        public async Task<ActionResult<IEnumerable<CardDto>>> GetCardDto()
        {
            return await _context.CardDto.ToListAsync();
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

            return cardDto;
        }

        // PUT: api/Card/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCardDto(int id, CardDto cardDto)
        {
            if (id != cardDto.Id)
            {
                return BadRequest();
            }

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

        // POST: api/Card
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<CardDto>> PostCardDto(CardDto cardDto)
        {
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
