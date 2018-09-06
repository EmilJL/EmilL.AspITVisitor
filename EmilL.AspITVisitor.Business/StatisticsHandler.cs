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
        //public int GetAgeRangeForGuests()
        //{
        //    return Model.Guests.Distinct().
        //}
    }
}
