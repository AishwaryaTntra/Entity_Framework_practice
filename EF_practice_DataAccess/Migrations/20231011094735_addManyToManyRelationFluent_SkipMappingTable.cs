using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EF_practice_DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class addManyToManyRelationFluent_SkipMappingTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Fluent_AuthorFluent_Book",
                columns: table => new
                {
                    AuthorsAuthor_id = table.Column<int>(type: "int", nullable: false),
                    BooksBookId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Fluent_AuthorFluent_Book", x => new { x.AuthorsAuthor_id, x.BooksBookId });
                    table.ForeignKey(
                        name: "FK_Fluent_AuthorFluent_Book_Fluent_Authors_AuthorsAuthor_id",
                        column: x => x.AuthorsAuthor_id,
                        principalTable: "Fluent_Authors",
                        principalColumn: "Author_id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Fluent_AuthorFluent_Book_Fluent_Books_BooksBookId",
                        column: x => x.BooksBookId,
                        principalTable: "Fluent_Books",
                        principalColumn: "BookId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Fluent_AuthorFluent_Book_BooksBookId",
                table: "Fluent_AuthorFluent_Book",
                column: "BooksBookId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Fluent_AuthorFluent_Book");
        }
    }
}
