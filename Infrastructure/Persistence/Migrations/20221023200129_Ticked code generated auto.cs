using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    public partial class Tickedcodegeneratedauto : Migration
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

            migrationBuilder.AlterColumn<int>(
                name: "Code",
                table: "Ticket",
                type: "NUMBER(10)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "NVARCHAR2(2000)")
                .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Code",
                table: "Ticket",
                type: "NVARCHAR2(2000)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "NUMBER(10)")
                .OldAnnotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1");

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
