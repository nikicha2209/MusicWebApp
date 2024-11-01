using System.ComponentModel.DataAnnotations;
using static MusicApp.Common.EntityValidationConstants.Artist;

namespace MusicApp.Data.Models
{
    public class Artist
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        [MaxLength(NameMaxLength)]
        public string Name { get; set; } = null!;

        [MaxLength(BiographyMaxLength)]
        public string? Biography { get; set; }
        public int Followers { get; set; }

        [MaxLength(ImageUrlMaxLength)]
        public string? ImageUrl { get; set; }

        [Required]
        [MaxLength(SpotifyIdMaxLength)]
        public string SpotifyId { get; set; } = null!;
        public ICollection<Song> Songs { get; set; } = new HashSet<Song>();
        public ICollection<Album> Albums { get; set; } = new List<Album>();
    }
}
