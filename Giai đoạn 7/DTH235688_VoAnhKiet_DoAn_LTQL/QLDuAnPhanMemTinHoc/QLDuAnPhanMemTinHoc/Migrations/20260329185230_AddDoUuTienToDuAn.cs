using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace QLDuAnPhanMemTinHoc.Migrations
{
    /// <inheritdoc />
    public partial class AddDoUuTienToDuAn : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "DoUuTien",
                table: "DuAn",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DoUuTien",
                table: "DuAn");
        }
    }
}
