using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Threading.Tasks;
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
    public class UserController : ControllerBase
    {
        private readonly DataContext _context;
        private readonly IValidators _validators;
        private readonly IEncryption _encryption;

        public UserController(DataContext context, IValidators validators, IEncryption encryption)
        {
            _context = context;
            _validators = validators;
            _encryption = encryption;
        }

        // GET: api/User
        [HttpGet]
        public async Task<ActionResult<IEnumerable<UserDto>>> GetUsers()
        {
            return await _context.Users
                .Include(u => u.PhoneNumbers)
                .Include(u => u.Emails)
                .Include(u => u.Cards)
                .ToListAsync();
        }

        // GET: api/User/5
        [HttpGet("{id}")]
        public async Task<ActionResult<UserDto>> GetUserDto(int id)
        {
            var userDto = await _context.Users
                .Include(u => u.PhoneNumbers)
                .Include(u => u.Emails)
                .Include(u => u.Cards).FirstOrDefaultAsync(u => u.Id == id);

            if (userDto == null)
            {
                return NotFound();
            }
            foreach (var cardDto in userDto.Cards)
            {
                if (!_validators.IsValidPinCode(cardDto.PinCode))
                {
                    cardDto.PinCode = _encryption.DecryptString(cardDto.PinCode);
                }
            }

            return userDto;
        }

        // PUT: api/User/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutUserDto(int id, UserDto userDto)
        {
            if (id != userDto.Id)
            {
                return BadRequest();
            }

            _context.Entry(userDto).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!UserDtoExists(id))
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

        // POST: api/User
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<UserDto>> PostUserDto(UserDto userDto)
        {
            _context.Users.Add(userDto);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetUserDto", new { id = userDto.Id }, userDto);
        }

        // DELETE: api/User/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteUserDto(int id)
        {
            var userDto = await _context.Users.FindAsync(id);
            if (userDto == null)
            {
                return NotFound();
            }

            _context.Users.Remove(userDto);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool UserDtoExists(int id)
        {
            return _context.Users.Any(e => e.Id == id);
        }
    }
}
