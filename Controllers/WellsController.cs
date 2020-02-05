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
    public class WellsController : ControllerBase
    {
        private readonly ProductionLiteContext _context;

        public WellsController(ProductionLiteContext context)
        {
            _context = context;
        }

        // GET: api/Wells
        [HttpGet]
        public IEnumerable<Well> GetWells()
        {
            return _context.Wells;
        }

        // GET: api/Wells/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetWell([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var well = await _context.Wells.FindAsync(id);

            if (well == null)
            {
                return NotFound();
            }

            return Ok(well);
        }

        // PUT: api/Wells/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutWell([FromRoute] int id, [FromBody] Well well)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != well.Id)
            {
                return BadRequest();
            }

            _context.Entry(well).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!WellExists(id))
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

        // POST: api/Wells
        [HttpPost]
        public async Task<IActionResult> PostWell([FromBody] Well well)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.Wells.Add(well);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetWell", new { id = well.Id }, well);
        }

        // DELETE: api/Wells/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteWell([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var well = await _context.Wells.FindAsync(id);
            if (well == null)
            {
                return NotFound();
            }

            _context.Wells.Remove(well);
            await _context.SaveChangesAsync();

            return Ok(well);
        }

        private bool WellExists(int id)
        {
            return _context.Wells.Any(e => e.Id == id);
        }
    }
}