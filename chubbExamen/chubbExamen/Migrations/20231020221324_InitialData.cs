using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace chubbExamen.Migrations
{
    /// <inheritdoc />
    public partial class InitialData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "tbl_Estado",
                columns: new[] { "IdEstado", "Nombre", "status" },
                values: new object[] { 1, "Estado de México", true });

            migrationBuilder.InsertData(
                table: "tbl_Municipio",
                columns: new[] { "IdMunicipio", "IdEstado", "Nombre", "status" },
                values: new object[,]
                {
                    { 1, 1, "Huehuetoca", true },
                    { 2, 1, "Coyotepec", true }
                });

            migrationBuilder.InsertData(
                table: "tbl_Colonia",
                columns: new[] { "IdColonia", "CP", "IdMunicipio", "Nombre", "status" },
                values: new object[,]
                {
                    { 1, "54680", 1, "Centro", true },
                    { 2, "54694", 1, "Santa Teresa", true }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "tbl_Colonia",
                keyColumn: "IdColonia",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "tbl_Colonia",
                keyColumn: "IdColonia",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "tbl_Municipio",
                keyColumn: "IdMunicipio",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "tbl_Municipio",
                keyColumn: "IdMunicipio",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "tbl_Estado",
                keyColumn: "IdEstado",
                keyValue: 1);
        }
    }
}
