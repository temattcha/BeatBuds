using System;
using System.Collections.Generic;
namespace BeatBuds.Models;

public class MusicaPlaylist
{
    // Chave composta para representar a relação entre músicas e playlists
    public int MusicaId { get; set; }
    public int PlaylistId { get; set; }
    
    // Propriedades de navegação para a música e a playlist correspondentes
    public Musica Musica { get; set; }
    public Playlist Playlist { get; set; }

    public int Id { get; set; }
}
