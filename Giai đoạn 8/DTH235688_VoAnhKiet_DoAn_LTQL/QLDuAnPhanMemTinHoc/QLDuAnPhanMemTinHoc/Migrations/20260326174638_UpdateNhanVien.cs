using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace QLDuAnPhanMemTinHoc.Migrations
{
    /// <inheritdoc />
    public partial class UpdateNhanVien : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "GhiChu",
                table: "NhanVien",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "GioiTinh",
                table: "NhanVien",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "NgaySinh",
                table: "NhanVien",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PhongBan",
                table: "NhanVien",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TrangThai",
                table: "NhanVien",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "GhiChu",
                table: "NhanVien");

            migrationBuilder.DropColumn(
                name: "GioiTinh",
                table: "NhanVien");

            migrationBuilder.DropColumn(
                name: "NgaySinh",
                table: "NhanVien");

            migrationBuilder.DropColumn(
                name: "PhongBan",
                table: "NhanVien");

            migrationBuilder.DropColumn(
                name: "TrangThai",
                table: "NhanVien");
        }
    }
}
