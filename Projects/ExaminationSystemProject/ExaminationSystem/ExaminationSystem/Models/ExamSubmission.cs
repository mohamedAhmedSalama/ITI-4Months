using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExaminationSystem.Models
{
    public class ExamSubmission
    {
        public int ExamSubmissionId { get; set; }
        public string AnswerText { get; set; }
        public bool IsCorrect { get; set; }

        // Foreign Key
        public int QuestionId { get; set; }
        public Question Question { get; set; }

        
    }
}
