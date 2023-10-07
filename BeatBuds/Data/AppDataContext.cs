using Microsoft.EntityFrameworkCore;
using BeatBuds.Models;

namespace BeatBuds.Data;

public class AppDataContext : DbContext
{
    public AppDataContext(DbContextOptions<AppDataContext> options) : base(options)
    {
    }

    public DbSet<Musica> Musica { get; set; }
    public DbSet<AvaliacaoPlaylist> AvaliacaoPlaylist { get; set; }

}
