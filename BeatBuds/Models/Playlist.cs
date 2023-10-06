namespace BeatBuds.Models;

public class Playlist
{
    public int Id { get; set; }
    public string Nome { get; set; }
    public string Descricao { get; set; }
    
    // Chave estrangeira para o criador da playlist (usuário)
    public int UsuarioId { get; set; }
    
    // Propriedade de navegação para o criador da playlist
    public Usuario Usuario { get; set; }
    
    // Relacionamento com músicas que fazem parte da playlist
    public List<MusicaPlaylist> Musicas { get; set; } = new List<MusicaPlaylist>();
    
    // Relacionamento com avaliações da playlist
    public List<AvaliacaoPlaylist> Avaliacoes { get; set; } = new List<AvaliacaoPlaylist>();
}
