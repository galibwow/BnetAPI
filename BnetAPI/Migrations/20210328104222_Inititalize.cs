using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BnetAPI.Migrations
{
    public partial class Inititalize : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Genres",
                columns: table => new
                {
                    GenreId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GenreName = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Genres", x => x.GenreId);
                });

            migrationBuilder.CreateTable(
                name: "MovieInfos",
                columns: table => new
                {
                    MovieId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Destination = table.Column<long>(type: "bigint", nullable: false),
                    MovieName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Imdb_id = table.Column<int>(type: "int", nullable: false),
                    OriginalTitle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Originallanguage = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OrginalOverview = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Populerity = table.Column<double>(type: "float", nullable: false),
                    PosterPath = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Release_date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Runtime = table.Column<float>(type: "real", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Tagline = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VoteAverage = table.Column<float>(type: "real", nullable: false),
                    Genreid = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MovieInfos", x => x.MovieId);
                    table.ForeignKey(
                        name: "FK_MovieInfos_Genres_Genreid",
                        column: x => x.Genreid,
                        principalTable: "Genres",
                        principalColumn: "GenreId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_MovieInfos_Genreid",
                table: "MovieInfos",
                column: "Genreid");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MovieInfos");

            migrationBuilder.DropTable(
                name: "Genres");
        }
    }
}
