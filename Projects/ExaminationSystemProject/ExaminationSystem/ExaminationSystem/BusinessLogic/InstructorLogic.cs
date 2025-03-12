using ExaminationSystem.Contexts;
using ExaminationSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExaminationSystem.BusinessLogic
{
    internal class InstructorLogic
    {
        Instructor instructor;

        public InstructorLogic()
        {
            instructor = new Instructor();
        }
        public bool IsInstructor(string email, string password, out string name, out int id)
        {
            bool instructorExists = false;
            name = "";
            id = 0;
            using (var context = new ExaminationSystemDbContext())
            {
                var result = context.Instructors
                                    .Where(i => i.Email == email && i.PasswordHash == password)
                                    .Select(i => new { i.FirstName, i.LastName , i.InstructorId })
                                    .FirstOrDefault();

                if (result != null)
                {
                    instructorExists = true;
                    name = result.FirstName + " " + result.LastName;
                    id = result.InstructorId;
                }
                return instructorExists;
            }
        }

        public void AddInstructor(string FName,string LName,string mail,string password)
        {
            instructor = new Instructor() { FirstName= FName, LastName = LName, Email = mail, PasswordHash = password, DateCreated = DateTime.Now };
            using (var context = new ExaminationSystemDbContext())
            {
                context.Instructors.Add(instructor);
                context.SaveChanges();
            }
        }
    }
}
