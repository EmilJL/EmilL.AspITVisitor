using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmilL.AspITVisitor.Business;
using EmilL.AspITVisitor.DAL.EF;

namespace EmilJlAspITVisitor.FillData.ConsoleApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            AspITVisitDayHandler aspDayHandler = new AspITVisitDayHandler();
            AdminHandler adminHandler = new AdminHandler();
            AnswerHandler answerHandler = new AnswerHandler();
            DBHandler dbHandler = new DBHandler();
            DepartmentHandler departmentHandler = new DepartmentHandler();
            InquiryHandler inquiryHandler = new InquiryHandler();
            GuestHandler guestHandler = new GuestHandler();
            QuestionnaireHandler questionnaireHandler = new QuestionnaireHandler();
            StatisticsHandler statisticsHandler = new StatisticsHandler();
            QuestionHandler questionHandler = new QuestionHandler();

            Admin admin = new Admin()
            {
                FirstName = "Bo",
                LastName = "Børgesen"
            };
            adminHandler.AddAdmin(admin);

            Department department = new Department()
            {
                Name = "AspIT Storkøbenhavn",
                Address = "Den der gade 22, -5 th.",
                ZipCode = "666"
            };
            departmentHandler.AddDepartment(department);

            AspITVisitDay aspITVisitDay = new AspITVisitDay()
            {
                Date = DateTime.Now,
                AdminId = 1,
                DepartmentId = 1
            };
            aspDayHandler.AddAspITVisitDay(aspITVisitDay);

            Questionnaire questionnaire = new Questionnaire()
            {
                Active = true,
                AdminId = 1
            };
            questionnaireHandler.AddQuestionnaire(questionnaire);

            MultipleChoiseQuestion multipleChoiseQuestion = new MultipleChoiseQuestion()
            {
                Question = "Hvad er rødt, dødt og ilde mødt?",
                QuestionnaireId = 1
            };
            questionHandler.AddMultipleChoiceQuestion(multipleChoiseQuestion);
            MultipleChoiseQuestion multipleChoiseQuestion2 = new MultipleChoiseQuestion()
            {
                Question = "Hvad er blødt, sødt og ret så sprødt?",
                QuestionnaireId = 1
            };
            questionHandler.AddMultipleChoiceQuestion(multipleChoiseQuestion2);
            MultipleChoiseQuestion multipleChoiseQuestion3 = new MultipleChoiseQuestion()
            {
                Question = "Hvad er født, stødt og hurtigt dødt?",
                QuestionnaireId = 1
            };
            questionHandler.AddMultipleChoiceQuestion(multipleChoiseQuestion3);

            FreeAnswerQuestion freeAnswerQuestion = new FreeAnswerQuestion()
            {
                Question = "Hvad er rødt, dødt og ilde mødt?",
                QuestionnaireId = 1
            };
            questionHandler.AddFreeAnswerQuestion(freeAnswerQuestion);
            FreeAnswerQuestion freeAnswerQuestion2 = new FreeAnswerQuestion()
            {
                Question = "Hvad er blødt, sødt og ret så sprødt?",
                QuestionnaireId = 1
            };
            questionHandler.AddFreeAnswerQuestion(freeAnswerQuestion2);
            FreeAnswerQuestion freeAnswerQuestion3 = new FreeAnswerQuestion()
            {
                Question = "Hvad er født, stødt og hurtigt dødt?",
                QuestionnaireId = 1
            };
            questionHandler.AddFreeAnswerQuestion(freeAnswerQuestion3);

            PossibleAnswer possibleAnswer = new PossibleAnswer()
            {
                Answer = "Egon",
                MultipleChoiseQuestionId = 1
            };
            questionHandler.AddPossibleAnswerForMultipleChoiceQuestion(possibleAnswer);
            PossibleAnswer possibleAnswer2 = new PossibleAnswer()
            {
                Answer = "Eller",
                MultipleChoiseQuestionId = 1
            };
            questionHandler.AddPossibleAnswerForMultipleChoiceQuestion(possibleAnswer2);
            PossibleAnswer possibleAnswer3 = new PossibleAnswer()
            {
                Answer = "Olsen",
                MultipleChoiseQuestionId = 1
            };
            questionHandler.AddPossibleAnswerForMultipleChoiceQuestion(possibleAnswer3);

            PossibleAnswer possibleAnswer4 = new PossibleAnswer()
            {
                Answer = "Chips",
                MultipleChoiseQuestionId = 2
            };
            questionHandler.AddPossibleAnswerForMultipleChoiceQuestion(possibleAnswer4);
            PossibleAnswer possibleAnswer5 = new PossibleAnswer()
            {
                Answer = "Kage",
                MultipleChoiseQuestionId = 2
            };
            questionHandler.AddPossibleAnswerForMultipleChoiceQuestion(possibleAnswer5);
            PossibleAnswer possibleAnswer6 = new PossibleAnswer()
            {
                Answer = "Tomat",
                MultipleChoiseQuestionId = 2
            };
            questionHandler.AddPossibleAnswerForMultipleChoiceQuestion(possibleAnswer6);

            PossibleAnswer possibleAnswer7 = new PossibleAnswer()
            {
                Answer = "Pizza",
                MultipleChoiseQuestionId = 3
            };
            questionHandler.AddPossibleAnswerForMultipleChoiceQuestion(possibleAnswer7);
            PossibleAnswer possibleAnswer8 = new PossibleAnswer()
            {
                Answer = "Med",
                MultipleChoiseQuestionId = 3
            };
            questionHandler.AddPossibleAnswerForMultipleChoiceQuestion(possibleAnswer8);
            PossibleAnswer possibleAnswer9 = new PossibleAnswer()
            {
                Answer = "Ost",
                MultipleChoiseQuestionId = 3
            };
            questionHandler.AddPossibleAnswerForMultipleChoiceQuestion(possibleAnswer9);

            Console.ReadLine();
        }
    }
}
