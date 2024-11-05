using Microsoft.AspNetCore.Identity;

namespace MusicWebApp.Data.Models
{
    public class ApplicationUser : IdentityUser<Guid>
    {
        public ApplicationUser()
        {
            Id = Guid.NewGuid();
        }

        public TimeSpan ListeningTime { get; set; } = TimeSpan.Zero;
        public int Xp { get; set; }
    }
}
