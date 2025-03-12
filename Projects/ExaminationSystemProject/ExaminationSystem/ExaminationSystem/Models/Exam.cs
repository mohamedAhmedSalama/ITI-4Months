using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExaminationSystem.Models
{
    public class Exam
    {
        public int ExamId { get; set; }
        public string Title { get; set; }
        public string Instructions { get; set; }
        public DateTime ExamDate { get; set; }
        public int Duration { get; set; } // In minutes
        public int TotalMarks { get; set; }
        public int PassMarks { get; set; }

        //Foreign Key
        public int CourseId { get; set; }
        public Course Course { get; set; }

        

        // Navigational Properties
        public ICollection<Question> Questions { get; set; }
        public ICollection<StudentExam> StudentExams { get; set; }

        public ICollection<StudentExamSubmission> StudentExamSubmissions { get; set; }

    }
}
