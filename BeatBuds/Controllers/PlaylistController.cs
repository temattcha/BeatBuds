using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BeatBuds.Models;
using BeatBuds.Data;

[Route("api/playlist")]
[ApiController]
public class PlaylistController : ControllerBase
{
    private readonly AppDataContext _context;

    public PlaylistController(AppDataContext context)
    {
        _context = context;
    }

    // GET: api/Playlist
    [HttpGet]
    public async Task<ActionResult<IEnumerable<Playlist>>> GetPlaylist()
    {
        return await _context.Playlist.ToListAsync();
    }

    // GET: api/Playlist/5
    [HttpGet("{id}")]
    public async Task<ActionResult<Playlist>> GetPlaylist(int id)
    {
        var playlist = await _context.Playlist.FindAsync(id);

        if (playlist == null)
        {
            return NotFound();
        }

        return playlist;
    }

    // POST: api/Playlist
    [HttpPost]
    public async Task<ActionResult<Playlist>> PostPlaylist(Playlist playlist)
    {
        _context.Playlist.Add(playlist);
        await _context.SaveChangesAsync();

        return CreatedAtAction("GetPlaylist", new { id = playlist.Id }, playlist);
    }

    // PUT: api/Playlist
    [HttpPut("{id}")]
    public async Task<IActionResult> PutPlaylist(int id, Playlist playlist)
    {
        if (id != playlist.Id)
        {
            return BadRequest();
        }

        _context.Entry(playlist).State = EntityState.Modified;

        try
        {
            await _context.SaveChangesAsync();
        }
        catch (DbUpdateConcurrencyException)
        {
            if (!PlaylistExists(id))
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

    // DELETE: api/Playlist
    [HttpDelete("{id}")]
    public async Task<IActionResult> DeletePlaylist(int id)
    {
        var playlist = await _context.Playlist.FindAsync(id);
        if (playlist == null)
        {
            return NotFound();
        }

        _context.Playlist.Remove(playlist);
        await _context.SaveChangesAsync();

        return NoContent();
    }

    private bool PlaylistExists(int id)
    {
        return _context.Playlist.Any(e => e.Id == id);
    }
}
