using ExaminationSystem.Contexts;
using ExaminationSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExaminationSystem.BusinessLogic
{
    internal class StudentExamLogic
    {
        StudentExam studentExam;
        public StudentExamLogic()
        {
            studentExam = new StudentExam();
        }

        private int getCourseId(int examId)
        {
            int result = -1;
            using (var context = new ExaminationSystemDbContext())
            {
                result = context.Exams.Where(e => e.ExamId == examId)
                                        .Select(e => e.CourseId)
                                        .SingleOrDefault();
            }
            return result;
        }
        public void sendExamToAllStudentsInCourse(int examId)
        {
            int courseId = getCourseId(examId);
            
            using (var context = new ExaminationSystemDbContext())
            {
                var students = context.StudentCourses.Where(sc => sc.CourseId == courseId)
                                                      .Select(sc => sc.StudentId).ToList();
                foreach (var student in students)
                {
                    studentExam = new StudentExam() 
                    { 
                        StudentId = student,
                        ExamId = examId
                    };
                    context.StudentExams.Add(studentExam);
                    context.SaveChanges();
                }
            }
            
        }

        public dynamic getStudentsExams(int studentid)
        {
            
            using (var context = new ExaminationSystemDbContext())
            {
                var result = context.StudentExams.Where(se => se.StudentId == studentid)
                                                 .Join(context.Exams,
                                                 se=> se.ExamId,
                                                 e=>e.ExamId,
                                                 (se, e) => new
                                                 {
                                                     courseName=e.Course.CourseName,
                                                     ExamTitle = e.Title,
                                                     ExamInstructions = e.Instructions,
                                                     Exam_Date = e.ExamDate,
                                                     ExamDuration = e.Duration,
                                                     TotalMarks = e.TotalMarks,
                                                     PassMarks = e.PassMarks,
                                                     ExamID = e.ExamId,
                                                     StartTime = se.StartTime,
                                                 })
                                                 .ToList();

                return result;
            }


        }

        public void addStudentExamAfterSubmit(int studentid, int examid,DateTime start, int score, string grade)
        {
            using (var context = new ExaminationSystemDbContext())
            {
                var updating =  context.StudentExams.
                    FirstOrDefault(s => s.StudentId == studentid && s.ExamId == examid);

                updating.StartTime = start;
                updating.EndTime = DateTime.Now;
                updating.Score = score;
                updating.Grade = grade;

                context.SaveChanges();

            }
        }

        public void giveFeedback(int studentid, int examid , string feedback)
        {
            using (var context = new ExaminationSystemDbContext())
            {
                var updating = context.StudentExams.
                    FirstOrDefault(s => s.StudentId == studentid && s.ExamId == examid);

                updating.Feedback = feedback;
                context.SaveChanges();
            }
        }

        public dynamic getStudentFinishedExams(int studentid)
        {
            using (var context = new ExaminationSystemDbContext())
            {
                var result = context.StudentExams.Where(se => se.StudentId == studentid && se.StartTime != null)
                                                 .Join(context.Exams,
                                                 se => se.ExamId,
                                                 e => e.ExamId,
                                                 (se, e) => new
                                                 {
                                                     courseName = e.Course.CourseName,
                                                     ExamTitle = e.Title,
                                                     StartTime = se.StartTime,
                                                     EndTime = se.EndTime,
                                                     Score = se.Score,
                                                     Grade = se.Grade,
                                                     ExamInstructions = e.Instructions,
                                                     Exam_Date = e.ExamDate,
                                                     ExamDuration = e.Duration,
                                                     TotalMarks = e.TotalMarks,
                                                     PassMarks = e.PassMarks,
                                                     ExamID = e.ExamId,
                                                     FeedBack = se.Feedback

                                                 })
                                            .ToList();

                return result;
            }
        }
    }
}
