using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace tallerMecanico.AccesoDatos.Migrations
{
    /// <inheritdoc />
    public partial class modifiRepairentity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "State",
                table: "Repairs",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "State",
                table: "Repairs");
        }
    }
}
