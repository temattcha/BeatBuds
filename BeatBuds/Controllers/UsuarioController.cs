using BeatBuds.Data;
using BeatBuds.Models;
using Microsoft.AspNetCore.Mvc;

namespace BeatBuds.Controllers;


[ApiController]
[Route ("api/usuario") ]
public class UsuarioController : ControllerBase
{
private readonly AppDataContext _context;

    public UsuarioController(AppDataContext context)
    {
        _context = context;
    }

    [HttpGet]
    [Route("listar")]
    public IActionResult Listar()
    {
        try
        {
            List<Usuario> usuarios =
                _context.Usuario
                .ToList();
            return Usuario.Count == 0 ? NotFound() : Ok(usuarios);
        }
        catch (Exception e)
        {
            return BadRequest(e.Message);
        }
    }



}
