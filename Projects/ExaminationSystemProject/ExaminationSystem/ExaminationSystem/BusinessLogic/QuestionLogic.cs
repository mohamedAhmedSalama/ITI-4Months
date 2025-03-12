using ExaminationSystem.Contexts;
using ExaminationSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExaminationSystem.BusinessLogic
{
    internal class QuestionLogic
    {
        Question question;
        public QuestionLogic()
        {
            question = new Question();
        }

        public int addQuestion(string questionText, string questionType, string difficultyLevel, int marks, int examId)
        {
            using (var context = new ExaminationSystemDbContext())
            {
                question = new Question()
                {
                    QuestionText = questionText,
                    QuestionType = questionType,
                    DifficultyLevel = difficultyLevel,
                    Marks = marks,
                    ExamId = examId
                };
                context.Questions.Add(question);
                context.SaveChanges();

                return question.QuestionId;
            }
        }
    }
}
