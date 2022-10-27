using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    public partial class StatusaddedtoAuditableEntity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Status",
                table: "UserRole",
                type: "NUMBER(1)",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Status",
                table: "User",
                type: "NUMBER(1)",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Status",
                table: "Role",
                type: "NUMBER(1)",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Status",
                table: "MenuItemRole",
                type: "NUMBER(1)",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Status",
                table: "MenuItem",
                type: "NUMBER(1)",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: new Guid("012fff70-84e2-4962-84a3-3b7833bb71fb"),
                column: "Status",
                value: true);

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: new Guid("504731d4-0a34-41d5-9b0b-0611b3f76096"),
                column: "Status",
                value: true);

            migrationBuilder.UpdateData(
                table: "MenuItemRole",
                keyColumns: new[] { "MenuItemId", "RoleId" },
                keyValues: new object[] { new Guid("012fff70-84e2-4962-84a3-3b7833bb71fb"), new Guid("4a77cee4-5cfa-4c90-b41a-08da36159111") },
                column: "Status",
                value: true);

            migrationBuilder.UpdateData(
                table: "MenuItemRole",
                keyColumns: new[] { "MenuItemId", "RoleId" },
                keyValues: new object[] { new Guid("504731d4-0a34-41d5-9b0b-0611b3f76096"), new Guid("4a77cee4-5cfa-4c90-b41a-08da36159111") },
                column: "Status",
                value: true);

            migrationBuilder.UpdateData(
                table: "MenuItemRole",
                keyColumns: new[] { "MenuItemId", "RoleId" },
                keyValues: new object[] { new Guid("012fff70-84e2-4962-84a3-3b7833bb71fb"), new Guid("bf1de1aa-fc78-4b92-6942-08da36131198") },
                column: "Status",
                value: true);

            migrationBuilder.UpdateData(
                table: "MenuItemRole",
                keyColumns: new[] { "MenuItemId", "RoleId" },
                keyValues: new object[] { new Guid("504731d4-0a34-41d5-9b0b-0611b3f76096"), new Guid("bf1de1aa-fc78-4b92-6942-08da36131198") },
                column: "Status",
                value: true);

            migrationBuilder.UpdateData(
                table: "Role",
                keyColumn: "Id",
                keyValue: new Guid("4a77cee4-5cfa-4c90-b41a-08da36159111"),
                column: "Status",
                value: true);

            migrationBuilder.UpdateData(
                table: "Role",
                keyColumn: "Id",
                keyValue: new Guid("bf1de1aa-fc78-4b92-6942-08da36131198"),
                column: "Status",
                value: true);

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("4a77cee4-5cfa-4c90-b41a-08da36159120"),
                column: "Status",
                value: true);

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("c82a18c6-e473-4976-5f2e-08da35e4eb6f"),
                column: "Status",
                value: true);

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("4a77cee4-5cfa-4c90-b41a-08da36159111"), new Guid("c82a18c6-e473-4976-5f2e-08da35e4eb6f") },
                column: "Status",
                value: true);

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("bf1de1aa-fc78-4b92-6942-08da36131198"), new Guid("4a77cee4-5cfa-4c90-b41a-08da36159120") },
                column: "Status",
                value: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Status",
                table: "UserRole");

            migrationBuilder.DropColumn(
                name: "Status",
                table: "User");

            migrationBuilder.DropColumn(
                name: "Status",
                table: "Role");

            migrationBuilder.DropColumn(
                name: "Status",
                table: "MenuItemRole");

            migrationBuilder.DropColumn(
                name: "Status",
                table: "MenuItem");
        }
    }
}
