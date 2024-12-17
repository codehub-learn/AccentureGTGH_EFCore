using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AccentureGTGH_EFCore.Migrations
{
    /// <inheritdoc />
    public partial class authospubiishers : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AuthorPublisher_Authors_AuthorId",
                table: "AuthorPublisher");

            migrationBuilder.DropForeignKey(
                name: "FK_AuthorPublisher_Publishers_PublisherPublisherKey",
                table: "AuthorPublisher");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AuthorPublisher",
                table: "AuthorPublisher");

            migrationBuilder.RenameTable(
                name: "AuthorPublisher",
                newName: "AuthorPublishers");

            migrationBuilder.RenameIndex(
                name: "IX_AuthorPublisher_PublisherPublisherKey",
                table: "AuthorPublishers",
                newName: "IX_AuthorPublishers_PublisherPublisherKey");

            migrationBuilder.AlterColumn<DateTime>(
                name: "StartDate",
                table: "AuthorPublishers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 12, 17, 13, 39, 29, 67, DateTimeKind.Utc).AddTicks(7661),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 12, 17, 13, 37, 55, 770, DateTimeKind.Utc).AddTicks(9015));

            migrationBuilder.AddPrimaryKey(
                name: "PK_AuthorPublishers",
                table: "AuthorPublishers",
                columns: new[] { "AuthorId", "PublisherPublisherKey" });

            migrationBuilder.AddForeignKey(
                name: "FK_AuthorPublishers_Authors_AuthorId",
                table: "AuthorPublishers",
                column: "AuthorId",
                principalTable: "Authors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AuthorPublishers_Publishers_PublisherPublisherKey",
                table: "AuthorPublishers",
                column: "PublisherPublisherKey",
                principalTable: "Publishers",
                principalColumn: "PublisherKey",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AuthorPublishers_Authors_AuthorId",
                table: "AuthorPublishers");

            migrationBuilder.DropForeignKey(
                name: "FK_AuthorPublishers_Publishers_PublisherPublisherKey",
                table: "AuthorPublishers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AuthorPublishers",
                table: "AuthorPublishers");

            migrationBuilder.RenameTable(
                name: "AuthorPublishers",
                newName: "AuthorPublisher");

            migrationBuilder.RenameIndex(
                name: "IX_AuthorPublishers_PublisherPublisherKey",
                table: "AuthorPublisher",
                newName: "IX_AuthorPublisher_PublisherPublisherKey");

            migrationBuilder.AlterColumn<DateTime>(
                name: "StartDate",
                table: "AuthorPublisher",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 12, 17, 13, 37, 55, 770, DateTimeKind.Utc).AddTicks(9015),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 12, 17, 13, 39, 29, 67, DateTimeKind.Utc).AddTicks(7661));

            migrationBuilder.AddPrimaryKey(
                name: "PK_AuthorPublisher",
                table: "AuthorPublisher",
                columns: new[] { "AuthorId", "PublisherPublisherKey" });

            migrationBuilder.AddForeignKey(
                name: "FK_AuthorPublisher_Authors_AuthorId",
                table: "AuthorPublisher",
                column: "AuthorId",
                principalTable: "Authors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AuthorPublisher_Publishers_PublisherPublisherKey",
                table: "AuthorPublisher",
                column: "PublisherPublisherKey",
                principalTable: "Publishers",
                principalColumn: "PublisherKey",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
