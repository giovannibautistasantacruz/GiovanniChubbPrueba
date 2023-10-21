using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace chubbExamen.Migrations
{
    /// <inheritdoc />
    public partial class personaSimpleDirection : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_tbl_Persona_tbl_Direccion_IdDireccion",
                table: "tbl_Persona");

            migrationBuilder.DropIndex(
                name: "IX_tbl_Persona_IdDireccion",
                table: "tbl_Persona");

            migrationBuilder.DropColumn(
                name: "IdDireccion",
                table: "tbl_Persona");

            migrationBuilder.AddColumn<string>(
                name: "Direccion",
                table: "tbl_Persona",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_tbl_Persona_tbl_Direccion_tbl_DireccionIdDireccion",
                table: "tbl_Persona");

            migrationBuilder.DropIndex(
                name: "IX_tbl_Persona_tbl_DireccionIdDireccion",
                table: "tbl_Persona");

            migrationBuilder.DropColumn(
                name: "Direccion",
                table: "tbl_Persona");

            migrationBuilder.DropColumn(
                name: "tbl_DireccionIdDireccion",
                table: "tbl_Persona");

            migrationBuilder.AddColumn<int>(
                name: "IdDireccion",
                table: "tbl_Persona",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_tbl_Persona_IdDireccion",
                table: "tbl_Persona",
                column: "IdDireccion");

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_Persona_tbl_Direccion_IdDireccion",
                table: "tbl_Persona",
                column: "IdDireccion",
                principalTable: "tbl_Direccion",
                principalColumn: "IdDireccion",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
