#nullable disable

using Microsoft.EntityFrameworkCore.Migrations;

namespace Infrastructure.Persistence.Migrations
{
    public partial class Ticketdetailsaddedtoticketentity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModifiedOn",
                table: "UserRole",
                type: "TIMESTAMP(7)",
                nullable: false,
                defaultValue: new DateTime(2023, 1, 7, 20, 50, 44, 738, DateTimeKind.Local).AddTicks(9973),
                oldClrType: typeof(DateTime),
                oldType: "TIMESTAMP(7)",
                oldDefaultValue: new DateTime(2023, 1, 7, 16, 10, 7, 91, DateTimeKind.Local).AddTicks(1747));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "UserRole",
                type: "TIMESTAMP(7)",
                nullable: false,
                defaultValue: new DateTime(2023, 1, 7, 20, 50, 44, 738, DateTimeKind.Local).AddTicks(9732),
                oldClrType: typeof(DateTime),
                oldType: "TIMESTAMP(7)",
                oldDefaultValue: new DateTime(2023, 1, 7, 16, 10, 7, 91, DateTimeKind.Local).AddTicks(1495));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModifiedOn",
                table: "User",
                type: "TIMESTAMP(7)",
                nullable: false,
                defaultValue: new DateTime(2023, 1, 7, 20, 50, 44, 738, DateTimeKind.Local).AddTicks(9510),
                oldClrType: typeof(DateTime),
                oldType: "TIMESTAMP(7)",
                oldDefaultValue: new DateTime(2023, 1, 7, 16, 10, 7, 91, DateTimeKind.Local).AddTicks(1271));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "User",
                type: "TIMESTAMP(7)",
                nullable: false,
                defaultValue: new DateTime(2023, 1, 7, 20, 50, 44, 738, DateTimeKind.Local).AddTicks(9290),
                oldClrType: typeof(DateTime),
                oldType: "TIMESTAMP(7)",
                oldDefaultValue: new DateTime(2023, 1, 7, 16, 10, 7, 91, DateTimeKind.Local).AddTicks(1056));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModifiedOn",
                table: "TicketStatus",
                type: "TIMESTAMP(7)",
                nullable: false,
                defaultValue: new DateTime(2023, 1, 7, 20, 50, 44, 738, DateTimeKind.Local).AddTicks(9051),
                oldClrType: typeof(DateTime),
                oldType: "TIMESTAMP(7)",
                oldDefaultValue: new DateTime(2023, 1, 7, 16, 10, 7, 91, DateTimeKind.Local).AddTicks(832));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "TicketStatus",
                type: "TIMESTAMP(7)",
                nullable: false,
                defaultValue: new DateTime(2023, 1, 7, 20, 50, 44, 738, DateTimeKind.Local).AddTicks(8878),
                oldClrType: typeof(DateTime),
                oldType: "TIMESTAMP(7)",
                oldDefaultValue: new DateTime(2023, 1, 7, 16, 10, 7, 91, DateTimeKind.Local).AddTicks(622));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModifiedOn",
                table: "Role",
                type: "TIMESTAMP(7)",
                nullable: false,
                defaultValue: new DateTime(2023, 1, 7, 20, 50, 44, 738, DateTimeKind.Local).AddTicks(8626),
                oldClrType: typeof(DateTime),
                oldType: "TIMESTAMP(7)",
                oldDefaultValue: new DateTime(2023, 1, 7, 16, 10, 7, 91, DateTimeKind.Local).AddTicks(408));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Role",
                type: "TIMESTAMP(7)",
                nullable: false,
                defaultValue: new DateTime(2023, 1, 7, 20, 50, 44, 738, DateTimeKind.Local).AddTicks(8437),
                oldClrType: typeof(DateTime),
                oldType: "TIMESTAMP(7)",
                oldDefaultValue: new DateTime(2023, 1, 7, 16, 10, 7, 91, DateTimeKind.Local).AddTicks(224));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModifiedOn",
                table: "MenuItemRole",
                type: "TIMESTAMP(7)",
                nullable: false,
                defaultValue: new DateTime(2023, 1, 7, 20, 50, 44, 738, DateTimeKind.Local).AddTicks(8124),
                oldClrType: typeof(DateTime),
                oldType: "TIMESTAMP(7)",
                oldDefaultValue: new DateTime(2023, 1, 7, 16, 10, 7, 90, DateTimeKind.Local).AddTicks(9950));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "MenuItemRole",
                type: "TIMESTAMP(7)",
                nullable: false,
                defaultValue: new DateTime(2023, 1, 7, 20, 50, 44, 738, DateTimeKind.Local).AddTicks(7891),
                oldClrType: typeof(DateTime),
                oldType: "TIMESTAMP(7)",
                oldDefaultValue: new DateTime(2023, 1, 7, 16, 10, 7, 90, DateTimeKind.Local).AddTicks(9687));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModifiedOn",
                table: "MenuItem",
                type: "TIMESTAMP(7)",
                nullable: false,
                defaultValue: new DateTime(2023, 1, 7, 20, 50, 44, 738, DateTimeKind.Local).AddTicks(7590),
                oldClrType: typeof(DateTime),
                oldType: "TIMESTAMP(7)",
                oldDefaultValue: new DateTime(2023, 1, 7, 16, 10, 7, 90, DateTimeKind.Local).AddTicks(9355));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "MenuItem",
                type: "TIMESTAMP(7)",
                nullable: false,
                defaultValue: new DateTime(2023, 1, 7, 20, 50, 44, 738, DateTimeKind.Local).AddTicks(7288),
                oldClrType: typeof(DateTime),
                oldType: "TIMESTAMP(7)",
                oldDefaultValue: new DateTime(2023, 1, 7, 16, 10, 7, 90, DateTimeKind.Local).AddTicks(9036));

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: new Guid("504731d4-0a34-41d5-9b0b-0611b3f76096"),
                column: "CreatedOn",
                value: new DateTime(2023, 1, 7, 20, 50, 44, 737, DateTimeKind.Local).AddTicks(2468));

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: new Guid("504731d4-0a34-41d5-9b0b-0611b3f76098"),
                column: "CreatedOn",
                value: new DateTime(2023, 1, 7, 20, 50, 44, 737, DateTimeKind.Local).AddTicks(2503));

            migrationBuilder.UpdateData(
                table: "TicketStatus",
                keyColumn: "Id",
                keyValue: new Guid("504731d4-0a34-41d5-9b0b-0611b3f76777"),
                column: "CreatedOn",
                value: new DateTime(2023, 1, 7, 20, 50, 44, 738, DateTimeKind.Local).AddTicks(6930));

            migrationBuilder.CreateIndex(
                name: "IX_TicketDetail_TicketId",
                table: "TicketDetail",
                column: "TicketId");

            migrationBuilder.AddForeignKey(
                name: "FK_TicketDetail_Ticket_TicketId",
                table: "TicketDetail",
                column: "TicketId",
                principalTable: "Ticket",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TicketDetail_Ticket_TicketId",
                table: "TicketDetail");

            migrationBuilder.DropIndex(
                name: "IX_TicketDetail_TicketId",
                table: "TicketDetail");

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModifiedOn",
                table: "UserRole",
                type: "TIMESTAMP(7)",
                nullable: false,
                defaultValue: new DateTime(2023, 1, 7, 16, 10, 7, 91, DateTimeKind.Local).AddTicks(1747),
                oldClrType: typeof(DateTime),
                oldType: "TIMESTAMP(7)",
                oldDefaultValue: new DateTime(2023, 1, 7, 20, 50, 44, 738, DateTimeKind.Local).AddTicks(9973));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "UserRole",
                type: "TIMESTAMP(7)",
                nullable: false,
                defaultValue: new DateTime(2023, 1, 7, 16, 10, 7, 91, DateTimeKind.Local).AddTicks(1495),
                oldClrType: typeof(DateTime),
                oldType: "TIMESTAMP(7)",
                oldDefaultValue: new DateTime(2023, 1, 7, 20, 50, 44, 738, DateTimeKind.Local).AddTicks(9732));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModifiedOn",
                table: "User",
                type: "TIMESTAMP(7)",
                nullable: false,
                defaultValue: new DateTime(2023, 1, 7, 16, 10, 7, 91, DateTimeKind.Local).AddTicks(1271),
                oldClrType: typeof(DateTime),
                oldType: "TIMESTAMP(7)",
                oldDefaultValue: new DateTime(2023, 1, 7, 20, 50, 44, 738, DateTimeKind.Local).AddTicks(9510));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "User",
                type: "TIMESTAMP(7)",
                nullable: false,
                defaultValue: new DateTime(2023, 1, 7, 16, 10, 7, 91, DateTimeKind.Local).AddTicks(1056),
                oldClrType: typeof(DateTime),
                oldType: "TIMESTAMP(7)",
                oldDefaultValue: new DateTime(2023, 1, 7, 20, 50, 44, 738, DateTimeKind.Local).AddTicks(9290));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModifiedOn",
                table: "TicketStatus",
                type: "TIMESTAMP(7)",
                nullable: false,
                defaultValue: new DateTime(2023, 1, 7, 16, 10, 7, 91, DateTimeKind.Local).AddTicks(832),
                oldClrType: typeof(DateTime),
                oldType: "TIMESTAMP(7)",
                oldDefaultValue: new DateTime(2023, 1, 7, 20, 50, 44, 738, DateTimeKind.Local).AddTicks(9051));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "TicketStatus",
                type: "TIMESTAMP(7)",
                nullable: false,
                defaultValue: new DateTime(2023, 1, 7, 16, 10, 7, 91, DateTimeKind.Local).AddTicks(622),
                oldClrType: typeof(DateTime),
                oldType: "TIMESTAMP(7)",
                oldDefaultValue: new DateTime(2023, 1, 7, 20, 50, 44, 738, DateTimeKind.Local).AddTicks(8878));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModifiedOn",
                table: "Role",
                type: "TIMESTAMP(7)",
                nullable: false,
                defaultValue: new DateTime(2023, 1, 7, 16, 10, 7, 91, DateTimeKind.Local).AddTicks(408),
                oldClrType: typeof(DateTime),
                oldType: "TIMESTAMP(7)",
                oldDefaultValue: new DateTime(2023, 1, 7, 20, 50, 44, 738, DateTimeKind.Local).AddTicks(8626));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Role",
                type: "TIMESTAMP(7)",
                nullable: false,
                defaultValue: new DateTime(2023, 1, 7, 16, 10, 7, 91, DateTimeKind.Local).AddTicks(224),
                oldClrType: typeof(DateTime),
                oldType: "TIMESTAMP(7)",
                oldDefaultValue: new DateTime(2023, 1, 7, 20, 50, 44, 738, DateTimeKind.Local).AddTicks(8437));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModifiedOn",
                table: "MenuItemRole",
                type: "TIMESTAMP(7)",
                nullable: false,
                defaultValue: new DateTime(2023, 1, 7, 16, 10, 7, 90, DateTimeKind.Local).AddTicks(9950),
                oldClrType: typeof(DateTime),
                oldType: "TIMESTAMP(7)",
                oldDefaultValue: new DateTime(2023, 1, 7, 20, 50, 44, 738, DateTimeKind.Local).AddTicks(8124));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "MenuItemRole",
                type: "TIMESTAMP(7)",
                nullable: false,
                defaultValue: new DateTime(2023, 1, 7, 16, 10, 7, 90, DateTimeKind.Local).AddTicks(9687),
                oldClrType: typeof(DateTime),
                oldType: "TIMESTAMP(7)",
                oldDefaultValue: new DateTime(2023, 1, 7, 20, 50, 44, 738, DateTimeKind.Local).AddTicks(7891));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModifiedOn",
                table: "MenuItem",
                type: "TIMESTAMP(7)",
                nullable: false,
                defaultValue: new DateTime(2023, 1, 7, 16, 10, 7, 90, DateTimeKind.Local).AddTicks(9355),
                oldClrType: typeof(DateTime),
                oldType: "TIMESTAMP(7)",
                oldDefaultValue: new DateTime(2023, 1, 7, 20, 50, 44, 738, DateTimeKind.Local).AddTicks(7590));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "MenuItem",
                type: "TIMESTAMP(7)",
                nullable: false,
                defaultValue: new DateTime(2023, 1, 7, 16, 10, 7, 90, DateTimeKind.Local).AddTicks(9036),
                oldClrType: typeof(DateTime),
                oldType: "TIMESTAMP(7)",
                oldDefaultValue: new DateTime(2023, 1, 7, 20, 50, 44, 738, DateTimeKind.Local).AddTicks(7288));

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
        }
    }
}
