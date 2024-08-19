using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SalesMangmentSystem.Migrations
{
    /// <inheritdoc />
    public partial class add_Order : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ItemsId",
                table: "Sales",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ItemsId",
                table: "Sales");
        }
    }
}
