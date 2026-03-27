using System.ComponentModel.DataAnnotations;

namespace BlazorWebAppGames.Models
{
    public class Platform
    {
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Name { get; set; } = string.Empty;

        public ICollection<GamePlatform> GamePlatforms { get; set; } = new List<GamePlatform>();
    }
}
