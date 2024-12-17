using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AccentureGTGH_EFCore.Migrations
{
    /// <inheritdoc />
    public partial class synopsis : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Synopsis",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    WriterFirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    WriterLastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BookId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Synopsis", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Synopsis_Books_BookId",
                        column: x => x.BookId,
                        principalTable: "Books",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Synopsis_BookId",
                table: "Synopsis",
                column: "BookId",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Synopsis");
        }
    }
}
