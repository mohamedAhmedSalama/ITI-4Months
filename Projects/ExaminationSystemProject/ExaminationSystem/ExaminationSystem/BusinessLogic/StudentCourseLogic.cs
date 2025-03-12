using ExaminationSystem.Contexts;
using ExaminationSystem.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExaminationSystem.BusinessLogic
{
    internal class StudentCourseLogic
    {
        StudentCourse studentCourse;
        public StudentCourseLogic()
        {
            studentCourse = new StudentCourse();
        }

        public dynamic getStudentCourses(int studentId)
        {
            using (var context = new ExaminationSystemDbContext())
            {
                var result = context.StudentCourses
                                    .Where(sc => sc.StudentId == studentId)
                                    .Include(sc => sc.Student)
                                    .Include(sc => sc.Course)
                                    .ThenInclude(c => c.Instructor)
                                    .Select(sc => new { CourseId = sc.Course.CourseId, CourseName= sc.Course.CourseName, CourseDescription= sc.Course.Description, CourseDateCreated= sc.Course.DateCreated, InstructorName= sc.Course.Instructor.FirstName + " " + sc.Course.Instructor.LastName,courseEnrollmentDate= sc.EnrollmentDate }).ToList();

                return result;
            }
        }

        public bool AddStudentCourse(int studentId, int courseId)
        {
            bool isEnrolled = false;
            using (var context = new ExaminationSystemDbContext())
            {
                isEnrolled = context.StudentCourses.Any(sc => sc.StudentId == studentId && sc.CourseId == courseId);
                
                if (isEnrolled == false)
                {
                    studentCourse = new StudentCourse() { StudentId = studentId, CourseId = courseId, EnrollmentDate = DateTime.Now };
                    context.StudentCourses.Add(studentCourse);
                    context.SaveChanges();
                    return true;
                }

                return false;
            }
        }
    }
}
