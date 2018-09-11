using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmilL.AspITVisitor.DAL.EF;

namespace EmilL.AspITVisitor.Business
{
    public class AnswerHandler : DBHandler
    {
        public bool AddFreeAnswer(FreeAnswer freeAnswer)
        {
            Model.FreeAnswers.Add(freeAnswer);
            return SaveChangeToDB();
        }
        public bool AddMultiAnswer(MultipleChoiseAnswer multiAnswer)
        {
            Model.MultipleChoiseAnswers.Add(multiAnswer);
            return SaveChangeToDB();
        }
    }
}
