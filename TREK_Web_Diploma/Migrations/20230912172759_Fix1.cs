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
            migrationBuilder.RenameTable(
                name: "JobTitle",
                schema: "Stuff",
                newName: "JobTitle",
                newSchema: "factory");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "Stuff");

            migrationBuilder.RenameTable(
                name: "JobTitle",
                schema: "factory",
                newName: "JobTitle",
                newSchema: "Stuff");
        }
    }
}
