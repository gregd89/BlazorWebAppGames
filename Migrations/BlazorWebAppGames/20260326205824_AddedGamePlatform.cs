using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BlazorWebAppGames.Migrations.BlazorWebAppGames
{
    /// <inheritdoc />
    public partial class AddedGamePlatform : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_GamePlatform_Games_GameID",
                table: "GamePlatform");

            migrationBuilder.DropForeignKey(
                name: "FK_GamePlatform_Platforms_PlatformId",
                table: "GamePlatform");

            migrationBuilder.DropPrimaryKey(
                name: "PK_GamePlatform",
                table: "GamePlatform");

            migrationBuilder.RenameTable(
                name: "GamePlatform",
                newName: "GamePlatforms");

            migrationBuilder.RenameIndex(
                name: "IX_GamePlatform_PlatformId",
                table: "GamePlatforms",
                newName: "IX_GamePlatforms_PlatformId");

            migrationBuilder.RenameIndex(
                name: "IX_GamePlatform_GameID",
                table: "GamePlatforms",
                newName: "IX_GamePlatforms_GameID");

            migrationBuilder.AddColumn<int>(
                name: "PlatformId",
                table: "Games",
                type: "int",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_GamePlatforms",
                table: "GamePlatforms",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_Games_PlatformId",
                table: "Games",
                column: "PlatformId");

            migrationBuilder.AddForeignKey(
                name: "FK_GamePlatforms_Games_GameID",
                table: "GamePlatforms",
                column: "GameID",
                principalTable: "Games",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_GamePlatforms_Platforms_PlatformId",
                table: "GamePlatforms",
                column: "PlatformId",
                principalTable: "Platforms",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Games_Platforms_PlatformId",
                table: "Games",
                column: "PlatformId",
                principalTable: "Platforms",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_GamePlatforms_Games_GameID",
                table: "GamePlatforms");

            migrationBuilder.DropForeignKey(
                name: "FK_GamePlatforms_Platforms_PlatformId",
                table: "GamePlatforms");

            migrationBuilder.DropForeignKey(
                name: "FK_Games_Platforms_PlatformId",
                table: "Games");

            migrationBuilder.DropIndex(
                name: "IX_Games_PlatformId",
                table: "Games");

            migrationBuilder.DropPrimaryKey(
                name: "PK_GamePlatforms",
                table: "GamePlatforms");

            migrationBuilder.DropColumn(
                name: "PlatformId",
                table: "Games");

            migrationBuilder.RenameTable(
                name: "GamePlatforms",
                newName: "GamePlatform");

            migrationBuilder.RenameIndex(
                name: "IX_GamePlatforms_PlatformId",
                table: "GamePlatform",
                newName: "IX_GamePlatform_PlatformId");

            migrationBuilder.RenameIndex(
                name: "IX_GamePlatforms_GameID",
                table: "GamePlatform",
                newName: "IX_GamePlatform_GameID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_GamePlatform",
                table: "GamePlatform",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_GamePlatform_Games_GameID",
                table: "GamePlatform",
                column: "GameID",
                principalTable: "Games",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_GamePlatform_Platforms_PlatformId",
                table: "GamePlatform",
                column: "PlatformId",
                principalTable: "Platforms",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
