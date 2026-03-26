using System.ComponentModel.DataAnnotations;

namespace BlazorWebAppGames.Models
{
    public class Games
    {
        public int Id { get; set; }

        [Required]
        public string Title { get; set; } = string.Empty;

        public DateOnly? ReleaseDate { get; set; }

        public string? CoverImageURL { get; set; }
    }
}
