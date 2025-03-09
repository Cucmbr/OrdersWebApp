using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OrdersWebApp.Migrations
{
    /// <inheritdoc />
    public partial class InitialMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    SenderCity = table.Column<string>(type: "TEXT", maxLength: 25, nullable: false),
                    SenderAddress = table.Column<string>(type: "TEXT", maxLength: 60, nullable: false),
                    RecipientCity = table.Column<string>(type: "TEXT", maxLength: 25, nullable: false),
                    RecipientAddress = table.Column<string>(type: "TEXT", maxLength: 60, nullable: false),
                    CargoWeight = table.Column<float>(type: "REAL", nullable: false),
                    CargoPickupDate = table.Column<DateOnly>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Orders");
        }
    }
}
