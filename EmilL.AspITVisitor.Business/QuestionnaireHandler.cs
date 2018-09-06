using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmilL.AspITVisitor.DAL.EF;

namespace EmilL.AspITVisitor.Business
{
    public class QuestionnaireHandler : DBHandler
    {
        public List<Questionnaire> GetAllQuestionnaires()
        {
            return Model.Questionnaires.ToList();
        }
        public Questionnaire GetQuestionnaire(int id)
        {
            return Model.Questionnaires.Find(id);
        }
        public bool AddQuestionnaire(Questionnaire questionnaire)
        {
            Model.Questionnaires.Add(questionnaire);
            return SaveChangeToDB();
        }
        public bool RemoveQuestionnaire(int id)
        {
            Model.Questionnaires.Remove(Model.Questionnaires.Find(id));
            return SaveChangeToDB();
        }
        public bool UpdateQuestionnaire(int id, Questionnaire questionnaire)
        {
            var qNaire = Model.Questionnaires.Find(id);
            qNaire.Active = questionnaire.Active;
            qNaire.AdminId = questionnaire.AdminId;
            return SaveChangeToDB();
        }
    }
}
