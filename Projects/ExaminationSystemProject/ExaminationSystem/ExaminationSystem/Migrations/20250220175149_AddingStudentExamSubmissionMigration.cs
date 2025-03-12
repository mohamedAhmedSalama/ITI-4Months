using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ExaminationSystem.Migrations
{
    /// <inheritdoc />
    public partial class AddingStudentExamSubmissionMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ExamSubmission");

            migrationBuilder.CreateTable(
                name: "StudentExamSubmissions",
                columns: table => new
                {
                    StudentId = table.Column<int>(type: "int", nullable: false),
                    ExamId = table.Column<int>(type: "int", nullable: false),
                    QuestionId = table.Column<int>(type: "int", nullable: false),
                    Answer = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsCorrct = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StudentExamSubmissions", x => new { x.StudentId, x.ExamId, x.QuestionId });
                    table.ForeignKey(
                        name: "FK_StudentExamSubmissions_Exams_ExamId",
                        column: x => x.ExamId,
                        principalTable: "Exams",
                        principalColumn: "ExamId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_StudentExamSubmissions_Questions_QuestionId",
                        column: x => x.QuestionId,
                        principalTable: "Questions",
                        principalColumn: "QuestionId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_StudentExamSubmissions_Students_StudentId",
                        column: x => x.StudentId,
                        principalTable: "Students",
                        principalColumn: "StudentId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_StudentExamSubmissions_ExamId",
                table: "StudentExamSubmissions",
                column: "ExamId");

            migrationBuilder.CreateIndex(
                name: "IX_StudentExamSubmissions_QuestionId",
                table: "StudentExamSubmissions",
                column: "QuestionId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "StudentExamSubmissions");

            migrationBuilder.CreateTable(
                name: "ExamSubmission",
                columns: table => new
                {
                    ExamSubmissionId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    QuestionId = table.Column<int>(type: "int", nullable: false),
                    AnswerText = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsCorrect = table.Column<bool>(type: "bit", nullable: false),
                    StudentExamExamId = table.Column<int>(type: "int", nullable: true),
                    StudentExamStudentId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExamSubmission", x => x.ExamSubmissionId);
                    table.ForeignKey(
                        name: "FK_ExamSubmission_Questions_QuestionId",
                        column: x => x.QuestionId,
                        principalTable: "Questions",
                        principalColumn: "QuestionId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ExamSubmission_StudentExams_StudentExamStudentId_StudentExamExamId",
                        columns: x => new { x.StudentExamStudentId, x.StudentExamExamId },
                        principalTable: "StudentExams",
                        principalColumns: new[] { "StudentId", "ExamId" });
                });

            migrationBuilder.CreateIndex(
                name: "IX_ExamSubmission_QuestionId",
                table: "ExamSubmission",
                column: "QuestionId");

            migrationBuilder.CreateIndex(
                name: "IX_ExamSubmission_StudentExamStudentId_StudentExamExamId",
                table: "ExamSubmission",
                columns: new[] { "StudentExamStudentId", "StudentExamExamId" });
        }
    }
}
