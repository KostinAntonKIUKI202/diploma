using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TREK_Web_Diploma.Migrations
{
    /// <inheritdoc />
    public partial class Fix1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "HandlbarName",
                schema: "sparesEquipment",
                table: "Handlebar",
                newName: "HandlebarName");

            migrationBuilder.RenameColumn(
                name: "HandlbarId",
                schema: "sparesEquipment",
                table: "Handlebar",
                newName: "HandlebarId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "HandlebarName",
                schema: "sparesEquipment",
                table: "Handlebar",
                newName: "HandlbarName");

            migrationBuilder.RenameColumn(
                name: "HandlebarId",
                schema: "sparesEquipment",
                table: "Handlebar",
                newName: "HandlbarId");
        }
    }
}
