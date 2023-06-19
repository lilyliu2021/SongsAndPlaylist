using System.ComponentModel.DataAnnotations;
using System.Net;

namespace SongsAndPlaylist.Models
{
    public class Playlists
    {
        [Key]
        public int PlaylistId { get; set; }
        [Required]
        [StringLength(100)]
        public string? Name { get; set; }
        public ICollection<PlaylistSong> PlaylistSongs { get; set; } = new List<PlaylistSong>();
    }
}

//[Key]
//public int Id { get; set; }

//[Required]
//[StringLength(100)]
//public string Name { get; set; }

//// Navigation property to establish a one-to-many relationship with the Song model
//public ICollection<Song> Songs { get; set; }