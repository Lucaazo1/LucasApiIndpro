using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Indprowebbackend.Data;
using Indprowebbackend.DataModels;

namespace Indprowebbackend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FullContentsController : ControllerBase
    {
        private readonly IndprowebbackendContext _context;

        public FullContentsController(IndprowebbackendContext context)
        {
            _context = context;
        }

        // GET: api/FullContents
        [HttpGet]
        public async Task<ActionResult<IEnumerable<FullContent>>> GetFullContent()
        {
          if (_context.FullContent == null)
          {
              return NotFound();
          }
            return await _context.FullContent.ToListAsync();
        }

        // GET: api/FullContents/5
        [HttpGet("{id}")]
        public async Task<ActionResult<FullContent>> GetFullContent(int id)
        {
          if (_context.FullContent == null)
          {
              return NotFound();
          }
            var fullContent = await _context.FullContent.FindAsync(id);

            if (fullContent == null)
            {
                return NotFound();
            }

            return fullContent;
        }

        // PUT: api/FullContents/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutFullContent(int id, FullContent fullContent)
        {
            if (id != fullContent.FullContentId)
            {
                return BadRequest();
            }

            _context.Entry(fullContent).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!FullContentExists(id))
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

        // POST: api/FullContents
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<FullContent>> PostFullContent(FullContent fullContent)
        {
          if (_context.FullContent == null)
          {
              return Problem("Entity set 'IndprowebbackendContext.FullContent'  is null.");
          }
            _context.FullContent.Add(fullContent);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetFullContent", new { id = fullContent.FullContentId }, fullContent);
        }

        // DELETE: api/FullContents/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteFullContent(int id)
        {
            if (_context.FullContent == null)
            {
                return NotFound();
            }
            var fullContent = await _context.FullContent.FindAsync(id);
            if (fullContent == null)
            {
                return NotFound();
            }

            _context.FullContent.Remove(fullContent);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool FullContentExists(int id)
        {
            return (_context.FullContent?.Any(e => e.FullContentId == id)).GetValueOrDefault();
        }
    }
}
