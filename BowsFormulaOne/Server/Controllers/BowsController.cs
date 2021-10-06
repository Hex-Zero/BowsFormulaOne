using System;
using System.Collections.Generic;
using System.Net.Mail;
using System.Threading.Tasks;
using BowsFormulaOne.Server.Helpers;
using Microsoft.EntityFrameworkCore;
using BowsFormulaOneAPI.Data;
using BowsFormulaOneAPI.Data.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

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
        private readonly IEncryption _encryption;

        public BowsController(DataContext context, IValidators validators, IKeyGenerator keyGenerator, IEncryption encryption)
        {
            _context = context;
            _validators = validators;
            _keyGenerator = keyGenerator;
            _encryption = encryption;
        }

        //GET: api/Bows/43kjfkdsfui343jk
        [HttpGet("{cardNumber}")]
        public async Task<ActionResult<UserDto>> GetCardUserDto(string cardNumber)
        {

            if (!_validators.IsValidCardNumber(cardNumber))
            {
                return NotFound("Card Number is invalid");
            }

            var cardDto = await _context.CardDto.FirstOrDefaultAsync(c => c.CardNumber.Equals(cardNumber));
            if (cardDto == null)
            {
                return NotFound("No Card User Found. Please add a new card user.");
            }

            if (!_validators.IsValidPinCode(cardDto.PinCode))
            {
                cardDto.PinCode = _encryption.DecryptString(cardDto.PinCode);
            }

            var cardUser = await _context.Users
                .Include(u => u.Emails)
                .Include(u => u.PhoneNumbers)
                .FirstOrDefaultAsync(u => u.Id.Equals(cardDto.UserDtoId));

            return cardUser;
        }

        private async Task<bool> IsUniqueCardNumber(string cardNumber)
        {
            return await _context.CardDto.FirstOrDefaultAsync(c => c.CardNumber == cardNumber) == null;;
        }

        [HttpPost]
        public async Task<ActionResult<UserDto>> PostCardDto(CreateNewUserModel newUser)
        {
            var newId = "";

            try {
               var address = new MailAddress(newUser.Email).Address;
            } catch(FormatException) {
                return NotFound("Email Address is Invalid");
            }

            if (!_validators.IsValidPinCode(newUser.PinCode))
            {
                return NotFound("The Pin Code is Invalid");
            }

            if (!_validators.IsValidUkPhoneNumber(newUser.PhoneNumber))
            {
                return NotFound("Phone Number is Invalid");
            }

            if (!String.IsNullOrEmpty(newUser.CardNumber))
            {
                if (!_validators.IsValidCardNumber(newUser.CardNumber))
                {
                    return NotFound("Card Number is Invalid");
                }

                if (!(await IsUniqueCardNumber(newUser.CardNumber)))
                {
                    return NotFound("Card number is NOT Unique");
                }

                newId = newUser.CardNumber;
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

            var addUser = new UserDto
            {
                EmployeeNumber = newUser.EmployeeNumber,
                FirstName = newUser.FirstName,
                LastName = newUser.LastName,
            };
            await _context.Users.AddAsync(addUser);
            await _context.SaveChangesAsync();

            var addEmail = new EmailDto
            {
                EmailAddress = newUser.Email,
                UserDtoId = addUser.Id,
            };
            await _context.Emails.AddAsync(addEmail);

            var addPhoneNumber = new PhoneNumberDto
            {
                PhoneNumber = newUser.PhoneNumber,
                UserDtoId = addUser.Id
            };
            await _context.PhoneNumbers.AddAsync(addPhoneNumber);

            var addCard = new CardDto
            {
                CardNumber = newId,
                PinCode = _encryption.EncryptString(newUser.PinCode),
                UserDtoId = addUser.Id,
            };
            await _context.CardDto.AddAsync(addCard);
            await _context.SaveChangesAsync();

            return addUser;
        }
    }

}
