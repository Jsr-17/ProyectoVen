using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ProyectoVentasElectronicas.Migrations
{
    /// <inheritdoc />
    public partial class DatosParaMisAmigos : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Clients",
                columns: new[] { "Client_id", "City", "Country", "Direction", "Email", "Name", "Surname", "Telephone" },
                values: new object[,]
                {
                    { 4, "Alhendin", "El barrio no tan bajo", "Calle Tiesa 789", "Minabo.Tieso@example.com", "Minabo", "Tieso", "+YoLaConociEnunTaxi" },
                    { 5, "Durcal", "Japon", "Al Lao de un Parque", "Elver_gaCorta_ElTerrorDeLasnennas@example.com", "Elver", "Gacorta", "QueBuenosEstanLoskebabsDeDurcal" }
                });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Product_id",
                keyValue: 1,
                column: "Description",
                value: "Laptop Dell  8GB RAM");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Product_id",
                keyValue: 3,
                column: "Description",
                value: "Monitor Samsung 27'' ");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Product_id",
                keyValue: 4,
                column: "Description",
                value: "Keyboard mechanic Logitech");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Client_id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Client_id",
                keyValue: 5);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Product_id",
                keyValue: 1,
                column: "Description",
                value: "Laptop Dell con 8GB RAM");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Product_id",
                keyValue: 3,
                column: "Description",
                value: "Monitor Samsung 27 pulgadas");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Product_id",
                keyValue: 4,
                column: "Description",
                value: "Teclado mecánico Logitech");
        }
    }
}
