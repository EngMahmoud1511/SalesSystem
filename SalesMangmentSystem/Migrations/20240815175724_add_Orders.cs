﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SalesMangmentSystem.Migrations
{
    /// <inheritdoc />
    public partial class add_Orders : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "OrdersId",
                table: "Items",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Items_OrdersId",
                table: "Items",
                column: "OrdersId");

            migrationBuilder.AddForeignKey(
                name: "FK_Items_Orders_OrdersId",
                table: "Items",
                column: "OrdersId",
                principalTable: "Orders",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Items_Orders_OrdersId",
                table: "Items");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropIndex(
                name: "IX_Items_OrdersId",
                table: "Items");

            migrationBuilder.DropColumn(
                name: "OrdersId",
                table: "Items");
        }
    }
}
