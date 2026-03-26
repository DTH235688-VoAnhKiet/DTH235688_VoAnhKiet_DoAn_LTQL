using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace QLDuAnPhanMemTinHoc.Migrations
{
    /// <inheritdoc />
    public partial class UpdateTable1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "NguoiDaiDien",
                table: "KhachHang",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "NguoiDaiDien",
                table: "KhachHang");
        }
    }
}
