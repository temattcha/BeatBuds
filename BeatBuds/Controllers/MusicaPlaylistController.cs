﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BeatBuds.Models;
using BeatBuds.Data;

namespace BeatBuds.Controllers
{
    [ApiController]
    [Route("api/musicaPlaylist")]
    public class MusicaPlaylistController : ControllerBase
    {
        private readonly AppDataContext _context;

        public MusicaPlaylistController(AppDataContext context)
        {
            _context = context;
        }

        // GET: api/MusicaPlaylist
        [HttpGet]
        [Route("listar")]
        public async Task<ActionResult<IEnumerable<MusicaPlaylist>>> GetMusicaPlaylists()
        {
            return await _context.MusicaPlaylist.ToListAsync();
        }

        // GET: api/MusicaPlaylist/5
        [HttpGet("{id}")]
        public async Task<ActionResult<MusicaPlaylist>> GetMusicaPlaylist(int id)
        {
            var musicaPlaylist = await _context.MusicaPlaylist.FindAsync(id);

            if (musicaPlaylist == null)
            {
                return NotFound();
            }

            return musicaPlaylist;
        }

        // POST: api/MusicaPlaylist
        [HttpPost]
        [Route("cadastrar")]
        public async Task<ActionResult<MusicaPlaylist>> PostMusicaPlaylist(MusicaPlaylist musicaPlaylist)
        {
            _context.MusicaPlaylist.Add(musicaPlaylist);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetMusicaPlaylist), new { id = musicaPlaylist.MusicaPlaylistId }, musicaPlaylist);
        }

        // PUT: api/MusicaPlaylist/5
        [HttpPut("{id}")]
        [Route("alterar")]
        public async Task<IActionResult> PutMusicaPlaylist(int id, MusicaPlaylist musicaPlaylist)
        {
            if (id != musicaPlaylist.MusicaPlaylistId)
            {
                return BadRequest();
            }

            _context.Entry(musicaPlaylist).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!MusicaPlaylistExists(id))
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

        // DELETE: api/MusicaPlaylist/5
        [HttpDelete("{id}")]
        [Route("deletar")]
        public async Task<IActionResult> DeleteMusicaPlaylist(int id)
        {
            var musicaPlaylist = await _context.MusicaPlaylist.FindAsync(id);
            if (musicaPlaylist == null)
            {
                return NotFound();
            }

            _context.MusicaPlaylist.Remove(musicaPlaylist);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool MusicaPlaylistExists(int id)
        {
            return _context.MusicaPlaylist.Any(e => e.MusicaPlaylistId == id);
        }
    }
}
