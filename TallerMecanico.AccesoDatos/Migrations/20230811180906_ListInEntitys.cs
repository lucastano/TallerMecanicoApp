using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace tallerMecanico.AccesoDatos.Migrations
{
    /// <inheritdoc />
    public partial class ListInEntitys : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Parts",
                table: "Repairs");

            migrationBuilder.AddColumn<int>(
                name: "RepairId",
                table: "Parts",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Parts_RepairId",
                table: "Parts",
                column: "RepairId");

            migrationBuilder.AddForeignKey(
                name: "FK_Parts_Repairs_RepairId",
                table: "Parts",
                column: "RepairId",
                principalTable: "Repairs",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Parts_Repairs_RepairId",
                table: "Parts");

            migrationBuilder.DropIndex(
                name: "IX_Parts_RepairId",
                table: "Parts");

            migrationBuilder.DropColumn(
                name: "RepairId",
                table: "Parts");

            migrationBuilder.AddColumn<int>(
                name: "Parts",
                table: "Repairs",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
