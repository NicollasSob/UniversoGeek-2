using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UniversoGeek.Infra.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddCategory2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "DateRegister",
                table: "ug_Product",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 6, 5, 18, 29, 12, 4, DateTimeKind.Local).AddTicks(1722),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 6, 5, 18, 27, 43, 437, DateTimeKind.Local).AddTicks(6171));

            migrationBuilder.CreateTable(
                name: "ug_Category",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(240)", maxLength: 240, nullable: false),
                    Active = table.Column<bool>(type: "bit", nullable: false, defaultValue: true),
                    CreatedAt = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    UpdatedAt = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ug_Category", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ug_Category");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateRegister",
                table: "ug_Product",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 6, 5, 18, 27, 43, 437, DateTimeKind.Local).AddTicks(6171),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 6, 5, 18, 29, 12, 4, DateTimeKind.Local).AddTicks(1722));
        }
    }
}
