namespace BeatBuds.Models;
public class Usuario
{
    public Usuario() => CriadoEm = DateTime.Now;
    public int UsuarioId { get; set; }
    public string? Nome { get; set; }
    public string? Email { get; set; }
    public string? Senha { get; set; }
    public DateTime CriadoEm { get; set; }

     // Relacionamento com músicas que o usuário possui
    public List<Musica> Musicas { get; set; } = new List<Musica>();
    
    // Relacionamento com playlists criadas pelo usuário
    public List<Playlist> Playlists { get; set; } = new List<Playlist>();
    
    // Relacionamento com contatos (outros usuários)
    public List<Usuario> Contatos { get; set; } = new List<Usuario>();
    
    // Relacionamento com avaliações de playlists
    public List<AvaliacaoPlaylist> Avaliacoes { get; set; } = new List<AvaliacaoPlaylist>();

}
