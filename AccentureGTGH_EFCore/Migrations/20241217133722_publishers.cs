using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AccentureGTGH_EFCore.Migrations
{
    /// <inheritdoc />
    public partial class publishers : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Publishers",
                columns: table => new
                {
                    PublisherKey = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Language = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Publishers", x => x.PublisherKey);
                });

            migrationBuilder.CreateTable(
                name: "AuthorPublisher",
                columns: table => new
                {
                    AuthorId = table.Column<int>(type: "int", nullable: false),
                    PublisherPublisherKey = table.Column<int>(type: "int", nullable: false),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2024, 12, 17, 13, 37, 22, 660, DateTimeKind.Utc).AddTicks(7888))
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AuthorPublisher", x => new { x.AuthorId, x.PublisherPublisherKey });
                    table.ForeignKey(
                        name: "FK_AuthorPublisher_Authors_AuthorId",
                        column: x => x.AuthorId,
                        principalTable: "Authors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AuthorPublisher_Publishers_PublisherPublisherKey",
                        column: x => x.PublisherPublisherKey,
                        principalTable: "Publishers",
                        principalColumn: "PublisherKey",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AuthorPublisher_PublisherPublisherKey",
                table: "AuthorPublisher",
                column: "PublisherPublisherKey");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AuthorPublisher");

            migrationBuilder.DropTable(
                name: "Publishers");
        }
    }
}
