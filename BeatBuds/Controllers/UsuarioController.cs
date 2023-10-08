using BeatBuds.Data;
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


}
