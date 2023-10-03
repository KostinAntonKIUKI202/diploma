using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TREK_Web_Diploma.Migrations
{
    /// <inheritdoc />
    public partial class Fix2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SteeringQuantity",
                schema: "sparesEquipment",
                table: "Steering");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "SteeringQuantity",
                schema: "sparesEquipment",
                table: "Steering",
                type: "int",
                maxLength: 4,
                nullable: false,
                defaultValue: 0);
        }
    }
}
