using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProyectoVentasElectronicas.Migrations
{
    /// <inheritdoc />
    public partial class data : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DetailOrders_Orders_Order_id",
                table: "DetailOrders");

            migrationBuilder.DropForeignKey(
                name: "FK_DetailOrders_Products_Product_id",
                table: "DetailOrders");

            migrationBuilder.DropPrimaryKey(
                name: "PK_DetailOrders",
                table: "DetailOrders");

            migrationBuilder.RenameTable(
                name: "DetailOrders",
                newName: "DetailsOrder");

            migrationBuilder.RenameIndex(
                name: "IX_DetailOrders_Product_id",
                table: "DetailsOrder",
                newName: "IX_DetailsOrder_Product_id");

            migrationBuilder.RenameIndex(
                name: "IX_DetailOrders_Order_id",
                table: "DetailsOrder",
                newName: "IX_DetailsOrder_Order_id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_DetailsOrder",
                table: "DetailsOrder",
                column: "Detail_id");

            migrationBuilder.AddForeignKey(
                name: "FK_DetailsOrder_Orders_Order_id",
                table: "DetailsOrder",
                column: "Order_id",
                principalTable: "Orders",
                principalColumn: "Order_id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_DetailsOrder_Products_Product_id",
                table: "DetailsOrder",
                column: "Product_id",
                principalTable: "Products",
                principalColumn: "Product_id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DetailsOrder_Orders_Order_id",
                table: "DetailsOrder");

            migrationBuilder.DropForeignKey(
                name: "FK_DetailsOrder_Products_Product_id",
                table: "DetailsOrder");

            migrationBuilder.DropPrimaryKey(
                name: "PK_DetailsOrder",
                table: "DetailsOrder");

            migrationBuilder.RenameTable(
                name: "DetailsOrder",
                newName: "DetailOrders");

            migrationBuilder.RenameIndex(
                name: "IX_DetailsOrder_Product_id",
                table: "DetailOrders",
                newName: "IX_DetailOrders_Product_id");

            migrationBuilder.RenameIndex(
                name: "IX_DetailsOrder_Order_id",
                table: "DetailOrders",
                newName: "IX_DetailOrders_Order_id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_DetailOrders",
                table: "DetailOrders",
                column: "Detail_id");

            migrationBuilder.AddForeignKey(
                name: "FK_DetailOrders_Orders_Order_id",
                table: "DetailOrders",
                column: "Order_id",
                principalTable: "Orders",
                principalColumn: "Order_id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_DetailOrders_Products_Product_id",
                table: "DetailOrders",
                column: "Product_id",
                principalTable: "Products",
                principalColumn: "Product_id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
