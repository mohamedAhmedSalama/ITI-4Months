using ExaminationSystem.Contexts;
using ExaminationSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExaminationSystem.BusinessLogic
{
    internal class StudentExamSubmissionLogic
    {
        StudentExamSubmission studentExamSubmission;

        public void addStudentExamSubmission(int studentId, int examid,int questionid,string answer,bool isCorrect)
        {
            using (var context = new ExaminationSystemDbContext())
            {
                studentExamSubmission = new StudentExamSubmission()
                {
                    StudentId = studentId,
                    ExamId = examid,
                    QuestionId = questionid,
                    Answer = answer,
                    IsCorrct = isCorrect
                };
                context.StudentExamSubmissions.Add(studentExamSubmission);
                context.SaveChanges();
            }
        }

        public dynamic getStudentAnswers(int studentId,int examId)
        {
            using (var context = new ExaminationSystemDbContext())
            {


                var result = context.StudentExamSubmissions
                                    .Where(ses => ses.StudentId == studentId && ses.ExamId == examId) 
                                    .Join(context.Questions, 
                                    ses => ses.QuestionId,
                                    q => q.QuestionId,
                                    (ses, q) => new { ses, q }) 
                                    .Join(context.Options,
                                    combined => combined.ses.QuestionId,
                                    o => o.QuestionId,
                                    (combined, o) => new 
                                    {
                
                                        QuestionType = combined.q.QuestionType,
                                        DifficultyLevel = combined.q.DifficultyLevel,
                                        QuestionMarks = combined.q.Marks,
                                        QuestionText = combined.q.QuestionText,

                
                                        Option1 = o.Option1,
                                        Option2 = o.Option2,
                                        Option3 = o.Option3,
                                        Option4 = o.Option4,
                                        IsCorrect = o.IsCorrect,

                
                                        YourAnswer = combined.ses.Answer,
                                        IsCorrectAnswer = combined.ses.IsCorrct
                                    })
                                    .ToList(); 

                return result;
            }
        }

        public dynamic getStudentsExamsAssigned(int studnetId, int courseid)
        {
            using (var context = new ExaminationSystemDbContext())
            {
                var result =   context.StudentCourses
                                        .Where(sc => sc.StudentId == studnetId && sc.CourseId == courseid)
                                        .Join(context.StudentExams,
                                            sc => sc.StudentId,
                                            se => se.StudentId,
                                            (sc, se) => new { sc, se })
                                        .Join(context.Exams,
                                            x => x.se.ExamId,
                                            e => e.ExamId,
                                            (x, e) => new
                                            {
                                                ExamId = e.ExamId,
                                                ExamName = e.Title,
                                                ExamDate = e.ExamDate,
                                                StartTime = x.se.StartTime,
                                                EndTime = x.se.EndTime,
                                                Score = x.se.Score,
                                                Grade = x.se.Grade,
                                                Feedback = x.se.Feedback
                                            })
                                        .ToList();

                return result;
            }
        }


    }
}
