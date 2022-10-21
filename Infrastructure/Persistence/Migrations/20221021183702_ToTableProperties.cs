using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    public partial class ToTableProperties : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Attachment");

            migrationBuilder.DropTable(
                name: "TicketDetail");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TicketDetail",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "RAW(16)", nullable: false),
                    CreatedBy = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: false),
                    LastModifiedBy = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    LastModifiedOn = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: false),
                    Message = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TicketDetail", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Attachment",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "RAW(16)", nullable: false),
                    CreatedBy = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: false),
                    LastModifiedBy = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    LastModifiedOn = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: false),
                    TicketDetailId = table.Column<Guid>(type: "RAW(16)", nullable: true),
                    Url = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false)
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

            migrationBuilder.CreateIndex(
                name: "IX_Attachment_TicketDetailId",
                table: "Attachment",
                column: "TicketDetailId");
        }
    }
}
