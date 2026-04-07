using BlazorWebAppGames.Models;
using Microsoft.EntityFrameworkCore;

namespace BlazorWebAppGames.Data
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new BlazorWebAppGamesContext(
                serviceProvider.GetRequiredService<DbContextOptions<BlazorWebAppGamesContext>>()))
            {
                // Look for any games.
                if (context.Games.Any())
                {
                    return;   // DB has been seeded
                }
                context.Games.AddRange(
                    new Game
                    {
                        Title = "The Legend of Zelda: Breath of the Wild",
                        ReleaseDate = new DateOnly(2017, 3, 3),
                        CoverImageURL = "https://upload.wikimedia.org/wikipedia/en/0/0b/The_Legend_of_Zelda_Breath_of_the_Wild.jpg",
                        Status = GameStatus.Backlog
                    },
                    new Game
                    {
                        Title = "God of War",
                        ReleaseDate = new DateOnly(2018, 4, 20),
                        CoverImageURL = "https://upload.wikimedia.org/wikipedia/en/a/a7/God_of_War_4_cover.jpg",
                        Status = GameStatus.Backlog
                    },
                    new Game
                    {
                        Title = "Red Dead Redemption 2",
                        ReleaseDate = new DateOnly(2018, 10, 26),
                        CoverImageURL = "https://upload.wikimedia.org/wikipedia/en/4/44/Red_Dead_Redemption_II.jpg",
                        Status = GameStatus.Backlog
                    }
                );
                context.SaveChanges();
            }
        }

        public static async Task SeedAsync(BlazorWebAppGamesContext context)
        {
            await context.Database.MigrateAsync();

            if (!await context.Platforms.AnyAsync())
            {
                context.Platforms.AddRange(
                    new Platform { Name = "Nintendo Switch" },
                    new Platform { Name = "PlayStation 3" },
                    new Platform { Name = "PlayStation 4" },
                    new Platform { Name = "PlayStation 5" },
                    new Platform { Name = "Xbox 360" },
                    new Platform { Name = "Xbox One" },
                    new Platform { Name = "PC" }
                    );
            }
            await context.SaveChangesAsync();
        }
    }
}
