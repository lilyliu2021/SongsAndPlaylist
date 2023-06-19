namespace SongsAndPlaylist.Models
{
    public class PlaylistViewModel
    {
        public int PlaylistId { get; set; }
        public string PlaylistName { get; set; }
        public List<Song> Songs { get; set; }
    }
}
