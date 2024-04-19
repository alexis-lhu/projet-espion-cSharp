using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Lhussiez.RG.DAL.Migrations
{
    /// <inheritdoc />
    public partial class CorrectionModel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Missions_Espions_EspionId",
                table: "Missions");

            migrationBuilder.AlterColumn<int>(
                name: "EspionId",
                table: "Missions",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Missions_Espions_EspionId",
                table: "Missions",
                column: "EspionId",
                principalTable: "Espions",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Missions_Espions_EspionId",
                table: "Missions");

            migrationBuilder.AlterColumn<int>(
                name: "EspionId",
                table: "Missions",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Missions_Espions_EspionId",
                table: "Missions",
                column: "EspionId",
                principalTable: "Espions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
