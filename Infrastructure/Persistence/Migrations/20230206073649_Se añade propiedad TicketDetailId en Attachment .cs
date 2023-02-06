using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Persistence.Migrations
{
    public partial class SeañadepropiedadTicketDetailIdenAttachment : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Attachment_TicketDetail_TicketDetailId",
                table: "Attachment");

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModifiedOn",
                table: "UserRole",
                type: "TIMESTAMP(7)",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 6, 2, 36, 48, 685, DateTimeKind.Local).AddTicks(1505),
                oldClrType: typeof(DateTime),
                oldType: "TIMESTAMP(7)",
                oldDefaultValue: new DateTime(2023, 2, 6, 2, 25, 40, 592, DateTimeKind.Local).AddTicks(2623));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "UserRole",
                type: "TIMESTAMP(7)",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 6, 2, 36, 48, 685, DateTimeKind.Local).AddTicks(1156),
                oldClrType: typeof(DateTime),
                oldType: "TIMESTAMP(7)",
                oldDefaultValue: new DateTime(2023, 2, 6, 2, 25, 40, 592, DateTimeKind.Local).AddTicks(2252));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModifiedOn",
                table: "User",
                type: "TIMESTAMP(7)",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 6, 2, 36, 48, 685, DateTimeKind.Local).AddTicks(797),
                oldClrType: typeof(DateTime),
                oldType: "TIMESTAMP(7)",
                oldDefaultValue: new DateTime(2023, 2, 6, 2, 25, 40, 592, DateTimeKind.Local).AddTicks(1918));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "User",
                type: "TIMESTAMP(7)",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 6, 2, 36, 48, 685, DateTimeKind.Local).AddTicks(441),
                oldClrType: typeof(DateTime),
                oldType: "TIMESTAMP(7)",
                oldDefaultValue: new DateTime(2023, 2, 6, 2, 25, 40, 592, DateTimeKind.Local).AddTicks(1571));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModifiedOn",
                table: "TicketStatus",
                type: "TIMESTAMP(7)",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 6, 2, 36, 48, 685, DateTimeKind.Local).AddTicks(73),
                oldClrType: typeof(DateTime),
                oldType: "TIMESTAMP(7)",
                oldDefaultValue: new DateTime(2023, 2, 6, 2, 25, 40, 592, DateTimeKind.Local).AddTicks(1238));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "TicketStatus",
                type: "TIMESTAMP(7)",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 6, 2, 36, 48, 684, DateTimeKind.Local).AddTicks(9676),
                oldClrType: typeof(DateTime),
                oldType: "TIMESTAMP(7)",
                oldDefaultValue: new DateTime(2023, 2, 6, 2, 25, 40, 592, DateTimeKind.Local).AddTicks(900));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModifiedOn",
                table: "Role",
                type: "TIMESTAMP(7)",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 6, 2, 36, 48, 684, DateTimeKind.Local).AddTicks(9335),
                oldClrType: typeof(DateTime),
                oldType: "TIMESTAMP(7)",
                oldDefaultValue: new DateTime(2023, 2, 6, 2, 25, 40, 592, DateTimeKind.Local).AddTicks(574));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Role",
                type: "TIMESTAMP(7)",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 6, 2, 36, 48, 684, DateTimeKind.Local).AddTicks(8976),
                oldClrType: typeof(DateTime),
                oldType: "TIMESTAMP(7)",
                oldDefaultValue: new DateTime(2023, 2, 6, 2, 25, 40, 592, DateTimeKind.Local).AddTicks(277));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModifiedOn",
                table: "MenuItemRole",
                type: "TIMESTAMP(7)",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 6, 2, 36, 48, 684, DateTimeKind.Local).AddTicks(8586),
                oldClrType: typeof(DateTime),
                oldType: "TIMESTAMP(7)",
                oldDefaultValue: new DateTime(2023, 2, 6, 2, 25, 40, 591, DateTimeKind.Local).AddTicks(9834));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "MenuItemRole",
                type: "TIMESTAMP(7)",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 6, 2, 36, 48, 684, DateTimeKind.Local).AddTicks(8008),
                oldClrType: typeof(DateTime),
                oldType: "TIMESTAMP(7)",
                oldDefaultValue: new DateTime(2023, 2, 6, 2, 25, 40, 591, DateTimeKind.Local).AddTicks(9445));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModifiedOn",
                table: "MenuItem",
                type: "TIMESTAMP(7)",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 6, 2, 36, 48, 684, DateTimeKind.Local).AddTicks(7595),
                oldClrType: typeof(DateTime),
                oldType: "TIMESTAMP(7)",
                oldDefaultValue: new DateTime(2023, 2, 6, 2, 25, 40, 591, DateTimeKind.Local).AddTicks(8922));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "MenuItem",
                type: "TIMESTAMP(7)",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 6, 2, 36, 48, 684, DateTimeKind.Local).AddTicks(7000),
                oldClrType: typeof(DateTime),
                oldType: "TIMESTAMP(7)",
                oldDefaultValue: new DateTime(2023, 2, 6, 2, 25, 40, 591, DateTimeKind.Local).AddTicks(8448));

            migrationBuilder.AlterColumn<Guid>(
                name: "TicketDetailId",
                table: "Attachment",
                type: "RAW(16)",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "RAW(16)",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: new Guid("504731d4-0a34-41d5-9b0b-0611b3f76096"),
                column: "CreatedOn",
                value: new DateTime(2023, 2, 6, 2, 36, 48, 681, DateTimeKind.Local).AddTicks(8094));

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: new Guid("504731d4-0a34-41d5-9b0b-0611b3f76098"),
                column: "CreatedOn",
                value: new DateTime(2023, 2, 6, 2, 36, 48, 681, DateTimeKind.Local).AddTicks(8136));

            migrationBuilder.UpdateData(
                table: "TicketStatus",
                keyColumn: "Id",
                keyValue: new Guid("504731d4-0a34-41d5-9b0b-0611b3f76777"),
                column: "CreatedOn",
                value: new DateTime(2023, 2, 6, 2, 36, 48, 684, DateTimeKind.Local).AddTicks(6147));

            migrationBuilder.AddForeignKey(
                name: "FK_Attachment_TicketDetail_TicketDetailId",
                table: "Attachment",
                column: "TicketDetailId",
                principalTable: "TicketDetail",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Attachment_TicketDetail_TicketDetailId",
                table: "Attachment");

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModifiedOn",
                table: "UserRole",
                type: "TIMESTAMP(7)",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 6, 2, 25, 40, 592, DateTimeKind.Local).AddTicks(2623),
                oldClrType: typeof(DateTime),
                oldType: "TIMESTAMP(7)",
                oldDefaultValue: new DateTime(2023, 2, 6, 2, 36, 48, 685, DateTimeKind.Local).AddTicks(1505));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "UserRole",
                type: "TIMESTAMP(7)",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 6, 2, 25, 40, 592, DateTimeKind.Local).AddTicks(2252),
                oldClrType: typeof(DateTime),
                oldType: "TIMESTAMP(7)",
                oldDefaultValue: new DateTime(2023, 2, 6, 2, 36, 48, 685, DateTimeKind.Local).AddTicks(1156));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModifiedOn",
                table: "User",
                type: "TIMESTAMP(7)",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 6, 2, 25, 40, 592, DateTimeKind.Local).AddTicks(1918),
                oldClrType: typeof(DateTime),
                oldType: "TIMESTAMP(7)",
                oldDefaultValue: new DateTime(2023, 2, 6, 2, 36, 48, 685, DateTimeKind.Local).AddTicks(797));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "User",
                type: "TIMESTAMP(7)",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 6, 2, 25, 40, 592, DateTimeKind.Local).AddTicks(1571),
                oldClrType: typeof(DateTime),
                oldType: "TIMESTAMP(7)",
                oldDefaultValue: new DateTime(2023, 2, 6, 2, 36, 48, 685, DateTimeKind.Local).AddTicks(441));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModifiedOn",
                table: "TicketStatus",
                type: "TIMESTAMP(7)",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 6, 2, 25, 40, 592, DateTimeKind.Local).AddTicks(1238),
                oldClrType: typeof(DateTime),
                oldType: "TIMESTAMP(7)",
                oldDefaultValue: new DateTime(2023, 2, 6, 2, 36, 48, 685, DateTimeKind.Local).AddTicks(73));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "TicketStatus",
                type: "TIMESTAMP(7)",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 6, 2, 25, 40, 592, DateTimeKind.Local).AddTicks(900),
                oldClrType: typeof(DateTime),
                oldType: "TIMESTAMP(7)",
                oldDefaultValue: new DateTime(2023, 2, 6, 2, 36, 48, 684, DateTimeKind.Local).AddTicks(9676));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModifiedOn",
                table: "Role",
                type: "TIMESTAMP(7)",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 6, 2, 25, 40, 592, DateTimeKind.Local).AddTicks(574),
                oldClrType: typeof(DateTime),
                oldType: "TIMESTAMP(7)",
                oldDefaultValue: new DateTime(2023, 2, 6, 2, 36, 48, 684, DateTimeKind.Local).AddTicks(9335));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Role",
                type: "TIMESTAMP(7)",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 6, 2, 25, 40, 592, DateTimeKind.Local).AddTicks(277),
                oldClrType: typeof(DateTime),
                oldType: "TIMESTAMP(7)",
                oldDefaultValue: new DateTime(2023, 2, 6, 2, 36, 48, 684, DateTimeKind.Local).AddTicks(8976));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModifiedOn",
                table: "MenuItemRole",
                type: "TIMESTAMP(7)",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 6, 2, 25, 40, 591, DateTimeKind.Local).AddTicks(9834),
                oldClrType: typeof(DateTime),
                oldType: "TIMESTAMP(7)",
                oldDefaultValue: new DateTime(2023, 2, 6, 2, 36, 48, 684, DateTimeKind.Local).AddTicks(8586));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "MenuItemRole",
                type: "TIMESTAMP(7)",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 6, 2, 25, 40, 591, DateTimeKind.Local).AddTicks(9445),
                oldClrType: typeof(DateTime),
                oldType: "TIMESTAMP(7)",
                oldDefaultValue: new DateTime(2023, 2, 6, 2, 36, 48, 684, DateTimeKind.Local).AddTicks(8008));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModifiedOn",
                table: "MenuItem",
                type: "TIMESTAMP(7)",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 6, 2, 25, 40, 591, DateTimeKind.Local).AddTicks(8922),
                oldClrType: typeof(DateTime),
                oldType: "TIMESTAMP(7)",
                oldDefaultValue: new DateTime(2023, 2, 6, 2, 36, 48, 684, DateTimeKind.Local).AddTicks(7595));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "MenuItem",
                type: "TIMESTAMP(7)",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 6, 2, 25, 40, 591, DateTimeKind.Local).AddTicks(8448),
                oldClrType: typeof(DateTime),
                oldType: "TIMESTAMP(7)",
                oldDefaultValue: new DateTime(2023, 2, 6, 2, 36, 48, 684, DateTimeKind.Local).AddTicks(7000));

            migrationBuilder.AlterColumn<Guid>(
                name: "TicketDetailId",
                table: "Attachment",
                type: "RAW(16)",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "RAW(16)");

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: new Guid("504731d4-0a34-41d5-9b0b-0611b3f76096"),
                column: "CreatedOn",
                value: new DateTime(2023, 2, 6, 2, 25, 40, 589, DateTimeKind.Local).AddTicks(7039));

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: new Guid("504731d4-0a34-41d5-9b0b-0611b3f76098"),
                column: "CreatedOn",
                value: new DateTime(2023, 2, 6, 2, 25, 40, 589, DateTimeKind.Local).AddTicks(7081));

            migrationBuilder.UpdateData(
                table: "TicketStatus",
                keyColumn: "Id",
                keyValue: new Guid("504731d4-0a34-41d5-9b0b-0611b3f76777"),
                column: "CreatedOn",
                value: new DateTime(2023, 2, 6, 2, 25, 40, 591, DateTimeKind.Local).AddTicks(7814));

            migrationBuilder.AddForeignKey(
                name: "FK_Attachment_TicketDetail_TicketDetailId",
                table: "Attachment",
                column: "TicketDetailId",
                principalTable: "TicketDetail",
                principalColumn: "Id");
        }
    }
}
