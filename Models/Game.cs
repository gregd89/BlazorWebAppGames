using System.ComponentModel.DataAnnotations;

namespace BlazorWebAppGames.Models
{
    public class Game
    {
        public int Id { get; set; }

        [Required]
        public string Title { get; set; } = string.Empty;

        public DateOnly? ReleaseDate { get; set; }

        public string? CoverImageURL { get; set; }

        [Required]
        public GameStatus Status { get; set; } = GameStatus.Backlog;

        public ICollection<GamePlatform> GamePlatforms { get; set; } = new List<GamePlatform>();
    }
}
