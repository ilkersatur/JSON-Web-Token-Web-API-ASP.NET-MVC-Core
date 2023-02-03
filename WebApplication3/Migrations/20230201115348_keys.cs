using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApplication3.Migrations
{
    public partial class keys : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "KategoriID",
                table: "Uruns",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "KategoriID1",
                table: "Kategoris",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Uruns_KategoriID",
                table: "Uruns",
                column: "KategoriID");

            migrationBuilder.CreateIndex(
                name: "IX_Kategoris_KategoriID1",
                table: "Kategoris",
                column: "KategoriID1");

            migrationBuilder.AddForeignKey(
                name: "FK_Kategoris_Kategoris_KategoriID1",
                table: "Kategoris",
                column: "KategoriID1",
                principalTable: "Kategoris",
                principalColumn: "KategoriID");

            migrationBuilder.AddForeignKey(
                name: "FK_Uruns_Kategoris_KategoriID",
                table: "Uruns",
                column: "KategoriID",
                principalTable: "Kategoris",
                principalColumn: "KategoriID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Kategoris_Kategoris_KategoriID1",
                table: "Kategoris");

            migrationBuilder.DropForeignKey(
                name: "FK_Uruns_Kategoris_KategoriID",
                table: "Uruns");

            migrationBuilder.DropIndex(
                name: "IX_Uruns_KategoriID",
                table: "Uruns");

            migrationBuilder.DropIndex(
                name: "IX_Kategoris_KategoriID1",
                table: "Kategoris");

            migrationBuilder.DropColumn(
                name: "KategoriID",
                table: "Uruns");

            migrationBuilder.DropColumn(
                name: "KategoriID1",
                table: "Kategoris");
        }
    }
}
