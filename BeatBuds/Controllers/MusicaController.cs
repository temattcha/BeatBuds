using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using BeatBuds.Models;
using BeatBuds.Data;

namespace BeatBuds.Controllers
{
    [ApiController]
    [Route("api/musica")]
    public class MusicaController : ControllerBase
    {
        private readonly AppDataContext _context;

        public MusicaController(AppDataContext context)
        {
            _context = context;
        }

        // GET: api/Musica
        [HttpGet]
        [Route("listar")]
        public async Task<ActionResult<IEnumerable<Musica>>> GetMusicas()
        {
            return await _context.Musica.ToListAsync();
        }

        // GET: api/Musica/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Musica>> GetMusica(int id)
        {
            var musica = await _context.Musica.FindAsync(id);

            if (musica == null)
            {
                return NotFound();
            }

            return musica;
        }

        // POST: api/Musica
        [HttpPost]
        [Route("cadastrar")]
        public async Task<ActionResult<Musica>> PostMusica(Musica musica)
        {
            _context.Musica.Add(musica);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetMusica), new { id = musica.Id }, musica);
        }

        // PUT: api/Musica/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutMusica(int id, Musica musica)
        {
            if (id != musica.Id)
            {
                return BadRequest();
            }

            _context.Entry(musica).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!MusicaExists(id))
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

        // DELETE: api/Musica/5
        [HttpDelete("{id}")]
        [Route("deletar/{id}")]
        public async Task<IActionResult> DeleteMusica(int id)
        {
            var musica = await _context.Musica.FindAsync(id);
            if (musica == null)
            {
                return NotFound();
            }

            _context.Musica.Remove(musica);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool MusicaExists(int id)
        {
            return _context.Musica.Any(e => e.Id == id);
        }
    }
}
