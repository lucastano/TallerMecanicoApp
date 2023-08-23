using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace tallerMecanico.AccesoDatos.Migrations
{
    /// <inheritdoc />
    public partial class costohora : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CostoHora",
                table: "Mechanics");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<double>(
                name: "CostoHora",
                table: "Mechanics",
                type: "float",
                nullable: false,
                defaultValue: 0.0);
        }
    }
}
