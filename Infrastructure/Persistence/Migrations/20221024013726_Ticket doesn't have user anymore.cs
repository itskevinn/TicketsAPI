using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    public partial class Ticketdoesnthaveuseranymore : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Ticket_User_GeneratedById",
                table: "Ticket");

            migrationBuilder.DropIndex(
                name: "IX_Ticket_GeneratedById",
                table: "Ticket");

            migrationBuilder.DropColumn(
                name: "GeneratedById",
                table: "Ticket");

            migrationBuilder.AddColumn<string>(
                name: "GeneratedBy",
                table: "Ticket",
                type: "NVARCHAR2(2000)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "GeneratedBy",
                table: "Ticket");

            migrationBuilder.AddColumn<Guid>(
                name: "GeneratedById",
                table: "Ticket",
                type: "RAW(16)",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateIndex(
                name: "IX_Ticket_GeneratedById",
                table: "Ticket",
                column: "GeneratedById");

            migrationBuilder.AddForeignKey(
                name: "FK_Ticket_User_GeneratedById",
                table: "Ticket",
                column: "GeneratedById",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
