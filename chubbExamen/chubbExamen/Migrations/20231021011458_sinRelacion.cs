using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace chubbExamen.Migrations
{
    /// <inheritdoc />
    public partial class sinRelacion : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_tbl_Colonia_tbl_Municipio_IdMunicipio",
                table: "tbl_Colonia");

            migrationBuilder.DropForeignKey(
                name: "FK_tbl_Direccion_tbl_Colonia_IdColonia",
                table: "tbl_Direccion");

            migrationBuilder.DropForeignKey(
                name: "FK_tbl_Municipio_tbl_Estado_IdEstado",
                table: "tbl_Municipio");

            migrationBuilder.DropIndex(
                name: "IX_tbl_Municipio_IdEstado",
                table: "tbl_Municipio");

            migrationBuilder.DropIndex(
                name: "IX_tbl_Direccion_IdColonia",
                table: "tbl_Direccion");

            migrationBuilder.DropIndex(
                name: "IX_tbl_Colonia_IdMunicipio",
                table: "tbl_Colonia");

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

            migrationBuilder.AddColumn<int>(
                name: "EstadoIdEstado",
                table: "tbl_Municipio",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ColoniaIdColonia",
                table: "tbl_Direccion",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "MunicipioIdMunicipio",
                table: "tbl_Colonia",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_tbl_Municipio_EstadoIdEstado",
                table: "tbl_Municipio",
                column: "EstadoIdEstado");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_Direccion_ColoniaIdColonia",
                table: "tbl_Direccion",
                column: "ColoniaIdColonia");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_Colonia_MunicipioIdMunicipio",
                table: "tbl_Colonia",
                column: "MunicipioIdMunicipio");

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_Colonia_tbl_Municipio_MunicipioIdMunicipio",
                table: "tbl_Colonia",
                column: "MunicipioIdMunicipio",
                principalTable: "tbl_Municipio",
                principalColumn: "IdMunicipio",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_Direccion_tbl_Colonia_ColoniaIdColonia",
                table: "tbl_Direccion",
                column: "ColoniaIdColonia",
                principalTable: "tbl_Colonia",
                principalColumn: "IdColonia",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_Municipio_tbl_Estado_EstadoIdEstado",
                table: "tbl_Municipio",
                column: "EstadoIdEstado",
                principalTable: "tbl_Estado",
                principalColumn: "IdEstado",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_tbl_Colonia_tbl_Municipio_MunicipioIdMunicipio",
                table: "tbl_Colonia");

            migrationBuilder.DropForeignKey(
                name: "FK_tbl_Direccion_tbl_Colonia_ColoniaIdColonia",
                table: "tbl_Direccion");

            migrationBuilder.DropForeignKey(
                name: "FK_tbl_Municipio_tbl_Estado_EstadoIdEstado",
                table: "tbl_Municipio");

            migrationBuilder.DropIndex(
                name: "IX_tbl_Municipio_EstadoIdEstado",
                table: "tbl_Municipio");

            migrationBuilder.DropIndex(
                name: "IX_tbl_Direccion_ColoniaIdColonia",
                table: "tbl_Direccion");

            migrationBuilder.DropIndex(
                name: "IX_tbl_Colonia_MunicipioIdMunicipio",
                table: "tbl_Colonia");

            migrationBuilder.DropColumn(
                name: "EstadoIdEstado",
                table: "tbl_Municipio");

            migrationBuilder.DropColumn(
                name: "ColoniaIdColonia",
                table: "tbl_Direccion");

            migrationBuilder.DropColumn(
                name: "MunicipioIdMunicipio",
                table: "tbl_Colonia");

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

            migrationBuilder.CreateIndex(
                name: "IX_tbl_Municipio_IdEstado",
                table: "tbl_Municipio",
                column: "IdEstado");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_Direccion_IdColonia",
                table: "tbl_Direccion",
                column: "IdColonia");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_Colonia_IdMunicipio",
                table: "tbl_Colonia",
                column: "IdMunicipio");

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_Colonia_tbl_Municipio_IdMunicipio",
                table: "tbl_Colonia",
                column: "IdMunicipio",
                principalTable: "tbl_Municipio",
                principalColumn: "IdMunicipio",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_Direccion_tbl_Colonia_IdColonia",
                table: "tbl_Direccion",
                column: "IdColonia",
                principalTable: "tbl_Colonia",
                principalColumn: "IdColonia",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_Municipio_tbl_Estado_IdEstado",
                table: "tbl_Municipio",
                column: "IdEstado",
                principalTable: "tbl_Estado",
                principalColumn: "IdEstado",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
