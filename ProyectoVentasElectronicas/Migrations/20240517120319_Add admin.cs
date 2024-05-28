using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProyectoVentasElectronicas.Migrations
{
    /// <inheritdoc />
    public partial class Addadmin : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "admin",
                table: "Clients",
                type: "bit",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Client_id",
                keyValue: 1,
                column: "admin",
                value: null);

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Client_id",
                keyValue: 2,
                column: "admin",
                value: null);

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Client_id",
                keyValue: 3,
                column: "admin",
                value: null);

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Client_id",
                keyValue: 4,
                column: "admin",
                value: null);

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Client_id",
                keyValue: 5,
                column: "admin",
                value: null);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "admin",
                table: "Clients");
        }
    }
}
