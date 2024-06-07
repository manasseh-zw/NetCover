using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NetCover.Server.Migrations
{
    /// <inheritdoc />
    public partial class init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CellTowers",
                columns: table => new
                {
                    Radio = table.Column<string>(type: "text", nullable: false),
                    MCC = table.Column<int>(type: "integer", nullable: false),
                    MNC = table.Column<int>(type: "integer", nullable: false),
                    LAC = table.Column<int>(type: "integer", nullable: false),
                    CID = table.Column<int>(type: "integer", nullable: false),
                    Longitude = table.Column<double>(type: "double precision", nullable: false),
                    Latitude = table.Column<double>(type: "double precision", nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateIndex(
                name: "IX_CellTowers_MNC",
                table: "CellTowers",
                column: "MNC");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CellTowers");
        }
    }
}
