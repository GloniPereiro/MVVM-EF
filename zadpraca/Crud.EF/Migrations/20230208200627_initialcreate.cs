using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Crud.EF.Migrations
{
    /// <inheritdoc />
    public partial class initialcreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "HistoriaProduktow",
                columns: table => new
                {
                    IdZmiany = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Produkt = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StaryKod = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HistoriaProduktow", x => x.IdZmiany);
                });

            migrationBuilder.CreateTable(
                name: "ListaProduktow",
                columns: table => new
                {
                    IdProduktu = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Produkt = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Kod = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ListaProduktow", x => x.IdProduktu);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "HistoriaProduktow");

            migrationBuilder.DropTable(
                name: "ListaProduktow");
        }
    }
}
