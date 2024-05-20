using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace lab_9.Migrations
{
    /// <inheritdoc />
    public partial class seedBooks : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Books",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Title = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    Author = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    Genre = table.Column<string>(type: "character varying(30)", maxLength: 30, nullable: false),
                    ISBN = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Books", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "Author", "Genre", "ISBN", "Title" },
                values: new object[,]
                {
                    { 1, "George Orwell", "Dystopian", "9780451524935", "1984" },
                    { 2, "Harper Lee", "Fiction", "9780061120084", "To Kill a Mockingbird" },
                    { 3, "F. Scott Fitzgerald", "Classics", "9780743273565", "The Great Gatsby" },
                    { 4, "Herman Melville", "Adventure", "9781503280786", "Moby Dick" },
                    { 5, "Jane Austen", "Romance", "9781503290563", "Pride and Prejudice" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Books");
        }
    }
}
