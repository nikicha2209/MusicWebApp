using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MusicWebApp.Data.Models;

namespace MusicWebApp.Data
{
    public class MusicDbContext : IdentityDbContext<ApplicationUser, IdentityRole<Guid>, Guid>
    {
        public MusicDbContext(DbContextOptions<MusicDbContext> options)
            :base(options)
        {
        }

        public virtual DbSet<Artist> Artists { get; set; } = null!;
        public virtual DbSet<Song> Songs { get; set; } = null!;
        public virtual DbSet<Album> Albums { get; set; } = null!;

    }
}
