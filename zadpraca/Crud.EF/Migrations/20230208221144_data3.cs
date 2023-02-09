using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Crud.EF.Migrations
{
    /// <inheritdoc />
    public partial class data3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DataUtworzenia",
                table: "HistoriaProduktow");

            migrationBuilder.AddColumn<int>(
                name: "IloscZmian",
                table: "ListaProduktow",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IloscZmian",
                table: "ListaProduktow");

            migrationBuilder.AddColumn<DateTime>(
                name: "DataUtworzenia",
                table: "HistoriaProduktow",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }
    }
}
