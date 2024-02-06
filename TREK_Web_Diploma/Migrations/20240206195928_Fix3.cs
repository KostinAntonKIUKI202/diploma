using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TREK_Web_Diploma.Migrations
{
    /// <inheritdoc />
    public partial class Fix3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Bike_GroopSet_GroopsetId",
                schema: "production",
                table: "Bike");

            migrationBuilder.DropForeignKey(
                name: "FK_GroopSet_Carriage_CarriageId",
                schema: "production",
                table: "GroopSet");

            migrationBuilder.DropForeignKey(
                name: "FK_GroopSet_Pedals_PedalsId",
                schema: "production",
                table: "GroopSet");

            migrationBuilder.DropForeignKey(
                name: "FK_GroopSet_Transmition_TransmitionId",
                schema: "production",
                table: "GroopSet");

            migrationBuilder.DropPrimaryKey(
                name: "PK_GroopSet",
                schema: "production",
                table: "GroopSet");

            migrationBuilder.RenameTable(
                name: "GroopSet",
                schema: "production",
                newName: "Groopset",
                newSchema: "production");

            migrationBuilder.RenameIndex(
                name: "IX_GroopSet_TransmitionId",
                schema: "production",
                table: "Groopset",
                newName: "IX_Groopset_TransmitionId");

            migrationBuilder.RenameIndex(
                name: "IX_GroopSet_PedalsId",
                schema: "production",
                table: "Groopset",
                newName: "IX_Groopset_PedalsId");

            migrationBuilder.RenameIndex(
                name: "IX_GroopSet_CarriageId",
                schema: "production",
                table: "Groopset",
                newName: "IX_Groopset_CarriageId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Groopset",
                schema: "production",
                table: "Groopset",
                column: "GroopsetId");

            migrationBuilder.AddForeignKey(
                name: "FK_Bike_Groopset_GroopsetId",
                schema: "production",
                table: "Bike",
                column: "GroopsetId",
                principalSchema: "production",
                principalTable: "Groopset",
                principalColumn: "GroopsetId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Groopset_Carriage_CarriageId",
                schema: "production",
                table: "Groopset",
                column: "CarriageId",
                principalSchema: "sparesGroopset",
                principalTable: "Carriage",
                principalColumn: "CarriageId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Groopset_Pedals_PedalsId",
                schema: "production",
                table: "Groopset",
                column: "PedalsId",
                principalSchema: "sparesGroopset",
                principalTable: "Pedals",
                principalColumn: "PedalsId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Groopset_Transmition_TransmitionId",
                schema: "production",
                table: "Groopset",
                column: "TransmitionId",
                principalSchema: "sparesGroopset",
                principalTable: "Transmition",
                principalColumn: "TransmitionId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Bike_Groopset_GroopsetId",
                schema: "production",
                table: "Bike");

            migrationBuilder.DropForeignKey(
                name: "FK_Groopset_Carriage_CarriageId",
                schema: "production",
                table: "Groopset");

            migrationBuilder.DropForeignKey(
                name: "FK_Groopset_Pedals_PedalsId",
                schema: "production",
                table: "Groopset");

            migrationBuilder.DropForeignKey(
                name: "FK_Groopset_Transmition_TransmitionId",
                schema: "production",
                table: "Groopset");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Groopset",
                schema: "production",
                table: "Groopset");

            migrationBuilder.RenameTable(
                name: "Groopset",
                schema: "production",
                newName: "GroopSet",
                newSchema: "production");

            migrationBuilder.RenameIndex(
                name: "IX_Groopset_TransmitionId",
                schema: "production",
                table: "GroopSet",
                newName: "IX_GroopSet_TransmitionId");

            migrationBuilder.RenameIndex(
                name: "IX_Groopset_PedalsId",
                schema: "production",
                table: "GroopSet",
                newName: "IX_GroopSet_PedalsId");

            migrationBuilder.RenameIndex(
                name: "IX_Groopset_CarriageId",
                schema: "production",
                table: "GroopSet",
                newName: "IX_GroopSet_CarriageId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_GroopSet",
                schema: "production",
                table: "GroopSet",
                column: "GroopsetId");

            migrationBuilder.AddForeignKey(
                name: "FK_Bike_GroopSet_GroopsetId",
                schema: "production",
                table: "Bike",
                column: "GroopsetId",
                principalSchema: "production",
                principalTable: "GroopSet",
                principalColumn: "GroopsetId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_GroopSet_Carriage_CarriageId",
                schema: "production",
                table: "GroopSet",
                column: "CarriageId",
                principalSchema: "sparesGroopset",
                principalTable: "Carriage",
                principalColumn: "CarriageId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_GroopSet_Pedals_PedalsId",
                schema: "production",
                table: "GroopSet",
                column: "PedalsId",
                principalSchema: "sparesGroopset",
                principalTable: "Pedals",
                principalColumn: "PedalsId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_GroopSet_Transmition_TransmitionId",
                schema: "production",
                table: "GroopSet",
                column: "TransmitionId",
                principalSchema: "sparesGroopset",
                principalTable: "Transmition",
                principalColumn: "TransmitionId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
