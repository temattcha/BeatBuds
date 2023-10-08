using Microsoft.EntityFrameworkCore;
using BeatBuds.Models;

namespace BeatBuds.Data;

public class AppDataContext : DbContext
{
    public AppDataContext(DbContextOptions<AppDataContext> options) : base(options)
    {
    }

<<<<<<< HEAD
    public DbSet<Musica> Musica { get; set; }
    public DbSet<AvaliacaoPlaylist> AvaliacaoPlaylist { get; set;}
    public DbSet<MusicaPlaylist> MusicaPlaylist { get; set; }
    public DbSet<Playlist> Playlist { get; set; }
    public DbSet<Usuario> Usuario { get; set; }

=======
    public DbSet<AvaliacaoPlaylist> AvaliacaoPlaylist { get; set; }
    public DbSet<Musica> Musica { get; set; }
    public DbSet<MusicaPlaylist> MusicaPlaylist { get; set; }
    public DbSet<Playlist> Playlist { get; set; }
    public DbSet<Usuario> Usuario { get; set; }
>>>>>>> 01cb9acb2a1bb939ecec67151e8d14d92d57b34d
}
