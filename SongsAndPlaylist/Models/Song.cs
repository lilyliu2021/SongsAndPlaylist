using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SongsAndPlaylist.Models
{
    public class Song
    {
        [Key]
        public int SongId { get; set; }
        [Required]
        [StringLength(100)]
        public string? Title { get; set; }
        public ICollection<PlaylistSong> PlaylistSongs { get; set; } = new List<PlaylistSong>();
    }
}
//[Key]
//public int Id { get; set; }

//[Required]
//[StringLength(100)]
//public string Title { get; set; }

//[Required]
//[StringLength(100)]
//public string Artist { get; set; }

//// Foreign key to reference the related Playlist
//public int PlaylistId { get; set; }

//// Navigation property to establish a many-to-one relationship with the Playlist model
//[ForeignKey("PlaylistId")]
//public Playlist Playlist { get; set; }