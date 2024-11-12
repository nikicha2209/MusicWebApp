using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

using static MusicWebApp.Common.EntityValidationConstants.Song;

namespace MusicWebApp.Data.Models
{
    public class Song
    {
        [Key]
        public Guid Id { get; set; } = Guid.NewGuid();

        [Required]
        [MaxLength(TitleMaxLength)]
        public string Title { get; set; } = null!;

        [Required]
        [Range(typeof(TimeSpan),DurationMinValue, DurationMaxValue)]
        public TimeSpan Duration { get; set; } = TimeSpan.Zero;


        [Required]
        [ForeignKey(nameof(ArtistId))]
        public virtual Artist Artist { get; set; } = null!;

        [Required]
        public Guid ArtistId { get; set; }


        [ForeignKey(nameof(AlbumId))]
        public virtual Album? Album { get; set; }

        public Guid? AlbumId { get; set; }


        [Required]
        [MaxLength(YouTubeVideoIdMaxLength)]
        public string YouTubeVideoId { get; set; } = null!;


        [MaxLength(YouTubeUrlMaxLength)]
        public string? YouTubeUrl => YouTubeVideoId != null ? $"https://www.youtube.com/watch?v={YouTubeVideoId}" : null;

        [MaxLength(DescriptionMaxLength)]
        public string? Description { get; set; }

        public DateTime? PublishedAt { get; set; }


        [MaxLength(ThumbnailUrlMaxLength)]
        public string? ThumbnailUrl { get; set; }   
    }
}
