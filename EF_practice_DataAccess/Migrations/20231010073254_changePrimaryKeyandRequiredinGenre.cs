using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EF_practice_DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class changePrimaryKeyandRequiredinGenre : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "GenreId",
                table: "tb_genre",
                newName: "Genre_Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Genre_Id",
                table: "tb_genre",
                newName: "GenreId");
        }
    }
}
