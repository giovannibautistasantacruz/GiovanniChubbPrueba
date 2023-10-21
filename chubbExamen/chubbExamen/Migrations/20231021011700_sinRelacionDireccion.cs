using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace chubbExamen.Migrations
{
    /// <inheritdoc />
    public partial class sinRelacionDireccion : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_tbl_Persona_tbl_Direccion_tbl_DireccionIdDireccion",
                table: "tbl_Persona");

            migrationBuilder.DropIndex(
                name: "IX_tbl_Persona_tbl_DireccionIdDireccion",
                table: "tbl_Persona");

            migrationBuilder.DropColumn(
                name: "tbl_DireccionIdDireccion",
                table: "tbl_Persona");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "tbl_DireccionIdDireccion",
                table: "tbl_Persona",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_tbl_Persona_tbl_DireccionIdDireccion",
                table: "tbl_Persona",
                column: "tbl_DireccionIdDireccion");

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_Persona_tbl_Direccion_tbl_DireccionIdDireccion",
                table: "tbl_Persona",
                column: "tbl_DireccionIdDireccion",
                principalTable: "tbl_Direccion",
                principalColumn: "IdDireccion");
        }
    }
}
