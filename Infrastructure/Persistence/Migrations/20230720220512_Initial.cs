﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Persistence.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModifiedOn",
                table: "TicketStatus",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 7, 20, 17, 5, 12, 174, DateTimeKind.Local).AddTicks(2145),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 6, 17, 18, 5, 37, 864, DateTimeKind.Local).AddTicks(4968));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "TicketStatus",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 7, 20, 17, 5, 12, 174, DateTimeKind.Local).AddTicks(1609),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 6, 17, 18, 5, 37, 864, DateTimeKind.Local).AddTicks(3679));

            migrationBuilder.UpdateData(
                table: "TicketStatus",
                keyColumn: "Id",
                keyValue: new Guid("504731d4-0a34-41d5-9b0b-0611b3f76777"),
                column: "CreatedOn",
                value: new DateTime(2023, 7, 20, 17, 5, 12, 174, DateTimeKind.Local).AddTicks(1265));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModifiedOn",
                table: "TicketStatus",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 6, 17, 18, 5, 37, 864, DateTimeKind.Local).AddTicks(4968),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 7, 20, 17, 5, 12, 174, DateTimeKind.Local).AddTicks(2145));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "TicketStatus",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 6, 17, 18, 5, 37, 864, DateTimeKind.Local).AddTicks(3679),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 7, 20, 17, 5, 12, 174, DateTimeKind.Local).AddTicks(1609));

            migrationBuilder.UpdateData(
                table: "TicketStatus",
                keyColumn: "Id",
                keyValue: new Guid("504731d4-0a34-41d5-9b0b-0611b3f76777"),
                column: "CreatedOn",
                value: new DateTime(2023, 6, 17, 18, 5, 37, 864, DateTimeKind.Local).AddTicks(2917));
        }
    }
}
