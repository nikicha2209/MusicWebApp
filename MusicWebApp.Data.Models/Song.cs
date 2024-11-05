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

        [Required]
        public Guid? AlbumId { get; set; } //it's possible for a song to not be part of any album
    }
}
