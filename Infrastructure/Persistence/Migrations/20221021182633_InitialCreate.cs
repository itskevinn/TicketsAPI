#nullable disable

using Microsoft.EntityFrameworkCore.Migrations;

namespace Infrastructure.Migrations
{
    public partial class InitialCreate : Migration
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
                    CreatedOn = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: false),
                    LastModifiedBy = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    LastModifiedOn = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: false)
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
                    CreatedOn = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: false),
                    LastModifiedBy = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    LastModifiedOn = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Role", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Ticket",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "RAW(16)", nullable: false),
                    Code = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    Title = table.Column<string>(type: "NVARCHAR2(255)", maxLength: 255, nullable: false),
                    Status = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    GeneratedOn = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: false),
                    SolvedOn = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: false),
                    AllegedSolveDate = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: false),
                    Description = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    CreatedBy = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: false),
                    LastModifiedBy = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    LastModifiedOn = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ticket", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TicketDetail",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "RAW(16)", nullable: false),
                    Message = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    CreatedBy = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: false),
                    LastModifiedBy = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    LastModifiedOn = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TicketDetail", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "RAW(16)", nullable: false),
                    Name = table.Column<string>(type: "NVARCHAR2(30)", maxLength: 30, nullable: false),
                    Username = table.Column<string>(type: "NVARCHAR2(15)", maxLength: 15, nullable: false),
                    Password = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    CreatedBy = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: false),
                    LastModifiedBy = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    LastModifiedOn = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: false)
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
                    CreatedOn = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: false),
                    LastModifiedBy = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    LastModifiedOn = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: false)
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
                name: "Attachment",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "RAW(16)", nullable: false),
                    Url = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    TicketDetailId = table.Column<Guid>(type: "RAW(16)", nullable: true),
                    CreatedBy = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: false),
                    LastModifiedBy = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    LastModifiedOn = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Attachment", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Attachment_TicketDetail_TicketDetailId",
                        column: x => x.TicketDetailId,
                        principalTable: "TicketDetail",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "UserRole",
                columns: table => new
                {
                    UserId = table.Column<Guid>(type: "RAW(16)", nullable: false),
                    RoleId = table.Column<Guid>(type: "RAW(16)", nullable: false),
                    Id = table.Column<Guid>(type: "RAW(16)", nullable: false),
                    CreatedBy = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: false),
                    LastModifiedBy = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    LastModifiedOn = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: false)
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

            migrationBuilder.CreateIndex(
                name: "IX_Attachment_TicketDetailId",
                table: "Attachment",
                column: "TicketDetailId");

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
                name: "Attachment");

            migrationBuilder.DropTable(
                name: "MenuItemRole");

            migrationBuilder.DropTable(
                name: "Ticket");

            migrationBuilder.DropTable(
                name: "UserRole");

            migrationBuilder.DropTable(
                name: "TicketDetail");

            migrationBuilder.DropTable(
                name: "MenuItem");

            migrationBuilder.DropTable(
                name: "Role");

            migrationBuilder.DropTable(
                name: "User");
        }
    }
}
