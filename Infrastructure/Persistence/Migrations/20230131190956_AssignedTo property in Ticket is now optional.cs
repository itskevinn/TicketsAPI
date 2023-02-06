using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Persistence.Migrations
{
    public partial class AssignedTopropertyinTicketisnowoptional : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Ticket_User_AssignedToId",
                table: "Ticket");

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModifiedOn",
                table: "UserRole",
                type: "TIMESTAMP(7)",
                nullable: false,
                defaultValue: new DateTime(2023, 1, 31, 14, 9, 56, 26, DateTimeKind.Local).AddTicks(7968),
                oldClrType: typeof(DateTime),
                oldType: "TIMESTAMP(7)",
                oldDefaultValue: new DateTime(2023, 1, 26, 23, 11, 42, 802, DateTimeKind.Local).AddTicks(4227));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "UserRole",
                type: "TIMESTAMP(7)",
                nullable: false,
                defaultValue: new DateTime(2023, 1, 31, 14, 9, 56, 26, DateTimeKind.Local).AddTicks(7578),
                oldClrType: typeof(DateTime),
                oldType: "TIMESTAMP(7)",
                oldDefaultValue: new DateTime(2023, 1, 26, 23, 11, 42, 802, DateTimeKind.Local).AddTicks(3809));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModifiedOn",
                table: "User",
                type: "TIMESTAMP(7)",
                nullable: false,
                defaultValue: new DateTime(2023, 1, 31, 14, 9, 56, 26, DateTimeKind.Local).AddTicks(7141),
                oldClrType: typeof(DateTime),
                oldType: "TIMESTAMP(7)",
                oldDefaultValue: new DateTime(2023, 1, 26, 23, 11, 42, 802, DateTimeKind.Local).AddTicks(3363));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "User",
                type: "TIMESTAMP(7)",
                nullable: false,
                defaultValue: new DateTime(2023, 1, 31, 14, 9, 56, 26, DateTimeKind.Local).AddTicks(6661),
                oldClrType: typeof(DateTime),
                oldType: "TIMESTAMP(7)",
                oldDefaultValue: new DateTime(2023, 1, 26, 23, 11, 42, 802, DateTimeKind.Local).AddTicks(3002));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModifiedOn",
                table: "TicketStatus",
                type: "TIMESTAMP(7)",
                nullable: false,
                defaultValue: new DateTime(2023, 1, 31, 14, 9, 56, 26, DateTimeKind.Local).AddTicks(6242),
                oldClrType: typeof(DateTime),
                oldType: "TIMESTAMP(7)",
                oldDefaultValue: new DateTime(2023, 1, 26, 23, 11, 42, 802, DateTimeKind.Local).AddTicks(2595));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "TicketStatus",
                type: "TIMESTAMP(7)",
                nullable: false,
                defaultValue: new DateTime(2023, 1, 31, 14, 9, 56, 26, DateTimeKind.Local).AddTicks(5846),
                oldClrType: typeof(DateTime),
                oldType: "TIMESTAMP(7)",
                oldDefaultValue: new DateTime(2023, 1, 26, 23, 11, 42, 802, DateTimeKind.Local).AddTicks(2233));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModifiedOn",
                table: "Role",
                type: "TIMESTAMP(7)",
                nullable: false,
                defaultValue: new DateTime(2023, 1, 31, 14, 9, 56, 26, DateTimeKind.Local).AddTicks(5437),
                oldClrType: typeof(DateTime),
                oldType: "TIMESTAMP(7)",
                oldDefaultValue: new DateTime(2023, 1, 26, 23, 11, 42, 802, DateTimeKind.Local).AddTicks(1807));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Role",
                type: "TIMESTAMP(7)",
                nullable: false,
                defaultValue: new DateTime(2023, 1, 31, 14, 9, 56, 26, DateTimeKind.Local).AddTicks(5033),
                oldClrType: typeof(DateTime),
                oldType: "TIMESTAMP(7)",
                oldDefaultValue: new DateTime(2023, 1, 26, 23, 11, 42, 802, DateTimeKind.Local).AddTicks(1409));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModifiedOn",
                table: "MenuItemRole",
                type: "TIMESTAMP(7)",
                nullable: false,
                defaultValue: new DateTime(2023, 1, 31, 14, 9, 56, 26, DateTimeKind.Local).AddTicks(4565),
                oldClrType: typeof(DateTime),
                oldType: "TIMESTAMP(7)",
                oldDefaultValue: new DateTime(2023, 1, 26, 23, 11, 42, 802, DateTimeKind.Local).AddTicks(419));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "MenuItemRole",
                type: "TIMESTAMP(7)",
                nullable: false,
                defaultValue: new DateTime(2023, 1, 31, 14, 9, 56, 26, DateTimeKind.Local).AddTicks(4059),
                oldClrType: typeof(DateTime),
                oldType: "TIMESTAMP(7)",
                oldDefaultValue: new DateTime(2023, 1, 26, 23, 11, 42, 794, DateTimeKind.Local).AddTicks(3963));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModifiedOn",
                table: "MenuItem",
                type: "TIMESTAMP(7)",
                nullable: false,
                defaultValue: new DateTime(2023, 1, 31, 14, 9, 56, 26, DateTimeKind.Local).AddTicks(3587),
                oldClrType: typeof(DateTime),
                oldType: "TIMESTAMP(7)",
                oldDefaultValue: new DateTime(2023, 1, 26, 23, 11, 42, 794, DateTimeKind.Local).AddTicks(3667));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "MenuItem",
                type: "TIMESTAMP(7)",
                nullable: false,
                defaultValue: new DateTime(2023, 1, 31, 14, 9, 56, 26, DateTimeKind.Local).AddTicks(3053),
                oldClrType: typeof(DateTime),
                oldType: "TIMESTAMP(7)",
                oldDefaultValue: new DateTime(2023, 1, 26, 23, 11, 42, 794, DateTimeKind.Local).AddTicks(3375));

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: new Guid("504731d4-0a34-41d5-9b0b-0611b3f76096"),
                column: "CreatedOn",
                value: new DateTime(2023, 1, 31, 14, 9, 56, 24, DateTimeKind.Local).AddTicks(3023));

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: new Guid("504731d4-0a34-41d5-9b0b-0611b3f76098"),
                column: "CreatedOn",
                value: new DateTime(2023, 1, 31, 14, 9, 56, 24, DateTimeKind.Local).AddTicks(3048));

            migrationBuilder.UpdateData(
                table: "TicketStatus",
                keyColumn: "Id",
                keyValue: new Guid("504731d4-0a34-41d5-9b0b-0611b3f76777"),
                column: "CreatedOn",
                value: new DateTime(2023, 1, 31, 14, 9, 56, 26, DateTimeKind.Local).AddTicks(2571));

            migrationBuilder.AddForeignKey(
                name: "FK_Ticket_User_AssignedToId",
                table: "Ticket",
                column: "AssignedToId",
                principalTable: "User",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Ticket_User_AssignedToId",
                table: "Ticket");

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModifiedOn",
                table: "UserRole",
                type: "TIMESTAMP(7)",
                nullable: false,
                defaultValue: new DateTime(2023, 1, 26, 23, 11, 42, 802, DateTimeKind.Local).AddTicks(4227),
                oldClrType: typeof(DateTime),
                oldType: "TIMESTAMP(7)",
                oldDefaultValue: new DateTime(2023, 1, 31, 14, 9, 56, 26, DateTimeKind.Local).AddTicks(7968));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "UserRole",
                type: "TIMESTAMP(7)",
                nullable: false,
                defaultValue: new DateTime(2023, 1, 26, 23, 11, 42, 802, DateTimeKind.Local).AddTicks(3809),
                oldClrType: typeof(DateTime),
                oldType: "TIMESTAMP(7)",
                oldDefaultValue: new DateTime(2023, 1, 31, 14, 9, 56, 26, DateTimeKind.Local).AddTicks(7578));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModifiedOn",
                table: "User",
                type: "TIMESTAMP(7)",
                nullable: false,
                defaultValue: new DateTime(2023, 1, 26, 23, 11, 42, 802, DateTimeKind.Local).AddTicks(3363),
                oldClrType: typeof(DateTime),
                oldType: "TIMESTAMP(7)",
                oldDefaultValue: new DateTime(2023, 1, 31, 14, 9, 56, 26, DateTimeKind.Local).AddTicks(7141));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "User",
                type: "TIMESTAMP(7)",
                nullable: false,
                defaultValue: new DateTime(2023, 1, 26, 23, 11, 42, 802, DateTimeKind.Local).AddTicks(3002),
                oldClrType: typeof(DateTime),
                oldType: "TIMESTAMP(7)",
                oldDefaultValue: new DateTime(2023, 1, 31, 14, 9, 56, 26, DateTimeKind.Local).AddTicks(6661));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModifiedOn",
                table: "TicketStatus",
                type: "TIMESTAMP(7)",
                nullable: false,
                defaultValue: new DateTime(2023, 1, 26, 23, 11, 42, 802, DateTimeKind.Local).AddTicks(2595),
                oldClrType: typeof(DateTime),
                oldType: "TIMESTAMP(7)",
                oldDefaultValue: new DateTime(2023, 1, 31, 14, 9, 56, 26, DateTimeKind.Local).AddTicks(6242));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "TicketStatus",
                type: "TIMESTAMP(7)",
                nullable: false,
                defaultValue: new DateTime(2023, 1, 26, 23, 11, 42, 802, DateTimeKind.Local).AddTicks(2233),
                oldClrType: typeof(DateTime),
                oldType: "TIMESTAMP(7)",
                oldDefaultValue: new DateTime(2023, 1, 31, 14, 9, 56, 26, DateTimeKind.Local).AddTicks(5846));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModifiedOn",
                table: "Role",
                type: "TIMESTAMP(7)",
                nullable: false,
                defaultValue: new DateTime(2023, 1, 26, 23, 11, 42, 802, DateTimeKind.Local).AddTicks(1807),
                oldClrType: typeof(DateTime),
                oldType: "TIMESTAMP(7)",
                oldDefaultValue: new DateTime(2023, 1, 31, 14, 9, 56, 26, DateTimeKind.Local).AddTicks(5437));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Role",
                type: "TIMESTAMP(7)",
                nullable: false,
                defaultValue: new DateTime(2023, 1, 26, 23, 11, 42, 802, DateTimeKind.Local).AddTicks(1409),
                oldClrType: typeof(DateTime),
                oldType: "TIMESTAMP(7)",
                oldDefaultValue: new DateTime(2023, 1, 31, 14, 9, 56, 26, DateTimeKind.Local).AddTicks(5033));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModifiedOn",
                table: "MenuItemRole",
                type: "TIMESTAMP(7)",
                nullable: false,
                defaultValue: new DateTime(2023, 1, 26, 23, 11, 42, 802, DateTimeKind.Local).AddTicks(419),
                oldClrType: typeof(DateTime),
                oldType: "TIMESTAMP(7)",
                oldDefaultValue: new DateTime(2023, 1, 31, 14, 9, 56, 26, DateTimeKind.Local).AddTicks(4565));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "MenuItemRole",
                type: "TIMESTAMP(7)",
                nullable: false,
                defaultValue: new DateTime(2023, 1, 26, 23, 11, 42, 794, DateTimeKind.Local).AddTicks(3963),
                oldClrType: typeof(DateTime),
                oldType: "TIMESTAMP(7)",
                oldDefaultValue: new DateTime(2023, 1, 31, 14, 9, 56, 26, DateTimeKind.Local).AddTicks(4059));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModifiedOn",
                table: "MenuItem",
                type: "TIMESTAMP(7)",
                nullable: false,
                defaultValue: new DateTime(2023, 1, 26, 23, 11, 42, 794, DateTimeKind.Local).AddTicks(3667),
                oldClrType: typeof(DateTime),
                oldType: "TIMESTAMP(7)",
                oldDefaultValue: new DateTime(2023, 1, 31, 14, 9, 56, 26, DateTimeKind.Local).AddTicks(3587));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "MenuItem",
                type: "TIMESTAMP(7)",
                nullable: false,
                defaultValue: new DateTime(2023, 1, 26, 23, 11, 42, 794, DateTimeKind.Local).AddTicks(3375),
                oldClrType: typeof(DateTime),
                oldType: "TIMESTAMP(7)",
                oldDefaultValue: new DateTime(2023, 1, 31, 14, 9, 56, 26, DateTimeKind.Local).AddTicks(3053));

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: new Guid("504731d4-0a34-41d5-9b0b-0611b3f76096"),
                column: "CreatedOn",
                value: new DateTime(2023, 1, 26, 23, 11, 42, 792, DateTimeKind.Local).AddTicks(9694));

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: new Guid("504731d4-0a34-41d5-9b0b-0611b3f76098"),
                column: "CreatedOn",
                value: new DateTime(2023, 1, 26, 23, 11, 42, 792, DateTimeKind.Local).AddTicks(9717));

            migrationBuilder.UpdateData(
                table: "TicketStatus",
                keyColumn: "Id",
                keyValue: new Guid("504731d4-0a34-41d5-9b0b-0611b3f76777"),
                column: "CreatedOn",
                value: new DateTime(2023, 1, 26, 23, 11, 42, 794, DateTimeKind.Local).AddTicks(3048));

            migrationBuilder.AddForeignKey(
                name: "FK_Ticket_User_AssignedToId",
                table: "Ticket",
                column: "AssignedToId",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
