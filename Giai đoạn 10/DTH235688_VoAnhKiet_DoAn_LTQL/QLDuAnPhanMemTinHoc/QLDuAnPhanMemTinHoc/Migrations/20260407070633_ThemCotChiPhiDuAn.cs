using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace QLDuAnPhanMemTinHoc.Migrations
{
    /// <inheritdoc />
    public partial class ThemCotChiPhiDuAn : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "ChiPhi",
                table: "DuAn",
                type: "decimal(18,2)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ChiPhi",
                table: "DuAn");
        }
    }
}
