using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static MusicWebApp.Common.EntityValidationConstants.Album;

namespace MusicWebApp.Data.Models
{
    public class Album
    {
        [Key]
        public Guid Id { get; set; } = Guid.NewGuid();

        [Required]
        [MaxLength(TitleMaxLength)]
        public string Title { get; set; } = null!;

        [MaxLength(ImageUrlMaxLength)]
        public string? ImageUrl { get; set; }

        [Required]
        [ForeignKey(nameof(ArtistId))]
        public virtual Artist Artist { get; set; } = null!;

        [Required]
        public Guid ArtistId { get; set; }
        public virtual ICollection<Song> Songs { get; set; } = new HashSet<Song>();
    }
}
