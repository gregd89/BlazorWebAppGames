namespace BlazorWebAppGames.Models
{
    public class GamePlatform
    {
        public int Id { get; set; }
        public int GameID { get; set; }
        public Game Game { get; set; } = null!;

        public int PlatformId { get; set; }
        public Platform Platform { get; set; } = null!;
    }
}
