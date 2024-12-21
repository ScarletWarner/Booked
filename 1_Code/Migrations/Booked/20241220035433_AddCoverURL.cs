using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Booked.Migrations.Booked
{
    /// <inheritdoc />
    public partial class AddCoverURL : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CoverURL",
                table: "Book",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CoverURL",
                table: "Book");
        }
    }
}
