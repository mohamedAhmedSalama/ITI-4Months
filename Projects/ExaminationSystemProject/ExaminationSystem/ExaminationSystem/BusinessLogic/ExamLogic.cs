using ExaminationSystem.Contexts;
using ExaminationSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExaminationSystem.BusinessLogic
{
    internal class ExamLogic
    {
        Exam exam;
        public ExamLogic()
        {
            exam = new Exam();
        }

        public dynamic getInstructorExams(int instId)
        {
            using (var context = new ExaminationSystemDbContext())
            {
                
                var result = context.Courses.Where(c => c.InstructorId == instId)
                    .Join(context.Exams,
                    c => c.CourseId,
                    e => e.CourseId,
                    (c, e) => new
                    {
                        CourseId = c.CourseId,
                        CourseName = c.CourseName,
                        ExamId = e.ExamId,
                        ExamTitle = e.Title,
                        Instructions = e.Instructions,
                        ExamDate = e.ExamDate,
                        ExamDuration = e.Duration,
                        TotalMarks = e.TotalMarks,
                        PassMarks = e.PassMarks
                    }
                    ).ToList();

                return result;
            }
        }

        public void AddExam(string title, string instruction, DateTime date, int duration, int totalMarks,int passMarks, int courseId)
        {
            using (var context = new ExaminationSystemDbContext())
            {
                exam = new Exam()
                {
                    Title = title,
                    Instructions = instruction,
                    ExamDate = date,
                    Duration = duration,
                    TotalMarks = totalMarks,
                    PassMarks = passMarks,
                    CourseId = courseId
                };
                context.Exams.Add(exam);
                context.SaveChanges();
            }
        }

        

       

    }
}
