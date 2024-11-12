using System.ComponentModel.DataAnnotations;
using System.Net.Mime;
using static MusicWebApp.Common.EntityValidationConstants.Artist;

namespace MusicWebApp.Data.Models
{
    public class Artist
    {
        [Key]
        public Guid Id { get; set; } = Guid.NewGuid();

        [Required]
        [MaxLength(NameMaxLength)]
        public string Name { get; set; } = null!;

        [MaxLength(DescriptionMaxLength)]
        public string? Description { get; set; }

        [MaxLength(ImageUrlMaxLength)]
        public string? ImageUrl { get; set; }
        public virtual ICollection<Song> Songs { get; set; } = new HashSet<Song>();
        public virtual ICollection<Album> Albums { get; set; } = new HashSet<Album>();


        [MaxLength(YouTubeChannelTitleMaxLength)]
        public string? YouTubeChannelTitle { get; set; }
    }
}
