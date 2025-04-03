using Dmusic.Controllers;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace Dmusic.Models
{
    public class AlbumGenreViewModel
    {
        public List<Album>? Albums { get; set; }
        public SelectList? Genres { get; set; }
        public string? MusicGenre { get; set; }
        public string? SearchString { get; set; }
    }
}