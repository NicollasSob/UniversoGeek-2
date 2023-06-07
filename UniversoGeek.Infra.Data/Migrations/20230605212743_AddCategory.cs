using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UniversoGeek.Infra.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddCategory : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "DateRegister",
                table: "ug_Product",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 6, 5, 18, 27, 43, 437, DateTimeKind.Local).AddTicks(6171),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 5, 31, 18, 33, 55, 568, DateTimeKind.Local).AddTicks(2950));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "DateRegister",
                table: "ug_Product",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 5, 31, 18, 33, 55, 568, DateTimeKind.Local).AddTicks(2950),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 6, 5, 18, 27, 43, 437, DateTimeKind.Local).AddTicks(6171));
        }
    }
}
