using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApplication3.Migrations
{
    public partial class Kategoriler : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Kategoris",
                columns: table => new
                {
                    KategoriID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KategoriAdi = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kategoris", x => x.KategoriID);
                });

            migrationBuilder.CreateTable(
                name: "Tedarikcis",
                columns: table => new
                {
                    TedarikciId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TedarikciAdi = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tedarikcis", x => x.TedarikciId);
                });

            //migrationBuilder.CreateTable(
            //    name: "Uruns",
            //    columns: table => new
            //    {
            //        UrunID = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        UrunAdi = table.Column<int>(type: "int", nullable: false),
            //        Fiyat = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_Uruns", x => x.UrunID);
            //    });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Kategoris");

            migrationBuilder.DropTable(
                name: "Tedarikcis");

            //migrationBuilder.DropTable(
            //    name: "Uruns");
        }
    }
}
