using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmilL.AspITVisitor.DAL.EF;

namespace EmilL.AspITVisitor.Business
{
    public class GuestHandler : DBHandler
    {
        public List<Guest> GetAllGuests()
        {
            return Model.Guests.ToList();
        }
        public Guest GetGuest(int id)
        {
            return Model.Guests.Find(id);
        }
        public bool AddGuest(Guest guest)
        {
            Model.Guests.Add(guest);
            return SaveChangeToDB();
        }
        public bool RemoveGuest(int id)
        {
            Model.Guests.Remove(Model.Guests.Find(id));
            return SaveChangeToDB();
        }
        public bool UpdateGuest(int id, Guest guest)
        {
            var gst = Model.Guests.Find(id);
            gst.Age = guest.Age;
            gst.AspITVisitDayId = guest.AspITVisitDayId;
            gst.FirstName = guest.FirstName;
            gst.LastName = guest.LastName;
            gst.QuestionnaireId = guest.QuestionnaireId;
            gst.WishesToBeStudent = guest.WishesToBeStudent;
            gst.Commune = guest.Commune;
            return SaveChangeToDB();
        }
        public int GetIdOfLastAddedGuest()
        {
            return Model.Guests.Select(g => g.Id).Last();
        }
    }
}
