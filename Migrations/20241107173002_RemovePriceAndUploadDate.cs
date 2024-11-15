using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PaulaPachecoHairStyle.Migrations
{
    /// <inheritdoc />
    public partial class RemovePriceAndUploadDate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
               name: "Price",
               table: "Photo");

            migrationBuilder.DropColumn(
                name: "UploadDate",
                table: "Photo");

        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "Price",
                table: "Photo",
                type: "decimal(18,2)", 
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "UploadDate",
                table: "Photo",
                nullable: true);
        }
    }
}
