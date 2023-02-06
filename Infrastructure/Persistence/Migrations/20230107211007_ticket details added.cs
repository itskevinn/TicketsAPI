#nullable disable

using Microsoft.EntityFrameworkCore.Migrations;

namespace Infrastructure.Persistence.Migrations
{
    public partial class ticketdetailsadded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModifiedOn",
                table: "UserRole",
                type: "TIMESTAMP(7)",
                nullable: false,
                defaultValue: new DateTime(2023, 1, 7, 16, 10, 7, 91, DateTimeKind.Local).AddTicks(1747),
                oldClrType: typeof(DateTime),
                oldType: "TIMESTAMP(7)",
                oldDefaultValue: new DateTime(2022, 12, 27, 17, 31, 53, 700, DateTimeKind.Local).AddTicks(3138));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "UserRole",
                type: "TIMESTAMP(7)",
                nullable: false,
                defaultValue: new DateTime(2023, 1, 7, 16, 10, 7, 91, DateTimeKind.Local).AddTicks(1495),
                oldClrType: typeof(DateTime),
                oldType: "TIMESTAMP(7)",
                oldDefaultValue: new DateTime(2022, 12, 27, 17, 31, 53, 700, DateTimeKind.Local).AddTicks(2836));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModifiedOn",
                table: "User",
                type: "TIMESTAMP(7)",
                nullable: false,
                defaultValue: new DateTime(2023, 1, 7, 16, 10, 7, 91, DateTimeKind.Local).AddTicks(1271),
                oldClrType: typeof(DateTime),
                oldType: "TIMESTAMP(7)",
                oldDefaultValue: new DateTime(2022, 12, 27, 17, 31, 53, 700, DateTimeKind.Local).AddTicks(2614));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "User",
                type: "TIMESTAMP(7)",
                nullable: false,
                defaultValue: new DateTime(2023, 1, 7, 16, 10, 7, 91, DateTimeKind.Local).AddTicks(1056),
                oldClrType: typeof(DateTime),
                oldType: "TIMESTAMP(7)",
                oldDefaultValue: new DateTime(2022, 12, 27, 17, 31, 53, 700, DateTimeKind.Local).AddTicks(2406));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModifiedOn",
                table: "TicketStatus",
                type: "TIMESTAMP(7)",
                nullable: false,
                defaultValue: new DateTime(2023, 1, 7, 16, 10, 7, 91, DateTimeKind.Local).AddTicks(832),
                oldClrType: typeof(DateTime),
                oldType: "TIMESTAMP(7)",
                oldDefaultValue: new DateTime(2022, 12, 27, 17, 31, 53, 700, DateTimeKind.Local).AddTicks(2189));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "TicketStatus",
                type: "TIMESTAMP(7)",
                nullable: false,
                defaultValue: new DateTime(2023, 1, 7, 16, 10, 7, 91, DateTimeKind.Local).AddTicks(622),
                oldClrType: typeof(DateTime),
                oldType: "TIMESTAMP(7)",
                oldDefaultValue: new DateTime(2022, 12, 27, 17, 31, 53, 700, DateTimeKind.Local).AddTicks(1962));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModifiedOn",
                table: "Role",
                type: "TIMESTAMP(7)",
                nullable: false,
                defaultValue: new DateTime(2023, 1, 7, 16, 10, 7, 91, DateTimeKind.Local).AddTicks(408),
                oldClrType: typeof(DateTime),
                oldType: "TIMESTAMP(7)",
                oldDefaultValue: new DateTime(2022, 12, 27, 17, 31, 53, 700, DateTimeKind.Local).AddTicks(1641));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Role",
                type: "TIMESTAMP(7)",
                nullable: false,
                defaultValue: new DateTime(2023, 1, 7, 16, 10, 7, 91, DateTimeKind.Local).AddTicks(224),
                oldClrType: typeof(DateTime),
                oldType: "TIMESTAMP(7)",
                oldDefaultValue: new DateTime(2022, 12, 27, 17, 31, 53, 700, DateTimeKind.Local).AddTicks(1454));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModifiedOn",
                table: "MenuItemRole",
                type: "TIMESTAMP(7)",
                nullable: false,
                defaultValue: new DateTime(2023, 1, 7, 16, 10, 7, 90, DateTimeKind.Local).AddTicks(9950),
                oldClrType: typeof(DateTime),
                oldType: "TIMESTAMP(7)",
                oldDefaultValue: new DateTime(2022, 12, 27, 17, 31, 53, 700, DateTimeKind.Local).AddTicks(1180));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "MenuItemRole",
                type: "TIMESTAMP(7)",
                nullable: false,
                defaultValue: new DateTime(2023, 1, 7, 16, 10, 7, 90, DateTimeKind.Local).AddTicks(9687),
                oldClrType: typeof(DateTime),
                oldType: "TIMESTAMP(7)",
                oldDefaultValue: new DateTime(2022, 12, 27, 17, 31, 53, 700, DateTimeKind.Local).AddTicks(958));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModifiedOn",
                table: "MenuItem",
                type: "TIMESTAMP(7)",
                nullable: false,
                defaultValue: new DateTime(2023, 1, 7, 16, 10, 7, 90, DateTimeKind.Local).AddTicks(9355),
                oldClrType: typeof(DateTime),
                oldType: "TIMESTAMP(7)",
                oldDefaultValue: new DateTime(2022, 12, 27, 17, 31, 53, 700, DateTimeKind.Local).AddTicks(669));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "MenuItem",
                type: "TIMESTAMP(7)",
                nullable: false,
                defaultValue: new DateTime(2023, 1, 7, 16, 10, 7, 90, DateTimeKind.Local).AddTicks(9036),
                oldClrType: typeof(DateTime),
                oldType: "TIMESTAMP(7)",
                oldDefaultValue: new DateTime(2022, 12, 27, 17, 31, 53, 700, DateTimeKind.Local).AddTicks(391));

            migrationBuilder.CreateTable(
                name: "TicketDetail",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "RAW(16)", nullable: false),
                    TicketId = table.Column<Guid>(type: "RAW(16)", nullable: false),
                    Message = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    CreatedBy = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: false),
                    LastModifiedBy = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    LastModifiedOn = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: false),
                    Status = table.Column<bool>(type: "NUMBER(1)", nullable: false)
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
                    Url = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    TicketDetailId = table.Column<Guid>(type: "RAW(16)", nullable: true),
                    CreatedBy = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: false),
                    LastModifiedBy = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    LastModifiedOn = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: false),
                    Status = table.Column<bool>(type: "NUMBER(1)", nullable: false)
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

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: new Guid("504731d4-0a34-41d5-9b0b-0611b3f76096"),
                column: "CreatedOn",
                value: new DateTime(2023, 1, 7, 16, 10, 7, 89, DateTimeKind.Local).AddTicks(5956));

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: new Guid("504731d4-0a34-41d5-9b0b-0611b3f76098"),
                column: "CreatedOn",
                value: new DateTime(2023, 1, 7, 16, 10, 7, 89, DateTimeKind.Local).AddTicks(5975));

            migrationBuilder.UpdateData(
                table: "TicketStatus",
                keyColumn: "Id",
                keyValue: new Guid("504731d4-0a34-41d5-9b0b-0611b3f76777"),
                column: "CreatedOn",
                value: new DateTime(2023, 1, 7, 16, 10, 7, 90, DateTimeKind.Local).AddTicks(8775));

            migrationBuilder.CreateIndex(
                name: "IX_Attachment_TicketDetailId",
                table: "Attachment",
                column: "TicketDetailId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Attachment");

            migrationBuilder.DropTable(
                name: "TicketDetail");

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModifiedOn",
                table: "UserRole",
                type: "TIMESTAMP(7)",
                nullable: false,
                defaultValue: new DateTime(2022, 12, 27, 17, 31, 53, 700, DateTimeKind.Local).AddTicks(3138),
                oldClrType: typeof(DateTime),
                oldType: "TIMESTAMP(7)",
                oldDefaultValue: new DateTime(2023, 1, 7, 16, 10, 7, 91, DateTimeKind.Local).AddTicks(1747));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "UserRole",
                type: "TIMESTAMP(7)",
                nullable: false,
                defaultValue: new DateTime(2022, 12, 27, 17, 31, 53, 700, DateTimeKind.Local).AddTicks(2836),
                oldClrType: typeof(DateTime),
                oldType: "TIMESTAMP(7)",
                oldDefaultValue: new DateTime(2023, 1, 7, 16, 10, 7, 91, DateTimeKind.Local).AddTicks(1495));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModifiedOn",
                table: "User",
                type: "TIMESTAMP(7)",
                nullable: false,
                defaultValue: new DateTime(2022, 12, 27, 17, 31, 53, 700, DateTimeKind.Local).AddTicks(2614),
                oldClrType: typeof(DateTime),
                oldType: "TIMESTAMP(7)",
                oldDefaultValue: new DateTime(2023, 1, 7, 16, 10, 7, 91, DateTimeKind.Local).AddTicks(1271));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "User",
                type: "TIMESTAMP(7)",
                nullable: false,
                defaultValue: new DateTime(2022, 12, 27, 17, 31, 53, 700, DateTimeKind.Local).AddTicks(2406),
                oldClrType: typeof(DateTime),
                oldType: "TIMESTAMP(7)",
                oldDefaultValue: new DateTime(2023, 1, 7, 16, 10, 7, 91, DateTimeKind.Local).AddTicks(1056));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModifiedOn",
                table: "TicketStatus",
                type: "TIMESTAMP(7)",
                nullable: false,
                defaultValue: new DateTime(2022, 12, 27, 17, 31, 53, 700, DateTimeKind.Local).AddTicks(2189),
                oldClrType: typeof(DateTime),
                oldType: "TIMESTAMP(7)",
                oldDefaultValue: new DateTime(2023, 1, 7, 16, 10, 7, 91, DateTimeKind.Local).AddTicks(832));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "TicketStatus",
                type: "TIMESTAMP(7)",
                nullable: false,
                defaultValue: new DateTime(2022, 12, 27, 17, 31, 53, 700, DateTimeKind.Local).AddTicks(1962),
                oldClrType: typeof(DateTime),
                oldType: "TIMESTAMP(7)",
                oldDefaultValue: new DateTime(2023, 1, 7, 16, 10, 7, 91, DateTimeKind.Local).AddTicks(622));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModifiedOn",
                table: "Role",
                type: "TIMESTAMP(7)",
                nullable: false,
                defaultValue: new DateTime(2022, 12, 27, 17, 31, 53, 700, DateTimeKind.Local).AddTicks(1641),
                oldClrType: typeof(DateTime),
                oldType: "TIMESTAMP(7)",
                oldDefaultValue: new DateTime(2023, 1, 7, 16, 10, 7, 91, DateTimeKind.Local).AddTicks(408));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Role",
                type: "TIMESTAMP(7)",
                nullable: false,
                defaultValue: new DateTime(2022, 12, 27, 17, 31, 53, 700, DateTimeKind.Local).AddTicks(1454),
                oldClrType: typeof(DateTime),
                oldType: "TIMESTAMP(7)",
                oldDefaultValue: new DateTime(2023, 1, 7, 16, 10, 7, 91, DateTimeKind.Local).AddTicks(224));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModifiedOn",
                table: "MenuItemRole",
                type: "TIMESTAMP(7)",
                nullable: false,
                defaultValue: new DateTime(2022, 12, 27, 17, 31, 53, 700, DateTimeKind.Local).AddTicks(1180),
                oldClrType: typeof(DateTime),
                oldType: "TIMESTAMP(7)",
                oldDefaultValue: new DateTime(2023, 1, 7, 16, 10, 7, 90, DateTimeKind.Local).AddTicks(9950));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "MenuItemRole",
                type: "TIMESTAMP(7)",
                nullable: false,
                defaultValue: new DateTime(2022, 12, 27, 17, 31, 53, 700, DateTimeKind.Local).AddTicks(958),
                oldClrType: typeof(DateTime),
                oldType: "TIMESTAMP(7)",
                oldDefaultValue: new DateTime(2023, 1, 7, 16, 10, 7, 90, DateTimeKind.Local).AddTicks(9687));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModifiedOn",
                table: "MenuItem",
                type: "TIMESTAMP(7)",
                nullable: false,
                defaultValue: new DateTime(2022, 12, 27, 17, 31, 53, 700, DateTimeKind.Local).AddTicks(669),
                oldClrType: typeof(DateTime),
                oldType: "TIMESTAMP(7)",
                oldDefaultValue: new DateTime(2023, 1, 7, 16, 10, 7, 90, DateTimeKind.Local).AddTicks(9355));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "MenuItem",
                type: "TIMESTAMP(7)",
                nullable: false,
                defaultValue: new DateTime(2022, 12, 27, 17, 31, 53, 700, DateTimeKind.Local).AddTicks(391),
                oldClrType: typeof(DateTime),
                oldType: "TIMESTAMP(7)",
                oldDefaultValue: new DateTime(2023, 1, 7, 16, 10, 7, 90, DateTimeKind.Local).AddTicks(9036));

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: new Guid("504731d4-0a34-41d5-9b0b-0611b3f76096"),
                column: "CreatedOn",
                value: new DateTime(2022, 12, 27, 17, 31, 53, 698, DateTimeKind.Local).AddTicks(8239));

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: new Guid("504731d4-0a34-41d5-9b0b-0611b3f76098"),
                column: "CreatedOn",
                value: new DateTime(2022, 12, 27, 17, 31, 53, 698, DateTimeKind.Local).AddTicks(8262));

            migrationBuilder.UpdateData(
                table: "TicketStatus",
                keyColumn: "Id",
                keyValue: new Guid("504731d4-0a34-41d5-9b0b-0611b3f76777"),
                column: "CreatedOn",
                value: new DateTime(2022, 12, 27, 17, 31, 53, 700, DateTimeKind.Local).AddTicks(195));
        }
    }
}
