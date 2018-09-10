using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmilL.AspITVisitor.DAL.EF;

namespace EmilL.AspITVisitor.Business
{
    public class StatisticsHandler : DBHandler
    {
        public int GetAmountOfGuestsForDepartment(int id)
        {
            return Model.Guests.Where(g => g.AspITVisitDay.DepartmentId == id).ToList().Count;
        }
        public int GetAmountOfGuestsForAllDepartments()
        {
            return Model.Guests.Distinct().ToList().Count;
        }
        public int GetAgeRangeForGuests()
        {
            return (Model.Guests.OrderByDescending(g => g.Age).First().Age) - (Model.Guests.OrderByDescending(g => g.Age).Last().Age);
        }
        public double getAverageAgeForGuests()
        {
            return Model.Guests.Select(g => g.Age).ToList().Average();
        }
        public int numberOfGuestsVisitingSpecifikDepartmentOnSpecifikDate(Department department, DateTime date)
        {
            if (Model.AspITVisitDays.Any(a => a.Date == date) && Model.AspITVisitDays.Where(a => a.Date == date).Any(v => v.DepartmentId == department.Id))
            {
                var aV = Model.AspITVisitDays.Where(a => a.Date == date).Where(v => v.DepartmentId == department.Id).Select(av => av.Id).First();
                return Model.Guests.Where(g => g.AspITVisitDayId == aV).ToList().Count();
            }
            else
            {
                return 0;
            }
        }
        public int NumberOfQuestionnairesFilledOut()
        {
            //var result = Model.FreeAnswers.GroupJoin(Model.MultipleChoiseAnswers,
            //                                    f => f.GuestId,
            //                                    m => m.GuestId
            //                                    (f, answersGrouped)
            //                                    {
            //                                        answers = answersGrouped,
            //var guestIdsFree = Model.FreeAnswers.Select(f => f.GuestId).Distinct().ToList();
            //var guestIdsMultiple = Model.MultipleChoiseAnswers.Select(m => m.GuestId).Distinct().ToList();
            return Model.FreeAnswers.Select(f => f.GuestId).Distinct().Count();
        }
        public int NumberOfCommunesVisitedBy()
        {
            return Model.Guests.Select(g => g.Commune).Count();
        }
        public int NumberOfVisitByCommune(string nameOfCommune)
        {
            return Model.Guests.Where(g => g.Commune == nameOfCommune).Count();
        }
    }
}
