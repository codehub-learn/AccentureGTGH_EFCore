using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AccentureGTGH_EFCore.Migrations
{
    /// <inheritdoc />
    public partial class publishers2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "StartDate",
                table: "AuthorPublisher",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 12, 17, 13, 37, 55, 770, DateTimeKind.Utc).AddTicks(9015),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 12, 17, 13, 37, 22, 660, DateTimeKind.Utc).AddTicks(7888));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "StartDate",
                table: "AuthorPublisher",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 12, 17, 13, 37, 22, 660, DateTimeKind.Utc).AddTicks(7888),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 12, 17, 13, 37, 55, 770, DateTimeKind.Utc).AddTicks(9015));
        }
    }
}
