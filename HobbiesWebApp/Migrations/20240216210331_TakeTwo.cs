using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Mission07_Watts.Migrations
{
    /// <inheritdoc />
    public partial class TakeTwo : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Applications",
                columns: table => new
                {
                    movieID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    movieTitle = table.Column<string>(type: "TEXT", nullable: false),
                    movieCategoryOne = table.Column<string>(type: "TEXT", nullable: false),
                    movieCategoryTwo = table.Column<string>(type: "TEXT", nullable: false),
                    movieYear = table.Column<int>(type: "INTEGER", nullable: false),
                    movieDirector = table.Column<string>(type: "TEXT", nullable: false),
                    movieRating = table.Column<string>(type: "TEXT", nullable: false),
                    movieEdited = table.Column<bool>(type: "INTEGER", nullable: true),
                    movieLent = table.Column<string>(type: "TEXT", nullable: true),
                    movieNotes = table.Column<string>(type: "TEXT", maxLength: 25, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Applications", x => x.movieID);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Applications");
        }
    }
}
