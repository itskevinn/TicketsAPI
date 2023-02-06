using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Persistence.Migrations
{
    public partial class SeañadeticketCodeenTicketDetails : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModifiedOn",
                table: "UserRole",
                type: "TIMESTAMP(7)",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 5, 18, 5, 31, 881, DateTimeKind.Local).AddTicks(411),
                oldClrType: typeof(DateTime),
                oldType: "TIMESTAMP(7)",
                oldDefaultValue: new DateTime(2023, 2, 1, 18, 24, 15, 931, DateTimeKind.Local).AddTicks(1564));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "UserRole",
                type: "TIMESTAMP(7)",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 5, 18, 5, 31, 880, DateTimeKind.Local).AddTicks(9959),
                oldClrType: typeof(DateTime),
                oldType: "TIMESTAMP(7)",
                oldDefaultValue: new DateTime(2023, 2, 1, 18, 24, 15, 931, DateTimeKind.Local).AddTicks(1298));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModifiedOn",
                table: "User",
                type: "TIMESTAMP(7)",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 5, 18, 5, 31, 880, DateTimeKind.Local).AddTicks(9660),
                oldClrType: typeof(DateTime),
                oldType: "TIMESTAMP(7)",
                oldDefaultValue: new DateTime(2023, 2, 1, 18, 24, 15, 931, DateTimeKind.Local).AddTicks(1059));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "User",
                type: "TIMESTAMP(7)",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 5, 18, 5, 31, 880, DateTimeKind.Local).AddTicks(9338),
                oldClrType: typeof(DateTime),
                oldType: "TIMESTAMP(7)",
                oldDefaultValue: new DateTime(2023, 2, 1, 18, 24, 15, 931, DateTimeKind.Local).AddTicks(823));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModifiedOn",
                table: "TicketStatus",
                type: "TIMESTAMP(7)",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 5, 18, 5, 31, 880, DateTimeKind.Local).AddTicks(9060),
                oldClrType: typeof(DateTime),
                oldType: "TIMESTAMP(7)",
                oldDefaultValue: new DateTime(2023, 2, 1, 18, 24, 15, 931, DateTimeKind.Local).AddTicks(589));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "TicketStatus",
                type: "TIMESTAMP(7)",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 5, 18, 5, 31, 880, DateTimeKind.Local).AddTicks(8840),
                oldClrType: typeof(DateTime),
                oldType: "TIMESTAMP(7)",
                oldDefaultValue: new DateTime(2023, 2, 1, 18, 24, 15, 931, DateTimeKind.Local).AddTicks(350));

            migrationBuilder.AddColumn<int>(
                name: "TicketCode",
                table: "TicketDetail",
                type: "NUMBER(10)",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModifiedOn",
                table: "Role",
                type: "TIMESTAMP(7)",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 5, 18, 5, 31, 880, DateTimeKind.Local).AddTicks(8533),
                oldClrType: typeof(DateTime),
                oldType: "TIMESTAMP(7)",
                oldDefaultValue: new DateTime(2023, 2, 1, 18, 24, 15, 931, DateTimeKind.Local).AddTicks(121));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Role",
                type: "TIMESTAMP(7)",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 5, 18, 5, 31, 880, DateTimeKind.Local).AddTicks(8308),
                oldClrType: typeof(DateTime),
                oldType: "TIMESTAMP(7)",
                oldDefaultValue: new DateTime(2023, 2, 1, 18, 24, 15, 930, DateTimeKind.Local).AddTicks(9918));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModifiedOn",
                table: "MenuItemRole",
                type: "TIMESTAMP(7)",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 5, 18, 5, 31, 880, DateTimeKind.Local).AddTicks(7946),
                oldClrType: typeof(DateTime),
                oldType: "TIMESTAMP(7)",
                oldDefaultValue: new DateTime(2023, 2, 1, 18, 24, 15, 930, DateTimeKind.Local).AddTicks(9588));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "MenuItemRole",
                type: "TIMESTAMP(7)",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 5, 18, 5, 31, 880, DateTimeKind.Local).AddTicks(7624),
                oldClrType: typeof(DateTime),
                oldType: "TIMESTAMP(7)",
                oldDefaultValue: new DateTime(2023, 2, 1, 18, 24, 15, 930, DateTimeKind.Local).AddTicks(9339));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModifiedOn",
                table: "MenuItem",
                type: "TIMESTAMP(7)",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 5, 18, 5, 31, 880, DateTimeKind.Local).AddTicks(7243),
                oldClrType: typeof(DateTime),
                oldType: "TIMESTAMP(7)",
                oldDefaultValue: new DateTime(2023, 2, 1, 18, 24, 15, 930, DateTimeKind.Local).AddTicks(9027));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "MenuItem",
                type: "TIMESTAMP(7)",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 5, 18, 5, 31, 880, DateTimeKind.Local).AddTicks(6820),
                oldClrType: typeof(DateTime),
                oldType: "TIMESTAMP(7)",
                oldDefaultValue: new DateTime(2023, 2, 1, 18, 24, 15, 930, DateTimeKind.Local).AddTicks(8651));

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: new Guid("504731d4-0a34-41d5-9b0b-0611b3f76096"),
                column: "CreatedOn",
                value: new DateTime(2023, 2, 5, 18, 5, 31, 878, DateTimeKind.Local).AddTicks(8222));

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: new Guid("504731d4-0a34-41d5-9b0b-0611b3f76098"),
                column: "CreatedOn",
                value: new DateTime(2023, 2, 5, 18, 5, 31, 878, DateTimeKind.Local).AddTicks(8252));

            migrationBuilder.UpdateData(
                table: "TicketStatus",
                keyColumn: "Id",
                keyValue: new Guid("504731d4-0a34-41d5-9b0b-0611b3f76777"),
                column: "CreatedOn",
                value: new DateTime(2023, 2, 5, 18, 5, 31, 880, DateTimeKind.Local).AddTicks(6386));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TicketCode",
                table: "TicketDetail");

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModifiedOn",
                table: "UserRole",
                type: "TIMESTAMP(7)",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 1, 18, 24, 15, 931, DateTimeKind.Local).AddTicks(1564),
                oldClrType: typeof(DateTime),
                oldType: "TIMESTAMP(7)",
                oldDefaultValue: new DateTime(2023, 2, 5, 18, 5, 31, 881, DateTimeKind.Local).AddTicks(411));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "UserRole",
                type: "TIMESTAMP(7)",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 1, 18, 24, 15, 931, DateTimeKind.Local).AddTicks(1298),
                oldClrType: typeof(DateTime),
                oldType: "TIMESTAMP(7)",
                oldDefaultValue: new DateTime(2023, 2, 5, 18, 5, 31, 880, DateTimeKind.Local).AddTicks(9959));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModifiedOn",
                table: "User",
                type: "TIMESTAMP(7)",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 1, 18, 24, 15, 931, DateTimeKind.Local).AddTicks(1059),
                oldClrType: typeof(DateTime),
                oldType: "TIMESTAMP(7)",
                oldDefaultValue: new DateTime(2023, 2, 5, 18, 5, 31, 880, DateTimeKind.Local).AddTicks(9660));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "User",
                type: "TIMESTAMP(7)",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 1, 18, 24, 15, 931, DateTimeKind.Local).AddTicks(823),
                oldClrType: typeof(DateTime),
                oldType: "TIMESTAMP(7)",
                oldDefaultValue: new DateTime(2023, 2, 5, 18, 5, 31, 880, DateTimeKind.Local).AddTicks(9338));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModifiedOn",
                table: "TicketStatus",
                type: "TIMESTAMP(7)",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 1, 18, 24, 15, 931, DateTimeKind.Local).AddTicks(589),
                oldClrType: typeof(DateTime),
                oldType: "TIMESTAMP(7)",
                oldDefaultValue: new DateTime(2023, 2, 5, 18, 5, 31, 880, DateTimeKind.Local).AddTicks(9060));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "TicketStatus",
                type: "TIMESTAMP(7)",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 1, 18, 24, 15, 931, DateTimeKind.Local).AddTicks(350),
                oldClrType: typeof(DateTime),
                oldType: "TIMESTAMP(7)",
                oldDefaultValue: new DateTime(2023, 2, 5, 18, 5, 31, 880, DateTimeKind.Local).AddTicks(8840));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModifiedOn",
                table: "Role",
                type: "TIMESTAMP(7)",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 1, 18, 24, 15, 931, DateTimeKind.Local).AddTicks(121),
                oldClrType: typeof(DateTime),
                oldType: "TIMESTAMP(7)",
                oldDefaultValue: new DateTime(2023, 2, 5, 18, 5, 31, 880, DateTimeKind.Local).AddTicks(8533));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Role",
                type: "TIMESTAMP(7)",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 1, 18, 24, 15, 930, DateTimeKind.Local).AddTicks(9918),
                oldClrType: typeof(DateTime),
                oldType: "TIMESTAMP(7)",
                oldDefaultValue: new DateTime(2023, 2, 5, 18, 5, 31, 880, DateTimeKind.Local).AddTicks(8308));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModifiedOn",
                table: "MenuItemRole",
                type: "TIMESTAMP(7)",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 1, 18, 24, 15, 930, DateTimeKind.Local).AddTicks(9588),
                oldClrType: typeof(DateTime),
                oldType: "TIMESTAMP(7)",
                oldDefaultValue: new DateTime(2023, 2, 5, 18, 5, 31, 880, DateTimeKind.Local).AddTicks(7946));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "MenuItemRole",
                type: "TIMESTAMP(7)",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 1, 18, 24, 15, 930, DateTimeKind.Local).AddTicks(9339),
                oldClrType: typeof(DateTime),
                oldType: "TIMESTAMP(7)",
                oldDefaultValue: new DateTime(2023, 2, 5, 18, 5, 31, 880, DateTimeKind.Local).AddTicks(7624));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModifiedOn",
                table: "MenuItem",
                type: "TIMESTAMP(7)",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 1, 18, 24, 15, 930, DateTimeKind.Local).AddTicks(9027),
                oldClrType: typeof(DateTime),
                oldType: "TIMESTAMP(7)",
                oldDefaultValue: new DateTime(2023, 2, 5, 18, 5, 31, 880, DateTimeKind.Local).AddTicks(7243));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "MenuItem",
                type: "TIMESTAMP(7)",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 1, 18, 24, 15, 930, DateTimeKind.Local).AddTicks(8651),
                oldClrType: typeof(DateTime),
                oldType: "TIMESTAMP(7)",
                oldDefaultValue: new DateTime(2023, 2, 5, 18, 5, 31, 880, DateTimeKind.Local).AddTicks(6820));

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: new Guid("504731d4-0a34-41d5-9b0b-0611b3f76096"),
                column: "CreatedOn",
                value: new DateTime(2023, 2, 1, 18, 24, 15, 929, DateTimeKind.Local).AddTicks(4282));

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: new Guid("504731d4-0a34-41d5-9b0b-0611b3f76098"),
                column: "CreatedOn",
                value: new DateTime(2023, 2, 1, 18, 24, 15, 929, DateTimeKind.Local).AddTicks(4302));

            migrationBuilder.UpdateData(
                table: "TicketStatus",
                keyColumn: "Id",
                keyValue: new Guid("504731d4-0a34-41d5-9b0b-0611b3f76777"),
                column: "CreatedOn",
                value: new DateTime(2023, 2, 1, 18, 24, 15, 930, DateTimeKind.Local).AddTicks(8238));
        }
    }
}
