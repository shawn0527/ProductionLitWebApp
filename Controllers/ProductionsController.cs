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
    public class ProductionsController : ControllerBase
    {
        private readonly ProductionLiteContext _context;

        public ProductionsController(ProductionLiteContext context)
        {
            _context = context;
        }

        // GET: api/Productions
        [HttpGet]
        public IEnumerable<Production> GetProductions()
        {
            return _context.Productions;
        }

        // GET: api/Productions/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetProduction([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var production = await _context.Productions.FindAsync(id);

            if (production == null)
            {
                return NotFound();
            }

            return Ok(production);
        }

        // PUT: api/Productions/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutProduction([FromRoute] int id, [FromBody] Production production)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != production.Id)
            {
                return BadRequest();
            }

            _context.Entry(production).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ProductionExists(id))
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

        // POST: api/Productions
        [HttpPost]
        public async Task<IActionResult> PostProduction([FromBody] Production production)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.Productions.Add(production);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetProduction", new { id = production.Id }, production);
        }

        // DELETE: api/Productions/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteProduction([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var production = await _context.Productions.FindAsync(id);
            if (production == null)
            {
                return NotFound();
            }

            _context.Productions.Remove(production);
            await _context.SaveChangesAsync();

            return Ok(production);
        }

        private bool ProductionExists(int id)
        {
            return _context.Productions.Any(e => e.Id == id);
        }
    }
}