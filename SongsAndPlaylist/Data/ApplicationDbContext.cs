using Microsoft.EntityFrameworkCore;
using SongsAndPlaylist.Models;
using System.Collections.Generic;
using System.Reflection.Emit;

namespace SongsAndPlaylist.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<Playlists> Playlists { get; set; }
        public DbSet<Song> Songs { get; set; }
        public DbSet<PlaylistSong> PlaylistSongs { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<PlaylistSong>()
               .HasKey(ps => new { ps.PlaylistId, ps.SongId });

            modelBuilder.Entity<PlaylistSong>()
                .HasOne(ps => ps.Playlist)
                .WithMany(p => p.PlaylistSongs)
                .HasForeignKey(ps => ps.PlaylistId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<PlaylistSong>()
                .HasOne(ps => ps.Song)
                .WithMany(s => s.PlaylistSongs)
                .HasForeignKey(ps => ps.SongId);
        }
    }
}
