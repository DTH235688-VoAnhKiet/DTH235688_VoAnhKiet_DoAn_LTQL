using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace QLDuAnPhanMemTinHoc.Migrations
{
    /// <inheritdoc />
    public partial class CleanupUnusedTables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "NhanVien_VaiTro");

            migrationBuilder.DropTable(
                name: "NhatKyHoatDong");

            migrationBuilder.DropTable(
                name: "TaiLieuDuAn");

            migrationBuilder.DropTable(
                name: "TienDo");

            migrationBuilder.DropTable(
                name: "VaiTro");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "NhatKyHoatDong",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NhanVienID = table.Column<int>(type: "int", nullable: false),
                    MoTaHoatDong = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ThoiGian = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NhatKyHoatDong", x => x.ID);
                    table.ForeignKey(
                        name: "FK_NhatKyHoatDong_NhanVien_NhanVienID",
                        column: x => x.NhanVienID,
                        principalTable: "NhanVien",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TaiLieuDuAn",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DuAnID = table.Column<int>(type: "int", nullable: false),
                    DuongDan = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NgayTaiLen = table.Column<DateTime>(type: "datetime2", nullable: true),
                    TenTaiLieu = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TaiLieuDuAn", x => x.ID);
                    table.ForeignKey(
                        name: "FK_TaiLieuDuAn_DuAn_DuAnID",
                        column: x => x.DuAnID,
                        principalTable: "DuAn",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TienDo",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CongViecID = table.Column<int>(type: "int", nullable: false),
                    GhiChu = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NgayCapNhat = table.Column<DateTime>(type: "datetime2", nullable: true),
                    PhanTram = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TienDo", x => x.ID);
                    table.ForeignKey(
                        name: "FK_TienDo_CongViec_CongViecID",
                        column: x => x.CongViecID,
                        principalTable: "CongViec",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "VaiTro",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenVaiTro = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VaiTro", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "NhanVien_VaiTro",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NhanVienID = table.Column<int>(type: "int", nullable: false),
                    VaiTroID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NhanVien_VaiTro", x => x.ID);
                    table.ForeignKey(
                        name: "FK_NhanVien_VaiTro_NhanVien_NhanVienID",
                        column: x => x.NhanVienID,
                        principalTable: "NhanVien",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_NhanVien_VaiTro_VaiTro_VaiTroID",
                        column: x => x.VaiTroID,
                        principalTable: "VaiTro",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_NhanVien_VaiTro_NhanVienID",
                table: "NhanVien_VaiTro",
                column: "NhanVienID");

            migrationBuilder.CreateIndex(
                name: "IX_NhanVien_VaiTro_VaiTroID",
                table: "NhanVien_VaiTro",
                column: "VaiTroID");

            migrationBuilder.CreateIndex(
                name: "IX_NhatKyHoatDong_NhanVienID",
                table: "NhatKyHoatDong",
                column: "NhanVienID");

            migrationBuilder.CreateIndex(
                name: "IX_TaiLieuDuAn_DuAnID",
                table: "TaiLieuDuAn",
                column: "DuAnID");

            migrationBuilder.CreateIndex(
                name: "IX_TienDo_CongViecID",
                table: "TienDo",
                column: "CongViecID");
        }
    }
}
