using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ProyectoVentasElectronicas.Migrations
{
    /// <inheritdoc />
    public partial class anadirDatos : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Categories",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.CreateTable(
                name: "DetailOrders",
                columns: table => new
                {
                    Detail_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Order_id = table.Column<int>(type: "int", nullable: false),
                    Product_id = table.Column<int>(type: "int", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    Prize = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DetailOrders", x => x.Detail_id);
                    table.ForeignKey(
                        name: "FK_DetailOrders_Orders_Order_id",
                        column: x => x.Order_id,
                        principalTable: "Orders",
                        principalColumn: "Order_id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DetailOrders_Products_Product_id",
                        column: x => x.Product_id,
                        principalTable: "Products",
                        principalColumn: "Product_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Category_id", "Name" },
                values: new object[,]
                {
                    { 1, "Computers" },
                    { 2, "Smartphones" },
                    { 3, "Accesory" }
                });

            migrationBuilder.InsertData(
                table: "Clients",
                columns: new[] { "Client_id", "City", "Country", "Direction", "Email", "Name", "Surname", "Telephone" },
                values: new object[,]
                {
                    { 1, "Buenos Aires", "Argentina", "Calle Falsa 123", "juan.perez@example.com", "Juan", "Pérez", "+5491145678901" },
                    { 2, "Buenos Aires", "Argentina", "Calle Falsa 123", "Juan.perez@example.com", "Maria", "Gonzalez", "+5491145678901" },
                    { 3, "Lima", "Perú", "Calle Larga 789", "pedro.martinez@example.com", "Pedro", "Martínez", "+5491145678903" }
                });

            migrationBuilder.InsertData(
                table: "Supliers",
                columns: new[] { "Suplier_id", "Direction", "Name", "Telephone" },
                values: new object[,]
                {
                    { 1, "1 Dell Way, Round Rock", "Dell Inc.", "+18005555555" },
                    { 2, "1 Infinite Loop, Cupertino", "Apple Inc", "+18006565432" },
                    { 3, "7600 Gateway Blvd, Newark", "Logitech Inc.", "+18001234567" }
                });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Order_id", "Client_id", "Order_date", "State" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2024, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Processing" },
                    { 2, 2, new DateTime(2024, 5, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Send" },
                    { 3, 3, new DateTime(2024, 5, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivered" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Product_id", "Category_id", "Description", "Name", "Price", "Suplier_id" },
                values: new object[,]
                {
                    { 1, 1, "Laptop Dell con 8GB RAM", "Laptop Dell", 1200.00m, 1 },
                    { 2, 2, "Smartphone Apple iPhone 13", "iPhone 13", 1000.00m, 2 },
                    { 3, 1, "Monitor Samsung 27 pulgadas", "Monitor Samsung", 300.00m, 1 },
                    { 4, 3, "Teclado mecánico Logitech", "Teclado Logitech", 80.00m, 3 }
                });

            migrationBuilder.InsertData(
                table: "DetailOrders",
                columns: new[] { "Detail_id", "Order_id", "Prize", "Product_id", "Quantity" },
                values: new object[,]
                {
                    { 1, 1, 1200.00m, 1, 1 },
                    { 2, 2, 1000.00m, 2, 1 },
                    { 3, 3, 300.00m, 3, 1 },
                    { 4, 1, 80.00m, 4, 2 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_DetailOrders_Order_id",
                table: "DetailOrders",
                column: "Order_id");

            migrationBuilder.CreateIndex(
                name: "IX_DetailOrders_Product_id",
                table: "DetailOrders",
                column: "Product_id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DetailOrders");

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Order_id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Order_id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Order_id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Product_id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Product_id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Product_id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Product_id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Category_id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Category_id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Category_id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Client_id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Client_id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Client_id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Supliers",
                keyColumn: "Suplier_id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Supliers",
                keyColumn: "Suplier_id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Supliers",
                keyColumn: "Suplier_id",
                keyValue: 3);

            migrationBuilder.AlterColumn<int>(
                name: "Name",
                table: "Categories",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");
        }
    }
}
