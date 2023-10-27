using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace studentAPI.Migrations
{
    /// <inheritdoc />
    public partial class AddedtheAuthnamechanged : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_student",
                table: "student");

            migrationBuilder.RenameTable(
                name: "student",
                newName: "Students");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Students",
                table: "Students",
                column: "StudentId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Students",
                table: "Students");

            migrationBuilder.RenameTable(
                name: "Students",
                newName: "student");

            migrationBuilder.AddPrimaryKey(
                name: "PK_student",
                table: "student",
                column: "StudentId");
        }
    }
}
