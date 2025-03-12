using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ExaminationSystem.Migrations
{
    /// <inheritdoc />
    public partial class RemoveExamSubMissionMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ExamSubmissions_Questions_QuestionId",
                table: "ExamSubmissions");

            migrationBuilder.DropForeignKey(
                name: "FK_ExamSubmissions_StudentExams_StudentExamStudentId_StudentExamExamId",
                table: "ExamSubmissions");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ExamSubmissions",
                table: "ExamSubmissions");

            migrationBuilder.RenameTable(
                name: "ExamSubmissions",
                newName: "ExamSubmission");

            migrationBuilder.RenameIndex(
                name: "IX_ExamSubmissions_StudentExamStudentId_StudentExamExamId",
                table: "ExamSubmission",
                newName: "IX_ExamSubmission_StudentExamStudentId_StudentExamExamId");

            migrationBuilder.RenameIndex(
                name: "IX_ExamSubmissions_QuestionId",
                table: "ExamSubmission",
                newName: "IX_ExamSubmission_QuestionId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ExamSubmission",
                table: "ExamSubmission",
                column: "ExamSubmissionId");

            migrationBuilder.AddForeignKey(
                name: "FK_ExamSubmission_Questions_QuestionId",
                table: "ExamSubmission",
                column: "QuestionId",
                principalTable: "Questions",
                principalColumn: "QuestionId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ExamSubmission_StudentExams_StudentExamStudentId_StudentExamExamId",
                table: "ExamSubmission",
                columns: new[] { "StudentExamStudentId", "StudentExamExamId" },
                principalTable: "StudentExams",
                principalColumns: new[] { "StudentId", "ExamId" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ExamSubmission_Questions_QuestionId",
                table: "ExamSubmission");

            migrationBuilder.DropForeignKey(
                name: "FK_ExamSubmission_StudentExams_StudentExamStudentId_StudentExamExamId",
                table: "ExamSubmission");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ExamSubmission",
                table: "ExamSubmission");

            migrationBuilder.RenameTable(
                name: "ExamSubmission",
                newName: "ExamSubmissions");

            migrationBuilder.RenameIndex(
                name: "IX_ExamSubmission_StudentExamStudentId_StudentExamExamId",
                table: "ExamSubmissions",
                newName: "IX_ExamSubmissions_StudentExamStudentId_StudentExamExamId");

            migrationBuilder.RenameIndex(
                name: "IX_ExamSubmission_QuestionId",
                table: "ExamSubmissions",
                newName: "IX_ExamSubmissions_QuestionId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ExamSubmissions",
                table: "ExamSubmissions",
                column: "ExamSubmissionId");

            migrationBuilder.AddForeignKey(
                name: "FK_ExamSubmissions_Questions_QuestionId",
                table: "ExamSubmissions",
                column: "QuestionId",
                principalTable: "Questions",
                principalColumn: "QuestionId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ExamSubmissions_StudentExams_StudentExamStudentId_StudentExamExamId",
                table: "ExamSubmissions",
                columns: new[] { "StudentExamStudentId", "StudentExamExamId" },
                principalTable: "StudentExams",
                principalColumns: new[] { "StudentId", "ExamId" });
        }
    }
}
