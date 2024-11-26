using Microsoft.AspNetCore.Mvc;
using MusicWebApp.Data.Models;
using MusicWebApp.Services.Data.Interfaces;

namespace MusicWebApp.Controllers
{
    public class SongsController : Controller
    {
        private readonly IYouTubeServiceClient _songsService;

        public SongsController(IYouTubeServiceClient songsService)
        {
            _songsService = songsService;
        }

        [HttpGet]
        public IActionResult Search()
        {
            return View(new HashSet<Song>());
        }

        [HttpPost]
        public async Task<IActionResult> Search(string query)
        {
            if (string.IsNullOrEmpty(query))
            {
                ModelState.AddModelError(string.Empty, "Please enter a search term.");
                return View(new HashSet<Song>());
            }

            var songs = await _songsService.SearchSongsAsync(query);

            if (songs == null || !songs.Any())
            {
                ViewBag.Message = "No songs found. Try another search.";
                return View(new HashSet<Song>());
            }

            return View(songs);
        }
    }
}