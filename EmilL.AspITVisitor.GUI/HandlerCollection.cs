using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmilL.AspITVisitor.Business;
using EmilL.AspITVisitor.DAL.EF;

namespace EmilL.AspITVisitor.GUI
{
    public class HandlerCollection
    {
        private GuestHandler gHandler;
        private QuestionnaireHandler qHandler;
        private AnswerHandler aHandler;

        public HandlerCollection()
        {
            gHandler = new GuestHandler();
            qHandler = new QuestionnaireHandler();
            aHandler = new AnswerHandler();
        }

        public AnswerHandler AHandler
        {
            get { return aHandler; }
        }
        public QuestionnaireHandler QHandler
        {
            get { return qHandler; }
        }
        public GuestHandler GHandler
        {
            get { return gHandler; }
        }

    }
}
