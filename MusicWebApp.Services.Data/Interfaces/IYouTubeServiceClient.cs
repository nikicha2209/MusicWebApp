using MusicWebApp.Data.Models;

namespace MusicWebApp.Services.Data.Interfaces
{
    public interface IYouTubeServiceClient
    {
        Task<HashSet<Song>> SearchSongsAsync(string query, int maxResults = 10);
    }
}
