using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProyectoVentasElectronicas.Migrations
{
    /// <inheritdoc />
    public partial class pass : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LoginUsers");

            migrationBuilder.AddColumn<string>(
                name: "Password",
                table: "Clients",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Username",
                table: "Clients",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Client_id",
                keyValue: 1,
                columns: new[] { "Password", "Username" },
                values: new object[] { "1234", "test" });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Client_id",
                keyValue: 2,
                columns: new[] { "Password", "Username" },
                values: new object[] { "1234", "test" });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Client_id",
                keyValue: 3,
                columns: new[] { "Password", "Username" },
                values: new object[] { "1234", "test" });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Client_id",
                keyValue: 4,
                columns: new[] { "Password", "Username" },
                values: new object[] { "1234", "test" });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Client_id",
                keyValue: 5,
                columns: new[] { "Password", "Username" },
                values: new object[] { "1234", "test" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Password",
                table: "Clients");

            migrationBuilder.DropColumn(
                name: "Username",
                table: "Clients");

            migrationBuilder.CreateTable(
                name: "LoginUsers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Username = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LoginUsers", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "LoginUsers",
                columns: new[] { "Id", "Password", "Username" },
                values: new object[] { 1, "Test", "Test" });
        }
    }
}
