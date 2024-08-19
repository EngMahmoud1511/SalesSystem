using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SalesMangmentSystem.Migrations
{
    /// <inheritdoc />
    public partial class to : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Rool",
                table: "Employees",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Rool",
                table: "Employees");
        }
    }
}
