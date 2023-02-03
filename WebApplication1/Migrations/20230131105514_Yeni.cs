using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApplication1.Migrations
{
    public partial class Yeni : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.CreateTable(
            //    name: "__MigrationHistory",
            //    columns: table => new
            //    {
            //        MigrationId = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
            //        ContextKey = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: false),
            //        Model = table.Column<byte[]>(type: "varbinary(max)", nullable: false),
            //        ProductVersion = table.Column<string>(type: "nvarchar(32)", maxLength: 32, nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_dbo.__MigrationHistory", x => new { x.MigrationId, x.ContextKey });
            //    });

            //migrationBuilder.CreateTable(
            //    name: "Kategoris",
            //    columns: table => new
            //    {
            //        KategoriID = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        KategoriAdi = table.Column<string>(type: "nvarchar(max)", nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_Kategoris", x => x.KategoriID);
            //    });

            migrationBuilder.CreateTable(
                name: "Kullanicilar",
                columns: table => new
                {
                    KullaniciID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KullaniciAdi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Sifre = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kullanicilar", x => x.KullaniciID);
                });

            //migrationBuilder.CreateTable(
            //    name: "Uruns",
            //    columns: table => new
            //    {
            //        UrunID = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        UrunAdi = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //        KategoriID = table.Column<int>(type: "int", nullable: false),
            //        Fiyat = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_Uruns", x => x.UrunID);
            //        table.ForeignKey(
            //            name: "FK_dbo.Uruns_dbo.Kategoris_KategoriID",
            //            column: x => x.KategoriID,
            //            principalTable: "Kategoris",
            //            principalColumn: "KategoriID",
            //            onDelete: ReferentialAction.Cascade);
            //    });

            migrationBuilder.InsertData(
                table: "Kullanicilar",
                columns: new[] { "KullaniciID", "KullaniciAdi", "Sifre" },
                values: new object[] { 1, "ilker", 1230 });

            migrationBuilder.InsertData(
                table: "Kullanicilar",
                columns: new[] { "KullaniciID", "KullaniciAdi", "Sifre" },
                values: new object[] { 2, "sema", 1230 });

            //migrationBuilder.CreateIndex(
            //    name: "IX_KategoriID",
            //    table: "Uruns",
            //    column: "KategoriID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "__MigrationHistory");

            migrationBuilder.DropTable(
                name: "Kullanicilar");

            migrationBuilder.DropTable(
                name: "Uruns");

            migrationBuilder.DropTable(
                name: "Kategoris");
        }
    }
}
