namespace BeatBuds.Models;

public class Musica
{
    public Musica() => CriadoEm = DateTime.Now;
    public int MusicaId { get; set; }
    public string? Titulo { get; set; }
    public string? Artista { get; set; }
    public string? Album { get; set; }
    public int AnoLancamento { get; set; }
    public DateTime CriadoEm { get; set; }

    public Usuario? Usuario { get; set; }
    public int UsuarioId { get; set; }
    
    // Relacionamento com playlists que incluem esta música
    public List<MusicaPlaylist> Playlists { get; set; } = new List<MusicaPlaylist>();
}