
using ExaminationSystem.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExaminationSystem.Contexts
{
    internal class ExaminationSystemDbContext : DbContext
    {
        //public ExaminationSystemDbContext():base()
        //{
            
        //}
        protected override void OnConfiguring(DbContextOptionsBuilder optionBuilder) =>
            optionBuilder.UseSqlServer("Server=.;Database=ExaminationSystemDb;Trusted_Connection= True; TrustServerCertificate= True");
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            
            //modelBuilder.Entity<ExamSubmission>()
            //    .HasKey(es => new {es.ExamId, es.StudentId, es.QuestionId });

            modelBuilder.Entity<StudentCourse>()
                .HasKey(sc => new { sc.StudentId, sc.CourseId });

            modelBuilder.Entity<StudentExam>()
                .HasKey(se => new { se.StudentId, se.ExamId });

            modelBuilder.Entity<Notifications>(entity =>
            {

                entity.HasKey(n => n.NotificationId);

                entity.Property(n => n.NotificationId)
                      .ValueGeneratedOnAdd()
                      .UseIdentityColumn();
            });

            modelBuilder.Entity<StudentExamSubmission>()
                .HasKey(ses => new { ses.StudentId, ses.ExamId, ses.QuestionId });

            modelBuilder.Entity<StudentExamSubmission>()
            .HasOne(s => s.Exam)
            .WithMany(e => e.StudentExamSubmissions)
            .HasForeignKey(s => s.ExamId)
            .OnDelete(DeleteBehavior.Cascade); // Cascades on exam deletion

            modelBuilder.Entity<StudentExamSubmission>()
                .HasOne(s => s.Question)
                .WithMany(q => q.StudentExamSubmissions)
                .HasForeignKey(s => s.QuestionId)
                .OnDelete(DeleteBehavior.Restrict); // Prevents cascading delete on questions

            modelBuilder.Entity<StudentExamSubmission>()
                .HasOne(s => s.Student)
                .WithMany(st => st.StudentExamSubmissions)
                .HasForeignKey(s => s.StudentId)
                .OnDelete(DeleteBehavior.Restrict); // Prevents cascading delete on students


            base.OnModelCreating(modelBuilder);
        }


        public DbSet<Student> Students { get; set; }
        public DbSet<Instructor> Instructors { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Exam> Exams { get; set; }
        public DbSet<Question> Questions { get; set; }
        public DbSet<Option> Options { get; set; }
        public DbSet<Notifications> Notifications { get; set; }
        public DbSet<StudentCourse> StudentCourses { get; set; }
        public DbSet<StudentExam> StudentExams { get; set; }

        public DbSet<StudentExamSubmission> StudentExamSubmissions { get; set; }

        //public DbSet<ExamSubmission> ExamSubmissions { get; set; }









    }
}
