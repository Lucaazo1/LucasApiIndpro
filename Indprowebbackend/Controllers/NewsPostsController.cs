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
    public class NewsPostsController : ControllerBase
    {
        private readonly IndprowebbackendContext _context;

        public NewsPostsController(IndprowebbackendContext context)
        {
            _context = context;
        }

        // GET: api/NewsPosts
        [HttpGet]
        public async Task<ActionResult<IEnumerable<NewsPosts>>> GetNewsPosts()
        {
          if (_context.NewsPosts == null)
          {
              return NotFound();
          }
            return await _context.NewsPosts.ToListAsync();
        }

        // GET: api/NewsPosts/5
        [HttpGet("{id}")]
        public async Task<ActionResult<NewsPosts>> GetNewsPosts(int id)
        {
          if (_context.NewsPosts == null)
          {
              return NotFound();
          }
            var newsPosts = await _context.NewsPosts.FindAsync(id);

            if (newsPosts == null)
            {
                return NotFound();
            }

            return newsPosts;
        }

        // PUT: api/NewsPosts/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutNewsPosts(int id, NewsPosts newsPosts)
        {
            if (id != newsPosts.Id)
            {
                return BadRequest();
            }

            _context.Entry(newsPosts).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!NewsPostsExists(id))
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

        // POST: api/NewsPosts
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<NewsPosts>> PostNewsPosts(NewsPosts newsPosts)
        {
          if (_context.NewsPosts == null)
          {
              return Problem("Entity set 'IndprowebbackendContext.NewsPosts'  is null.");
          }
            _context.NewsPosts.Add(newsPosts);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetNewsPosts", new { id = newsPosts.Id }, newsPosts);
        }

        // DELETE: api/NewsPosts/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteNewsPosts(int id)
        {
            if (_context.NewsPosts == null)
            {
                return NotFound();
            }
            var newsPosts = await _context.NewsPosts.FindAsync(id);
            if (newsPosts == null)
            {
                return NotFound();
            }

            _context.NewsPosts.Remove(newsPosts);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool NewsPostsExists(int id)
        {
            return (_context.NewsPosts?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
