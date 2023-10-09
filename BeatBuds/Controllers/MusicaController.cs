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

        [HttpGet]
        [Route("listar")]
        public IActionResult listar()
        {
            try
            {
                List<Musica> musica =
                    _context.Musica
                    .Include(x => x.Usuario)
                    .ToList();
                return musica.Count == 0 ? NotFound() : Ok(musica);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
        [HttpPost]
        [Route("cadastrar")]
        public IActionResult Cadastrar([FromBody] Musica musica)
        {
            try
            {
                Usuario? usuario =
                    _context.Usuario.Find(musica.UsuarioId);
                if (usuario == null)
                {
                    return NotFound();
                }
                musica.Usuario = usuario;
                _context.Musica.Add(musica);
                _context.SaveChanges();
                return Created("", musica);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return BadRequest(e.Message);
            }
        }

        [HttpDelete("{id}")]
        [Route("deletar/{id}")]
        public IActionResult Deletar([FromRoute] int id)
        {
            try
            {
                Musica? musicaCadastrada = _context.Musica.Find(id);
                if (musicaCadastrada != null)
                {
                    _context.Musica.Remove(musicaCadastrada);
                    _context.SaveChanges();
                    return Ok();
                }
                return NotFound();
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
    }
}
