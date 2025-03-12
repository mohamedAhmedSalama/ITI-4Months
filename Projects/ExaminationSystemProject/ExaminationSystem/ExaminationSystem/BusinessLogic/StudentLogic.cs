using ExaminationSystem.Contexts;
using ExaminationSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExaminationSystem.BusinessLogic
{
    internal class StudentLogic
    {
        Student Student;
        public StudentLogic()
        {
            Student = new Student();
        }

        public bool IsStudent (string email, string password, out string name, out int id)
        {
            bool studentExists = false;
            name = "";
            id = 0;
            using (var context = new ExaminationSystemDbContext())
            {
                var result = context.Students
                                    .Where(s => s.Email == email && s.PasswordHash == password)
                                    .Select(s => new { s.FirstName, s.LastName, s.StudentId })
                                    .FirstOrDefault();
                
                    if (result != null)
                    {
                        studentExists = true;
                        name = result.FirstName + " " + result.LastName;
                        id = result.StudentId;
                    }
                return studentExists;
            }
        }
        public void AddStudent(string FName, string LName, string mail, string password)
        {
            Student = new Student() { FirstName = FName, LastName = LName, Email = mail, PasswordHash = password, DateCreated = DateTime.Now };
            using (var context = new ExaminationSystemDbContext())
            {
                context.Students.Add(Student);
                context.SaveChanges();
            }
        }
    }
}
