using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UniversoGeek.Infra.Data.Migrations
{
    /// <inheritdoc />
    public partial class ADDPassword : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "DateRegister",
                table: "ug_Product",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 6, 6, 16, 33, 47, 456, DateTimeKind.Local).AddTicks(8416),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 6, 5, 18, 52, 24, 108, DateTimeKind.Local).AddTicks(9345));

            migrationBuilder.AddColumn<string>(
                name: "Password",
                table: "ug_Client",
                type: "nvarchar(14)",
                maxLength: 14,
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Password",
                table: "ug_Client");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateRegister",
                table: "ug_Product",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 6, 5, 18, 52, 24, 108, DateTimeKind.Local).AddTicks(9345),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 6, 6, 16, 33, 47, 456, DateTimeKind.Local).AddTicks(8416));
        }
    }
}
