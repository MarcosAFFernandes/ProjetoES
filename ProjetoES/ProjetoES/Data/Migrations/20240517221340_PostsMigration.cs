using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProjetoES.Migrations
{
    /// <inheritdoc />
    public partial class PostsMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_Favourites_FavouritesId",
                table: "AspNetUsers");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_FavouritesId",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "FavouritesId",
                table: "AspNetUsers");

            migrationBuilder.AddColumn<string>(
                name: "ApplicationUserId",
                table: "Favourites",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateTable(
                name: "Posts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    user = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    titulo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    texto = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Posts", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Favourites_ApplicationUserId",
                table: "Favourites",
                column: "ApplicationUserId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Favourites_AspNetUsers_ApplicationUserId",
                table: "Favourites",
                column: "ApplicationUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Favourites_AspNetUsers_ApplicationUserId",
                table: "Favourites");

            migrationBuilder.DropTable(
                name: "Posts");

            migrationBuilder.DropIndex(
                name: "IX_Favourites_ApplicationUserId",
                table: "Favourites");

            migrationBuilder.DropColumn(
                name: "ApplicationUserId",
                table: "Favourites");

            migrationBuilder.AddColumn<int>(
                name: "FavouritesId",
                table: "AspNetUsers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_FavouritesId",
                table: "AspNetUsers",
                column: "FavouritesId");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_Favourites_FavouritesId",
                table: "AspNetUsers",
                column: "FavouritesId",
                principalTable: "Favourites",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
