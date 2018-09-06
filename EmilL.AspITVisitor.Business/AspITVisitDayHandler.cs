using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmilL.AspITVisitor.DAL.EF;

namespace EmilL.AspITVisitor.Business
{
    public class AspITVisitDayHandler : DBHandler
    {
        public List<AspITVisitDay> GetAllAspITVisitDays()
        {
            return Model.AspITVisitDays.ToList();
        }
        public AspITVisitDay GetAspITVisitDay(int id)
        {
            return Model.AspITVisitDays.Find(id);
        }
        public bool AddAspITVisitDay(AspITVisitDay aspITVisitDay)
        {
            Model.AspITVisitDays.Add(aspITVisitDay);
            return SaveChangeToDB();
        }
        public bool RemoveAspITVisitDay(int id)
        {
            Model.AspITVisitDays.Remove(Model.AspITVisitDays.Find(id));
            return SaveChangeToDB();
        }
        public bool UpdateAspITVisitDay(int id, AspITVisitDay aspITVisitDay)
        {
            var aspD = Model.AspITVisitDays.Find(id);
            aspD.AdminId = aspITVisitDay.AdminId;
            aspD.Date = aspITVisitDay.Date;
            aspD.DepartmentId = aspITVisitDay.DepartmentId;
            return SaveChangeToDB();
        }
    }
}
