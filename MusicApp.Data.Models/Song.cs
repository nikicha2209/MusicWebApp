using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicApp.Data.Models
{
    public class Song
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public TimeSpan Duration { get; set; }
        public Guid AlbumId { get; set; }
        public Album Album { get; set; }
        public Guid ArtistId { get; set; }
        public Artist Artist { get; set; }
    }
}
