using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    public partial class Statuschanged : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<bool>(
                name: "Status",
                table: "Ticket",
                type: "NUMBER(1)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "NVARCHAR2(2000)");

            migrationBuilder.AddColumn<string>(
                name: "State",
                table: "Ticket",
                type: "NVARCHAR2(2000)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "State",
                table: "Ticket");

            migrationBuilder.AlterColumn<string>(
                name: "Status",
                table: "Ticket",
                type: "NVARCHAR2(2000)",
                nullable: false,
                oldClrType: typeof(bool),
                oldType: "NUMBER(1)");
        }
    }
}
