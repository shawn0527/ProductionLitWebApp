using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProductionLiteWebApp.Data;
using ProductionLiteWebApp.Models;

namespace ProductionLiteWebApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PhoneNumbersController : ControllerBase
    {
        private readonly ProductionLiteContext _context;

        public PhoneNumbersController(ProductionLiteContext context)
        {
            _context = context;
        }

        // GET: api/PhoneNumbers
        [HttpGet]
        public IEnumerable<PhoneNumber> GetPhoneNumber()
        {
            return _context.PhoneNumber;
        }

        // GET: api/PhoneNumbers/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetPhoneNumber([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var phoneNumber = await _context.PhoneNumber.FindAsync(id);

            if (phoneNumber == null)
            {
                return NotFound();
            }

            return Ok(phoneNumber);
        }

        // PUT: api/PhoneNumbers/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutPhoneNumber([FromRoute] int id, [FromBody] PhoneNumber phoneNumberModifier)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (!PhoneNumberExists(id))
            {
                return NotFound();
            }

            var phoneNumber = await _context.PhoneNumber.FindAsync(id);
            phoneNumber.CellPhoneNumber = phoneNumberModifier.CellPhoneNumber;
            phoneNumber.WorkPhoneNumber = phoneNumberModifier.WorkPhoneNumber;

            _context.Entry(phoneNumber).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {

            }
            return Ok(phoneNumber);
        }

        // POST: api/PhoneNumbers
        [HttpPost]
        public async Task<IActionResult> PostPhoneNumber([FromBody] PhoneNumber phoneNumber)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.PhoneNumber.Add(phoneNumber);
            await _context.SaveChangesAsync();

            return Ok(phoneNumber);
        }

        // DELETE: api/PhoneNumbers/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePhoneNumber([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var phoneNumber = await _context.PhoneNumber.FindAsync(id);
            if (phoneNumber == null)
            {
                return NotFound();
            }

            _context.PhoneNumber.Remove(phoneNumber);
            await _context.SaveChangesAsync();

            return Ok(phoneNumber);
        }

        private bool PhoneNumberExists(int id)
        {
            return _context.PhoneNumber.Any(e => e.Id == id);
        }
    }
}