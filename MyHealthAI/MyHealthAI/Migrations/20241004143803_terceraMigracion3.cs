using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TestConsolaBD.Migrations
{
    /// <inheritdoc />
    public partial class terceraMigracion3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_answerIAs_Users_UserID",
                table: "answerIAs");

            migrationBuilder.DropForeignKey(
                name: "FK_dialyExercises_Users_UserID",
                table: "dialyExercises");

            migrationBuilder.DropForeignKey(
                name: "FK_Meals_MealTypes_MealTypeID",
                table: "Meals");

            migrationBuilder.DropForeignKey(
                name: "FK_Users_objectives_ObjectiveID",
                table: "Users");

            migrationBuilder.DropPrimaryKey(
                name: "PK_objectives",
                table: "objectives");

            migrationBuilder.DropPrimaryKey(
                name: "PK_dialyExercises",
                table: "dialyExercises");

            migrationBuilder.DropPrimaryKey(
                name: "PK_MealTypes",
                table: "MealTypes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_answerIAs",
                table: "answerIAs");

            migrationBuilder.RenameTable(
                name: "objectives",
                newName: "Objectives");

            migrationBuilder.RenameTable(
                name: "dialyExercises",
                newName: "DialyExercises");

            migrationBuilder.RenameTable(
                name: "MealTypes",
                newName: "MealType");

            migrationBuilder.RenameTable(
                name: "answerIAs",
                newName: "AnswerIA");

            migrationBuilder.RenameColumn(
                name: "ExerciseHighPerfomance",
                table: "DialyExercises",
                newName: "ExerciseHighPerformance");

            migrationBuilder.RenameIndex(
                name: "IX_dialyExercises_UserID",
                table: "DialyExercises",
                newName: "IX_DialyExercises_UserID");

            migrationBuilder.RenameIndex(
                name: "IX_answerIAs_UserID",
                table: "AnswerIA",
                newName: "IX_AnswerIA_UserID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Objectives",
                table: "Objectives",
                column: "ID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_DialyExercises",
                table: "DialyExercises",
                column: "ID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_MealType",
                table: "MealType",
                column: "ID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AnswerIA",
                table: "AnswerIA",
                column: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_AnswerIA_Users_UserID",
                table: "AnswerIA",
                column: "UserID",
                principalTable: "Users",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_DialyExercises_Users_UserID",
                table: "DialyExercises",
                column: "UserID",
                principalTable: "Users",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Meals_MealType_MealTypeID",
                table: "Meals",
                column: "MealTypeID",
                principalTable: "MealType",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Objectives_ObjectiveID",
                table: "Users",
                column: "ObjectiveID",
                principalTable: "Objectives",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AnswerIA_Users_UserID",
                table: "AnswerIA");

            migrationBuilder.DropForeignKey(
                name: "FK_DialyExercises_Users_UserID",
                table: "DialyExercises");

            migrationBuilder.DropForeignKey(
                name: "FK_Meals_MealType_MealTypeID",
                table: "Meals");

            migrationBuilder.DropForeignKey(
                name: "FK_Users_Objectives_ObjectiveID",
                table: "Users");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Objectives",
                table: "Objectives");

            migrationBuilder.DropPrimaryKey(
                name: "PK_DialyExercises",
                table: "DialyExercises");

            migrationBuilder.DropPrimaryKey(
                name: "PK_MealType",
                table: "MealType");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AnswerIA",
                table: "AnswerIA");

            migrationBuilder.RenameTable(
                name: "Objectives",
                newName: "objectives");

            migrationBuilder.RenameTable(
                name: "DialyExercises",
                newName: "dialyExercises");

            migrationBuilder.RenameTable(
                name: "MealType",
                newName: "MealTypes");

            migrationBuilder.RenameTable(
                name: "AnswerIA",
                newName: "answerIAs");

            migrationBuilder.RenameColumn(
                name: "ExerciseHighPerformance",
                table: "dialyExercises",
                newName: "ExerciseHighPerfomance");

            migrationBuilder.RenameIndex(
                name: "IX_DialyExercises_UserID",
                table: "dialyExercises",
                newName: "IX_dialyExercises_UserID");

            migrationBuilder.RenameIndex(
                name: "IX_AnswerIA_UserID",
                table: "answerIAs",
                newName: "IX_answerIAs_UserID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_objectives",
                table: "objectives",
                column: "ID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_dialyExercises",
                table: "dialyExercises",
                column: "ID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_MealTypes",
                table: "MealTypes",
                column: "ID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_answerIAs",
                table: "answerIAs",
                column: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_answerIAs_Users_UserID",
                table: "answerIAs",
                column: "UserID",
                principalTable: "Users",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_dialyExercises_Users_UserID",
                table: "dialyExercises",
                column: "UserID",
                principalTable: "Users",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Meals_MealTypes_MealTypeID",
                table: "Meals",
                column: "MealTypeID",
                principalTable: "MealTypes",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Users_objectives_ObjectiveID",
                table: "Users",
                column: "ObjectiveID",
                principalTable: "objectives",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
