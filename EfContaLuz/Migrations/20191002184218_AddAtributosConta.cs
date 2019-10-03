using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EfContaLuz.Migrations
{
    public partial class AddAtributosConta : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "dataPagamento",
                table: "account",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<decimal>(
                name: "kwGasto",
                table: "account",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<int>(
                name: "mediaConsumo",
                table: "account",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "numLeitura",
                table: "account",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<decimal>(
                name: "valorPagar",
                table: "account",
                nullable: false,
                defaultValue: 0m);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "dataPagamento",
                table: "account");

            migrationBuilder.DropColumn(
                name: "kwGasto",
                table: "account");

            migrationBuilder.DropColumn(
                name: "mediaConsumo",
                table: "account");

            migrationBuilder.DropColumn(
                name: "numLeitura",
                table: "account");

            migrationBuilder.DropColumn(
                name: "valorPagar",
                table: "account");
        }
    }
}
