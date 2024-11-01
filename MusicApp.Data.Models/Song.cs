using System.ComponentModel.DataAnnotations;
using static MusicApp.Common.EntityValidationConstants.Song;

namespace MusicApp.Data.Models
{
    public class Song
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        [MaxLength(TitleMaxLength)]
        public string Title { get; set; } = null!;

        [Required]
        [Range(typeof(TimeSpan), DurationMinValue, DurationMaxValue)]
        public TimeSpan Duration { get; set; }

        [Required]
        public Album Album { get; set; } = null!;
        public Guid AlbumId { get; set; }

        [Required]
        public Artist Artist { get; set; } = null!;
        public Guid ArtistId { get; set; }

        [Required]
        public string SpotifyId { get; set; } = null!;
    }
}
