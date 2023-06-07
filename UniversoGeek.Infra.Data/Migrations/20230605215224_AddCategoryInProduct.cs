using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UniversoGeek.Infra.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddCategoryInProduct : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "DateRegister",
                table: "ug_Product",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 6, 5, 18, 52, 24, 108, DateTimeKind.Local).AddTicks(9345),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 6, 5, 18, 29, 12, 4, DateTimeKind.Local).AddTicks(1722));

            migrationBuilder.AddColumn<Guid>(
                name: "CategoryId",
                table: "ug_Product",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CategoryId",
                table: "ug_Product");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateRegister",
                table: "ug_Product",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 6, 5, 18, 29, 12, 4, DateTimeKind.Local).AddTicks(1722),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 6, 5, 18, 52, 24, 108, DateTimeKind.Local).AddTicks(9345));
        }
    }
}
