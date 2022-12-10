using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class v2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Telefon",
                table: "Abouts",
                newName: "Phone");

            migrationBuilder.RenameColumn(
                name: "Adres",
                table: "Abouts",
                newName: "Address");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Phone",
                table: "Abouts",
                newName: "Telefon");

            migrationBuilder.RenameColumn(
                name: "Address",
                table: "Abouts",
                newName: "Adres");
        }
    }
}
