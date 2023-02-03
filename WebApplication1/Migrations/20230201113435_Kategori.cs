using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApplication1.Migrations
{
    public partial class Kategori : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Sifre",
                table: "Kullanicilar",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.UpdateData(
                table: "Kullanicilar",
                keyColumn: "KullaniciID",
                keyValue: 1,
                column: "Sifre",
                value: "1230");

            migrationBuilder.UpdateData(
                table: "Kullanicilar",
                keyColumn: "KullaniciID",
                keyValue: 2,
                column: "Sifre",
                value: "1230");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Sifre",
                table: "Kullanicilar",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.UpdateData(
                table: "Kullanicilar",
                keyColumn: "KullaniciID",
                keyValue: 1,
                column: "Sifre",
                value: 1230);

            migrationBuilder.UpdateData(
                table: "Kullanicilar",
                keyColumn: "KullaniciID",
                keyValue: 2,
                column: "Sifre",
                value: 1230);
        }
    }
}
