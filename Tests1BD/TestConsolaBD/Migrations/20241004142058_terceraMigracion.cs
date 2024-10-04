using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TestConsolaBD.Migrations
{
    /// <inheritdoc />
    public partial class terceraMigracion : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Meals_MealType_MealTypeID",
                table: "Meals");

            migrationBuilder.DropPrimaryKey(
                name: "PK_MealType",
                table: "MealType");

            migrationBuilder.RenameTable(
                name: "MealType",
                newName: "MealTypes");

            migrationBuilder.AddPrimaryKey(
                name: "PK_MealTypes",
                table: "MealTypes",
                column: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Meals_MealTypes_MealTypeID",
                table: "Meals",
                column: "MealTypeID",
                principalTable: "MealTypes",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Meals_MealTypes_MealTypeID",
                table: "Meals");

            migrationBuilder.DropPrimaryKey(
                name: "PK_MealTypes",
                table: "MealTypes");

            migrationBuilder.RenameTable(
                name: "MealTypes",
                newName: "MealType");

            migrationBuilder.AddPrimaryKey(
                name: "PK_MealType",
                table: "MealType",
                column: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Meals_MealType_MealTypeID",
                table: "Meals",
                column: "MealTypeID",
                principalTable: "MealType",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
