using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using BlazorSignalR.Server.Context;
using BlazorSignalR.Server.Data;
using BlazorSignalR.Shared;

namespace BlazorSignalR.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProgrammingsController : ControllerBase
    {
        private readonly BlazorSignalRServerContext _context;

        public ProgrammingsController(BlazorSignalRServerContext context)
        {
            _context = context;
        }

        // GET: api/Programmings
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Programming>>> GetProgramming()
        {
            return await _context.Programming.ToListAsync();
        }

        // GET: api/Programmings/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Programming>> GetProgramming(int id)
        {
            var programming = await _context.Programming.FindAsync(id);

            if (programming == null)
            {
                return NotFound();
            }

            return programming;
        }

        // PUT: api/Programmings/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutProgramming(int id, Programming programming)
        {
            if (id != programming.Id)
            {
                return BadRequest();
            }

            _context.Entry(programming).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ProgrammingExists(id))
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

        // POST: api/Programmings
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Programming>> PostProgramming(Programming programming)
        {
            _context.Programming.Add(programming);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetProgramming", new { id = programming.Id }, programming);
        }

        // DELETE: api/Programmings/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Programming>> DeleteProgramming(int id)
        {
            var programming = await _context.Programming.FindAsync(id);
            if (programming == null)
            {
                return NotFound();
            }

            _context.Programming.Remove(programming);
            await _context.SaveChangesAsync();

            return programming;
        }

        private bool ProgrammingExists(int id)
        {
            return _context.Programming.Any(e => e.Id == id);
        }
    }
}
