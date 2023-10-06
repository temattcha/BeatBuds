namespace BeatBuds.Models;

public class AvaliacaoPlaylist
{
    public int Id { get; set; }
    public int PlaylistId { get; set; }
    public int UsuarioId { get; set; }
    public int Classificacao { get; set; }
    
    // Propriedades de navegação para a playlist e o usuário correspondentes
    public Playlist Playlist { get; set; }
    public Usuario Usuario { get; set; }
}