using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExaminationSystem.Models
{
    public class Question
    {
        public int QuestionId { get; set; }
        public string QuestionText { get; set; }
        public string QuestionType { get; set; } // e.g., MCQ, True/False, Essay
        public string DifficultyLevel { get; set; } // Easy, Medium, Hard
        public int Marks { get; set; }

        //Foreign Key
        public int ExamId { get; set; }
        public Exam Exam { get; set; }

        //Navigational Properties
        public ICollection<Option> Options { get; set; }

        public ICollection<StudentExamSubmission> StudentExamSubmissions { get; set; }
    }
}
