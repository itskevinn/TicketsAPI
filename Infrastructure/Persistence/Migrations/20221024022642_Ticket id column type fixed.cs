using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    public partial class Ticketidcolumntypefixed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<Guid>(
                name: "Id",
                table: "Ticket",
                type: "RAW(16)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "VARCHAR(36)");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Id",
                table: "Ticket",
                type: "VARCHAR(36)",
                nullable: false,
                oldClrType: typeof(Guid),
                oldType: "RAW(16)");
        }
    }
}
