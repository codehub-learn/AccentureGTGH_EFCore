using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AccentureGTGH_EFCore.Migrations
{
    /// <inheritdoc />
    public partial class fix : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "StartDate",
                table: "AuthorPublishers",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 12, 17, 13, 39, 29, 67, DateTimeKind.Utc).AddTicks(7661));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "StartDate",
                table: "AuthorPublishers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 12, 17, 13, 39, 29, 67, DateTimeKind.Utc).AddTicks(7661),
                oldClrType: typeof(DateTime),
                oldType: "datetime2");
        }
    }
}
