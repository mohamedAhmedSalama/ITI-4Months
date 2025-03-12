namespace ExaminationSystem.Models
{
    public class Course
    {
        public int CourseId { get; set; }
        public string CourseName { get; set; }
        public string Description { get; set; }
        public DateTime DateCreated { get; set; } = DateTime.Now;

        // Forigen Keys
        public int InstructorId { get; set; }
        public Instructor Instructor { get; set; }

        // Navigational Properties

        public ICollection<StudentCourse> StudentCourses { get; set; }
        public ICollection<Exam> Exams { get; set; }

    }
}
