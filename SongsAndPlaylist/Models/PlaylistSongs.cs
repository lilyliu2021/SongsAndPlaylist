using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Net;

namespace SongsAndPlaylist.Models
{
    public class PlaylistSong
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int PlaylistSongId { get; set; }
        public int PlaylistId { get; set; }
        public Playlists? Playlist { get; set; }
        public int SongId { get; set; }
        public Song? Song { get; set; }
    }
}
