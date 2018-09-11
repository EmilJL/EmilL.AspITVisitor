using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmilL.AspITVisitor.DAL.EF;

namespace EmilL.AspITVisitor.Business
{
    public class QuestionHandler : DBHandler
    {
        public bool AddMultipleChoiceQuestion(MultipleChoiseQuestion multipleChoiseQuestion)
        {
            Model.MultipleChoiseQuestions.Add(multipleChoiseQuestion);
            return SaveChangeToDB();
        }
        public bool AddPossibleAnswerForMultipleChoiceQuestion(PossibleAnswer possibleAnswer)
        {
            Model.PossibleAnswers.Add(possibleAnswer);
            return SaveChangeToDB();
        }
        public bool AddFreeAnswerQuestion(FreeAnswerQuestion freeAnswerQuestion)
        {
            Model.FreeAnswerQuestions.Add(freeAnswerQuestion);
            return SaveChangeToDB();
        }
    }
}
