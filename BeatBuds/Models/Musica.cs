namespace BeatBuds.Models;

public class Musica
{
    public int Id { get; set; }
    public string Titulo { get; set; }
    public string Artista { get; set; }
    public string Album { get; set; }
    public int AnoLancamento { get; set; }
    
    // Chave estrangeira para o criador da música (usuário)
    public int UsuarioId { get; set; }
    
    // Propriedade de navegação para o criador da música
    public Usuario Usuario { get; set; }
    
    // Relacionamento com playlists que incluem esta música
    public List<MusicaPlaylist> Playlists { get; set; } = new List<MusicaPlaylist>();
}