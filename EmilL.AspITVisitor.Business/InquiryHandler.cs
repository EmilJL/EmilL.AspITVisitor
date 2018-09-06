using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmilL.AspITVisitor.DAL.EF;

namespace EmilL.AspITVisitor.Business
{
    public class InquiryHandler : DBHandler
    {
        public List<Inquiry> GetAllInquiries()
        {
            return Model.Inquiries.ToList();
        }
        public Inquiry GetInquiry(int id)
        {
            return Model.Inquiries.Find(id);
        }
        public bool AddInquiry(Inquiry inquiry)
        {
            Model.Inquiries.Add(inquiry);
            return SaveChangeToDB();
        }
        public bool RemoveInquiry(int id)
        {
            Model.Inquiries.Remove(Model.Inquiries.Find(id));
            return SaveChangeToDB();
        }
        public bool UpdateInquiry(int id, Inquiry inquiry)
        {
            var inq = Model.Inquiries.Find(id);
            inq.AspITVisitDayId = inquiry.AspITVisitDayId;
            inq.Date = inquiry.Date;
            inq.QuestionsString = inquiry.QuestionsString;
            return SaveChangeToDB();
        }
    }
}
