using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RMS.Data.Migrations
{
    /// <inheritdoc />
    public partial class Create_table_Khachhang : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "NgaySinh",
                table: "NhanVien",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "TEXT");

            migrationBuilder.CreateTable(
                name: "KhachHang",
                columns: table => new
                {
                    KhachhangId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    HoTen = table.Column<string>(type: "TEXT", nullable: true),
                    DiaChi = table.Column<string>(type: "TEXT", nullable: true),
                    SoDienThoai = table.Column<string>(type: "TEXT", nullable: true),
                    NgaySinh = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KhachHang", x => x.KhachhangId);
                });

            migrationBuilder.CreateTable(
                name: "MonAn",
                columns: table => new
                {
                    MonAnId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    TenMonAn = table.Column<string>(type: "TEXT", nullable: true),
                    MoTa = table.Column<string>(type: "TEXT", nullable: true),
                    Gia = table.Column<decimal>(type: "TEXT", nullable: false),
                    HinhAnh = table.Column<string>(type: "TEXT", nullable: true),
                    DanhMuc = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MonAn", x => x.MonAnId);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "KhachHang");

            migrationBuilder.DropTable(
                name: "MonAn");

            migrationBuilder.AlterColumn<DateTime>(
                name: "NgaySinh",
                table: "NhanVien",
                type: "TEXT",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "INTEGER");
        }
    }
}
