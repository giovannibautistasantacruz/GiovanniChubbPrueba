using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace chubbExamen.Migrations
{
    /// <inheritdoc />
    public partial class InitialMigrationWithRelations : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "tbl_Estado",
                columns: table => new
                {
                    IdEstado = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    status = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_Estado", x => x.IdEstado);
                });

            migrationBuilder.CreateTable(
                name: "tbl_Municipio",
                columns: table => new
                {
                    IdMunicipio = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IdEstado = table.Column<int>(type: "int", nullable: false),
                    status = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_Municipio", x => x.IdMunicipio);
                    table.ForeignKey(
                        name: "FK_tbl_Municipio_tbl_Estado_IdEstado",
                        column: x => x.IdEstado,
                        principalTable: "tbl_Estado",
                        principalColumn: "IdEstado",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tbl_Colonia",
                columns: table => new
                {
                    IdColonia = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CP = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IdMunicipio = table.Column<int>(type: "int", nullable: false),
                    status = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_Colonia", x => x.IdColonia);
                    table.ForeignKey(
                        name: "FK_tbl_Colonia_tbl_Municipio_IdMunicipio",
                        column: x => x.IdMunicipio,
                        principalTable: "tbl_Municipio",
                        principalColumn: "IdMunicipio",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tbl_Direccion",
                columns: table => new
                {
                    IdDireccion = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Calle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NoInterior = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NoExterior = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IdColonia = table.Column<int>(type: "int", nullable: false),
                    status = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_Direccion", x => x.IdDireccion);
                    table.ForeignKey(
                        name: "FK_tbl_Direccion_tbl_Colonia_IdColonia",
                        column: x => x.IdColonia,
                        principalTable: "tbl_Colonia",
                        principalColumn: "IdColonia",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tbl_Persona",
                columns: table => new
                {
                    IdPersona = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Apaterno = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Amaterno = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Telefono = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IdDireccion = table.Column<int>(type: "int", nullable: false),
                    status = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_Persona", x => x.IdPersona);
                    table.ForeignKey(
                        name: "FK_tbl_Persona_tbl_Direccion_IdDireccion",
                        column: x => x.IdDireccion,
                        principalTable: "tbl_Direccion",
                        principalColumn: "IdDireccion",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_tbl_Colonia_IdMunicipio",
                table: "tbl_Colonia",
                column: "IdMunicipio");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_Direccion_IdColonia",
                table: "tbl_Direccion",
                column: "IdColonia");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_Municipio_IdEstado",
                table: "tbl_Municipio",
                column: "IdEstado");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_Persona_IdDireccion",
                table: "tbl_Persona",
                column: "IdDireccion");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tbl_Persona");

            migrationBuilder.DropTable(
                name: "tbl_Direccion");

            migrationBuilder.DropTable(
                name: "tbl_Colonia");

            migrationBuilder.DropTable(
                name: "tbl_Municipio");

            migrationBuilder.DropTable(
                name: "tbl_Estado");
        }
    }
}
