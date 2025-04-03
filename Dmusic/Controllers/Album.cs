using System.ComponentModel.DataAnnotations;

namespace Dmusic.Controllers
{
    public class Album
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Title is required.")]
        public string? Title { get; set; }

        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }

        [Required(ErrorMessage = "Artist name is required.")]
        public string? Artist { get; set; }

        [Required(ErrorMessage = "Genre is required.")]
        public string? Genre { get; set; }

        [Range(0.01, 1000.00, ErrorMessage = "Price must be between $0.01 and $1000.")]
        public decimal Price { get; set; }

        public int TrackCount { get; set; }  // Số lượng bài hát trong album
    }
}