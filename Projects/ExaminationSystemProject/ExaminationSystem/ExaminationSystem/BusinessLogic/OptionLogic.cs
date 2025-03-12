using ExaminationSystem.Contexts;
using ExaminationSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExaminationSystem.BusinessLogic
{
    internal class OptionLogic
    {
        Option option;
        
        public OptionLogic()
        {
            option = new Option();
            
        }

        public void addOption(string questionText1, string questionText2, string questionText3, string questionText4, string iscorrect, int questionId)
        {
            using(var context = new ExaminationSystemDbContext())
            {
                option = new Option()
                {
                    Option1 = questionText1,
                    Option2 = questionText2,
                    Option3 = questionText3,
                    Option4 = questionText4,
                    IsCorrect = iscorrect,
                    QuestionId = questionId
                };

                context.Options.Add(option);
                context.SaveChanges();
            }
        }

        public dynamic getQuestionOptions(int examId)
        {
            using (var context = new ExaminationSystemDbContext())
            {
                var result = context.Exams.Where(e=> e.ExamId == examId)
                                          .Join(context.Questions,
                                          e=> e.ExamId,
                                          q=> q.ExamId,
                                          (e,q)=>q)
                                          .Join(context.Options,
                                          q => q.QuestionId,
                                          o=> o.QuestionId,
                                          (q,o) => new 
                                          {
                                              q.QuestionId,
                                              q.QuestionText,
                                              q.QuestionType,
                                              q.DifficultyLevel,
                                              q.Marks,
                                              o.Option1,
                                              o.Option2,
                                              o.Option3,
                                              o.Option4,
                                              o.IsCorrect
                                          }
                                          ).ToList();
                return result;
            }
        }
    }
}
