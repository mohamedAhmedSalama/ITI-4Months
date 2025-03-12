using ExaminationSystem.Contexts;
using ExaminationSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExaminationSystem.BusinessLogic
{
    public class CourseItem
    {
        public int CourseId { get; set; }
        public string CourseName { get; set; }
    }

    internal class CourseLogic
    {
        Course course;

        public CourseLogic()
        {
            course = new Course();
        }

        public dynamic getCourses()
        {
            using (var context = new ExaminationSystemDbContext())
            {
                //var result = context.Courses.Select(c => new { c.CourseName, c.Description, c.DateCreated }).ToList();
                var result = context.Courses.Join(context.Instructors,
                                            c => c.InstructorId,
                                            i => i.InstructorId,
                                            (c, i) => new { c.CourseId, c.CourseName, c.Description, c.DateCreated,InstructorName= i.FirstName+ " "+ i.LastName }).ToList();
                return result;
            }
        }

        public int getCourseIDByName(string name)
        {
            using (var context = new ExaminationSystemDbContext())
            {
                var result = context.Courses.Where(c => c.CourseName  == name)
                    .Select(c => c.CourseId)
                    .FirstOrDefault();

                return result;
            }
        }
        public dynamic getInstructorCourses(int InstId)
        {
            using (var context = new ExaminationSystemDbContext())
            {
                var result = context.Courses
                                    .Where(c => c.InstructorId == InstId)
                                    .Select(c => new
                                    {
                                        CourseId = c.CourseId,
                                        CourseName = c.CourseName,
                                        CourseDescription = c.Description,
                                        CourseDateCreated = c.DateCreated,
                                        NumberOfStudentsEnrolled = c.StudentCourses.Count
                                    }).ToList();
                return result;
            }
            
        }

        public dynamic getInstructorCourse2(int InstId)
        {
            using (var context = new ExaminationSystemDbContext())
            {
                var result = context.Courses.Where(c => c.InstructorId == InstId)
                                            .Select(c => new 
                                            {
                                                CourseId = c.CourseId,
                                                CourseName = c.CourseName
                                            }).ToList();
                                            

                return result;
            }
        }

        public dynamic getStudentsInInstructorCourses(int InstId)
        {
            using (var context = new ExaminationSystemDbContext())
            {
                var result = context.Courses
                                    .Where(c => c.InstructorId == InstId)
                                    .SelectMany(c => c.StudentCourses)
                                    .Select(sc => new
                                    {
                                        StudentId = sc.Student.StudentId,
                                        StudentName = sc.Student.FirstName + " " + sc.Student.LastName,
                                        CourseId = sc.CourseId,
                                        CourseName = sc.Course.CourseName
                                    }).ToList();
                return result;
            }
        }


    }
}
