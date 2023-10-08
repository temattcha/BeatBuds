using Microsoft.EntityFrameworkCore;
using BeatBuds.Models;

namespace BeatBuds.Data;

public class AppDataContext : DbContext
{
    public AppDataContext(DbContextOptions<AppDataContext> options) : base(options)
    {
    }

    public DbSet<Musica> Musica { get; set; }
    public DbSet<AvaliacaoPlaylist> AvaliacaoPlaylist { get; set;}
    public DbSet<MusicaPlaylist> MusicaPlaylist { get; set; }
    public DbSet<Playlist> Playlist { get; set; }
    public DbSet<Usuario> Usuarios { get; set; }

}
