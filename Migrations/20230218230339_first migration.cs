using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Security.Infrastructure.Migrations
{
    public partial class firstmigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "MenuItem",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "RAW(16)", nullable: false),
                    Icon = table.Column<string>(type: "NVARCHAR2(30)", maxLength: 30, nullable: false),
                    RouterLink = table.Column<string>(type: "NVARCHAR2(255)", maxLength: 255, nullable: false),
                    Label = table.Column<string>(type: "NVARCHAR2(30)", maxLength: 30, nullable: false),
                    Order = table.Column<int>(type: "NUMBER(10)", nullable: false),
                    CreatedBy = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: false, defaultValue: new DateTime(2023, 2, 18, 18, 3, 39, 363, DateTimeKind.Local).AddTicks(8811)),
                    LastModifiedBy = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true),
                    LastModifiedOn = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: false, defaultValue: new DateTime(2023, 2, 18, 18, 3, 39, 363, DateTimeKind.Local).AddTicks(9142)),
                    Status = table.Column<bool>(type: "NUMBER(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MenuItem", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Role",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "RAW(16)", nullable: false),
                    RoleName = table.Column<string>(type: "NVARCHAR2(20)", maxLength: 20, nullable: false),
                    CreatedBy = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: false, defaultValue: new DateTime(2023, 2, 18, 18, 3, 39, 364, DateTimeKind.Local).AddTicks(22)),
                    LastModifiedBy = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true),
                    LastModifiedOn = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: false, defaultValue: new DateTime(2023, 2, 18, 18, 3, 39, 364, DateTimeKind.Local).AddTicks(225)),
                    Status = table.Column<bool>(type: "NUMBER(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Role", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "RAW(16)", nullable: false),
                    Name = table.Column<string>(type: "NVARCHAR2(30)", maxLength: 30, nullable: false),
                    Email = table.Column<string>(type: "NVARCHAR2(50)", maxLength: 50, nullable: true),
                    Username = table.Column<string>(type: "NVARCHAR2(15)", maxLength: 15, nullable: false),
                    Password = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    CreatedBy = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: false, defaultValue: new DateTime(2023, 2, 18, 18, 3, 39, 364, DateTimeKind.Local).AddTicks(498)),
                    LastModifiedBy = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true),
                    LastModifiedOn = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: false, defaultValue: new DateTime(2023, 2, 18, 18, 3, 39, 364, DateTimeKind.Local).AddTicks(691)),
                    Status = table.Column<bool>(type: "NUMBER(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MenuItemRole",
                columns: table => new
                {
                    MenuItemId = table.Column<Guid>(type: "RAW(16)", nullable: false),
                    RoleId = table.Column<Guid>(type: "RAW(16)", nullable: false),
                    Id = table.Column<Guid>(type: "RAW(16)", nullable: false),
                    CreatedBy = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: false, defaultValue: new DateTime(2023, 2, 18, 18, 3, 39, 363, DateTimeKind.Local).AddTicks(9454)),
                    LastModifiedBy = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true),
                    LastModifiedOn = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: false, defaultValue: new DateTime(2023, 2, 18, 18, 3, 39, 363, DateTimeKind.Local).AddTicks(9688)),
                    Status = table.Column<bool>(type: "NUMBER(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MenuItemRole", x => new { x.RoleId, x.MenuItemId });
                    table.ForeignKey(
                        name: "FK_MenuItemRole_MenuItem_MenuItemId",
                        column: x => x.MenuItemId,
                        principalTable: "MenuItem",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MenuItemRole_Role_RoleId",
                        column: x => x.RoleId,
                        principalTable: "Role",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserRole",
                columns: table => new
                {
                    UserId = table.Column<Guid>(type: "RAW(16)", nullable: false),
                    RoleId = table.Column<Guid>(type: "RAW(16)", nullable: false),
                    Id = table.Column<Guid>(type: "RAW(16)", nullable: false),
                    CreatedBy = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: false, defaultValue: new DateTime(2023, 2, 18, 18, 3, 39, 364, DateTimeKind.Local).AddTicks(913)),
                    LastModifiedBy = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true),
                    LastModifiedOn = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: false, defaultValue: new DateTime(2023, 2, 18, 18, 3, 39, 364, DateTimeKind.Local).AddTicks(1166)),
                    Status = table.Column<bool>(type: "NUMBER(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserRole", x => new { x.RoleId, x.UserId });
                    table.ForeignKey(
                        name: "FK_UserRole_Role_RoleId",
                        column: x => x.RoleId,
                        principalTable: "Role",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserRole_User_UserId",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "MenuItem",
                columns: new[] { "Id", "CreatedBy", "CreatedOn", "Icon", "Label", "LastModifiedBy", "Order", "RouterLink", "Status" },
                values: new object[,]
                {
                    { new Guid("504731d4-0a34-41d5-9b0b-0611b3f76096"), "AutoGenerated", new DateTime(2023, 2, 18, 18, 3, 39, 363, DateTimeKind.Local).AddTicks(8447), "fa-solid fa-plane-departure", "Tickets", "AutoGenerated", 1, "tickets", true },
                    { new Guid("504731d4-0a34-41d5-9b0b-0611b3f76098"), "AutoGenerated", new DateTime(2023, 2, 18, 18, 3, 39, 363, DateTimeKind.Local).AddTicks(8470), "fa-solid fa-plane-departure", "Usuarios", "AutoGenerated", 2, "users", true }
                });

            migrationBuilder.InsertData(
                table: "Role",
                columns: new[] { "Id", "CreatedBy", "LastModifiedBy", "RoleName", "Status" },
                values: new object[,]
                {
                    { new Guid("4a77cee4-5cfa-4c90-b41a-08da36159111"), "AutoGenerated", "AutoGenerated", "User", true },
                    { new Guid("bf1de1aa-fc78-4b92-6942-08da36131198"), "AutoGenerated", "AutoGenerated", "Admin", true }
                });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "CreatedBy", "Email", "LastModifiedBy", "Name", "Password", "Status", "Username" },
                values: new object[,]
                {
                    { new Guid("4a77cee4-5cfa-4c90-b41a-08da36159120"), "AutoGenerated", "kvnpntn@gmail.com", "AutoGenerated", "Kevin Pontón", "8c6976e5b5410415bde908bd4dee15dfb167a9c873fc4bb8a81f6f2ab448a918", true, "Admin" },
                    { new Guid("c82a18c6-e473-4976-5f2e-08da35e4eb6f"), "AutoGenerated", "keviinpn2@gmail.com", "AutoGenerated", "Usuario", "03ac674216f3e15c761ee1a5e255f067953623c8b388b4459e13f978d7c846f4", true, "User" }
                });

            migrationBuilder.InsertData(
                table: "MenuItemRole",
                columns: new[] { "MenuItemId", "RoleId", "CreatedBy", "Id", "LastModifiedBy", "Status" },
                values: new object[,]
                {
                    { new Guid("504731d4-0a34-41d5-9b0b-0611b3f76096"), new Guid("4a77cee4-5cfa-4c90-b41a-08da36159111"), "AutoGenerated", new Guid("c82a18c6-e473-4976-5f2e-08da35e4eb8a"), "AutoGenerated", true },
                    { new Guid("504731d4-0a34-41d5-9b0b-0611b3f76098"), new Guid("4a77cee4-5cfa-4c90-b41a-08da36159111"), "AutoGenerated", new Guid("c82a18c6-e473-4976-5f2e-08da35e4eb8b"), "AutoGenerated", true },
                    { new Guid("504731d4-0a34-41d5-9b0b-0611b3f76096"), new Guid("bf1de1aa-fc78-4b92-6942-08da36131198"), "AutoGenerated", new Guid("c82a18c6-e473-4976-5f2e-08da35e4ebfe"), "AutoGenerated", true },
                    { new Guid("504731d4-0a34-41d5-9b0b-0611b3f76098"), new Guid("bf1de1aa-fc78-4b92-6942-08da36131198"), "AutoGenerated", new Guid("c82a18c6-e473-4976-5f2e-08da35e4eb8e"), "AutoGenerated", true }
                });

            migrationBuilder.InsertData(
                table: "UserRole",
                columns: new[] { "RoleId", "UserId", "CreatedBy", "Id", "LastModifiedBy", "Status" },
                values: new object[,]
                {
                    { new Guid("4a77cee4-5cfa-4c90-b41a-08da36159111"), new Guid("c82a18c6-e473-4976-5f2e-08da35e4eb6f"), "AutoGenerated", new Guid("bf1de1aa-fc78-4b92-6942-09da3e131298"), "AutoGenerated", true },
                    { new Guid("bf1de1aa-fc78-4b92-6942-08da36131198"), new Guid("4a77cee4-5cfa-4c90-b41a-08da36159120"), "AutoGenerated", new Guid("bf1de1aa-fc78-4b92-6942-09da36131298"), "AutoGenerated", true }
                });

            migrationBuilder.CreateIndex(
                name: "IX_MenuItemRole_MenuItemId",
                table: "MenuItemRole",
                column: "MenuItemId");

            migrationBuilder.CreateIndex(
                name: "IX_UserRole_UserId",
                table: "UserRole",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MenuItemRole");

            migrationBuilder.DropTable(
                name: "UserRole");

            migrationBuilder.DropTable(
                name: "MenuItem");

            migrationBuilder.DropTable(
                name: "Role");

            migrationBuilder.DropTable(
                name: "User");
        }
    }
}
