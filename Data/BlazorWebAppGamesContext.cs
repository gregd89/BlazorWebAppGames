using Microsoft.EntityFrameworkCore;

namespace BlazorWebAppGames.Data
{
    public class BlazorWebAppGamesContext : DbContext
    {
        public BlazorWebAppGamesContext(DbContextOptions<BlazorWebAppGamesContext> options)
            : base(options)
        {
        }

        public DbSet<BlazorWebAppGames.Models.Game> Games { get; set; } = default!;
        public DbSet<BlazorWebAppGames.Models.Platform> Platforms { get; set; } = default!;
        public DbSet<BlazorWebAppGames.Models.GamePlatform> GamePlatforms { get; set; } = default!;

    }
}
