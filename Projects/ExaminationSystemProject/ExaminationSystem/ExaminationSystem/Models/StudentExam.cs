using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExaminationSystem.Models
{
    public class StudentExam
    {
        //public int StudentExamId { get; set; }
        public DateTime? StartTime { get; set; }
        public DateTime? EndTime { get; set; }
        public int? Score { get; set; }
        public string? Grade { get; set; }
        public string? Feedback { get; set; }

        // Foreign Key
        public int StudentId { get; set; }
        public Student Student { get; set; }

        public int ExamId { get; set; }
        public Exam Exam { get; set; }

        // Navigational Properties
        //public ICollection <ExamSubmission> ExamSubmissions { get; set; }
    }
}
