using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MovieRatingEngine.Infrastructure.Ef.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Actors",
                columns: table => new
                {
                    ActorID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Actors", x => x.ActorID);
                });

            migrationBuilder.CreateTable(
                name: "Movies",
                columns: table => new
                {
                    MovieID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: false),
                    ReleaseDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    VoteCount = table.Column<int>(type: "int", nullable: false, defaultValue: 0),
                    Rating = table.Column<decimal>(type: "decimal(3,2)", precision: 3, scale: 2, nullable: false, defaultValue: 0m),
                    IsMovie = table.Column<bool>(type: "bit", nullable: false),
                    ImageName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Movies", x => x.MovieID);
                });

            migrationBuilder.CreateTable(
                name: "MovieActors",
                columns: table => new
                {
                    MovieID = table.Column<int>(type: "int", nullable: false),
                    ActorID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MovieActors", x => new { x.MovieID, x.ActorID });
                    table.ForeignKey(
                        name: "FK_MovieActors_Actors_ActorID",
                        column: x => x.ActorID,
                        principalTable: "Actors",
                        principalColumn: "ActorID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MovieActors_Movies_MovieID",
                        column: x => x.MovieID,
                        principalTable: "Movies",
                        principalColumn: "MovieID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Actors",
                columns: new[] { "ActorID", "FirstName", "LastName" },
                values: new object[,]
                {
                    { 1, "John", "Doe" },
                    { 2, "Edin", "Dzeko" },
                    { 3, "Dino", "Merlin" },
                    { 4, "Denzel", "Washington" },
                    { 5, "Jason", "Statham" },
                    { 6, "Tom", "Cruz" },
                    { 7, "David", "Suchet" },
                    { 8, "Tom", "Hanks" }
                });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "MovieID", "Description", "ImageName", "IsMovie", "Rating", "ReleaseDate", "Title", "VoteCount" },
                values: new object[,]
                {
                    { 12, "Description of movie 12", "12.png", true, 2.7m, new DateTime(2014, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Movie 12", 3 },
                    { 11, "Description of movie 11", "11.png", true, 3.5m, new DateTime(2017, 7, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Movie 11", 2 },
                    { 10, "Description of movie 10", "10.png", true, 3.0m, new DateTime(2019, 4, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Movie 10", 1 },
                    { 9, "Description of movie 9", "9.png", true, 4.1m, new DateTime(2007, 7, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Movie 9", 3 },
                    { 8, "Description of movie 8", "8.png", true, 2.4m, new DateTime(2000, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Movie 8", 5 },
                    { 7, "Description of movie 7", "7.png", true, 4.4m, new DateTime(2015, 2, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Movie 7", 5 },
                    { 3, "Description of movie 3", null, true, 3.5m, new DateTime(2021, 5, 21, 0, 0, 0, 0, DateTimeKind.Local), "Movie 3", 3 },
                    { 5, "Description of TV Show 5", "5.png", false, 2.4m, new DateTime(2005, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "TV Show 5", 5 },
                    { 4, "Description of movie 4", "4.png", true, 4.5m, new DateTime(2021, 5, 21, 0, 0, 0, 0, DateTimeKind.Local), "Movie 4", 2 },
                    { 13, "Description of movie 13", "13.png", true, 4.7m, new DateTime(2012, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Movie 13", 3 },
                    { 2, "Description of movie 2", "2.png", true, 4m, new DateTime(2021, 5, 21, 0, 0, 0, 0, DateTimeKind.Local), "Movie 2", 1 },
                    { 1, "Description of movie 1", "1.png", true, 3m, new DateTime(2021, 5, 21, 0, 0, 0, 0, DateTimeKind.Local), "Movie 1", 1 },
                    { 6, "Description of TV Show 6", "6.png", false, 3.4m, new DateTime(2012, 6, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "TV Show 6", 2 },
                    { 14, "Description of movie 14", "14.png", true, 5.0m, new DateTime(2016, 8, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Movie 14", 4 }
                });

            migrationBuilder.InsertData(
                table: "MovieActors",
                columns: new[] { "ActorID", "MovieID" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 6, 13 },
                    { 3, 13 },
                    { 7, 12 },
                    { 2, 12 },
                    { 8, 11 },
                    { 1, 11 },
                    { 8, 10 },
                    { 7, 10 },
                    { 6, 9 },
                    { 5, 9 },
                    { 4, 8 },
                    { 3, 8 },
                    { 2, 7 },
                    { 1, 7 },
                    { 5, 6 },
                    { 3, 6 },
                    { 4, 5 },
                    { 2, 5 },
                    { 7, 4 },
                    { 8, 4 },
                    { 5, 3 },
                    { 3, 3 },
                    { 1, 2 },
                    { 3, 1 },
                    { 2, 1 },
                    { 4, 14 },
                    { 5, 14 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_MovieActors_ActorID",
                table: "MovieActors",
                column: "ActorID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MovieActors");

            migrationBuilder.DropTable(
                name: "Actors");

            migrationBuilder.DropTable(
                name: "Movies");
        }
    }
}
